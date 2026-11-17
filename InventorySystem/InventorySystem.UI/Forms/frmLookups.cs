using InventorySystem.UI.DataAccess;
using InventorySystem.UI.Helpers;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace InventorySystem.UI.Forms
{
    /// <summary>
    /// شاشة الجداول المرجعية
    /// </summary>
    public partial class frmLookups : Form
    {
        // ============================================
        // Constructor
        // ============================================

        public frmLookups()
        {
            InitializeComponent();
            StyleGrid();
        }

        // ============================================
        // تنسيق الجدول
        // ============================================

        private void StyleGrid()
        {
            dgvData.BackgroundColor = Color.White;
            dgvData.GridColor = Color.FromArgb(230, 230, 230);
            dgvData.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(41, 128, 185);
            dgvData.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvData.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dgvData.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvData.EnableHeadersVisualStyles = false;
            dgvData.DefaultCellStyle.Font = new Font("Segoe UI", 12F);
            dgvData.DefaultCellStyle.ForeColor = Color.FromArgb(52, 73, 94);
            dgvData.DefaultCellStyle.BackColor = Color.White;
            dgvData.DefaultCellStyle.SelectionBackColor = Color.FromArgb(52, 152, 219);
            dgvData.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvData.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvData.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);
            dgvData.RightToLeft = RightToLeft.Yes;
        }

        // ============================================
        // تحميل الشاشة
        // ============================================

        private void frmLookups_Load(object sender, EventArgs e)
        {
            LoadTablesList();
        }

        /// <summary>
        /// تحميل قائمة الجداول (مصنّفة)
        /// </summary>
        private void LoadTablesList()
        {
            cmbTable.Items.Clear();

            // 📋 الأساسيات
            cmbTable.Items.Add("━━━ 📋 الأساسيات ━━━");
            cmbTable.Items.Add("🏷️  التصنيفات");
            cmbTable.Items.Add("📏  الوحدات");
            cmbTable.Items.Add("📦  المنتجات");
            cmbTable.Items.Add("🏪  المستودعات");
            cmbTable.Items.Add("🤝  الشركاء");

            // 📦 المخزون
            cmbTable.Items.Add("━━━ 📦 المخزون ━━━");
            cmbTable.Items.Add("📊  رصيد المخزون");
            cmbTable.Items.Add("📦  الدفعات");
            cmbTable.Items.Add("📊  كميات الدفعات");

            // 🔄 الحركات
            cmbTable.Items.Add("━━━ 🔄 الحركات ━━━");
            cmbTable.Items.Add("🔄  الحركات");
            cmbTable.Items.Add("📋  تفاصيل الحركات");

            // 📋 الجرد
            cmbTable.Items.Add("━━━ 📋 الجرد ━━━");
            cmbTable.Items.Add("📋  الجرد");
            cmbTable.Items.Add("📊  تفاصيل الجرد");

            // 🔐 الأمان
            cmbTable.Items.Add("━━━ 🔐 الأمان ━━━");
            cmbTable.Items.Add("👥  المستخدمون");
            cmbTable.Items.Add("🎭  الأدوار");
            cmbTable.Items.Add("🔐  الصلاحيات");
            cmbTable.Items.Add("🔗  ربط المستخدم بالدور");
            cmbTable.Items.Add("🔗  ربط الدور بالصلاحية");
            cmbTable.Items.Add("📝  سجل التدقيق");

            cmbTable.SelectedIndex = 1;
        }

        /// <summary>
        /// تغيير الجدول المحدد
        /// </summary>
        private void cmbTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            // تجاهل العناوين
            if (cmbTable.SelectedItem.ToString().StartsWith("━━━"))
                return;

            LoadTableData();
        }

        // ============================================
        // تحميل البيانات
        // ============================================

        private void LoadTableData()
        {
            try
            {
                string tableName = GetTableName();

                if (string.IsNullOrEmpty(tableName))
                    return;

                string query = $"SELECT * FROM {tableName}";
                var dt = DatabaseHelper.ExecuteDataTable(query);

                dgvData.DataSource = null;
                dgvData.DataSource = dt;

                FormatColumns(tableName);

                lblCount.Text = $"📊 العدد: {dt.Rows.Count}";
                lblStats.Text = $"الجدول: {tableName}  |  السجلات: {dt.Rows.Count}  |  الأعمدة: {dt.Columns.Count}";
                lblTableType.Text = $"النوع: {GetTableType()}";

                // تحديث الإحصائيات
                lblCount.Text = $"📊 العدد: {dt.Rows.Count}";
            }
            catch (Exception ex)
            {
                LogHelper.LogError(ex, "frmLookups.LoadTableData");
                MessageHelper.ShowError($"فشل: {ex.Message}");
            }
        }

        /// <summary>
        /// الحصول على اسم الجدول
        /// </summary>
        private string GetTableName()
        {
            switch (cmbTable.SelectedIndex)
            {
                // أساسيات
                case 1: return "Categories";
                case 2: return "Units";
                case 3: return "Products";
                case 4: return "Warehouses";
                case 5: return "Partners";

                // مخزون
                case 7: return "Inventory";
                case 8: return "Batches";
                case 9: return "InventoryBatches";

                // حركات
                case 11: return "StockMovements";
                case 12: return "StockMovementDetails";

                // جرد
                case 14: return "Stocktakes";
                case 15: return "StocktakeDetails";

                // أمان
                case 17: return "Users";
                case 18: return "Roles";
                case 19: return "Permissions";
                case 20: return "UserRoles";
                case 21: return "RolePermissions";
                case 22: return "AuditLog";

                default: return "";
            }
        }

        /// <summary>
        /// نوع الجدول الحالي
        /// </summary>
        private string GetTableType()
        {
            int idx = cmbTable.SelectedIndex;

            if (idx >= 1 && idx <= 5) return "📋 الأساسيات";
            if (idx >= 7 && idx <= 9) return "📦 المخزون";
            if (idx >= 11 && idx <= 12) return "🔄 الحركات";
            if (idx >= 14 && idx <= 15) return "📋 الجرد";
            if (idx >= 17 && idx <= 22) return "🔐 الأمان";

            return "-";
        }

        /// <summary>
        /// تنسيق الأعمدة
        /// </summary>
        private void FormatColumns(string tableName)
        {
            if (dgvData.Columns.Count == 0) return;

            if (tableName == "Users" && dgvData.Columns.Contains("PasswordHash"))
                dgvData.Columns["PasswordHash"].Visible = false;

            foreach (DataGridViewColumn col in dgvData.Columns)
            {
                col.HeaderText = GetArabicHeader(col.Name);
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        /// <summary>
        /// العناوين العربية
        /// </summary>
        private string GetArabicHeader(string columnName)
        {
            switch (columnName)
            {
                // مشترك
                case "Name": return "📝 الاسم";
                case "Description": return "📄 الوصف";
                case "IsActive": return "✅ مفعّل";
                case "CreatedAt": return "📅 تاريخ الإنشاء";

                // التصنيفات
                case "CategoryId": return "🔢 رقم التصنيف";
                case "ParentId": return "👆 التصنيف الأب";

                // الوحدات
                case "UnitId": return "🔢 رقم الوحدة";
                case "Symbol": return "🏷️ الرمز";

                // المنتجات
                case "ProductId": return "🔢 رقم المنتج";
                case "Code": return "🔖 الكود";
                case "MinStock": return "📉 الحد الأدنى";
                case "MaxStock": return "📈 الحد الأقصى";

                // المستودعات
                case "WarehouseId": return "🔢 رقم المستودع";
                case "Location": return "📍 الموقع";
                case "ManagerId": return "👤 المدير";

                // الشركاء
                case "PartnerId": return "🔢 رقم الشريك";
                case "Type": return "🎯 النوع";
                case "Phone": return "📞 الهاتف";
                case "Email": return "📧 البريد";
                case "Address": return "📍 العنوان";
                case "TaxNumber": return "🧾 الرقم الضريبي";

                // المستخدمون
                case "UserId": return "🔢 رقم المستخدم";
                case "Username": return "👤 اسم الدخول";
                case "FullName": return "📝 الاسم الكامل";
                case "PasswordHash": return "🔒 كلمة المرور";

                // الأدوار
                case "RoleId": return "🔢 رقم الدور";

                // الصلاحيات
                case "PermissionId": return "🔢 رقم الصلاحية";

                // ربط
                case "RoleName": return "🎭 الدور";
                case "PermissionName": return "🔐 الصلاحية";
                case "PermissionCode": return "🔖 كود الصلاحية";

                // المخزون
                case "InventoryId": return "🔢 رقم السجل";
                case "Quantity": return "📊 الكمية";
                case "ReservedQty": return "🔒 المحجوز";
                case "LastUpdated": return "📅 آخر تحديث";

                // الدفعات
                case "BatchId": return "🔢 رقم الدفعة";
                case "BatchNumber": return "🏷️ رقم الدفعة";
                case "ProductionDate": return "📅 تاريخ الإنتاج";
                case "ExpiryDate": return "⏰ تاريخ الانتهاء";

                // الحركات
                case "MovementId": return "🔢 رقم الحركة";
                case "MovementDate": return "📅 التاريخ";
                case "FromWarehouseId": return "🏪 من مستودع";
                case "ToWarehouseId": return "🏪 إلى مستودع";
                case "Reference": return "🔖 المرجع";
                case "Notes": return "📝 ملاحظات";
                case "DetailId": return "🔢 رقم التفصيل";
                case "UnitPrice": return "💰 السعر";

                // الجرد
                case "StocktakeId": return "🔢 رقم الجرد";
                case "StocktakeDate": return "📅 تاريخ الجرد";
                case "Status": return "🎯 الحالة";
                case "CreatedBy": return "👤 أنشأه";
                case "SystemQty": return "📊 كمية النظام";
                case "CountedQty": return "🔢 الكمية الفعلية";
                case "Difference": return "⚖️ الفرق";

                // التدقيق
                case "LogId": return "🔢 رقم السجل";
                case "Action": return "🎯 العملية";
                case "TableName": return "📋 الجدول";
                case "RecordId": return "🔢 رقم السجل";
                case "OldValue": return "📄 القيمة القديمة";
                case "NewValue": return "📄 القيمة الجديدة";
                case "LogDate": return "📅 التاريخ";

                default: return columnName;
            }
        }

        // ============================================
        // الأزرار
        // ============================================

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            LoadTableData();
            MessageHelper.ShowInfo("تم تحديث البيانات ✅");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            FilterData();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            FilterData();
        }

        /// <summary>
        /// فلترة البيانات
        /// </summary>
        private void FilterData()
        {
            try
            {
                string keyword = txtSearch.Text.Trim();

                if (string.IsNullOrEmpty(keyword))
                {
                    LoadTableData();
                    return;
                }

                string tableName = GetTableName();
                string query = $"SELECT * FROM {tableName}";
                var dt = DatabaseHelper.ExecuteDataTable(query);

                // فلترة في الذاكرة
                var filtered = dt.Clone();
                foreach (DataRow row in dt.Rows)
                {
                    foreach (DataColumn col in dt.Columns)
                    {
                        if (row[col] != DBNull.Value &&
                            row[col].ToString().IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0)
                        {
                            filtered.ImportRow(row);
                            break;
                        }
                    }
                }

                dgvData.DataSource = null;
                dgvData.DataSource = filtered;
                FormatColumns(tableName);

                lblCount.Text = $"📊 النتائج: {filtered.Rows.Count}";
            }
            catch (Exception ex)
            {
                LogHelper.LogError(ex, "frmLookups.FilterData");
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (dgvData.Rows.Count == 0)
            {
                MessageHelper.ShowWarning("لا توجد بيانات للتصدير");
                return;
            }

            ExportHelper.ExportToExcel(dgvData, $"Lookup_{GetTableName()}");
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (dgvData.Rows.Count == 0)
            {
                MessageHelper.ShowWarning("لا توجد بيانات للطباعة");
                return;
            }

            ExportHelper.PrintGrid(dgvData, cmbTable.Text);
        }
    }
}