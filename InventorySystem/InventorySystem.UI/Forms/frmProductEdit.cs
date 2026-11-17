using InventorySystem.UI.Business;
using InventorySystem.UI.Helpers;
using InventorySystem.UI.Models.Entities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace InventorySystem.UI.Forms
{
    /// <summary>
    /// شاشة إضافة/تعديل منتج
    /// </summary>
    public partial class frmProductEdit : Form
    {
        private readonly ProductBLL _productBLL;
        private readonly CategoryBLL _categoryBLL;
        private readonly UnitBLL _unitBLL;
        private readonly Product _product;
        private readonly bool _isEditMode;

        public frmProductEdit()
        {
            InitializeComponent();
            _productBLL = new ProductBLL();
            _categoryBLL = new CategoryBLL();
            _unitBLL = new UnitBLL();
            _product = new Product();
            _isEditMode = false;
        }

        public frmProductEdit(Product product)
        {
            InitializeComponent();
            _productBLL = new ProductBLL();
            _categoryBLL = new CategoryBLL();
            _unitBLL = new UnitBLL();
            _product = product;
            _isEditMode = true;
        }

        private void frmProductEdit_Load(object sender, EventArgs e)
        {
            LoadCategories();
            LoadUnits();

            if (_isEditMode)
            {
                lblTitle.Text = "تعديل منتج";
                this.Text = "تعديل منتج";
                LoadProductData();
            }
            else
            {
                lblTitle.Text = "إضافة منتج";
                this.Text = "إضافة منتج";
            }

            txtCode.Focus();
        }

        /// <summary>
        /// تحميل التصنيفات
        /// </summary>
        private void LoadCategories()
        {
            string error;
            var categories = _categoryBLL.GetActive(out error);

            ComboHelper.LoadFromList(cmbCategory, categories, "CategoryId", "Name");
        }

        /// <summary>
        /// تحميل الوحدات
        /// </summary>
        private void LoadUnits()
        {
            string error;
            var units = _unitBLL.GetAll(out error);

            ComboHelper.LoadFromList(cmbUnit, units, "UnitId", "Name");
        }

        /// <summary>
        /// تحميل بيانات المنتج
        /// </summary>
        private void LoadProductData()
        {
            txtCode.Text = _product.Code;
            txtName.Text = _product.Name;
            numMinStock.Value = _product.MinStock;
            numMaxStock.Value = _product.MaxStock;
            chkIsActive.Checked = _product.IsActive;

            ComboHelper.SelectById(cmbCategory, _product.CategoryId);
            ComboHelper.SelectById(cmbUnit, _product.UnitId);
        }

        // ============================================
        // حفظ
        // ============================================

        private void btnSave_Click(object sender, EventArgs e)
        {
            // جمع البيانات
            _product.Code = txtCode.Text.Trim();
            _product.Name = txtName.Text.Trim();
            _product.CategoryId = ComboHelper.GetSelectedId(cmbCategory);
            _product.UnitId = ComboHelper.GetSelectedId(cmbUnit);
            _product.MinStock = numMinStock.Value;
            _product.MaxStock = numMaxStock.Value;
            _product.IsActive = chkIsActive.Checked;

            // الحفظ
            string error;
            bool success;

            if (_isEditMode)
                success = _productBLL.Update(_product, out error);
            else
                success = _productBLL.Add(_product, out error);

            if (success)
            {
                LogHelper.LogInfo($"حفظ منتج: {_product.Name}");

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