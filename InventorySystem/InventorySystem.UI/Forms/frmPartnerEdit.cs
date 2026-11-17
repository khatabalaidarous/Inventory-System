using InventorySystem.UI.Business;
using InventorySystem.UI.Helpers;
using InventorySystem.UI.Models.Entities;
using System;
using System.Windows.Forms;

namespace InventorySystem.UI.Forms
{
    /// <summary>
    /// شاشة إضافة/تعديل شريك
    /// </summary>
    public partial class frmPartnerEdit : Form
    {
        private readonly PartnerBLL _partnerBLL;
        private readonly Partner _partner;
        private readonly bool _isEditMode;

        public frmPartnerEdit()
        {
            InitializeComponent();
            _partnerBLL = new PartnerBLL();
            _partner = new Partner();
            _isEditMode = false;
        }

        public frmPartnerEdit(Partner partner)
        {
            InitializeComponent();
            _partnerBLL = new PartnerBLL();
            _partner = partner;
            _isEditMode = true;
        }

        private void frmPartnerEdit_Load(object sender, EventArgs e)
        {
            LoadPartnerTypes();

            if (_isEditMode)
            {
                lblTitle.Text = "تعديل شريك";
                this.Text = "تعديل شريك";
                LoadPartnerData();
            }
            else
            {
                lblTitle.Text = "إضافة شريك";
                this.Text = "إضافة شريك";
            }

            txtName.Focus();
        }

        private void LoadPartnerTypes()
        {
            cmbType.Items.Clear();
            cmbType.Items.Add("مورد");
            cmbType.Items.Add("عميل");
            cmbType.Items.Add("مورد وعميل");
            cmbType.SelectedIndex = 0;
        }

        private void LoadPartnerData()
        {
            txtName.Text = _partner.Name;
            txtPhone.Text = _partner.Phone;
            txtEmail.Text = _partner.Email;
            txtAddress.Text = _partner.Address;
            txtTaxNumber.Text = _partner.TaxNumber;
            chkIsActive.Checked = _partner.IsActive;

            switch (_partner.Type)
            {
                case "Supplier": cmbType.SelectedIndex = 0; break;
                case "Customer": cmbType.SelectedIndex = 1; break;
                case "Both": cmbType.SelectedIndex = 2; break;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _partner.Name = txtName.Text.Trim();
            _partner.Phone = txtPhone.Text.Trim();
            _partner.Email = txtEmail.Text.Trim();
            _partner.Address = txtAddress.Text.Trim();
            _partner.TaxNumber = txtTaxNumber.Text.Trim();
            _partner.IsActive = chkIsActive.Checked;

            switch (cmbType.SelectedIndex)
            {
                case 0: _partner.Type = "Supplier"; break;
                case 1: _partner.Type = "Customer"; break;
                case 2: _partner.Type = "Both"; break;
            }

            string error;
            bool success;

            if (_isEditMode)
                success = _partnerBLL.Update(_partner, out error);
            else
                success = _partnerBLL.Add(_partner, out error);

            if (success)
            {
                LogHelper.LogInfo($"حفظ شريك: {_partner.Name}");

                if (_isEditMode)
                    MessageHelper.ShowUpdateSuccess();
                else
                    MessageHelper.ShowSaveSuccess();

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

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
    }
}