using InventorySystem.UI.Business;
using InventorySystem.UI.Helpers;
using InventorySystem.UI.Models.Entities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace InventorySystem.UI.Forms
{
    /// <summary>
    /// شاشة إضافة/تعديل مستودع
    /// </summary>
    public partial class frmWarehouseEdit : Form
    {
        private readonly WarehouseBLL _warehouseBLL;
        private readonly UserBLL _userBLL;
        private readonly Warehouse _warehouse;
        private readonly bool _isEditMode;

        public frmWarehouseEdit()
        {
            InitializeComponent();
            _warehouseBLL = new WarehouseBLL();
            _userBLL = new UserBLL();
            _warehouse = new Warehouse();
            _isEditMode = false;
        }

        public frmWarehouseEdit(Warehouse warehouse)
        {
            InitializeComponent();
            _warehouseBLL = new WarehouseBLL();
            _userBLL = new UserBLL();
            _warehouse = warehouse;
            _isEditMode = true;
        }

        private void frmWarehouseEdit_Load(object sender, EventArgs e)
        {
            LoadManagers();

            if (_isEditMode)
            {
                lblTitle.Text = "تعديل مستودع";
                this.Text = "تعديل مستودع";
                LoadWarehouseData();
            }
            else
            {
                lblTitle.Text = "إضافة مستودع";
                this.Text = "إضافة مستودع";
            }

            txtName.Focus();
        }

        /// <summary>
        /// تحميل قائمة المدراء
        /// </summary>
        private void LoadManagers()
        {
            string error;
            var users = _userBLL.GetAll(out error);

            // إضافة عنصر فارغ
            var list = new List<User>
            {
                new User { UserId = 0, FullName = "— بدون مدير —" }
            };

            foreach (var user in users)
                list.Add(user);

            ComboHelper.LoadFromList(cmbManager, list, "UserId", "FullName");
            cmbManager.SelectedIndex = 0;
        }

        /// <summary>
        /// تحميل بيانات المستودع
        /// </summary>
        private void LoadWarehouseData()
        {
            txtName.Text = _warehouse.Name;
            txtLocation.Text = _warehouse.Location;
            chkIsActive.Checked = _warehouse.IsActive;

            if (_warehouse.ManagerId.HasValue)
                ComboHelper.SelectById(cmbManager, _warehouse.ManagerId.Value);
            else
                cmbManager.SelectedIndex = 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _warehouse.Name = txtName.Text.Trim();
            _warehouse.Location = txtLocation.Text.Trim();
            _warehouse.IsActive = chkIsActive.Checked;

            int managerId = ComboHelper.GetSelectedId(cmbManager);
            _warehouse.ManagerId = managerId > 0 ? (int?)managerId : null;

            string error;
            bool success;

            if (_isEditMode)
                success = _warehouseBLL.Update(_warehouse, out error);
            else
                success = _warehouseBLL.Add(_warehouse, out error);

            if (success)
            {
                LogHelper.LogInfo($"حفظ مستودع: {_warehouse.Name}");

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