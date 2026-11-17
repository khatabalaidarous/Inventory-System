using InventorySystem.UI.Business;
using InventorySystem.UI.Helpers;
using InventorySystem.UI.Models.Entities;
using System;
using System.Windows.Forms;

namespace InventorySystem.UI.Forms
{
    public partial class frmUsers : Form
    {
        private readonly UserBLL _userBLL;

        public frmUsers()
        {
            InitializeComponent();
            _userBLL = new UserBLL();
            GridHelper.StyleGrid(dgvUsers);
        }

        private void frmUsers_Load(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private void LoadUsers()
        {
            try
            {
                string error;
                var users = _userBLL.GetAll(out error);

                if (!string.IsNullOrEmpty(error))
                {
                    MessageHelper.ShowError(error);
                    return;
                }

                dgvUsers.DataSource = null;
                dgvUsers.DataSource = users;

                FormatGrid();
                UpdateCount();
            }
            catch (Exception ex)
            {
                LogHelper.LogError(ex, "frmUsers.LoadUsers");
                MessageHelper.ShowException(ex);
            }
        }

        private void FormatGrid()
        {
            if (dgvUsers.Columns.Count == 0) return;

            GridHelper.HideColumns(dgvUsers, "UserId", "PasswordHash", "CreatedAt");

            GridHelper.SetColumnHeader(dgvUsers, "Username", "اسم المستخدم");
            GridHelper.SetColumnHeader(dgvUsers, "FullName", "الاسم الكامل");
            GridHelper.SetColumnHeader(dgvUsers, "IsActive", "مفعّل");
        }

        private void UpdateCount()
        {
            lblCount.Text = $"العدد: {GridHelper.GetVisibleRowCount(dgvUsers)}";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var form = new frmUserEdit();
            if (form.ShowDialog() == DialogResult.OK)
                LoadUsers();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvUsers.CurrentRow == null)
            {
                MessageHelper.ShowSelectItem();
                return;
            }

            int userId = GridHelper.GetSelectedValue<int>(dgvUsers, "UserId");

            string error;
            var user = _userBLL.GetById(userId, out error);

            if (user == null)
            {
                MessageHelper.ShowError(error ?? "لم يتم العثور على المستخدم");
                return;
            }

            var form = new frmUserEdit(user);
            if (form.ShowDialog() == DialogResult.OK)
                LoadUsers();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvUsers.CurrentRow == null)
            {
                MessageHelper.ShowSelectItem();
                return;
            }

            int userId = GridHelper.GetSelectedValue<int>(dgvUsers, "UserId");
            string fullName = GridHelper.GetSelectedValue<string>(dgvUsers, "FullName");

            if (!MessageHelper.ConfirmDelete($"المستخدم '{fullName}'"))
                return;

            string error;
            if (_userBLL.Delete(userId, out error))
            {
                MessageHelper.ShowDeleteSuccess();
                LoadUsers();
            }
            else
            {
                MessageHelper.ShowError(error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            LoadUsers();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            GridHelper.FilterRows(dgvUsers, txtSearch.Text);
            UpdateCount();
        }

        private void dgvUsers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                btnEdit_Click(sender, e);
        }
    }
}