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
    /// شاشة إدارة التصنيفات
    /// </summary>
    public partial class frmCategories : Form
    {
        // ============================================
        // المتغيرات
        // ============================================

        private readonly CategoryBLL _categoryBLL;
        private List<Category> _categories;

        // ============================================
        // Constructor
        // ============================================

        public frmCategories()
        {
            InitializeComponent();
            _categoryBLL = new CategoryBLL();

            // تنسيق DataGridView
            GridHelper.StyleGrid(dgvCategories);
        }

        // ============================================
        // تحميل الشاشة
        // ============================================

        private void frmCategories_Load(object sender, EventArgs e)
        {
            LoadCategories();
        }

        /// <summary>
        /// تحميل التصنيفات
        /// </summary>
        private void LoadCategories()
        {
            try
            {
                string error;
                _categories = _categoryBLL.GetAll(out error);

                if (!string.IsNullOrEmpty(error))
                {
                    MessageHelper.ShowError(error);
                    return;
                }

                dgvCategories.DataSource = null;
                dgvCategories.DataSource = _categories;

                FormatGrid();
                UpdateCount();
            }
            catch (Exception ex)
            {
                LogHelper.LogError(ex, "frmCategories.LoadCategories");
                MessageHelper.ShowException(ex);
            }
        }

        /// <summary>
        /// تنسيق الأعمدة
        /// </summary>
        private void FormatGrid()
        {
            if (dgvCategories.Columns.Count == 0) return;

            // إخفاء الأعمدة
            GridHelper.HideColumns(dgvCategories, "CategoryId", "ParentId", "IsActive", "CreatedAt");

            // تعيين العناوين
            GridHelper.SetColumnHeader(dgvCategories, "Name", "اسم التصنيف");
            GridHelper.SetColumnHeader(dgvCategories, "ParentName", "التصنيف الأب");

            // تنسيق التواريخ
            if (dgvCategories.Columns.Contains("CreatedAt"))
                GridHelper.FormatAsDate(dgvCategories, "CreatedAt");
        }

        /// <summary>
        /// تحديث العدد
        /// </summary>
        private void UpdateCount()
        {
            lblCount.Text = $"العدد: {dgvCategories.Rows.Count}";
        }

        // ============================================
        // الأزرار
        // ============================================

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var form = new frmCategoryEdit();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadCategories();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvCategories.CurrentRow == null)
            {
                MessageHelper.ShowSelectItem();
                return;
            }

            int categoryId = GridHelper.GetSelectedValue<int>(dgvCategories, "CategoryId");

            string error;
            var category = _categoryBLL.GetById(categoryId, out error);

            if (category == null)
            {
                MessageHelper.ShowError(error ?? "لم يتم العثور على التصنيف");
                return;
            }

            var form = new frmCategoryEdit(category);
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadCategories();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvCategories.CurrentRow == null)
            {
                MessageHelper.ShowSelectItem();
                return;
            }

            int categoryId = GridHelper.GetSelectedValue<int>(dgvCategories, "CategoryId");
            string categoryName = GridHelper.GetSelectedValue<string>(dgvCategories, "Name");

            if (!MessageHelper.ConfirmDelete($"التصنيف '{categoryName}'"))
                return;

            string error;
            if (_categoryBLL.Delete(categoryId, out error))
            {
                MessageHelper.ShowDeleteSuccess();
                LoadCategories();
            }
            else
            {
                MessageHelper.ShowError(error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            LoadCategories();
        }

        // ============================================
        // البحث
        // ============================================

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            GridHelper.FilterRows(dgvCategories, txtSearch.Text);
            UpdateCount();
        }

        // ============================================
        // Double Click للتعديل
        // ============================================

        private void dgvCategories_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                btnEdit_Click(sender, e);
            }
        }
    }
}