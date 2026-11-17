namespace InventorySystem.UI.Forms
{
    partial class frmMain
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.btnBackup = new System.Windows.Forms.Button();
            this.btnLookups = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnRoles = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnStocktake = new System.Windows.Forms.Button();
            this.btnMovements = new System.Windows.Forms.Button();
            this.btnInventory = new System.Windows.Forms.Button();
            this.btnPartners = new System.Windows.Forms.Button();
            this.btnWarehouses = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.btnUnits = new System.Windows.Forms.Button();
            this.btnCategories = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.pnlUserInfo = new System.Windows.Forms.Panel();
            this.lblUserRole = new System.Windows.Forms.Label();
            this.lblUserFullName = new System.Windows.Forms.Label();
            this.lblUserIcon = new System.Windows.Forms.Label();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlDashboard = new System.Windows.Forms.Panel();
            this.grpAlerts = new System.Windows.Forms.GroupBox();
            this.dgvAlerts = new System.Windows.Forms.DataGridView();
            this.grpRecentMovements = new System.Windows.Forms.GroupBox();
            this.dgvRecentMovements = new System.Windows.Forms.DataGridView();
            this.pnlStats = new System.Windows.Forms.Panel();
            this.cardAlerts = new System.Windows.Forms.Panel();
            this.lblAlertsCount = new System.Windows.Forms.Label();
            this.lblAlertsTitle = new System.Windows.Forms.Label();
            this.picAlerts = new System.Windows.Forms.Label();
            this.cardMovements = new System.Windows.Forms.Panel();
            this.lblMovementsCount = new System.Windows.Forms.Label();
            this.lblMovementsTitle = new System.Windows.Forms.Label();
            this.picMovements = new System.Windows.Forms.Label();
            this.cardWarehouses = new System.Windows.Forms.Panel();
            this.lblWarehousesCount = new System.Windows.Forms.Label();
            this.lblWarehousesTitle = new System.Windows.Forms.Label();
            this.picWarehouses = new System.Windows.Forms.Label();
            this.cardProducts = new System.Windows.Forms.Panel();
            this.lblProductsCount = new System.Windows.Forms.Label();
            this.lblProductsTitle = new System.Windows.Forms.Label();
            this.picProducts = new System.Windows.Forms.Label();
            this.pnlWelcome = new System.Windows.Forms.Panel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.pnlStatus = new System.Windows.Forms.Panel();
            this.lblStatusVersion = new System.Windows.Forms.Label();
            this.lblStatusDate = new System.Windows.Forms.Label();
            this.lblStatusUser = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.pnlSidebar.SuspendLayout();
            this.pnlUserInfo.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlDashboard.SuspendLayout();
            this.grpAlerts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlerts)).BeginInit();
            this.grpRecentMovements.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecentMovements)).BeginInit();
            this.pnlStats.SuspendLayout();
            this.cardAlerts.SuspendLayout();
            this.cardMovements.SuspendLayout();
            this.cardWarehouses.SuspendLayout();
            this.cardProducts.SuspendLayout();
            this.pnlWelcome.SuspendLayout();
            this.pnlStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.pnlHeader.Controls.Add(this.btnLogout);
            this.pnlHeader.Controls.Add(this.lblUser);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1633, 92);
            this.pnlHeader.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(23, 18);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(152, 55);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "🚪 خروج";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblUser
            // 
            this.lblUser.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblUser.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblUser.ForeColor = System.Drawing.Color.White;
            this.lblUser.Location = new System.Drawing.Point(1050, 0);
            this.lblUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Padding = new System.Windows.Forms.Padding(0, 0, 23, 0);
            this.lblUser.Size = new System.Drawing.Size(583, 92);
            this.lblUser.TabIndex = 1;
            this.lblUser.Text = "👤 المستخدم";
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.lblTitle.Size = new System.Drawing.Size(949, 92);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "📚 نظام إدارة المخزون والمستودعات";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.pnlSidebar.Controls.Add(this.btnBackup);
            this.pnlSidebar.Controls.Add(this.btnLookups);
            this.pnlSidebar.Controls.Add(this.btnSettings);
            this.pnlSidebar.Controls.Add(this.btnRoles);
            this.pnlSidebar.Controls.Add(this.btnReports);
            this.pnlSidebar.Controls.Add(this.btnStocktake);
            this.pnlSidebar.Controls.Add(this.btnMovements);
            this.pnlSidebar.Controls.Add(this.btnInventory);
            this.pnlSidebar.Controls.Add(this.btnPartners);
            this.pnlSidebar.Controls.Add(this.btnWarehouses);
            this.pnlSidebar.Controls.Add(this.btnProducts);
            this.pnlSidebar.Controls.Add(this.btnUnits);
            this.pnlSidebar.Controls.Add(this.btnCategories);
            this.pnlSidebar.Controls.Add(this.btnUsers);
            this.pnlSidebar.Controls.Add(this.pnlUserInfo);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 92);
            this.pnlSidebar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(292, 862);
            this.pnlSidebar.TabIndex = 1;
            // 
            // btnBackup
            // 
            this.btnBackup.BackColor = System.Drawing.Color.Transparent;
            this.btnBackup.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBackup.FlatAppearance.BorderSize = 0;
            this.btnBackup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackup.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.btnBackup.ForeColor = System.Drawing.Color.White;
            this.btnBackup.Location = new System.Drawing.Point(0, 715);
            this.btnBackup.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Padding = new System.Windows.Forms.Padding(0, 0, 23, 0);
            this.btnBackup.Size = new System.Drawing.Size(292, 55);
            this.btnBackup.TabIndex = 13;
            this.btnBackup.Text = "💾  النسخ الاحتياطي";
            this.btnBackup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBackup.UseVisualStyleBackColor = false;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // btnLookups
            // 
            this.btnLookups.BackColor = System.Drawing.Color.Transparent;
            this.btnLookups.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLookups.FlatAppearance.BorderSize = 0;
            this.btnLookups.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnLookups.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLookups.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.btnLookups.ForeColor = System.Drawing.Color.White;
            this.btnLookups.Location = new System.Drawing.Point(0, 660);
            this.btnLookups.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLookups.Name = "btnLookups";
            this.btnLookups.Padding = new System.Windows.Forms.Padding(0, 0, 23, 0);
            this.btnLookups.Size = new System.Drawing.Size(292, 55);
            this.btnLookups.TabIndex = 12;
            this.btnLookups.Text = "📚  الجداول المرجعية";
            this.btnLookups.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLookups.UseVisualStyleBackColor = false;
            this.btnLookups.Click += new System.EventHandler(this.btnLookups_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.Transparent;
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.Location = new System.Drawing.Point(0, 605);
            this.btnSettings.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Padding = new System.Windows.Forms.Padding(0, 0, 23, 0);
            this.btnSettings.Size = new System.Drawing.Size(292, 55);
            this.btnSettings.TabIndex = 11;
            this.btnSettings.Text = "⚙️  الإعدادات";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnRoles
            // 
            this.btnRoles.BackColor = System.Drawing.Color.Transparent;
            this.btnRoles.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRoles.FlatAppearance.BorderSize = 0;
            this.btnRoles.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnRoles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoles.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.btnRoles.ForeColor = System.Drawing.Color.White;
            this.btnRoles.Location = new System.Drawing.Point(0, 550);
            this.btnRoles.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRoles.Name = "btnRoles";
            this.btnRoles.Padding = new System.Windows.Forms.Padding(0, 0, 23, 0);
            this.btnRoles.Size = new System.Drawing.Size(292, 55);
            this.btnRoles.TabIndex = 10;
            this.btnRoles.Text = "🎭  الأدوار والصلاحيات";
            this.btnRoles.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRoles.UseVisualStyleBackColor = false;
            this.btnRoles.Click += new System.EventHandler(this.btnRoles_Click);
            // 
            // btnReports
            // 
            this.btnReports.BackColor = System.Drawing.Color.Transparent;
            this.btnReports.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReports.FlatAppearance.BorderSize = 0;
            this.btnReports.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.btnReports.ForeColor = System.Drawing.Color.White;
            this.btnReports.Location = new System.Drawing.Point(0, 495);
            this.btnReports.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReports.Name = "btnReports";
            this.btnReports.Padding = new System.Windows.Forms.Padding(0, 0, 23, 0);
            this.btnReports.Size = new System.Drawing.Size(292, 55);
            this.btnReports.TabIndex = 9;
            this.btnReports.Text = "📊  التقارير";
            this.btnReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReports.UseVisualStyleBackColor = false;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnStocktake
            // 
            this.btnStocktake.BackColor = System.Drawing.Color.Transparent;
            this.btnStocktake.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStocktake.FlatAppearance.BorderSize = 0;
            this.btnStocktake.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnStocktake.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStocktake.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.btnStocktake.ForeColor = System.Drawing.Color.White;
            this.btnStocktake.Location = new System.Drawing.Point(0, 440);
            this.btnStocktake.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStocktake.Name = "btnStocktake";
            this.btnStocktake.Padding = new System.Windows.Forms.Padding(0, 0, 23, 0);
            this.btnStocktake.Size = new System.Drawing.Size(292, 55);
            this.btnStocktake.TabIndex = 8;
            this.btnStocktake.Text = "📋  الجرد";
            this.btnStocktake.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStocktake.UseVisualStyleBackColor = false;
            this.btnStocktake.Click += new System.EventHandler(this.btnStocktake_Click);
            // 
            // btnMovements
            // 
            this.btnMovements.BackColor = System.Drawing.Color.Transparent;
            this.btnMovements.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMovements.FlatAppearance.BorderSize = 0;
            this.btnMovements.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnMovements.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMovements.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.btnMovements.ForeColor = System.Drawing.Color.White;
            this.btnMovements.Location = new System.Drawing.Point(0, 385);
            this.btnMovements.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMovements.Name = "btnMovements";
            this.btnMovements.Padding = new System.Windows.Forms.Padding(0, 0, 23, 0);
            this.btnMovements.Size = new System.Drawing.Size(292, 55);
            this.btnMovements.TabIndex = 7;
            this.btnMovements.Text = "🔄  الحركات";
            this.btnMovements.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMovements.UseVisualStyleBackColor = false;
            this.btnMovements.Click += new System.EventHandler(this.btnMovements_Click);
            // 
            // btnInventory
            // 
            this.btnInventory.BackColor = System.Drawing.Color.Transparent;
            this.btnInventory.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInventory.FlatAppearance.BorderSize = 0;
            this.btnInventory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventory.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.btnInventory.ForeColor = System.Drawing.Color.White;
            this.btnInventory.Location = new System.Drawing.Point(0, 330);
            this.btnInventory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Padding = new System.Windows.Forms.Padding(0, 0, 23, 0);
            this.btnInventory.Size = new System.Drawing.Size(292, 55);
            this.btnInventory.TabIndex = 6;
            this.btnInventory.Text = "📦  المخزون";
            this.btnInventory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventory.UseVisualStyleBackColor = false;
            this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click);
            // 
            // btnPartners
            // 
            this.btnPartners.BackColor = System.Drawing.Color.Transparent;
            this.btnPartners.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPartners.FlatAppearance.BorderSize = 0;
            this.btnPartners.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnPartners.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPartners.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.btnPartners.ForeColor = System.Drawing.Color.White;
            this.btnPartners.Location = new System.Drawing.Point(0, 275);
            this.btnPartners.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPartners.Name = "btnPartners";
            this.btnPartners.Padding = new System.Windows.Forms.Padding(0, 0, 23, 0);
            this.btnPartners.Size = new System.Drawing.Size(292, 55);
            this.btnPartners.TabIndex = 5;
            this.btnPartners.Text = "🤝  الشركاء";
            this.btnPartners.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPartners.UseVisualStyleBackColor = false;
            this.btnPartners.Click += new System.EventHandler(this.btnPartners_Click);
            // 
            // btnWarehouses
            // 
            this.btnWarehouses.BackColor = System.Drawing.Color.Transparent;
            this.btnWarehouses.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnWarehouses.FlatAppearance.BorderSize = 0;
            this.btnWarehouses.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnWarehouses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWarehouses.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.btnWarehouses.ForeColor = System.Drawing.Color.White;
            this.btnWarehouses.Location = new System.Drawing.Point(0, 220);
            this.btnWarehouses.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnWarehouses.Name = "btnWarehouses";
            this.btnWarehouses.Padding = new System.Windows.Forms.Padding(0, 0, 23, 0);
            this.btnWarehouses.Size = new System.Drawing.Size(292, 55);
            this.btnWarehouses.TabIndex = 4;
            this.btnWarehouses.Text = "🏪  المستودعات";
            this.btnWarehouses.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWarehouses.UseVisualStyleBackColor = false;
            this.btnWarehouses.Click += new System.EventHandler(this.btnWarehouses_Click);
            // 
            // btnProducts
            // 
            this.btnProducts.BackColor = System.Drawing.Color.Transparent;
            this.btnProducts.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProducts.FlatAppearance.BorderSize = 0;
            this.btnProducts.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProducts.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.btnProducts.ForeColor = System.Drawing.Color.White;
            this.btnProducts.Location = new System.Drawing.Point(0, 165);
            this.btnProducts.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Padding = new System.Windows.Forms.Padding(0, 0, 23, 0);
            this.btnProducts.Size = new System.Drawing.Size(292, 55);
            this.btnProducts.TabIndex = 3;
            this.btnProducts.Text = "📦  المنتجات";
            this.btnProducts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProducts.UseVisualStyleBackColor = false;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // btnUnits
            // 
            this.btnUnits.BackColor = System.Drawing.Color.Transparent;
            this.btnUnits.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUnits.FlatAppearance.BorderSize = 0;
            this.btnUnits.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnUnits.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnits.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.btnUnits.ForeColor = System.Drawing.Color.White;
            this.btnUnits.Location = new System.Drawing.Point(0, 110);
            this.btnUnits.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUnits.Name = "btnUnits";
            this.btnUnits.Padding = new System.Windows.Forms.Padding(0, 0, 23, 0);
            this.btnUnits.Size = new System.Drawing.Size(292, 55);
            this.btnUnits.TabIndex = 2;
            this.btnUnits.Text = "📏  الوحدات";
            this.btnUnits.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUnits.UseVisualStyleBackColor = false;
            this.btnUnits.Click += new System.EventHandler(this.btnUnits_Click);
            // 
            // btnCategories
            // 
            this.btnCategories.BackColor = System.Drawing.Color.Transparent;
            this.btnCategories.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCategories.FlatAppearance.BorderSize = 0;
            this.btnCategories.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnCategories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategories.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.btnCategories.ForeColor = System.Drawing.Color.White;
            this.btnCategories.Location = new System.Drawing.Point(0, 55);
            this.btnCategories.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCategories.Name = "btnCategories";
            this.btnCategories.Padding = new System.Windows.Forms.Padding(0, 0, 23, 0);
            this.btnCategories.Size = new System.Drawing.Size(292, 55);
            this.btnCategories.TabIndex = 1;
            this.btnCategories.Text = "📂  التصنيفات";
            this.btnCategories.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategories.UseVisualStyleBackColor = false;
            this.btnCategories.Click += new System.EventHandler(this.btnCategories_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.BackColor = System.Drawing.Color.Transparent;
            this.btnUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsers.FlatAppearance.BorderSize = 0;
            this.btnUsers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsers.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.btnUsers.ForeColor = System.Drawing.Color.White;
            this.btnUsers.Location = new System.Drawing.Point(0, 0);
            this.btnUsers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Padding = new System.Windows.Forms.Padding(0, 0, 23, 0);
            this.btnUsers.Size = new System.Drawing.Size(292, 55);
            this.btnUsers.TabIndex = 0;
            this.btnUsers.Text = "👥  المستخدمون";
            this.btnUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsers.UseVisualStyleBackColor = false;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // pnlUserInfo
            // 
            this.pnlUserInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.pnlUserInfo.Controls.Add(this.lblUserRole);
            this.pnlUserInfo.Controls.Add(this.lblUserFullName);
            this.pnlUserInfo.Controls.Add(this.lblUserIcon);
            this.pnlUserInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlUserInfo.Location = new System.Drawing.Point(0, 788);
            this.pnlUserInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlUserInfo.Name = "pnlUserInfo";
            this.pnlUserInfo.Size = new System.Drawing.Size(292, 74);
            this.pnlUserInfo.TabIndex = 14;
            // 
            // lblUserRole
            // 
            this.lblUserRole.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblUserRole.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblUserRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.lblUserRole.Location = new System.Drawing.Point(0, 24);
            this.lblUserRole.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserRole.Name = "lblUserRole";
            this.lblUserRole.Padding = new System.Windows.Forms.Padding(0, 0, 23, 0);
            this.lblUserRole.Size = new System.Drawing.Size(292, 25);
            this.lblUserRole.TabIndex = 2;
            this.lblUserRole.Text = "مدير النظام";
            this.lblUserRole.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblUserFullName
            // 
            this.lblUserFullName.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblUserFullName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblUserFullName.ForeColor = System.Drawing.Color.White;
            this.lblUserFullName.Location = new System.Drawing.Point(0, 49);
            this.lblUserFullName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserFullName.Name = "lblUserFullName";
            this.lblUserFullName.Padding = new System.Windows.Forms.Padding(0, 0, 23, 0);
            this.lblUserFullName.Size = new System.Drawing.Size(292, 25);
            this.lblUserFullName.TabIndex = 1;
            this.lblUserFullName.Text = "المستخدم";
            this.lblUserFullName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblUserIcon
            // 
            this.lblUserIcon.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblUserIcon.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.lblUserIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.lblUserIcon.Location = new System.Drawing.Point(0, 0);
            this.lblUserIcon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserIcon.Name = "lblUserIcon";
            this.lblUserIcon.Padding = new System.Windows.Forms.Padding(0, 0, 23, 0);
            this.lblUserIcon.Size = new System.Drawing.Size(292, 25);
            this.lblUserIcon.TabIndex = 0;
            this.lblUserIcon.Text = "👤";
            this.lblUserIcon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.pnlContent.Controls.Add(this.pnlDashboard);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(292, 92);
            this.pnlContent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1341, 862);
            this.pnlContent.TabIndex = 2;
            // 
            // pnlDashboard
            // 
            this.pnlDashboard.AutoScroll = true;
            this.pnlDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.pnlDashboard.Controls.Add(this.grpAlerts);
            this.pnlDashboard.Controls.Add(this.grpRecentMovements);
            this.pnlDashboard.Controls.Add(this.pnlStats);
            this.pnlDashboard.Controls.Add(this.pnlWelcome);
            this.pnlDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDashboard.Location = new System.Drawing.Point(0, 0);
            this.pnlDashboard.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlDashboard.Name = "pnlDashboard";
            this.pnlDashboard.Padding = new System.Windows.Forms.Padding(23, 25, 23, 25);
            this.pnlDashboard.Size = new System.Drawing.Size(1341, 862);
            this.pnlDashboard.TabIndex = 0;
            // 
            // grpAlerts
            // 
            this.grpAlerts.BackColor = System.Drawing.Color.White;
            this.grpAlerts.Controls.Add(this.dgvAlerts);
            this.grpAlerts.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.grpAlerts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.grpAlerts.Location = new System.Drawing.Point(23, 615);
            this.grpAlerts.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpAlerts.Name = "grpAlerts";
            this.grpAlerts.Padding = new System.Windows.Forms.Padding(12, 12, 12, 12);
            this.grpAlerts.Size = new System.Drawing.Size(1295, 222);
            this.grpAlerts.TabIndex = 3;
            this.grpAlerts.TabStop = false;
            this.grpAlerts.Text = "🔔 منتجات تحت الحد الأدنى";
            // 
            // dgvAlerts
            // 
            this.dgvAlerts.AllowUserToAddRows = false;
            this.dgvAlerts.AllowUserToDeleteRows = false;
            this.dgvAlerts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAlerts.BackgroundColor = System.Drawing.Color.White;
            this.dgvAlerts.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvAlerts.ColumnHeadersHeight = 40;
            this.dgvAlerts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAlerts.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.dgvAlerts.Location = new System.Drawing.Point(12, 39);
            this.dgvAlerts.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvAlerts.MultiSelect = false;
            this.dgvAlerts.Name = "dgvAlerts";
            this.dgvAlerts.ReadOnly = true;
            this.dgvAlerts.RowHeadersVisible = false;
            this.dgvAlerts.RowHeadersWidth = 51;
            this.dgvAlerts.RowTemplate.Height = 35;
            this.dgvAlerts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAlerts.Size = new System.Drawing.Size(1271, 171);
            this.dgvAlerts.TabIndex = 0;
            // 
            // grpRecentMovements
            // 
            this.grpRecentMovements.BackColor = System.Drawing.Color.White;
            this.grpRecentMovements.Controls.Add(this.dgvRecentMovements);
            this.grpRecentMovements.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.grpRecentMovements.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.grpRecentMovements.Location = new System.Drawing.Point(23, 345);
            this.grpRecentMovements.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpRecentMovements.Name = "grpRecentMovements";
            this.grpRecentMovements.Padding = new System.Windows.Forms.Padding(12, 12, 12, 12);
            this.grpRecentMovements.Size = new System.Drawing.Size(1295, 246);
            this.grpRecentMovements.TabIndex = 2;
            this.grpRecentMovements.TabStop = false;
            this.grpRecentMovements.Text = "🔄 آخر الحركات";
            // 
            // dgvRecentMovements
            // 
            this.dgvRecentMovements.AllowUserToAddRows = false;
            this.dgvRecentMovements.AllowUserToDeleteRows = false;
            this.dgvRecentMovements.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRecentMovements.BackgroundColor = System.Drawing.Color.White;
            this.dgvRecentMovements.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvRecentMovements.ColumnHeadersHeight = 40;
            this.dgvRecentMovements.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRecentMovements.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.dgvRecentMovements.Location = new System.Drawing.Point(12, 39);
            this.dgvRecentMovements.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvRecentMovements.MultiSelect = false;
            this.dgvRecentMovements.Name = "dgvRecentMovements";
            this.dgvRecentMovements.ReadOnly = true;
            this.dgvRecentMovements.RowHeadersVisible = false;
            this.dgvRecentMovements.RowHeadersWidth = 51;
            this.dgvRecentMovements.RowTemplate.Height = 35;
            this.dgvRecentMovements.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRecentMovements.Size = new System.Drawing.Size(1271, 195);
            this.dgvRecentMovements.TabIndex = 0;
            // 
            // pnlStats
            // 
            this.pnlStats.Controls.Add(this.cardAlerts);
            this.pnlStats.Controls.Add(this.cardMovements);
            this.pnlStats.Controls.Add(this.cardWarehouses);
            this.pnlStats.Controls.Add(this.cardProducts);
            this.pnlStats.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlStats.Location = new System.Drawing.Point(23, 123);
            this.pnlStats.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlStats.Name = "pnlStats";
            this.pnlStats.Padding = new System.Windows.Forms.Padding(0, 0, 0, 25);
            this.pnlStats.Size = new System.Drawing.Size(1295, 222);
            this.pnlStats.TabIndex = 1;
            // 
            // cardAlerts
            // 
            this.cardAlerts.BackColor = System.Drawing.Color.White;
            this.cardAlerts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardAlerts.Controls.Add(this.lblAlertsCount);
            this.cardAlerts.Controls.Add(this.lblAlertsTitle);
            this.cardAlerts.Controls.Add(this.picAlerts);
            this.cardAlerts.Location = new System.Drawing.Point(980, 0);
            this.cardAlerts.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cardAlerts.Name = "cardAlerts";
            this.cardAlerts.Size = new System.Drawing.Size(303, 196);
            this.cardAlerts.TabIndex = 3;
            // 
            // lblAlertsCount
            // 
            this.lblAlertsCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAlertsCount.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold);
            this.lblAlertsCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.lblAlertsCount.Location = new System.Drawing.Point(0, 74);
            this.lblAlertsCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAlertsCount.Name = "lblAlertsCount";
            this.lblAlertsCount.Size = new System.Drawing.Size(301, 71);
            this.lblAlertsCount.TabIndex = 2;
            this.lblAlertsCount.Text = "0";
            this.lblAlertsCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAlertsTitle
            // 
            this.lblAlertsTitle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblAlertsTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblAlertsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblAlertsTitle.Location = new System.Drawing.Point(0, 145);
            this.lblAlertsTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAlertsTitle.Name = "lblAlertsTitle";
            this.lblAlertsTitle.Size = new System.Drawing.Size(301, 49);
            this.lblAlertsTitle.TabIndex = 1;
            this.lblAlertsTitle.Text = "تنبيهات المخزون";
            this.lblAlertsTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picAlerts
            // 
            this.picAlerts.Dock = System.Windows.Forms.DockStyle.Top;
            this.picAlerts.Font = new System.Drawing.Font("Segoe UI Emoji", 28F);
            this.picAlerts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.picAlerts.Location = new System.Drawing.Point(0, 0);
            this.picAlerts.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.picAlerts.Name = "picAlerts";
            this.picAlerts.Size = new System.Drawing.Size(301, 74);
            this.picAlerts.TabIndex = 0;
            this.picAlerts.Text = "🔔";
            this.picAlerts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cardMovements
            // 
            this.cardMovements.BackColor = System.Drawing.Color.White;
            this.cardMovements.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardMovements.Controls.Add(this.lblMovementsCount);
            this.cardMovements.Controls.Add(this.lblMovementsTitle);
            this.cardMovements.Controls.Add(this.picMovements);
            this.cardMovements.Location = new System.Drawing.Point(653, 0);
            this.cardMovements.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cardMovements.Name = "cardMovements";
            this.cardMovements.Size = new System.Drawing.Size(303, 196);
            this.cardMovements.TabIndex = 2;
            // 
            // lblMovementsCount
            // 
            this.lblMovementsCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMovementsCount.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold);
            this.lblMovementsCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.lblMovementsCount.Location = new System.Drawing.Point(0, 74);
            this.lblMovementsCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMovementsCount.Name = "lblMovementsCount";
            this.lblMovementsCount.Size = new System.Drawing.Size(301, 71);
            this.lblMovementsCount.TabIndex = 2;
            this.lblMovementsCount.Text = "0";
            this.lblMovementsCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMovementsTitle
            // 
            this.lblMovementsTitle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblMovementsTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblMovementsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblMovementsTitle.Location = new System.Drawing.Point(0, 145);
            this.lblMovementsTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMovementsTitle.Name = "lblMovementsTitle";
            this.lblMovementsTitle.Size = new System.Drawing.Size(301, 49);
            this.lblMovementsTitle.TabIndex = 1;
            this.lblMovementsTitle.Text = "حركات اليوم";
            this.lblMovementsTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picMovements
            // 
            this.picMovements.Dock = System.Windows.Forms.DockStyle.Top;
            this.picMovements.Font = new System.Drawing.Font("Segoe UI Emoji", 28F);
            this.picMovements.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.picMovements.Location = new System.Drawing.Point(0, 0);
            this.picMovements.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.picMovements.Name = "picMovements";
            this.picMovements.Size = new System.Drawing.Size(301, 74);
            this.picMovements.TabIndex = 0;
            this.picMovements.Text = "🔄";
            this.picMovements.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cardWarehouses
            // 
            this.cardWarehouses.BackColor = System.Drawing.Color.White;
            this.cardWarehouses.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardWarehouses.Controls.Add(this.lblWarehousesCount);
            this.cardWarehouses.Controls.Add(this.lblWarehousesTitle);
            this.cardWarehouses.Controls.Add(this.picWarehouses);
            this.cardWarehouses.Location = new System.Drawing.Point(327, 0);
            this.cardWarehouses.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cardWarehouses.Name = "cardWarehouses";
            this.cardWarehouses.Size = new System.Drawing.Size(303, 196);
            this.cardWarehouses.TabIndex = 1;
            // 
            // lblWarehousesCount
            // 
            this.lblWarehousesCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblWarehousesCount.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold);
            this.lblWarehousesCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.lblWarehousesCount.Location = new System.Drawing.Point(0, 74);
            this.lblWarehousesCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWarehousesCount.Name = "lblWarehousesCount";
            this.lblWarehousesCount.Size = new System.Drawing.Size(301, 71);
            this.lblWarehousesCount.TabIndex = 2;
            this.lblWarehousesCount.Text = "0";
            this.lblWarehousesCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWarehousesTitle
            // 
            this.lblWarehousesTitle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblWarehousesTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblWarehousesTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblWarehousesTitle.Location = new System.Drawing.Point(0, 145);
            this.lblWarehousesTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWarehousesTitle.Name = "lblWarehousesTitle";
            this.lblWarehousesTitle.Size = new System.Drawing.Size(301, 49);
            this.lblWarehousesTitle.TabIndex = 1;
            this.lblWarehousesTitle.Text = "المستودعات";
            this.lblWarehousesTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picWarehouses
            // 
            this.picWarehouses.Dock = System.Windows.Forms.DockStyle.Top;
            this.picWarehouses.Font = new System.Drawing.Font("Segoe UI Emoji", 28F);
            this.picWarehouses.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.picWarehouses.Location = new System.Drawing.Point(0, 0);
            this.picWarehouses.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.picWarehouses.Name = "picWarehouses";
            this.picWarehouses.Size = new System.Drawing.Size(301, 74);
            this.picWarehouses.TabIndex = 0;
            this.picWarehouses.Text = "🏪";
            this.picWarehouses.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cardProducts
            // 
            this.cardProducts.BackColor = System.Drawing.Color.White;
            this.cardProducts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardProducts.Controls.Add(this.lblProductsCount);
            this.cardProducts.Controls.Add(this.lblProductsTitle);
            this.cardProducts.Controls.Add(this.picProducts);
            this.cardProducts.Location = new System.Drawing.Point(0, 0);
            this.cardProducts.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cardProducts.Name = "cardProducts";
            this.cardProducts.Size = new System.Drawing.Size(303, 196);
            this.cardProducts.TabIndex = 0;
            // 
            // lblProductsCount
            // 
            this.lblProductsCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblProductsCount.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold);
            this.lblProductsCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblProductsCount.Location = new System.Drawing.Point(0, 74);
            this.lblProductsCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProductsCount.Name = "lblProductsCount";
            this.lblProductsCount.Size = new System.Drawing.Size(301, 71);
            this.lblProductsCount.TabIndex = 2;
            this.lblProductsCount.Text = "0";
            this.lblProductsCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProductsTitle
            // 
            this.lblProductsTitle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblProductsTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblProductsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblProductsTitle.Location = new System.Drawing.Point(0, 145);
            this.lblProductsTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProductsTitle.Name = "lblProductsTitle";
            this.lblProductsTitle.Size = new System.Drawing.Size(301, 49);
            this.lblProductsTitle.TabIndex = 1;
            this.lblProductsTitle.Text = "المنتجات";
            this.lblProductsTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picProducts
            // 
            this.picProducts.Dock = System.Windows.Forms.DockStyle.Top;
            this.picProducts.Font = new System.Drawing.Font("Segoe UI Emoji", 28F);
            this.picProducts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.picProducts.Location = new System.Drawing.Point(0, 0);
            this.picProducts.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.picProducts.Name = "picProducts";
            this.picProducts.Size = new System.Drawing.Size(301, 74);
            this.picProducts.TabIndex = 0;
            this.picProducts.Text = "📦";
            this.picProducts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlWelcome
            // 
            this.pnlWelcome.Controls.Add(this.lblWelcome);
            this.pnlWelcome.Controls.Add(this.btnRefresh);
            this.pnlWelcome.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlWelcome.Location = new System.Drawing.Point(23, 25);
            this.pnlWelcome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlWelcome.Name = "pnlWelcome";
            this.pnlWelcome.Size = new System.Drawing.Size(1295, 98);
            this.pnlWelcome.TabIndex = 0;
            // 
            // lblWelcome
            // 
            this.lblWelcome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblWelcome.Location = new System.Drawing.Point(0, 0);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.lblWelcome.Size = new System.Drawing.Size(1196, 98);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "مرحباً بك في لوحة التحكم 👋";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnRefresh.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(1196, 0);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(99, 98);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "🔄 تحديث";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // pnlStatus
            // 
            this.pnlStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.pnlStatus.Controls.Add(this.lblStatusVersion);
            this.pnlStatus.Controls.Add(this.lblStatusDate);
            this.pnlStatus.Controls.Add(this.lblStatusUser);
            this.pnlStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlStatus.Location = new System.Drawing.Point(0, 954);
            this.pnlStatus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlStatus.Name = "pnlStatus";
            this.pnlStatus.Size = new System.Drawing.Size(1633, 43);
            this.pnlStatus.TabIndex = 3;
            // 
            // lblStatusVersion
            // 
            this.lblStatusVersion.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblStatusVersion.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblStatusVersion.ForeColor = System.Drawing.Color.White;
            this.lblStatusVersion.Location = new System.Drawing.Point(1050, 0);
            this.lblStatusVersion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatusVersion.Name = "lblStatusVersion";
            this.lblStatusVersion.Padding = new System.Windows.Forms.Padding(0, 0, 23, 0);
            this.lblStatusVersion.Size = new System.Drawing.Size(233, 43);
            this.lblStatusVersion.TabIndex = 2;
            this.lblStatusVersion.Text = "الإصدار 1.0.0";
            this.lblStatusVersion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblStatusDate
            // 
            this.lblStatusDate.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblStatusDate.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblStatusDate.ForeColor = System.Drawing.Color.White;
            this.lblStatusDate.Location = new System.Drawing.Point(1283, 0);
            this.lblStatusDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatusDate.Name = "lblStatusDate";
            this.lblStatusDate.Padding = new System.Windows.Forms.Padding(0, 0, 23, 0);
            this.lblStatusDate.Size = new System.Drawing.Size(350, 43);
            this.lblStatusDate.TabIndex = 1;
            this.lblStatusDate.Text = "التاريخ";
            this.lblStatusDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblStatusUser
            // 
            this.lblStatusUser.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblStatusUser.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblStatusUser.ForeColor = System.Drawing.Color.White;
            this.lblStatusUser.Location = new System.Drawing.Point(0, 0);
            this.lblStatusUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatusUser.Name = "lblStatusUser";
            this.lblStatusUser.Padding = new System.Windows.Forms.Padding(23, 0, 0, 0);
            this.lblStatusUser.Size = new System.Drawing.Size(583, 43);
            this.lblStatusUser.TabIndex = 0;
            this.lblStatusUser.Text = "المستخدم:";
            this.lblStatusUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1633, 997);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlSidebar);
            this.Controls.Add(this.pnlStatus);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1397, 851);
            this.Name = "frmMain";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "نظام إدارة المخزون والمستودعات";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlSidebar.ResumeLayout(false);
            this.pnlUserInfo.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlDashboard.ResumeLayout(false);
            this.grpAlerts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlerts)).EndInit();
            this.grpRecentMovements.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecentMovements)).EndInit();
            this.pnlStats.ResumeLayout(false);
            this.cardAlerts.ResumeLayout(false);
            this.cardMovements.ResumeLayout(false);
            this.cardWarehouses.ResumeLayout(false);
            this.cardProducts.ResumeLayout(false);
            this.pnlWelcome.ResumeLayout(false);
            this.pnlStatus.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.Button btnLookups;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnRoles;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnStocktake;
        private System.Windows.Forms.Button btnMovements;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Button btnPartners;
        private System.Windows.Forms.Button btnWarehouses;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Button btnUnits;
        private System.Windows.Forms.Button btnCategories;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Panel pnlUserInfo;
        private System.Windows.Forms.Label lblUserRole;
        private System.Windows.Forms.Label lblUserFullName;
        private System.Windows.Forms.Label lblUserIcon;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Panel pnlDashboard;
        private System.Windows.Forms.Panel pnlWelcome;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Panel pnlStats;
        private System.Windows.Forms.Panel cardProducts;
        private System.Windows.Forms.Label lblProductsCount;
        private System.Windows.Forms.Label lblProductsTitle;
        private System.Windows.Forms.Label picProducts;
        private System.Windows.Forms.Panel cardWarehouses;
        private System.Windows.Forms.Label lblWarehousesCount;
        private System.Windows.Forms.Label lblWarehousesTitle;
        private System.Windows.Forms.Label picWarehouses;
        private System.Windows.Forms.Panel cardMovements;
        private System.Windows.Forms.Label lblMovementsCount;
        private System.Windows.Forms.Label lblMovementsTitle;
        private System.Windows.Forms.Label picMovements;
        private System.Windows.Forms.Panel cardAlerts;
        private System.Windows.Forms.Label lblAlertsCount;
        private System.Windows.Forms.Label lblAlertsTitle;
        private System.Windows.Forms.Label picAlerts;
        private System.Windows.Forms.GroupBox grpRecentMovements;
        private System.Windows.Forms.DataGridView dgvRecentMovements;
        private System.Windows.Forms.GroupBox grpAlerts;
        private System.Windows.Forms.DataGridView dgvAlerts;
        private System.Windows.Forms.Panel pnlStatus;
        private System.Windows.Forms.Label lblStatusVersion;
        private System.Windows.Forms.Label lblStatusDate;
        private System.Windows.Forms.Label lblStatusUser;
    }
}