using InventorySystem.UI.Business;
using InventorySystem.UI.Helpers;
using InventorySystem.UI.Models.Entities;
using System;
using System.Windows.Forms;

namespace InventorySystem.UI.Forms
{
    public partial class frmStocktakeDetails : Form
    {
        private readonly StocktakeBLL _stocktakeBLL;
        private readonly Stocktake _stocktake;

        public frmStocktakeDetails(Stocktake stocktake)
        {
            InitializeComponent();
            _stocktakeBLL = new StocktakeBLL();
            _stocktake = stocktake;
            GridHelper.StyleGrid(dgvDetails);

            // إتاحة التعديل
            dgvDetails.ReadOnly = false;
            dgvDetails.AllowUserToAddRows = false;
            dgvDetails.AllowUserToDeleteRows = false;
        }

        private void frmStocktakeDetails_Load(object sender, EventArgs e)
        {
            lblWarehouseValue.Text = _stocktake.WarehouseName;
            LoadDetails();

            // إذا كان مغلقاً، عطّل التعديل
            if (_stocktake.Status == "Closed")
            {
                dgvDetails.ReadOnly = true;
                btnRefresh.Enabled = false;
                lblTitle.Text = "تفاصيل الجرد (مغلق)";
            }
        }

        private void LoadDetails()
        {
            dgvDetails.DataSource = null;
            dgvDetails.DataSource = _stocktake.Details;

            if (dgvDetails.Columns.Count == 0) return;

            GridHelper.HideColumns(dgvDetails,
                "Id", "StocktakeId", "ProductId", "BatchId", "Difference");

            GridHelper.SetColumnHeader(dgvDetails, "ProductCode", "الكود");
            GridHelper.SetColumnHeader(dgvDetails, "ProductName", "المنتج");
            GridHelper.SetColumnHeader(dgvDetails, "SystemQty", "كمية النظام");
            GridHelper.SetColumnHeader(dgvDetails, "CountedQty", "الكمية الفعلية");

            // جعل عمود SystemQty للقراءة فقط
            if (dgvDetails.Columns.Contains("SystemQty"))
                dgvDetails.Columns["SystemQty"].ReadOnly = true;

            if (dgvDetails.Columns.Contains("ProductCode"))
                dgvDetails.Columns["ProductCode"].ReadOnly = true;

            if (dgvDetails.Columns.Contains("ProductName"))
                dgvDetails.Columns["ProductName"].ReadOnly = true;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            // حفظ الكميات
            try
            {
                dgvDetails.EndEdit();

                string error;
                int savedCount = 0;

                foreach (DataGridViewRow row in dgvDetails.Rows)
                {
                    var detail = row.DataBoundItem as StocktakeDetail;

                    if (detail == null) continue;

                    // حفظ الكمية الفعلية
                    if (_stocktakeBLL.UpdateCountedQuantity(
                        detail.Id, detail.CountedQty, out error))
                    {
                        savedCount++;
                    }
                }

                MessageHelper.ShowSuccess($"تم حفظ {savedCount} صنف ✅");
                this.Close();
            }
            catch (Exception ex)
            {
                LogHelper.LogError(ex, "frmStocktakeDetails.btnRefresh_Click");
                MessageHelper.ShowException(ex);
            }
        }
    }
}