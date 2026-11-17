using InventorySystem.UI.DataAccess;
using InventorySystem.UI.Helpers;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using System.Security.AccessControl;
using System.Security.Principal;



namespace InventorySystem.UI.Forms
{
    /// <summary>
    /// شاشة النسخ الاحتياطي والاستعادة
    /// </summary>
    public partial class frmBackup : Form
    {
        // ============================================
        // مجلد النسخ الاحتياطي
        // ============================================

        private readonly string _backupFolder;

        public frmBackup()
        {
            InitializeComponent();

            // مجلد النسخ في مسار البرنامج

                // ✅ مجلد على القرص C (يمكن الوصول من SQL Server)
                _backupFolder = @"C:\InventorySystem_Backups";
            
        }

        // ============================================
        // تحميل الشاشة
        // ============================================

        private void frmBackup_Load(object sender, EventArgs e)
        {
            // إنشاء مجلد النسخ
            if (!Directory.Exists(_backupFolder))
            {
                try
                {
                    Directory.CreateDirectory(_backupFolder);

                    // ✅ إعطاء صلاحية الكتابة للجميع
                    GrantWritePermission(_backupFolder);
                }
                catch (Exception ex)
                {
                    MessageHelper.ShowError($"فشل في إنشاء مجلد النسخ: {ex.Message}");
                    return;
                }
            }

            lblBackupPath.Text = _backupFolder;
            txtBackupName.Text = $"InventoryDB_{DateTime.Now:yyyyMMdd_HHmmss}";

            LoadBackupsList();
        }



        /// <summary>
        /// إعطاء صلاحية الكتابة لمجلد النسخ
        /// </summary>
        private void GrantWritePermission(string folderPath)
        {
            try
            {
                var directoryInfo = new DirectoryInfo(folderPath);
                var security = directoryInfo.GetAccessControl();

                // إعطاء صلاحية للجميع
                var everyone = new SecurityIdentifier(WellKnownSidType.WorldSid, null);

                security.AddAccessRule(new FileSystemAccessRule(
                    everyone,
                    FileSystemRights.FullControl,
                    InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit,
                    PropagationFlags.None,
                    AccessControlType.Allow));

                directoryInfo.SetAccessControl(security);
            }
            catch (Exception ex)
            {
                LogHelper.LogError(ex, "frmBackup.GrantWritePermission");
            }
        }


        // ============================================
        // تحميل قائمة النسخ الاحتياطية
        // ============================================

        private void LoadBackupsList()
        {
            try
            {
                lstBackups.Items.Clear();

                if (!Directory.Exists(_backupFolder))
                    return;

                var files = Directory.GetFiles(_backupFolder, "*.bak");

                foreach (var file in files)
                {
                    var fileInfo = new FileInfo(file);
                    var size = fileInfo.Length / 1024.0 / 1024.0; // MB

                    lstBackups.Items.Add(
                        $"{fileInfo.Name}  |  {fileInfo.LastWriteTime:dd/MM/yyyy HH:mm}  |  {size:N2} MB");
                }

                if (lstBackups.Items.Count == 0)
                {
                    lstBackups.Items.Add("— لا توجد نسخ احتياطية —");
                }
            }
            catch (Exception ex)
            {
                LogHelper.LogError(ex, "frmBackup.LoadBackupsList");
            }
        }

        // ============================================
        // إنشاء نسخة احتياطية
        // ============================================

        private void btnBackup_Click(object sender, EventArgs e)
        {
            try
            {
                // التحقق من الاسم
                string backupName = txtBackupName.Text.Trim();

                if (string.IsNullOrWhiteSpace(backupName))
                {
                    MessageHelper.ShowWarning("يجب إدخال اسم النسخة");
                    return;
                }

                // إزالة الأحرف غير المسموحة
                foreach (char c in Path.GetInvalidFileNameChars())
                    backupName = backupName.Replace(c, '_');

                // مسار الملف
                string backupFile = Path.Combine(_backupFolder, backupName + ".bak");

                // التحقق من عدم الوجود
                if (File.Exists(backupFile))
                {
                    if (!MessageHelper.Confirm($"الملف '{backupName}.bak' موجود مسبقاً. هل تريد استبداله؟"))
                        return;

                    File.Delete(backupFile);
                }

                // تأكيد
                if (!MessageHelper.Confirm("سيتم إنشاء نسخة احتياطية كاملة. هل أنت متأكد؟"))
                    return;

                // الحصول على اسم قاعدة البيانات
                string dbName = GetDatabaseName();

                if (string.IsNullOrEmpty(dbName))
                {
                    MessageHelper.ShowError("فشل في الحصول على اسم قاعدة البيانات");
                    return;
                }

                // تنفيذ النسخ الاحتياطي
                string query = $@"
                    BACKUP DATABASE [{dbName}] 
                    TO DISK = @BackupPath 
                    WITH FORMAT, INIT, NAME = N'{backupName}', SKIP, NOREWIND, NOUNLOAD, STATS = 10";

                // استخدام اتصال master
                var builder = new SqlConnectionStringBuilder(DatabaseHelper.ConnectionString);
                string masterConnection = builder.ConnectionString.Replace(
                    $"Database={builder.InitialCatalog}", "Database=master");

                using (var connection = new SqlConnection(masterConnection))
                {
                    connection.Open();

                    using (var command = new SqlCommand(query, connection))
                    {
                        command.CommandTimeout = 300; // 5 دقائق
                        command.Parameters.AddWithValue("@BackupPath", backupFile);
                        command.ExecuteNonQuery();
                    }
                }

                LogHelper.LogInfo($"تم إنشاء نسخة احتياطية: {backupFile}");
                MessageHelper.ShowSuccess("تم إنشاء النسخة الاحتياطية بنجاح ✅");

                LoadBackupsList();
                txtBackupName.Text = $"InventoryDB_{DateTime.Now:yyyyMMdd_HHmmss}";
            }
            catch (Exception ex)
            {
                LogHelper.LogError(ex, "frmBackup.btnBackup_Click");
                MessageHelper.ShowError($"فشل في إنشاء النسخة: {ex.Message}");
            }
        }

        // ============================================
        // استعادة نسخة
        // ============================================

        private void btnRestore_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstBackups.SelectedIndex < 0)
                {
                    MessageHelper.ShowSelectItem();
                    return;
                }

                string selectedItem = lstBackups.SelectedItem.ToString();
                string fileName = selectedItem.Split('|')[0].Trim();
                string backupFile = Path.Combine(_backupFolder, fileName);

                if (!MessageHelper.Confirm(
                    "⚠️ سيتم استبدال قاعدة البيانات!\n" +
                    "سيتم إغلاق البرنامج وإعادة فتحه.\n" +
                    "هل أنت متأكد؟"))
                    return;

                string dbName = GetDatabaseName();

                // ✅ إنشاء ملف SQL مؤقت
                string sqlScript = $@"
ALTER DATABASE [{dbName}] SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
RESTORE DATABASE [{dbName}] FROM DISK = N'{backupFile}' WITH REPLACE;
ALTER DATABASE [{dbName}] SET MULTI_USER;
";

                string tempFile = Path.Combine(Path.GetTempPath(), "restore.sql");
                File.WriteAllText(tempFile, sqlScript);

                // ✅ تنفيذ باستخدام SQLCMD
                var builder = new SqlConnectionStringBuilder(DatabaseHelper.ConnectionString);

                string cmdArgs = $"-S {builder.DataSource} -U {builder.UserID} -P {builder.Password} -i \"{tempFile}\"";

                if (builder.IntegratedSecurity)
                    cmdArgs = $"-S {builder.DataSource} -E -i \"{tempFile}\"";

                var processInfo = new System.Diagnostics.ProcessStartInfo
                {
                    FileName = "sqlcmd.exe",
                    Arguments = cmdArgs,
                    UseShellExecute = false,
                    CreateNoWindow = true,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true
                };

                var process = System.Diagnostics.Process.Start(processInfo);
                string output = process.StandardOutput.ReadToEnd();
                string error = process.StandardError.ReadToEnd();
                process.WaitForExit();

                if (process.ExitCode == 0)
                {
                    MessageHelper.ShowSuccess("تم استعادة النسخة ✅\nسيتم إعادة تشغيل البرنامج.");
                    Application.Restart();
                }
                else
                {
                    MessageHelper.ShowError($"فشل: {error}");
                }
            }
            catch (Exception ex)
            {
                LogHelper.LogError(ex, "frmBackup.btnRestore_Click");
                MessageHelper.ShowError($"فشل: {ex.Message}");
            }
        }

        // ============================================
        // تحديث القائمة
        // ============================================

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadBackupsList();
            MessageHelper.ShowInfo("تم تحديث القائمة ✅");
        }

        // ============================================
        // دوال مساعدة
        // ============================================

        /// <summary>
        /// الحصول على اسم قاعدة البيانات
        /// </summary>
        private string GetDatabaseName()
        {
            try
            {
                var builder = new SqlConnectionStringBuilder(DatabaseHelper.ConnectionString);
                return builder.InitialCatalog;
            }
            catch
            {
                return null;
            }
        }
    }
}