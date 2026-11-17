using InventorySystem.UI.Business;
using InventorySystem.UI.Helpers;
using InventorySystem.UI.Models.Entities;
using System;
using System.Windows.Forms;

namespace InventorySystem.UI.Forms
{
    public partial class frmNewStocktake : Form
    {
        private readonly WarehouseBLL _warehouseBLL;
        private readonly StocktakeBLL _stocktakeBLL;

        public frmNewStocktake()
        {
            InitializeComponent();
            _warehouseBLL = new WarehouseBLL();
            _stocktakeBLL = new StocktakeBLL();
        }

        private void frmNewStocktake_Load(object sender, EventArgs e)
        {
            string error;
            var warehouses = _warehouseBLL.GetActive(out error);
            ComboHelper.LoadFromList(cmbWarehouse, warehouses, "WarehouseId", "Name");
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            int warehouseId = ComboHelper.GetSelectedId(cmbWarehouse);

            if (warehouseId == 0)
            {
                MessageHelper.ShowWarning("يجب اختيار المستودع");
                return;
            }

            string error;
            int stocktakeId = _stocktakeBLL.Create(
                warehouseId,
                SessionManager.UserId,
                txtNotes.Text.Trim(),
                out error);

            if (stocktakeId > 0)
            {
                MessageHelper.ShowSuccess("تم إنشاء الجرد بنجاح ✅");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageHelper.ShowError(error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}