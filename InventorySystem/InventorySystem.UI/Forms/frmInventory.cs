using InventorySystem.UI.Business;
using InventorySystem.UI.Helpers;
using InventorySystem.UI.Models.Entities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace InventorySystem.UI.Forms
{
    /// <summary>
    /// شاشة عرض المخزون
    /// </summary>
    public partial class frmInventory : Form
    {
        private readonly InventoryBLL _inventoryBLL;
        private readonly WarehouseBLL _warehouseBLL;
        private List<Inventory> _allInventory;

        public frmInventory()
        {
            InitializeComponent();
            _inventoryBLL = new InventoryBLL();
            _warehouseBLL = new WarehouseBLL();
            GridHelper.StyleGrid(dgvInventory);
        }

        private void frmInventory_Load(object sender, EventArgs e)
        {
            LoadWarehouses();
            LoadInventory();
        }

        private void LoadWarehouses()
        {
            string error;
            var warehouses = _warehouseBLL.GetActive(out error);

            var list = new List<Warehouse>
            {
                new Warehouse { WarehouseId = 0, Name = "— كل المستودعات —" }
            };

            foreach (var wh in warehouses)
                list.Add(wh);

            ComboHelper.LoadFromList(cmbWarehouse, list, "WarehouseId", "Name");
            cmbWarehouse.SelectedIndex = 0;
        }

        private void LoadInventory()
        {
            try
            {
                string error;
                _allInventory = _inventoryBLL.GetAll(out error);

                if (!string.IsNullOrEmpty(error))
                {
                    MessageHelper.ShowError(error);
                    return;
                }

                ApplyFilter();
            }
            catch (Exception ex)
            {
                LogHelper.LogError(ex, "frmInventory.LoadInventory");
                MessageHelper.ShowException(ex);
            }
        }

        private void ApplyFilter()
        { string z = "0";
            if (_allInventory == null)
            {
                dgvInventory.DataSource = null;
                lblTotal.Text = "عدد السجلات"+z;
                return;
            }
            var filtered = new List<Inventory>();
            int warehouseId = ComboHelper.GetSelectedId(cmbWarehouse);

            foreach (var inv in _allInventory)
            {
                if (warehouseId == 0 || inv.WarehouseId == warehouseId)
                    filtered.Add(inv);
            }

            dgvInventory.DataSource = null;
            dgvInventory.DataSource = filtered;

            FormatGrid();
            UpdateTotal(filtered);
        }

        private void FormatGrid()
        {
            if (dgvInventory.Columns.Count == 0) return;

            GridHelper.HideColumns(dgvInventory,
                "InventoryId", "ProductId", "WarehouseId", "ReservedQty", "LastUpdated");

            GridHelper.SetColumnHeader(dgvInventory, "ProductCode", "الكود");
            GridHelper.SetColumnHeader(dgvInventory, "ProductName", "المنتج");
            GridHelper.SetColumnHeader(dgvInventory, "WarehouseName", "المستودع");
            GridHelper.SetColumnHeader(dgvInventory, "Quantity", "الكمية");
            GridHelper.SetColumnHeader(dgvInventory, "AvailableQuantity", "المتاح");

            GridHelper.FormatAsCurrency(dgvInventory, "Quantity");
            GridHelper.FormatAsCurrency(dgvInventory, "AvailableQuantity");
        }

        private void UpdateTotal(List<Inventory> list)
        {
            decimal total = 0;
            foreach (var inv in list)
                total += inv.Quantity;

            lblTotal.Text = $"عدد السجلات: {list.Count}  |  إجمالي الكميات: {total:N2}";
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            cmbWarehouse.SelectedIndex = 0;
            LoadInventory();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            GridHelper.FilterRows(dgvInventory, txtSearch.Text);
        }

        private void cmbWarehouse_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }
    }
}