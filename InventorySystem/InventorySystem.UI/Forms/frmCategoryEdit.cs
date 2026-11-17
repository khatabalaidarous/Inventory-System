using InventorySystem.UI.Business;
using InventorySystem.UI.Helpers;
using InventorySystem.UI.Models.Entities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace InventorySystem.UI.Forms
{
    /// <summary>
    /// شاشة إضافة/تعديل تصنيف
    /// </summary>
    public partial class frmCategoryEdit : Form
    {
        // ============================================
        // المتغيرات
        // ============================================

        private readonly CategoryBLL _categoryBLL;
        private readonly Category _category;
        private readonly bool _isEditMode;

        // ============================================
        // Constructor
        // ============================================

        /// <summary>
        /// وضع الإضافة
        /// </summary>
        public frmCategoryEdit()
        {
            InitializeComponent();
            _categoryBLL = new CategoryBLL();
            _category = new Category();
            _isEditMode = false;
        }

        /// <summary>
        /// وضع التعديل
        /// </summary>
        public frmCategoryEdit(Category category)
        {
            InitializeComponent();
            _categoryBLL = new CategoryBLL();
            _category = category;
            _isEditMode = true;
        }

        // ============================================
        // تحميل الشاشة
        // ============================================

        private void frmCategoryEdit_Load(object sender, EventArgs e)
        {
            LoadParents();

            if (_isEditMode)
            {
                lblTitle.Text = "تعديل تصنيف";
                this.Text = "تعديل تصنيف";
                LoadCategoryData();
            }
            else
            {
                lblTitle.Text = "إضافة تصنيف";
                this.Text = "إضافة تصنيف";
            }

            txtName.Focus();
        }

        /// <summary>
        /// تحميل قائمة التصنيفات الأب
        /// </summary>
        private void LoadParents()
        {
            string error;
            var categories = _categoryBLL.GetActive(out error);

            // إضافة عنصر فارغ
            var list = new List<Category>
            {
                new Category { CategoryId = 0, Name = "— بدون (تصنيف رئيسي) —" }
            };

            // إضافة التصنيفات الأخرى
            foreach (var cat in categories)
            {
                // استثناء التصنيف الحالي (في وضع التعديل)
                if (_isEditMode && cat.CategoryId == _category.CategoryId)
                    continue;

                list.Add(cat);
            }

            ComboHelper.LoadFromList(cmbParent, list, "CategoryId", "Name");
            cmbParent.SelectedIndex = 0;
        }

        /// <summary>
        /// تحميل بيانات التصنيف
        /// </summary>
        private void LoadCategoryData()
        {
            txtName.Text = _category.Name;
            chkIsActive.Checked = _category.IsActive;

            if (_category.ParentId.HasValue)
            {
                ComboHelper.SelectById(cmbParent, _category.ParentId.Value);
            }
            else
            {
                cmbParent.SelectedIndex = 0;
            }
        }

        // ============================================
        // حفظ
        // ============================================

        private void btnSave_Click(object sender, EventArgs e)
        {
            // جمع البيانات
            _category.Name = txtName.Text.Trim();
            _category.IsActive = chkIsActive.Checked;

            int parentId = ComboHelper.GetSelectedId(cmbParent);
            _category.ParentId = parentId > 0 ? (int?)parentId : null;

            // الحفظ
            string error;
            bool success;

            if (_isEditMode)
            {
                success = _categoryBLL.Update(_category, out error);
            }
            else
            {
                success = _categoryBLL.Add(_category, out error);
            }

            if (success)
            {
                LogHelper.LogInfo($"حفظ تصنيف: {_category.Name}");

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

        // ============================================
        // إلغاء
        // ============================================

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}