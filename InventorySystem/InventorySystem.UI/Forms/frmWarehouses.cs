using InventorySystem.UI.Business;
using InventorySystem.UI.Helpers;
using InventorySystem.UI.Models.Entities;
using System;
using System.Windows.Forms;

namespace InventorySystem.UI.Forms
{
    /// <summary>
    /// شاشة إدارة المستودعات
    /// </summary>
    public partial class frmWarehouses : Form
    {
        private readonly WarehouseBLL _warehouseBLL;

        public frmWarehouses()
        {
            InitializeComponent();
            _warehouseBLL = new WarehouseBLL();
            GridHelper.StyleGrid(dgvWarehouses);
        }

        private void frmWarehouses_Load(object sender, EventArgs e)
        {
            LoadWarehouses();
        }

        private void LoadWarehouses()
        {
            try
            {
                string error;
                var warehouses = _warehouseBLL.GetAll(out error);

                if (!string.IsNullOrEmpty(error))
                {
                    MessageHelper.ShowError(error);
                    return;
                }

                dgvWarehouses.DataSource = null;
                dgvWarehouses.DataSource = warehouses;

                FormatGrid();
                UpdateCount();
            }
            catch (Exception ex)
            {
                LogHelper.LogError(ex, "frmWarehouses.LoadWarehouses");
                MessageHelper.ShowException(ex);
            }
        }

        private void FormatGrid()
        {
            if (dgvWarehouses.Columns.Count == 0) return;

            GridHelper.HideColumns(dgvWarehouses, "WarehouseId", "ManagerId", "IsActive");

            GridHelper.SetColumnHeader(dgvWarehouses, "Name", "اسم المستودع");
            GridHelper.SetColumnHeader(dgvWarehouses, "Location", "الموقع");
            GridHelper.SetColumnHeader(dgvWarehouses, "ManagerName", "المدير");
        }

        private void UpdateCount()
        {
            lblCount.Text = $"العدد: {GridHelper.GetVisibleRowCount(dgvWarehouses)}";
        }

        // ============================================
        // الأزرار
        // ============================================

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var form = new frmWarehouseEdit();
            if (form.ShowDialog() == DialogResult.OK)
                LoadWarehouses();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvWarehouses.CurrentRow == null)
            {
                MessageHelper.ShowSelectItem();
                return;
            }

            int warehouseId = GridHelper.GetSelectedValue<int>(dgvWarehouses, "WarehouseId");

            string error;
            var warehouse = _warehouseBLL.GetById(warehouseId, out error);

            if (warehouse == null)
            {
                MessageHelper.ShowError(error ?? "لم يتم العثور على المستودع");
                return;
            }

            var form = new frmWarehouseEdit(warehouse);
            if (form.ShowDialog() == DialogResult.OK)
                LoadWarehouses();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvWarehouses.CurrentRow == null)
            {
                MessageHelper.ShowSelectItem();
                return;
            }

            int warehouseId = GridHelper.GetSelectedValue<int>(dgvWarehouses, "WarehouseId");
            string warehouseName = GridHelper.GetSelectedValue<string>(dgvWarehouses, "Name");

            if (!MessageHelper.ConfirmDelete($"المستودع '{warehouseName}'"))
                return;

            string error;
            if (_warehouseBLL.Delete(warehouseId, out error))
            {
                MessageHelper.ShowDeleteSuccess();
                LoadWarehouses();
            }
            else
            {
                MessageHelper.ShowError(error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            LoadWarehouses();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            GridHelper.FilterRows(dgvWarehouses, txtSearch.Text);
            UpdateCount();
        }

        private void dgvWarehouses_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                btnEdit_Click(sender, e);
        }
    }
}