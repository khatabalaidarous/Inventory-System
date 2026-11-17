using InventorySystem.UI.Business;
using InventorySystem.UI.Helpers;
using System;
using System.Windows.Forms;

namespace InventorySystem.UI.Forms
{
    public partial class frmRoles : Form
    {
        private readonly RoleBLL _roleBLL;

        public frmRoles()
        {
            InitializeComponent();
            _roleBLL = new RoleBLL();
            GridHelper.StyleGrid(dgvRoles);
        }

        private void frmRoles_Load(object sender, EventArgs e)
        {
            LoadRoles();
        }

        private void LoadRoles()
        {
            try
            {
                string error;
                var roles = _roleBLL.GetAll(out error);

                if (!string.IsNullOrEmpty(error))
                {
                    MessageHelper.ShowError(error);
                    return;
                }

                dgvRoles.DataSource = null;
                dgvRoles.DataSource = roles;

                if (dgvRoles.Columns.Count > 0)
                {
                    GridHelper.HideColumn(dgvRoles, "RoleId");
                    GridHelper.SetColumnHeader(dgvRoles, "Name", "اسم الدور");
                    GridHelper.SetColumnHeader(dgvRoles, "Description", "الوصف");
                }
            }
            catch (Exception ex)
            {
                LogHelper.LogError(ex, "frmRoles.LoadRoles");
                MessageHelper.ShowException(ex);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MessageHelper.ShowInfo("شاشة إضافة دور - يمكن تنفيذها بنفس النمط");
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadRoles();
        }
    }
}