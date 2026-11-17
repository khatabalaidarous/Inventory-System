using InventorySystem.UI.Business;
using InventorySystem.UI.Helpers;
using InventorySystem.UI.Models.Entities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace InventorySystem.UI.Forms
{
    /// <summary>
    /// الشاشة الرئيسية
    /// </summary>
    public partial class frmMain : Form
    {
        private readonly ProductBLL _productBLL;
        private readonly WarehouseBLL _warehouseBLL;
        private readonly StockMovementBLL _movementBLL;


        public frmMain()
        {

            InitializeComponent();

            _productBLL = new ProductBLL();
            _warehouseBLL = new WarehouseBLL();
            _movementBLL = new StockMovementBLL();
        }

        // ============================================
        // تحميل الشاشة
        // ============================================

        private void frmMain_Load(object sender, EventArgs e)
        {
            if (!SessionManager.IsLoggedIn)
            {
                MessageHelper.ShowError("يجب تسجيل الدخول أولاً");
                this.Close();
                return;
            }

            // تنسيق الشبكات
            GridHelper.StyleGrid(dgvRecentMovements);
            GridHelper.StyleGrid(dgvAlerts);

            LoadUserInfo();
            LoadStatistics();
            LoadRecentMovements();
            LoadAlerts();
            ApplyPermissions();

            LogHelper.LogInfo($"فتح الشاشة الرئيسية - المستخدم: {SessionManager.Username}");
        }

        // ============================================
        // معلومات المستخدم
        // ============================================

        private void LoadUserInfo()
        {
            lblUser.Text = $"👤 {SessionManager.FullName}";
            lblUserFullName.Text = SessionManager.FullName;
            lblUserRole.Text = SessionManager.Roles.Count > 0
                ? string.Join(" | ", SessionManager.Roles)
                : "مستخدم";

            lblStatusUser.Text = $"المستخدم: {SessionManager.FullName}";
            lblStatusDate.Text = $"التاريخ: {DateTime.Now:dd/MM/yyyy HH:mm}";
            lblStatusVersion.Text = "الإصدار 1.0.0";
        }

        // ============================================
        // الإحصائيات
        // ============================================

        private void LoadStatistics()
        {
            try
            {
                string error;

                lblProductsCount.Text = _productBLL.GetCount(out error).ToString();
                lblWarehousesCount.Text = _warehouseBLL.GetCount(out error).ToString();
                lblMovementsCount.Text = _movementBLL.GetTodayCount(out error).ToString();

                var belowMin = _productBLL.GetBelowMinStock(out error);
                lblAlertsCount.Text = belowMin.Count.ToString();

                lblAlertsCount.ForeColor = belowMin.Count > 0
                    ? Color.FromArgb(231, 76, 60)
                    : Color.FromArgb(46, 204, 113);
            }
            catch (Exception ex)
            {
                LogHelper.LogError(ex, "frmMain.LoadStatistics");
            }
        }

        // ============================================
        // آخر الحركات
        // ============================================

        private void LoadRecentMovements()
        {
            try
            {
                string error;
                var movements = _movementBLL.GetAll(out error);

                var recent = new List<StockMovement>();
                for (int i = 0; i < Math.Min(5, movements.Count); i++)
                    recent.Add(movements[i]);

                dgvRecentMovements.DataSource = null;
                dgvRecentMovements.DataSource = recent;

                if (dgvRecentMovements.Columns.Count > 0)
                {
                    GridHelper.HideColumns(dgvRecentMovements,
                        "MovementId", "Type", "UserId", "FromWarehouseId",
                        "ToWarehouseId", "PartnerId", "Details", "Reference", "Notes");

                    GridHelper.SetColumnHeader(dgvRecentMovements, "MovementDate", "التاريخ");
                    GridHelper.SetColumnHeader(dgvRecentMovements, "TypeName", "النوع");
                    GridHelper.SetColumnHeader(dgvRecentMovements, "FromWarehouseName", "من");
                    GridHelper.SetColumnHeader(dgvRecentMovements, "ToWarehouseName", "إلى");
                    GridHelper.SetColumnHeader(dgvRecentMovements, "PartnerName", "الشريك");
                    GridHelper.SetColumnHeader(dgvRecentMovements, "UserName", "المستخدم");

                    GridHelper.FormatAsDateTime(dgvRecentMovements, "MovementDate");
                }
            }
            catch (Exception ex)
            {
                LogHelper.LogError(ex, "frmMain.LoadRecentMovements");
            }
        }

        // ============================================
        // التنبيهات
        // ============================================

        private void LoadAlerts()
        {
            try
            {
                string error;
                var belowMin = _productBLL.GetBelowMinStock(out error);

                dgvAlerts.DataSource = null;
                dgvAlerts.DataSource = belowMin;

                if (dgvAlerts.Columns.Count > 0)
                {
                    GridHelper.HideColumns(dgvAlerts,
                        "ProductId", "CategoryId", "UnitId", "MaxStock", "IsActive", "CreatedAt");

                    GridHelper.SetColumnHeader(dgvAlerts, "Code", "الكود");
                    GridHelper.SetColumnHeader(dgvAlerts, "Name", "المنتج");
                    GridHelper.SetColumnHeader(dgvAlerts, "CategoryName", "التصنيف");
                    GridHelper.SetColumnHeader(dgvAlerts, "UnitName", "الوحدة");
                    GridHelper.SetColumnHeader(dgvAlerts, "MinStock", "الحد الأدنى");
                    GridHelper.SetColumnHeader(dgvAlerts, "CurrentStock", "الرصيد الحالي");
                }
            }
            catch (Exception ex)
            {
                LogHelper.LogError(ex, "frmMain.LoadAlerts");
            }
        }

        // ============================================
        // تطبيق الصلاحيات
        // ============================================

        private void ApplyPermissions()
        {
            if (SessionManager.IsAdmin()) return;

            btnUsers.Visible = SessionManager.HasPermission("Users.Manage");
            btnCategories.Visible = SessionManager.HasPermission("Categories.View");
            btnUnits.Visible = SessionManager.HasPermission("Products.View");
            btnProducts.Visible = SessionManager.HasPermission("Products.View");
            btnWarehouses.Visible = SessionManager.HasPermission("Warehouses.View");
            btnPartners.Visible = SessionManager.HasPermission("Partners.View");
            btnInventory.Visible = SessionManager.HasPermission("Inventory.View");
            btnMovements.Visible = SessionManager.HasPermission("Movements.View");
            btnStocktake.Visible = SessionManager.HasPermission("Stocktake.View");
            btnReports.Visible = SessionManager.HasPermission("Reports.View");
            btnRoles.Visible = SessionManager.HasPermission("Roles.Manage");
            btnSettings.Visible = SessionManager.HasPermission("Settings.Manage");
        }

        // ============================================
        // الأزرار
        // ============================================

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadStatistics();
            LoadRecentMovements();
            LoadAlerts();
            MessageHelper.ShowInfo("تم تحديث البيانات ✅");
        }

        private void btnCategories_Click(object sender, EventArgs e) { OpenForm(new frmCategories()); }
        private void btnUnits_Click(object sender, EventArgs e) { OpenForm(new frmUnits()); }
        private void btnProducts_Click(object sender, EventArgs e) { OpenForm(new frmProducts()); }
        private void btnWarehouses_Click(object sender, EventArgs e) { OpenForm(new frmWarehouses()); }
        private void btnPartners_Click(object sender, EventArgs e) { OpenForm(new frmPartners()); }
        private void btnInventory_Click(object sender, EventArgs e) { OpenForm(new frmInventory()); }
        private void btnMovements_Click(object sender, EventArgs e) { OpenForm(new frmMovements()); }
        private void btnStocktake_Click(object sender, EventArgs e) { OpenForm(new frmStocktakes()); }
        private void btnReports_Click(object sender, EventArgs e) { OpenForm(new frmReports()); }
        private void btnUsers_Click(object sender, EventArgs e) { OpenForm(new frmUsers()); }
        private void btnRoles_Click(object sender, EventArgs e) { OpenForm(new frmRoles()); }
        private void btnSettings_Click(object sender, EventArgs e) { OpenForm(new frmSettings()); }
        private void btnLookups_Click(object sender, EventArgs e)
        {
            OpenForm(new frmLookups());
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            OpenForm(new frmBackup());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageHelper.ConfirmLogout())
            {
                LogHelper.LogInfo($"تسجيل خروج - المستخدم: {SessionManager.Username}");
                SessionManager.Logout();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void OpenForm(Form form)
        {
            form.ShowDialog();
            LoadStatistics();
            LoadRecentMovements();
            LoadAlerts();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing && SessionManager.IsLoggedIn)
            {
                if (MessageHelper.ConfirmLogout())
                {
                    SessionManager.Logout();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }
    }
}