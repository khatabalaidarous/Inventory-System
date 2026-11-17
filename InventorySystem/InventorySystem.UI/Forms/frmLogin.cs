using InventorySystem.UI.Business;
using InventorySystem.UI.DataAccess;
using InventorySystem.UI.Helpers;
using InventorySystem.UI.Models.Entities;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace InventorySystem.UI.Forms
{
    /// <summary>
    /// شاشة تسجيل الدخول
    /// </summary>
    public partial class frmLogin : Form
    {
        // ============================================
        // المتغيرات
        // ============================================
        
        private  UserBLL _userBLL;
        private int _failedAttempts = 0;
        private const int MAX_ATTEMPTS = 3;
        
        // ============================================
        // Constructor
        // ============================================
        
        public frmLogin()
        {
            InitializeComponent();
            _userBLL = new UserBLL();
        }
        
        // ============================================
        // تحميل الشاشة
        // ============================================
        
        private void frmLogin_Load(object sender, EventArgs e)
        {
            LoadLogo();
            
            // اختبار الاتصال بقاعدة البيانات
            if (!DatabaseHelper.TestConnection())
            {
                MessageHelper.ShowError(
                    "فشل الاتصال بقاعدة البيانات!\n" +
                    "تأكد من:\n" +
                    "1. تشغيل SQL Server\n" +
                    "2. صحة سلسلة الاتصال في App.config\n" +
                    "3. وجود قاعدة البيانات InventoryDB");
                
                Application.Exit();
                return;
            }
            
            txtUsername.Focus();
            LogHelper.LogInfo("فتح شاشة تسجيل الدخول");
        }
        
        /// <summary>
        /// تحميل الشعار
        /// </summary>
        private void LoadLogo()
        {
            //try
            //{
            //    // ✅ محاولة 1: من Resources
            //    picLogo.Image = InventorySystem.UI.Properties.Resources.login;
            //}
            //catch
            //{
            //    try
            //    {
            //        // ✅ محاولة 2: من الملف مباشرة
            //        string logoPath = System.IO.Path.Combine(
            //            Application.StartupPath, 
            //            "Resources", "Images", "login.png");
                    
            //        if (System.IO.File.Exists(logoPath))
            //            picLogo.Image = System.Drawing.Image.FromFile(logoPath);
            //        else
            //            DrawTextLogo();
            //    }
            //    catch
            //    {
            //        // ✅ محاولة 3: شعار نصي
            //        DrawTextLogo();
            //    }
            //}
        }
        
        /// <summary>
        /// رسم شعار نصي احتياطي
        /// </summary>
        private void DrawTextLogo()
        {
            picLogo.Paint += (s, pe) =>
            {
                pe.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                
                // رسم دائرة بيضاء
                pe.Graphics.FillEllipse(Brushes.White, 5, 5, 110, 110);
                
                // رسم الحد الأزرق
                using (var pen = new Pen(Color.FromArgb(41, 128, 185), 3))
                {
                    pe.Graphics.DrawEllipse(pen, 5, 5, 110, 110);
                }
                
                // رسم الرمز
                using (var font = new Font("Segoe UI Emoji", 42F, FontStyle.Regular))
                using (var brush = new SolidBrush(Color.FromArgb(41, 128, 185)))
                {
                    var text = "📦";
                    var size = pe.Graphics.MeasureString(text, font);
                    pe.Graphics.DrawString(text, font, brush,
                        (120 - size.Width) / 2 + 5,
                        (120 - size.Height) / 2 + 5);
                }
            };
            picLogo.Invalidate();
        }
        
        // ============================================
        // زر الدخول
        // ============================================
        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                ShowError("اسم المستخدم مطلوب");
                txtUsername.Focus();
                return;
            }
            
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                ShowError("كلمة المرور مطلوبة");
                txtPassword.Focus();
                return;
            }
            
            TryLogin();
        }
        
        private void TryLogin()
        {
            try
            {
                btnLogin.Enabled = false;
                btnExit.Enabled = false;
                btnLogin.Text = "...جاري التحقق";
                
                string error;
                User user = _userBLL.Login(txtUsername.Text.Trim(), txtPassword.Text, out error);
                
                if (user == null)
                {
                    _failedAttempts++;
                    ShowError(error ?? "بيانات الدخول غير صحيحة");
                    txtPassword.Clear();
                    txtPassword.Focus();
                    
                    LogHelper.LogInfo($"محاولة دخول فاشلة - المستخدم: {txtUsername.Text}");
                    
                    if (_failedAttempts >= MAX_ATTEMPTS)
                    {
                        MessageHelper.ShowError(
                            $"تم استنفاد عدد المحاولات ({MAX_ATTEMPTS}).\n" +
                            "سيتم إغلاق البرنامج.");
                        
                        Application.Exit();
                        return;
                    }
                    
                    int remaining = MAX_ATTEMPTS - _failedAttempts;
                    ShowError($"{error} - المحاولات المتبقية: {remaining}");
                    return;
                }
                
                LogHelper.LogInfo($"تسجيل دخول ناجح - المستخدم: {user.Username}");
                
                this.Hide();
                var frmMain = new frmMain();
                frmMain.ShowDialog();
                
                if (SessionManager.IsLoggedIn)
                {
                    this.Close();
                }
                else
                {
                    ResetForm();
                    this.Show();
                }
            }
            catch (Exception ex)
            {
                LogHelper.LogError(ex, "frmLogin.TryLogin");
                ShowError($"حدث خطأ: {ex.Message}");
            }
            finally
            {
                btnLogin.Enabled = true;
                btnExit.Enabled = true;
                btnLogin.Text = "دخول";
            }
        }
        
        // ============================================
        // زر الخروج
        // ============================================
        
        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageHelper.ConfirmExit())
            {
                LogHelper.LogInfo("الخروج من شاشة تسجيل الدخول");
                Application.Exit();
            }
        }
        
        // ============================================
        // إظهار/إخفاء كلمة المرور
        // ============================================
        
        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
        }
        
        // ============================================
        // إغلاق الشاشة
        // ============================================
        
        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing && SessionManager.IsLoggedIn == false)
            {
                if (!MessageHelper.ConfirmExit())
                {
                    e.Cancel = true;
                }
            }
        }
        
        // ============================================
        // دوال مساعدة
        // ============================================
        
        private void ShowError(string message)
        {
            lblError.Text = message;
            lblError.Visible = true;
        }
        
        private void ResetForm()
        {
            txtUsername.Clear();
            txtPassword.Clear();
            chkShowPassword.Checked = false;
            lblError.Visible = false;
            _failedAttempts = 0;
            txtUsername.Focus();
        }
    }
}