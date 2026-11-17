using InventorySystem.UI.Business;
using InventorySystem.UI.Helpers;
using InventorySystem.UI.Models.Entities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace InventorySystem.UI.Forms
{
    /// <summary>
    /// شاشة عرض حركات المخزون
    /// </summary>
    public partial class frmMovements : Form
    {
        private readonly StockMovementBLL _movementBLL;

        public frmMovements()
        {
            InitializeComponent();
            _movementBLL = new StockMovementBLL();
            GridHelper.StyleGrid(dgvMovements);
        }

        private void frmMovements_Load(object sender, EventArgs e)
        {
            LoadFilter();
            LoadMovements();
        }

        private void LoadFilter()
        {
            cmbType.Items.Clear();
            cmbType.Items.Add("الكل");
            cmbType.Items.Add("استلام");
            cmbType.Items.Add("صرف");
            cmbType.Items.Add("تحويل");
            cmbType.Items.Add("تسوية");
            cmbType.SelectedIndex = 0;
        }

        private void LoadMovements()
        {
            try
            {
                string error;
                var movements = _movementBLL.GetAll(out error);

                if (!string.IsNullOrEmpty(error))
                {
                    MessageHelper.ShowError(error);
                    return;
                }

                dgvMovements.DataSource = null;
                dgvMovements.DataSource = movements;

                FormatGrid();
                UpdateCount();
            }
            catch (Exception ex)
            {
                LogHelper.LogError(ex, "frmMovements.LoadMovements");
                MessageHelper.ShowException(ex);
            }
        }

        private void FormatGrid()
        {
            if (dgvMovements.Columns.Count == 0) return;

            GridHelper.HideColumns(dgvMovements,
                "MovementId", "Type", "UserId", "FromWarehouseId", "ToWarehouseId", "PartnerId", "Details");

            GridHelper.SetColumnHeader(dgvMovements, "MovementDate", "التاريخ");
            GridHelper.SetColumnHeader(dgvMovements, "TypeName", "النوع");
            GridHelper.SetColumnHeader(dgvMovements, "FromWarehouseName", "من مستودع");
            GridHelper.SetColumnHeader(dgvMovements, "ToWarehouseName", "إلى مستودع");
            GridHelper.SetColumnHeader(dgvMovements, "PartnerName", "الشريك");
            GridHelper.SetColumnHeader(dgvMovements, "UserName", "المستخدم");
            GridHelper.SetColumnHeader(dgvMovements, "Reference", "المرجع");
            GridHelper.SetColumnHeader(dgvMovements, "Notes", "ملاحظات");

            GridHelper.FormatAsDateTime(dgvMovements, "MovementDate");
        }

        private void UpdateCount()
        {
            lblCount.Text = $"العدد: {dgvMovements.Rows.Count}";
        }

        // ============================================
        // الأزرار
        // ============================================

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var form = new frmAddMovement();
            if (form.ShowDialog() == DialogResult.OK)
                LoadMovements();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            ViewSelectedMovement();
        }

        private void ViewSelectedMovement()
        {
            if (dgvMovements.CurrentRow == null)
            {
                MessageHelper.ShowSelectItem();
                return;
            }

            int movementId = GridHelper.GetSelectedValue<int>(dgvMovements, "MovementId");

            string error;
            var movement = _movementBLL.GetById(movementId, out error);

            if (movement == null)
            {
                MessageHelper.ShowError(error ?? "لم يتم العثور على الحركة");
                return;
            }

            var form = new frmMovementDetails(movement);
            form.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            cmbType.SelectedIndex = 0;
            LoadMovements();
        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string type = null;
            switch (cmbType.SelectedIndex)
            {
                case 1: type = "IN"; break;
                case 2: type = "OUT"; break;
                case 3: type = "TRANSFER"; break;
                case 4: type = "ADJUST"; break;
            }

            if (type == null)
            {
                LoadMovements();
            }
            else
            {
                string error;
                var movements = _movementBLL.GetByType(type, out error);

                dgvMovements.DataSource = null;
                dgvMovements.DataSource = movements;

                FormatGrid();
                UpdateCount();
            }
        }

        private void dgvMovements_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                ViewSelectedMovement();
        }
    }
}