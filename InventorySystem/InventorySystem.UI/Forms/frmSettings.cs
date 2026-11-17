using InventorySystem.UI.DataAccess;
using InventorySystem.UI.Helpers;
using System;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace InventorySystem.UI.Forms
{
    public partial class frmSettings : Form
    {
        // ============================================
        // عناصر التحكم
        // ============================================

        // 🏢 عام
        private TextBox txtCompanyName;
        private TextBox txtCompanyPhone;
        private TextBox txtCompanyAddress;
        private TextBox txtCurrency;
        private PictureBox picLogo;
        private Button btnBrowseLogo;
        private ComboBox cmbLanguage;
        private ComboBox cmbDateFormat;

        // 📦 المخزون
        private NumericUpDown numMinStockAlert;
        private NumericUpDown numExpiryDays;
        private ComboBox cmbValuationMethod;
        private ComboBox cmbIssueMethod;
        private CheckBox chkAllowNegative;
        private CheckBox chkShowLowStockAlert;
        private CheckBox chkShowExpiryAlert;
        private CheckBox chkForceBatch;
        private NumericUpDown numStocktakeDays;

        // 🧾 الفواتير
        private TextBox txtInvoiceHeader;
        private TextBox txtInvoiceFooter;
        private NumericUpDown numTaxRate;
        private NumericUpDown numDefaultDiscount;
        private ComboBox cmbPaperSize;
        private NumericUpDown numCopies;

        // 🔐 الأمان
        private NumericUpDown numPasswordMinLength;
        private CheckBox chkRequireUppercase;
        private CheckBox chkRequireNumbers;
        private CheckBox chkRequireSymbols;
        private NumericUpDown numSessionTimeout;
        private NumericUpDown numMaxLoginAttempts;
        private NumericUpDown numLockoutMinutes;

        // 🔔 الإشعارات
        private CheckBox chkSoundAlerts;
        private CheckBox chkDesktopNotifications;
        private CheckBox chkEmailNotifications;
        private TextBox txtSmtpServer;
        private NumericUpDown numSmtpPort;
        private TextBox txtSmtpUser;
        private TextBox txtSmtpPassword;

        // 🗄️ قاعدة البيانات
        private TextBox txtConnectionString;
        private Button btnTestConnection;
        private Label lblBackupPathValue;
        private Button btnCreateBackup;
        private Button btnRestoreBackup;
        private CheckBox chkAutoBackup;
        private ComboBox cmbBackupFrequency;
        private NumericUpDown numBackupKeepDays;

        // 📊 متقدم
        private NumericUpDown numCommandTimeout;
        private NumericUpDown numRetryCount;
        private ComboBox cmbLogLevel;
        private TextBox txtLogPath;
        private CheckBox chkAutoUpdate;

        // ℹ️ حول
        private PictureBox picAboutLogo;
        private TextBox txtAppName;
        private TextBox txtVersion;
        private Label lblAboutText;

        // ============================================
        // Constructor
        // ============================================

        public frmSettings()
        {
            InitializeComponent();
        }

        // ============================================
        // تحميل الشاشة
        // ============================================

        private void frmSettings_Load(object sender, EventArgs e)
        {
            BuildGeneralTab();
            BuildInventoryTab();
            BuildInvoicesTab();
            BuildSecurityTab();
            BuildNotificationsTab();
            BuildDatabaseTab();
            BuildAdvancedTab();
            BuildAboutTab();

            LoadSettings();
        }

        // ============================================
        // 🏢 تبويب عام
        // ============================================

        private void BuildGeneralTab()
        {
            tabGeneral.Controls.Clear();

            int y = 20;

            // عنوان المجموعة
            AddSectionTitle(tabGeneral, "🏢  معلومات الشركة", ref y);

            // اسم الشركة
            AddLabel(tabGeneral, "🏢  اسم الشركة:", 30, y);
            txtCompanyName = AddTextBox(tabGeneral, 30, y + 30, 850);
            y += 80;

            // هاتف الشركة
            AddLabel(tabGeneral, "📞  هاتف الشركة:", 30, y);
            txtCompanyPhone = AddTextBox(tabGeneral, 30, y + 30, 850);
            y += 80;

            // عنوان الشركة
            AddLabel(tabGeneral, "📍  عنوان الشركة:", 30, y);
            txtCompanyAddress = AddTextBox(tabGeneral, 30, y + 30, 850, 60, true);
            y += 110;

            // العملة
            AddLabel(tabGeneral, "💰  العملة:", 30, y);
            txtCurrency = AddTextBox(tabGeneral, 30, y + 30, 400);
            y += 80;

            // اللغة
            AddLabel(tabGeneral, "🌐  اللغة:", 460, y - 80);
            cmbLanguage = AddComboBox(tabGeneral, 460, y - 50, 420);
            cmbLanguage.Items.AddRange(new object[] { "🇾🇪 العربية", "🇺🇸 English" });
            cmbLanguage.SelectedIndex = 0;

            // تنسيق التاريخ
            AddLabel(tabGeneral, "📅  تنسيق التاريخ:", 30, y);
            cmbDateFormat = AddComboBox(tabGeneral, 30, y + 30, 400);
            cmbDateFormat.Items.AddRange(new object[] {
                "dd/MM/yyyy", "MM/dd/yyyy", "yyyy-MM-dd", "dd-MM-yyyy" });
            cmbDateFormat.SelectedIndex = 0;
            y += 80;

            // الشعار
            AddSectionTitle(tabGeneral, "🖼️  شعار الشركة", ref y);

            picLogo = new PictureBox
            {
                Location = new Point(30, y),
                Size = new Size(200, 200),
                BorderStyle = BorderStyle.FixedSingle,
                SizeMode = PictureBoxSizeMode.Zoom,
                BackColor = Color.FromArgb(236, 240, 241)
            };
            tabGeneral.Controls.Add(picLogo);

            btnBrowseLogo = new Button
            {
                Text = "📂  اختيار صورة",
                Location = new Point(250, y),
                Size = new Size(200, 45),
                Font = new Font("Segoe UI", 11F, FontStyle.Bold),
                BackColor = Color.FromArgb(52, 152, 219),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat
            };
            btnBrowseLogo.FlatAppearance.BorderSize = 0;
            btnBrowseLogo.Click += btnBrowseLogo_Click;
            tabGeneral.Controls.Add(btnBrowseLogo);
        }

        // ============================================
        // 📦 تبويب المخزون
        // ============================================

        private void BuildInventoryTab()
        {
            tabInventory.Controls.Clear();
            int y = 20;

            // التنبيهات
            AddSectionTitle(tabInventory, "🔔  التنبيهات", ref y);

            chkShowLowStockAlert = AddCheckBox(tabInventory, "📉  إظهار تنبيه عند نقص المخزون", 30, y);
            y += 40;

            chkShowExpiryAlert = AddCheckBox(tabInventory, "⏰  إظهار تنبيه عند قرب انتهاء الصلاحية", 30, y);
            y += 40;

            chkForceBatch = AddCheckBox(tabInventory, "📦  إجبار إدخال رقم الدفعة", 30, y);
            y += 50;

            // الحدود
            AddSectionTitle(tabInventory, "🔢  الحدود", ref y);

            AddLabel(tabInventory, "📉  الحد الأدنى العام لتنبيه المخزون:", 30, y);
            numMinStockAlert = AddNumeric(tabInventory, 30, y + 30, 400, 1, 1000);
            y += 80;

            AddLabel(tabInventory, "⏰  عدد الأيام لتنبيه انتهاء الصلاحية:", 30, y);
            numExpiryDays = AddNumeric(tabInventory, 30, y + 30, 400, 1, 365);
            y += 80;

            AddLabel(tabInventory, "📋  عدد الأيام بين عمليات الجرد:", 30, y);
            numStocktakeDays = AddNumeric(tabInventory, 30, y + 30, 400, 7, 365);
            y += 80;

            // طرق التقييم
            AddSectionTitle(tabInventory, "📊  طرق المحاسبة", ref y);

            AddLabel(tabInventory, "💰  طريقة تقييم المخزون:", 30, y);
            cmbValuationMethod = AddComboBox(tabInventory, 30, y + 30, 400);
            cmbValuationMethod.Items.AddRange(new object[] {
                "FIFO (الأول داخل - الأول خارج)",
                "LIFO (الأخير داخل - الأول خارج)",
                "متوسط مرجح" });
            cmbValuationMethod.SelectedIndex = 0;
            y += 80;

            AddLabel(tabInventory, "📤  طريقة الصرف:", 460, y - 80);
            cmbIssueMethod = AddComboBox(tabInventory, 460, y - 50, 400);
            cmbIssueMethod.Items.AddRange(new object[] {
                "FIFO (الأقدم أولاً)",
                "LIFO (الأحدث أولاً)",
                "FEFO (الأقرب انتهاءً أولاً)" });
            cmbIssueMethod.SelectedIndex = 0;

            chkAllowNegative = AddCheckBox(tabInventory,
                "⚠️  السماح بالمخزون السالب", 30, y);
        }

        // ============================================
        // 🧾 تبويب الفواتير
        // ============================================

        private void BuildInvoicesTab()
        {
            tabInvoices.Controls.Clear();
            int y = 20;

            AddSectionTitle(tabInvoices, "🧾  الفواتير", ref y);

            AddLabel(tabInvoices, "📄  ترويسة الفاتورة:", 30, y);
            txtInvoiceHeader = AddTextBox(tabInvoices, 30, y + 30, 850, 60, true);
            y += 110;

            AddLabel(tabInvoices, "📄  تذييل الفاتورة:", 30, y);
            txtInvoiceFooter = AddTextBox(tabInvoices, 30, y + 30, 850, 60, true);
            y += 110;

            AddSectionTitle(tabInvoices, "💰  الضرائب والخصومات", ref y);

            AddLabel(tabInvoices, "📊  نسبة الضريبة الافتراضية (%):", 30, y);
            numTaxRate = AddNumeric(tabInvoices, 30, y + 30, 400, 0, 100);
            y += 80;

            AddLabel(tabInvoices, "💸  نسبة الخصم الافتراضية (%):", 460, y - 80);
            numDefaultDiscount = AddNumeric(tabInvoices, 460, y - 50, 400, 0, 100);

            AddSectionTitle(tabInvoices, "🖨️  الطباعة", ref y);

            AddLabel(tabInvoices, "📄  حجم الورق:", 30, y);
            cmbPaperSize = AddComboBox(tabInvoices, 30, y + 30, 400);
            cmbPaperSize.Items.AddRange(new object[] {
                "A4 (210 × 297 mm)",
                "A5 (148 × 210 mm)",
                "حرارية (80mm)" });
            cmbPaperSize.SelectedIndex = 0;
            y += 80;

            AddLabel(tabInvoices, "📋  عدد النسخ:", 460, y - 80);
            numCopies = AddNumeric(tabInvoices, 460, y - 50, 400, 1, 5);
        }

        // ============================================
        // 🔐 تبويب الأمان
        // ============================================

        private void BuildSecurityTab()
        {
            tabSecurity.Controls.Clear();
            int y = 20;

            AddSectionTitle(tabSecurity, "🔒  سياسة كلمة المرور", ref y);

            AddLabel(tabSecurity, "📏  الحد الأدنى لطول كلمة المرور:", 30, y);
            numPasswordMinLength = AddNumeric(tabSecurity, 30, y + 30, 400, 4, 50);
            numPasswordMinLength.Value = 6;
            y += 80;

            chkRequireUppercase = AddCheckBox(tabSecurity, "🔠  يجب أن تحتوي على حرف كبير", 30, y);
            y += 35;

            chkRequireNumbers = AddCheckBox(tabSecurity, "🔢  يجب أن تحتوي على رقم", 30, y);
            y += 35;

            chkRequireSymbols = AddCheckBox(tabSecurity, "❗  يجب أن تحتوي على رمز خاص", 30, y);
            y += 50;

            AddSectionTitle(tabSecurity, "🔐  الجلسة والقفل", ref y);

            AddLabel(tabSecurity, "⏱️  مدة الجلسة (دقيقة):", 30, y);
            numSessionTimeout = AddNumeric(tabSecurity, 30, y + 30, 400, 5, 240);
            numSessionTimeout.Value = 30;
            y += 80;

            AddLabel(tabSecurity, "🔒  عدد محاولات الدخول المسموحة:", 30, y);
            numMaxLoginAttempts = AddNumeric(tabSecurity, 30, y + 30, 400, 1, 10);
            numMaxLoginAttempts.Value = 3;
            y += 80;

            AddLabel(tabSecurity, "⏸️  مدة القفل (دقيقة):", 30, y);
            numLockoutMinutes = AddNumeric(tabSecurity, 30, y + 30, 400, 1, 60);
            numLockoutMinutes.Value = 15;
        }

        // ============================================
        // 🔔 تبويب الإشعارات
        // ============================================

        private void BuildNotificationsTab()
        {
            tabNotifications.Controls.Clear();
            int y = 20;

            AddSectionTitle(tabNotifications, "🔔  نوع الإشعارات", ref y);

            chkSoundAlerts = AddCheckBox(tabNotifications, "🔊  تنبيهات صوتية", 30, y);
            chkSoundAlerts.Checked = true;
            y += 35;

            chkDesktopNotifications = AddCheckBox(tabNotifications, "💻  إشعارات سطح المكتب", 30, y);
            chkDesktopNotifications.Checked = true;
            y += 35;

            chkEmailNotifications = AddCheckBox(tabNotifications, "📧  إشعارات بالبريد الإلكتروني", 30, y);
            y += 50;

            AddSectionTitle(tabNotifications, "📧  إعدادات البريد (SMTP)", ref y);

            AddLabel(tabNotifications, "🌐  SMTP Server:", 30, y);
            txtSmtpServer = AddTextBox(tabNotifications, 30, y + 30, 400);
            txtSmtpServer.Text = "smtp.gmail.com";
            y += 80;

            AddLabel(tabNotifications, "🔢  Port:", 460, y - 80);
            numSmtpPort = AddNumeric(tabNotifications, 460, y - 50, 400, 1, 65535);
            numSmtpPort.Value = 587;

            AddLabel(tabNotifications, "👤  Username:", 30, y);
            txtSmtpUser = AddTextBox(tabNotifications, 30, y + 30, 400);
            y += 80;

            AddLabel(tabNotifications, "🔒  Password:", 460, y - 80);
            txtSmtpPassword = AddTextBox(tabNotifications, 460, y - 50, 400);
            txtSmtpPassword.UseSystemPasswordChar = true;
        }

        // ============================================
        // 🗄️ تبويب قاعدة البيانات
        // ============================================

        private void BuildDatabaseTab()
        {
            tabDatabase.Controls.Clear();
            int y = 20;

            AddSectionTitle(tabDatabase, "🔗  الاتصال", ref y);

            AddLabel(tabDatabase, "🔗  سلسلة الاتصال:", 30, y);
            txtConnectionString = AddTextBox(tabDatabase, 30, y + 30, 850, 80, true);
            txtConnectionString.Font = new Font("Consolas", 9F);
            y += 130;

            btnTestConnection = new Button
            {
                Text = "🔌  اختبار الاتصال",
                Location = new Point(30, y),
                Size = new Size(250, 45),
                Font = new Font("Segoe UI", 12F, FontStyle.Bold),
                BackColor = Color.FromArgb(52, 152, 219),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat
            };
            btnTestConnection.FlatAppearance.BorderSize = 0;
            btnTestConnection.Click += btnTestConnection_Click;
            tabDatabase.Controls.Add(btnTestConnection);
            y += 70;

            AddSectionTitle(tabDatabase, "💾  النسخ الاحتياطي", ref y);

            lblBackupPathValue = AddLabel(tabDatabase,
                GetBackupPath(), 30, y);
            lblBackupPathValue.Font = new Font("Consolas", 9F);
            lblBackupPathValue.ForeColor = Color.FromArgb(41, 128, 185);
            y += 40;

            btnCreateBackup = new Button
            {
                Text = "💾  إنشاء نسخة",
                Location = new Point(30, y),
                Size = new Size(400, 45),
                Font = new Font("Segoe UI", 12F, FontStyle.Bold),
                BackColor = Color.FromArgb(46, 204, 113),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat
            };
            btnCreateBackup.FlatAppearance.BorderSize = 0;
            btnCreateBackup.Click += btnCreateBackup_Click;
            tabDatabase.Controls.Add(btnCreateBackup);

            btnRestoreBackup = new Button
            {
                Text = "♻️  استعادة نسخة",
                Location = new Point(450, y),
                Size = new Size(430, 45),
                Font = new Font("Segoe UI", 12F, FontStyle.Bold),
                BackColor = Color.FromArgb(231, 76, 60),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat
            };
            btnRestoreBackup.FlatAppearance.BorderSize = 0;
            btnRestoreBackup.Click += btnRestoreBackup_Click;
            tabDatabase.Controls.Add(btnRestoreBackup);
            y += 70;

            chkAutoBackup = AddCheckBox(tabDatabase, "⏰  نسخ احتياطي تلقائي", 30, y);
            y += 45;

            AddLabel(tabDatabase, "📅  التكرار:", 30, y);
            cmbBackupFrequency = AddComboBox(tabDatabase, 30, y + 30, 400);
            cmbBackupFrequency.Items.AddRange(new object[] {
                "يومياً", "أسبوعياً", "شهرياً" });
            cmbBackupFrequency.SelectedIndex = 0;
            y += 80;

            AddLabel(tabDatabase, "📆  الاحتفاظ بالنسخ (يوم):", 460, y - 80);
            numBackupKeepDays = AddNumeric(tabDatabase, 460, y - 50, 400, 1, 365);
            numBackupKeepDays.Value = 30;
        }

        // ============================================
        // 📊 تبويب متقدم
        // ============================================

        private void BuildAdvancedTab()
        {
            tabAdvanced.Controls.Clear();
            int y = 20;

            AddSectionTitle(tabAdvanced, "⚙️  إعدادات الاتصال", ref y);

            AddLabel(tabAdvanced, "⏱️  Timeout (ثانية):", 30, y);
            numCommandTimeout = AddNumeric(tabAdvanced, 30, y + 30, 400, 5, 300);
            numCommandTimeout.Value = 30;
            y += 80;

            AddLabel(tabAdvanced, "🔄  عدد المحاولات عند الفشل:", 460, y - 80);
            numRetryCount = AddNumeric(tabAdvanced, 460, y - 50, 400, 0, 10);
            numRetryCount.Value = 3;

            AddSectionTitle(tabAdvanced, "📋  السجلات", ref y);

            AddLabel(tabAdvanced, "📊  مستوى السجلات:", 30, y);
            cmbLogLevel = AddComboBox(tabAdvanced, 30, y + 30, 400);
            cmbLogLevel.Items.AddRange(new object[] {
                "Debug", "Info", "Warning", "Error" });
            cmbLogLevel.SelectedIndex = 1;
            y += 80;

            AddLabel(tabAdvanced, "📁  مسار السجلات:", 30, y);
            txtLogPath = AddTextBox(tabAdvanced, 30, y + 30, 850);
            txtLogPath.Text = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Logs");
            y += 80;

            AddSectionTitle(tabAdvanced, "🚀  التحديثات", ref y);

            chkAutoUpdate = AddCheckBox(tabAdvanced, "🔄  التحديث التلقائي عند بدء التشغيل", 30, y);
        }

        // ============================================
        // ℹ️ تبويب حول
        // ============================================

        private void BuildAboutTab()
        {
            tabAbout.Controls.Clear();

            picAboutLogo = new PictureBox
            {
                Location = new Point(30, 30),
                Size = new Size(200, 200),
                BorderStyle = BorderStyle.FixedSingle,
                SizeMode = PictureBoxSizeMode.Zoom,
                BackColor = Color.FromArgb(236, 240, 241)
            };
            try { picAboutLogo.Image = System.Drawing.Image.FromFile(@"C:\Users\khatab\Pictures\1791225504223.jpg"); }
            catch { }
            tabAbout.Controls.Add(picAboutLogo);

            txtAppName = new TextBox
            {
                Location = new Point(260, 60),
                Size = new Size(620, 40),
                Font = new Font("Segoe UI", 16F, FontStyle.Bold),
                Text = "نظام إدارة المخزون والمستودعات",
                ReadOnly = true,
                TextAlign = HorizontalAlignment.Center,
                BackColor = Color.White,
                BorderStyle = BorderStyle.None
            };
            tabAbout.Controls.Add(txtAppName);

            txtVersion = new TextBox
            {
                Location = new Point(260, 120),
                Size = new Size(620, 35),
                Font = new Font("Segoe UI", 13F, FontStyle.Bold),
                Text = "الإصدار 1.0.0",
                ReadOnly = true,
                TextAlign = HorizontalAlignment.Center,
                ForeColor = Color.FromArgb(41, 128, 185),
                BackColor = Color.White,
                BorderStyle = BorderStyle.None
            };
            tabAbout.Controls.Add(txtVersion);

            lblAboutText = new Label
            {
                Location = new Point(30, 260),
                Size = new Size(850, 200),
                Font = new Font("Segoe UI", 12F),
                Text = "نظام إدارة المخزون والمستودعات\n\n" +
                       "تم تطويره باستخدام:\n" +
                       "• C# .NET Framework 4.8\n" +
                       "• WinForms\n" +
                       "• SQL Server\n" +
                       "• ADO.NET\n\n" +
                       "© 2026 - جميع الحقوق محفوظة",
                TextAlign = ContentAlignment.MiddleCenter
            };
            tabAbout.Controls.Add(lblAboutText);
        }

        // ============================================
        // دوال مساعدة
        // ============================================

        private void AddSectionTitle(TabPage page, string text, ref int y)
        {
            var lbl = new Label
            {
                Text = text,
                Location = new Point(20, y),
                Size = new Size(870, 35),
                Font = new Font("Segoe UI", 13F, FontStyle.Bold),
                ForeColor = Color.FromArgb(41, 128, 185),
                BackColor = Color.FromArgb(236, 240, 241),
                TextAlign = ContentAlignment.MiddleRight,
                Padding = new Padding(10, 0, 10, 0)
            };
            page.Controls.Add(lbl);
            y += 45;
        }

        private Label AddLabel(TabPage page, string text, int x, int y)
        {
            var lbl = new Label
            {
                Text = text,
                Location = new Point(x, y),
                Size = new Size(850, 25),
                Font = new Font("Segoe UI", 11F, FontStyle.Bold),
                ForeColor = Color.FromArgb(52, 73, 94),
                TextAlign = ContentAlignment.MiddleRight
            };
            page.Controls.Add(lbl);
            return lbl;
        }

        private TextBox AddTextBox(TabPage page, int x, int y, int width, int height = 29, bool multiline = false)
        {
            var txt = new TextBox
            {
                Location = new Point(x, y),
                Size = new Size(width, height),
                Font = new Font("Segoe UI", 11F),
                Multiline = multiline,
                ScrollBars = multiline ? ScrollBars.Vertical : ScrollBars.None
            };
            page.Controls.Add(txt);
            return txt;
        }

        private ComboBox AddComboBox(TabPage page, int x, int y, int width)
        {
            var cmb = new ComboBox
            {
                Location = new Point(x, y),
                Size = new Size(width, 29),
                Font = new Font("Segoe UI", 11F),
                DropDownStyle = ComboBoxStyle.DropDownList
            };
            page.Controls.Add(cmb);
            return cmb;
        }

        private NumericUpDown AddNumeric(TabPage page, int x, int y, int width, decimal min, decimal max)
        {
            var num = new NumericUpDown
            {
                Location = new Point(x, y),
                Size = new Size(width, 29),
                Font = new Font("Segoe UI", 11F),
                Minimum = min,
                Maximum = max,
                TextAlign = HorizontalAlignment.Center
            };
            page.Controls.Add(num);
            return num;
        }

        private CheckBox AddCheckBox(TabPage page, string text, int x, int y)
        {
            var chk = new CheckBox
            {
                Text = text,
                Location = new Point(x, y),
                Size = new Size(850, 30),
                Font = new Font("Segoe UI", 11F),
                ForeColor = Color.FromArgb(52, 73, 94)
            };
            page.Controls.Add(chk);
            return chk;
        }

        // ============================================
        // تحميل / حفظ الإعدادات
        // ============================================

        private string GetBackupPath()
        {
            return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Backups");
        }

        private string Get(string key, string def = "")
        {
            return ConfigurationManager.AppSettings[key] ?? def;
        }

        private void LoadSettings()
        {
            try
            {
                // 🏢 عام
                txtCompanyName.Text = Get("CompanyName", "شركتي");
                txtCompanyPhone.Text = Get("CompanyPhone", "");
                txtCompanyAddress.Text = Get("CompanyAddress", "");
                txtCurrency.Text = Get("Currency", "ريال");

                // 📦 المخزون
                numMinStockAlert.Value = decimal.Parse(Get("MinStockAlert", "10"));
                numExpiryDays.Value = decimal.Parse(Get("ExpiryAlertDays", "30"));
                numStocktakeDays.Value = decimal.Parse(Get("StocktakeDays", "30"));
                chkShowLowStockAlert.Checked = bool.Parse(Get("ShowLowStockAlert", "true"));
                chkShowExpiryAlert.Checked = bool.Parse(Get("ShowExpiryAlert", "true"));
                chkForceBatch.Checked = bool.Parse(Get("ForceBatch", "false"));
                chkAllowNegative.Checked = bool.Parse(Get("AllowNegative", "false"));

                // 🧾 الفواتير
                txtInvoiceHeader.Text = Get("InvoiceHeader", "");
                txtInvoiceFooter.Text = Get("InvoiceFooter", "");
                numTaxRate.Value = decimal.Parse(Get("TaxRate", "0"));
                numDefaultDiscount.Value = decimal.Parse(Get("DefaultDiscount", "0"));

                // 🔐 الأمان
                numPasswordMinLength.Value = decimal.Parse(Get("PasswordMinLength", "6"));
                numSessionTimeout.Value = decimal.Parse(Get("SessionTimeout", "30"));
                numMaxLoginAttempts.Value = decimal.Parse(Get("MaxLoginAttempts", "3"));
                numLockoutMinutes.Value = decimal.Parse(Get("LockoutMinutes", "15"));

                // 🔔 الإشعارات
                chkSoundAlerts.Checked = bool.Parse(Get("SoundAlerts", "true"));
                chkDesktopNotifications.Checked = bool.Parse(Get("DesktopNotifications", "true"));
                chkEmailNotifications.Checked = bool.Parse(Get("EmailNotifications", "false"));
                txtSmtpServer.Text = Get("SmtpServer", "smtp.gmail.com");
                numSmtpPort.Value = decimal.Parse(Get("SmtpPort", "587"));
                txtSmtpUser.Text = Get("SmtpUser", "");

                // 🗄️ قاعدة البيانات
                var conn = ConfigurationManager.ConnectionStrings["InventoryDbConnection"];
                if (conn != null)
                    txtConnectionString.Text = conn.ConnectionString;

                chkAutoBackup.Checked = bool.Parse(Get("AutoBackup", "false"));
                numBackupKeepDays.Value = decimal.Parse(Get("BackupKeepDays", "30"));

                // 📊 متقدم
                numCommandTimeout.Value = decimal.Parse(Get("CommandTimeout", "30"));
                numRetryCount.Value = decimal.Parse(Get("RetryCount", "3"));
                txtLogPath.Text = Get("LogPath", Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Logs"));
                chkAutoUpdate.Checked = bool.Parse(Get("AutoUpdate", "false"));
            }
            catch (Exception ex)
            {
                LogHelper.LogError(ex, "frmSettings.LoadSettings");
            }
        }

        private void Save(string key, string value)
        {
            try
            {
                var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                if (config.AppSettings.Settings[key] == null)
                    config.AppSettings.Settings.Add(key, value);
                else
                    config.AppSettings.Settings[key].Value = value;
                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");
            }
            catch (Exception ex)
            {
                LogHelper.LogError(ex, "frmSettings.Save");
            }
        }

        // ============================================
        // الأحداث
        // ============================================

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // ✅ التحقق
                if (string.IsNullOrWhiteSpace(txtCompanyName.Text))
                {
                    MessageHelper.ShowWarning("اسم الشركة مطلوب");
                    tabSettings.SelectedTab = tabGeneral;
                    txtCompanyName.Focus();
                    return;
                }

                // 🏢 عام
                Save("CompanyName", txtCompanyName.Text.Trim());
                Save("CompanyPhone", txtCompanyPhone.Text.Trim());
                Save("CompanyAddress", txtCompanyAddress.Text.Trim());
                Save("Currency", txtCurrency.Text.Trim());
                Save("Language", cmbLanguage.SelectedItem.ToString());
                Save("DateFormat", cmbDateFormat.SelectedItem.ToString());

                // 📦 المخزون
                Save("MinStockAlert", numMinStockAlert.Value.ToString());
                Save("ExpiryAlertDays", numExpiryDays.Value.ToString());
                Save("StocktakeDays", numStocktakeDays.Value.ToString());
                Save("ShowLowStockAlert", chkShowLowStockAlert.Checked.ToString());
                Save("ShowExpiryAlert", chkShowExpiryAlert.Checked.ToString());
                Save("ForceBatch", chkForceBatch.Checked.ToString());
                Save("AllowNegative", chkAllowNegative.Checked.ToString());
                Save("ValuationMethod", cmbValuationMethod.SelectedIndex.ToString());
                Save("IssueMethod", cmbIssueMethod.SelectedIndex.ToString());

                // 🧾 الفواتير
                Save("InvoiceHeader", txtInvoiceHeader.Text);
                Save("InvoiceFooter", txtInvoiceFooter.Text);
                Save("TaxRate", numTaxRate.Value.ToString());
                Save("DefaultDiscount", numDefaultDiscount.Value.ToString());
                Save("PaperSize", cmbPaperSize.SelectedIndex.ToString());
                Save("Copies", numCopies.Value.ToString());

                // 🔐 الأمان
                Save("PasswordMinLength", numPasswordMinLength.Value.ToString());
                Save("RequireUppercase", chkRequireUppercase.Checked.ToString());
                Save("RequireNumbers", chkRequireNumbers.Checked.ToString());
                Save("RequireSymbols", chkRequireSymbols.Checked.ToString());
                Save("SessionTimeout", numSessionTimeout.Value.ToString());
                Save("MaxLoginAttempts", numMaxLoginAttempts.Value.ToString());
                Save("LockoutMinutes", numLockoutMinutes.Value.ToString());

                // 🔔 الإشعارات
                Save("SoundAlerts", chkSoundAlerts.Checked.ToString());
                Save("DesktopNotifications", chkDesktopNotifications.Checked.ToString());
                Save("EmailNotifications", chkEmailNotifications.Checked.ToString());
                Save("SmtpServer", txtSmtpServer.Text);
                Save("SmtpPort", numSmtpPort.Value.ToString());
                Save("SmtpUser", txtSmtpUser.Text);
                Save("SmtpPassword", txtSmtpPassword.Text);

                // 🗄️ قاعدة البيانات
                Save("AutoBackup", chkAutoBackup.Checked.ToString());
                Save("BackupFrequency", cmbBackupFrequency.SelectedIndex.ToString());
                Save("BackupKeepDays", numBackupKeepDays.Value.ToString());

                // 📊 متقدم
                Save("CommandTimeout", numCommandTimeout.Value.ToString());
                Save("RetryCount", numRetryCount.Value.ToString());
                Save("LogLevel", cmbLogLevel.SelectedIndex.ToString());
                Save("LogPath", txtLogPath.Text);
                Save("AutoUpdate", chkAutoUpdate.Checked.ToString());

                LogHelper.LogInfo("تم حفظ إعدادات النظام");
                MessageHelper.ShowSuccess("✅ تم حفظ الإعدادات بنجاح\n\nبعض الإعدادات تحتاج إعادة تشغيل البرنامج.");

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                LogHelper.LogError(ex, "frmSettings.btnSave_Click");
                MessageHelper.ShowError($"فشل في الحفظ: {ex.Message}");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (!MessageHelper.Confirm("هل تريد استعادة الإعدادات الافتراضية؟"))
                return;

            try
            {
                txtCompanyName.Text = "شركتي";
                txtCompanyPhone.Text = "";
                txtCompanyAddress.Text = "";
                txtCurrency.Text = "ريال";
                numMinStockAlert.Value = 10;
                numExpiryDays.Value = 30;
                numStocktakeDays.Value = 30;
                numTaxRate.Value = 0;
                numDefaultDiscount.Value = 0;
                numPasswordMinLength.Value = 6;
                numSessionTimeout.Value = 30;
                numMaxLoginAttempts.Value = 3;
                numLockoutMinutes.Value = 15;
                numCommandTimeout.Value = 30;
                numRetryCount.Value = 3;
                numBackupKeepDays.Value = 30;
                numSmtpPort.Value = 587;
                txtSmtpServer.Text = "smtp.gmail.com";
                txtSmtpUser.Text = "";
                txtSmtpPassword.Text = "";

                MessageHelper.ShowSuccess("✅ تم استعادة الإعدادات الافتراضية\n\nاضغط 'حفظ الإعدادات' للتأكيد.");
            }
            catch (Exception ex)
            {
                LogHelper.LogError(ex, "frmSettings.btnReset_Click");
                MessageHelper.ShowError($"فشل: {ex.Message}");
            }
        }

        private void btnBrowseLogo_Click(object sender, EventArgs e)
        {
            using (var dialog = new OpenFileDialog())
            {
                dialog.Filter = "Images (*.png;*.jpg;*.jpeg;*.bmp)|*.png;*.jpg;*.jpeg;*.bmp";
                dialog.Title = "اختر شعار الشركة";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        picLogo.Image = Image.FromFile(dialog.FileName);
                        Save("CompanyLogo", dialog.FileName);
                    }
                    catch (Exception ex)
                    {
                        MessageHelper.ShowError($"فشل: {ex.Message}");
                    }
                }
            }
        }

        private void btnTestConnection_Click(object sender, EventArgs e)
        {
            try
            {
                if (DatabaseHelper.TestConnection())
                    MessageHelper.ShowSuccess("✅ الاتصال ناجح");
                else
                    MessageHelper.ShowError("❌ فشل الاتصال");
            }
            catch (Exception ex)
            {
                MessageHelper.ShowException(ex);
            }
        }

        private void btnCreateBackup_Click(object sender, EventArgs e)
        {
            try
            {
                new frmBackup().ShowDialog();
            }
            catch (Exception ex)
            {
                MessageHelper.ShowException(ex);
            }
        }

        private void btnRestoreBackup_Click(object sender, EventArgs e)
        {
            MessageHelper.ShowInfo(
                "⚠️ لاستعادة نسخة احتياطية:\n\n" +
                "1. أغلق البرنامج\n" +
                "2. افتح SQL Server Management Studio\n" +
                "3. اضغط Right-click على قاعدة البيانات\n" +
                "4. اختر Tasks → Restore → Database\n" +
                "5. اختر ملف النسخة الاحتياطية");
        }
    }
}