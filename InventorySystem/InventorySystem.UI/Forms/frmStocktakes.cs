using InventorySystem.UI.Business;
using InventorySystem.UI.Helpers;
using InventorySystem.UI.Models.Entities;
using System;
using System.Windows.Forms;

namespace InventorySystem.UI.Forms
{
    /// <summary>
    /// شاشة إدارة الجرد
    /// </summary>
    public partial class frmStocktakes : Form
    {
        private readonly StocktakeBLL _stocktakeBLL;

        public frmStocktakes()
        {
            InitializeComponent();
            _stocktakeBLL = new StocktakeBLL();
            GridHelper.StyleGrid(dgvStocktakes);
        }

        private void frmStocktakes_Load(object sender, EventArgs e)
        {
            LoadStocktakes();
        }

        private void LoadStocktakes()
        {
            try
            {
                string error;
                var stocktakes = _stocktakeBLL.GetAll(out error);

                if (!string.IsNullOrEmpty(error))
                {
                    MessageHelper.ShowError(error);
                    return;
                }

                dgvStocktakes.DataSource = null;
                dgvStocktakes.DataSource = stocktakes;

                FormatGrid();
                UpdateCount();
            }
            catch (Exception ex)
            {
                LogHelper.LogError(ex, "frmStocktakes.LoadStocktakes");
                MessageHelper.ShowException(ex);
            }
        }

        private void FormatGrid()
        {
            if (dgvStocktakes.Columns.Count == 0) return;

            GridHelper.HideColumns(dgvStocktakes, "StocktakeId", "WarehouseId", "CreatedBy", "Status", "Details");

            GridHelper.SetColumnHeader(dgvStocktakes, "StocktakeDate", "التاريخ");
            GridHelper.SetColumnHeader(dgvStocktakes, "WarehouseName", "المستودع");
            GridHelper.SetColumnHeader(dgvStocktakes, "StatusName", "الحالة");
            GridHelper.SetColumnHeader(dgvStocktakes, "CreatorName", "أنشأه");
            GridHelper.SetColumnHeader(dgvStocktakes, "Notes", "ملاحظات");

            GridHelper.FormatAsDateTime(dgvStocktakes, "StocktakeDate");
        }

        private void UpdateCount()
        {
            lblCount.Text = $"العدد: {dgvStocktakes.Rows.Count}";
        }

        // ============================================
        // إنشاء جرد جديد
        // ============================================

        private void btnNew_Click(object sender, EventArgs e)
        {
            // شاشة اختيار المستودع
            var form = new frmNewStocktake();
            if (form.ShowDialog() == DialogResult.OK)
                LoadStocktakes();
        }

        // ============================================
        // فتح الجرد
        // ============================================

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenSelectedStocktake();
        }

        private void OpenSelectedStocktake()
        {
            if (dgvStocktakes.CurrentRow == null)
            {
                MessageHelper.ShowSelectItem();
                return;
            }

            int stocktakeId = GridHelper.GetSelectedValue<int>(dgvStocktakes, "StocktakeId");

            string error;
            var stocktake = _stocktakeBLL.GetById(stocktakeId, out error);

            if (stocktake == null)
            {
                MessageHelper.ShowError(error ?? "لم يتم العثور على الجرد");
                return;
            }

            var form = new frmStocktakeDetails(stocktake);
            form.ShowDialog();
            LoadStocktakes();
        }

        // ============================================
        // إغلاق الجرد
        // ============================================

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (dgvStocktakes.CurrentRow == null)
            {
                MessageHelper.ShowSelectItem();
                return;
            }

            string status = GridHelper.GetSelectedValue<string>(dgvStocktakes, "Status");

            if (status == "Closed")
            {
                MessageHelper.ShowWarning("الجرد مغلق مسبقاً");
                return;
            }

            int stocktakeId = GridHelper.GetSelectedValue<int>(dgvStocktakes, "StocktakeId");

            if (!MessageHelper.Confirm(
                "سيتم إغلاق الجرد وتسوية الفروقات تلقائياً.\nهل أنت متأكد؟"))
                return;

            string error;
            if (_stocktakeBLL.Close(stocktakeId, SessionManager.UserId, out error))
            {
                MessageHelper.ShowSuccess("تم إغلاق الجرد وتسوية الفروقات ✅");
                LoadStocktakes();
            }
            else
            {
                MessageHelper.ShowError(error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadStocktakes();
        }

        private void dgvStocktakes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                OpenSelectedStocktake();
        }
    }
}