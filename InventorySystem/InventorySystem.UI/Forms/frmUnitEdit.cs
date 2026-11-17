using InventorySystem.UI.Business;
using InventorySystem.UI.Helpers;
using InventorySystem.UI.Models.Entities;
using System;
using System.Windows.Forms;

namespace InventorySystem.UI.Forms
{
    /// <summary>
    /// شاشة إضافة/تعديل وحدة
    /// </summary>
    public partial class frmUnitEdit : Form
    {
        private readonly UnitBLL _unitBLL;
        private readonly Unit _unit;
        private readonly bool _isEditMode;

        public frmUnitEdit()
        {
            InitializeComponent();
            _unitBLL = new UnitBLL();
            _unit = new Unit();
            _isEditMode = false;
        }

        public frmUnitEdit(Unit unit)
        {
            InitializeComponent();
            _unitBLL = new UnitBLL();
            _unit = unit;
            _isEditMode = true;
        }

        private void frmUnitEdit_Load(object sender, EventArgs e)
        {
            if (_isEditMode)
            {
                lblTitle.Text = "تعديل وحدة";
                this.Text = "تعديل وحدة";
                txtName.Text = _unit.Name;
                txtSymbol.Text = _unit.Symbol;
            }
            else
            {
                lblTitle.Text = "إضافة وحدة";
                this.Text = "إضافة وحدة";
            }

            txtName.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _unit.Name = txtName.Text.Trim();
            _unit.Symbol = txtSymbol.Text.Trim();

            string error;
            bool success;

            if (_isEditMode)
                success = _unitBLL.Update(_unit, out error);
            else
                success = _unitBLL.Add(_unit, out error);

            if (success)
            {
                LogHelper.LogInfo($"حفظ وحدة: {_unit.Name}");

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
    }
}