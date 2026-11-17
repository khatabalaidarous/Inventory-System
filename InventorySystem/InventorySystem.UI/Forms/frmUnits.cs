using InventorySystem.UI.Business;
using InventorySystem.UI.Helpers;
using InventorySystem.UI.Models.Entities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using InventorySystem.InventorySystem.UI.Forms;

namespace InventorySystem.UI.Forms
{
    /// <summary>
    /// شاشة إدارة الوحدات
    /// </summary>
    public partial class frmUnits : Form
    {
        private readonly UnitBLL _unitBLL;

        public frmUnits()
        {
            InitializeComponent();
            _unitBLL = new UnitBLL();
            GridHelper.StyleGrid(dgvUnits);
        }

        private void frmUnits_Load(object sender, EventArgs e)
        {
            LoadUnits();
        }

        private void LoadUnits()
        {
            try
            {
                string error;
                var units = _unitBLL.GetAll(out error);

                if (!string.IsNullOrEmpty(error))
                {
                    MessageHelper.ShowError(error);
                    return;
                }

                dgvUnits.DataSource = null;
                dgvUnits.DataSource = units;

                FormatGrid();
                UpdateCount();
            }
            catch (Exception ex)
            {
                LogHelper.LogError(ex, "frmUnits.LoadUnits");
                MessageHelper.ShowException(ex);
            }
        }

        private void FormatGrid()
        {
            if (dgvUnits.Columns.Count == 0) return;

            GridHelper.HideColumn(dgvUnits, "UnitId");
            GridHelper.SetColumnHeader(dgvUnits, "Name", "اسم الوحدة");
            GridHelper.SetColumnHeader(dgvUnits, "Symbol", "الرمز");
        }

        private void UpdateCount()
        {
            lblCount.Text = $"العدد: {GridHelper.GetVisibleRowCount(dgvUnits)}";
        }

        // ============================================
        // الأزرار
        // ============================================

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var form = new frmUnitEdit();
            if (form.ShowDialog() == DialogResult.OK)
                LoadUnits();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvUnits.CurrentRow == null)
            {
                MessageHelper.ShowSelectItem();
                return;
            }

            int unitId = GridHelper.GetSelectedValue<int>(dgvUnits, "UnitId");

            string error;
            var unit = _unitBLL.GetById(unitId, out error);

            if (unit == null)
            {
                MessageHelper.ShowError(error ?? "لم يتم العثور على الوحدة");
                return;
            }

            var form = new frmUnitEdit(unit);
            if (form.ShowDialog() == DialogResult.OK)
                LoadUnits();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvUnits.CurrentRow == null)
            {
                MessageHelper.ShowSelectItem();
                return;
            }

            int unitId = GridHelper.GetSelectedValue<int>(dgvUnits, "UnitId");
            string unitName = GridHelper.GetSelectedValue<string>(dgvUnits, "Name");

            if (!MessageHelper.ConfirmDelete($"الوحدة '{unitName}'"))
                return;

            string error;
            if (_unitBLL.Delete(unitId, out error))
            {
                MessageHelper.ShowDeleteSuccess();
                LoadUnits();
            }
            else
            {
                MessageHelper.ShowError(error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            LoadUnits();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            GridHelper.FilterRows(dgvUnits, txtSearch.Text);
            UpdateCount();
        }

        private void dgvUnits_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                btnEdit_Click(sender, e);
        }
    }
}