using InventorySystem.UI.Business;
using InventorySystem.UI.Helpers;
using InventorySystem.UI.Models.Entities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace InventorySystem.UI.Forms
{
    public partial class frmUserEdit : Form
    {
        private readonly UserBLL _userBLL;
        private readonly RoleBLL _roleBLL;
        private readonly User _user;
        private readonly bool _isEditMode;

        // قائمة الأدوار المتاحة
        private List<Role> _allRoles;

        public frmUserEdit()
        {
            InitializeComponent();
            _userBLL = new UserBLL();
            _roleBLL = new RoleBLL();
            _user = new User();
            _isEditMode = false;
        }

        public frmUserEdit(User user)
        {
            InitializeComponent();
            _userBLL = new UserBLL();
            _roleBLL = new RoleBLL();
            _user = user;
            _isEditMode = true;
        }

        private void frmUserEdit_Load(object sender, EventArgs e)
        {
            LoadRoles();

            if (_isEditMode)
            {
                lblTitle.Text = "تعديل مستخدم";
                this.Text = "تعديل مستخدم";

                txtUsername.Text = _user.Username;
                txtFullName.Text = _user.FullName;
                chkIsActive.Checked = _user.IsActive;

                lblPassword.Text = "كلمة المرور (اتركها فارغة للإبقاء):";
                lblConfirmPassword.Text = "تأكيد كلمة المرور:";

                LoadUserRoles();
            }
            else
            {
                lblTitle.Text = "إضافة مستخدم";
                this.Text = "إضافة مستخدم";
            }

            txtUsername.Focus();
        }

        /// <summary>
        /// تحميل كل الأدوار المتاحة
        /// </summary>
        private void LoadRoles()
        {
            string error;
            _allRoles = _roleBLL.GetAll(out error);

            clbRoles.Items.Clear();

            foreach (var role in _allRoles)
            {
                clbRoles.Items.Add(role.Name);
            }
        }

        /// <summary>
        /// تحميل أدوار المستخدم الحالي
        /// </summary>
        private void LoadUserRoles()
        {
            string error;
            var userRoles = _userBLL.GetUserRoles(_user.UserId, out error);

            for (int i = 0; i < clbRoles.Items.Count; i++)
            {
                string roleName = clbRoles.Items[i].ToString();

                foreach (var ur in userRoles)
                {
                    if (ur.Name == roleName)
                    {
                        clbRoles.SetItemChecked(i, true);
                        break;
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _user.Username = txtUsername.Text.Trim();
            _user.FullName = txtFullName.Text.Trim();
            _user.IsActive = chkIsActive.Checked;

            string error;
            bool success;
            int userId = _user.UserId;

            if (_isEditMode)
            {
                success = _userBLL.Update(_user, out error);

                if (success && !string.IsNullOrWhiteSpace(txtPassword.Text))
                {
                    if (txtPassword.Text != txtConfirmPassword.Text)
                    {
                        MessageHelper.ShowError("كلمة المرور وتأكيدها غير متطابقين");
                        return;
                    }

                    _userBLL.ChangePassword(_user.UserId, txtPassword.Text, out error);
                }
            }
            else
            {
                if (string.IsNullOrWhiteSpace(txtPassword.Text))
                {
                    MessageHelper.ShowWarning("كلمة المرور مطلوبة");
                    return;
                }

                if (txtPassword.Text != txtConfirmPassword.Text)
                {
                    MessageHelper.ShowError("كلمة المرور وتأكيدها غير متطابقين");
                    return;
                }

                success = _userBLL.Add(_user, txtPassword.Text, out error);

                // الحصول على معرف المستخدم الجديد
                if (success)
                {
                    var newUser = _userBLL.Login(_user.Username, txtPassword.Text, out error);
                    if (newUser != null)
                        userId = newUser.UserId;
                }
            }

            if (success)
            {
                // حفظ الأدوار
                if (userId > 0)
                    SaveUserRoles(userId);

                LogHelper.LogInfo($"حفظ مستخدم: {_user.Username}");

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

        /// <summary>
        /// حفظ أدوار المستخدم
        /// </summary>
        private void SaveUserRoles(int userId)
        {
            try
            {
                // جمع الأدوار المحددة
                var selectedRoleIds = new List<int>();

                for (int i = 0; i < clbRoles.Items.Count; i++)
                {
                    if (clbRoles.GetItemChecked(i))
                    {
                        // ابحث عن الدور بالاسم
                        string roleName = clbRoles.Items[i].ToString();

                        foreach (var role in _allRoles)
                        {
                            if (role.Name == roleName)
                            {
                                selectedRoleIds.Add(role.RoleId);
                                break;
                            }
                        }
                    }
                }

                string error;
                _userBLL.SetUserRoles(userId, selectedRoleIds, out error);
            }
            catch (Exception ex)
            {
                LogHelper.LogError(ex, "frmUserEdit.SaveUserRoles");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}