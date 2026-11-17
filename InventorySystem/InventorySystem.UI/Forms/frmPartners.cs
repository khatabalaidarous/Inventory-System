using InventorySystem.UI.Business;
using InventorySystem.UI.Helpers;
using InventorySystem.UI.Models.Entities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace InventorySystem.UI.Forms
{
    /// <summary>
    /// شاشة إدارة الشركاء
    /// </summary>
    public partial class frmPartners : Form
    {
        private readonly PartnerBLL _partnerBLL;
        private List<Partner> _allPartners;

        public frmPartners()
        {
            InitializeComponent();
            _partnerBLL = new PartnerBLL();
            GridHelper.StyleGrid(dgvPartners);
        }

        private void frmPartners_Load(object sender, EventArgs e)
        {
            LoadFilter();
            LoadPartners();
        }

        private void LoadFilter()
        {
            cmbFilter.Items.Clear();
            cmbFilter.Items.Add("الكل");
            cmbFilter.Items.Add("مورد");
            cmbFilter.Items.Add("عميل");
            cmbFilter.Items.Add("مورد وعميل");
            cmbFilter.SelectedIndex = 0;
        }

        private void LoadPartners()
        {
            try
            {
                string error;
                _allPartners = _partnerBLL.GetAll(out error);

                if (!string.IsNullOrEmpty(error))
                {
                    MessageHelper.ShowError(error);
                    return;
                }

                ApplyFilter();
            }
            catch (Exception ex)
            {
                LogHelper.LogError(ex, "frmPartners.LoadPartners");
                MessageHelper.ShowException(ex);
            }
        }

        private void ApplyFilter()
        {
            var filtered = new List<Partner>();

            // الفلترة حسب النوع
            string filterType = cmbFilter.SelectedItem?.ToString();
            if (_allPartners == null)
            {
                return;
            }

            foreach (var partner in _allPartners)
            {
                bool matchesType = filterType == "الكل" ||
                    (filterType == "مورد" && (partner.Type == "Supplier" || partner.Type == "Both")) ||
                    (filterType == "عميل" && (partner.Type == "Customer" || partner.Type == "Both")) ||
                    (filterType == "مورد وعميل" && partner.Type == "Both");

                if (matchesType)
                    filtered.Add(partner);
            }

            dgvPartners.DataSource = null;
            dgvPartners.DataSource = filtered;

            FormatGrid();
            UpdateCount();
        }

        private void FormatGrid()
        {
            if (dgvPartners.Columns.Count == 0) return;

            GridHelper.HideColumns(dgvPartners,
                "PartnerId", "Type", "IsActive", "CreatedAt");

            GridHelper.SetColumnHeader(dgvPartners, "Name", "الاسم");
            GridHelper.SetColumnHeader(dgvPartners, "TypeName", "النوع");
            GridHelper.SetColumnHeader(dgvPartners, "Phone", "الهاتف");
            GridHelper.SetColumnHeader(dgvPartners, "Email", "البريد");
            GridHelper.SetColumnHeader(dgvPartners, "Address", "العنوان");
        }

        private void UpdateCount()
        {
            lblCount.Text = $"العدد: {GridHelper.GetVisibleRowCount(dgvPartners)}";
        }

        // ============================================
        // الأزرار
        // ============================================

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var form = new frmPartnerEdit();
            if (form.ShowDialog() == DialogResult.OK)
                LoadPartners();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvPartners.CurrentRow == null)
            {
                MessageHelper.ShowSelectItem();
                return;
            }

            int partnerId = GridHelper.GetSelectedValue<int>(dgvPartners, "PartnerId");

            string error;
            var partner = _partnerBLL.GetById(partnerId, out error);

            if (partner == null)
            {
                MessageHelper.ShowError(error ?? "لم يتم العثور على الشريك");
                return;
            }

            var form = new frmPartnerEdit(partner);
            if (form.ShowDialog() == DialogResult.OK)
                LoadPartners();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvPartners.CurrentRow == null)
            {
                MessageHelper.ShowSelectItem();
                return;
            }

            int partnerId = GridHelper.GetSelectedValue<int>(dgvPartners, "PartnerId");
            string partnerName = GridHelper.GetSelectedValue<string>(dgvPartners, "Name");

            if (!MessageHelper.ConfirmDelete($"الشريك '{partnerName}'"))
                return;

            string error;
            if (_partnerBLL.Delete(partnerId, out error))
            {
                MessageHelper.ShowDeleteSuccess();
                LoadPartners();
            }
            else
            {
                MessageHelper.ShowError(error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            cmbFilter.SelectedIndex = 0;
            LoadPartners();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            GridHelper.FilterRows(dgvPartners, txtSearch.Text);
            UpdateCount();
        }

        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void dgvPartners_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                btnEdit_Click(sender, e);
        }
    }
}