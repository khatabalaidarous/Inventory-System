using InventorySystem.UI.Business;
using InventorySystem.UI.Helpers;
using InventorySystem.UI.Models.Entities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace InventorySystem.UI.Forms
{
    /// <summary>
    /// شاشة إدارة المنتجات
    /// </summary>
    public partial class frmProducts : Form
    {
        private readonly ProductBLL _productBLL;

        public frmProducts()
        {
            InitializeComponent();
            _productBLL = new ProductBLL();
            GridHelper.StyleGrid(dgvProducts);
        }

        private void frmProducts_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void LoadProducts()
        {
            try
            {
                string error;
                var products = _productBLL.GetAll(out error);

                if (!string.IsNullOrEmpty(error))
                {
                    MessageHelper.ShowError(error);
                    return;
                }

                dgvProducts.DataSource = null;
                dgvProducts.DataSource = products;

                FormatGrid();
                UpdateCount();
            }
            catch (Exception ex)
            {
                LogHelper.LogError(ex, "frmProducts.LoadProducts");
                MessageHelper.ShowException(ex);
            }
        }

        private void FormatGrid()
        {
            if (dgvProducts.Columns.Count == 0) return;

            GridHelper.HideColumns(dgvProducts,
                "ProductId", "CategoryId", "UnitId", "MinStock", "MaxStock", "IsActive", "CreatedAt");

            GridHelper.SetColumnHeader(dgvProducts, "Code", "الكود");
            GridHelper.SetColumnHeader(dgvProducts, "Name", "اسم المنتج");
            GridHelper.SetColumnHeader(dgvProducts, "CategoryName", "التصنيف");
            GridHelper.SetColumnHeader(dgvProducts, "UnitName", "الوحدة");
            GridHelper.SetColumnHeader(dgvProducts, "CurrentStock", "الرصيد الحالي");

            // تنسيق الرصيد
            if (dgvProducts.Columns.Contains("CurrentStock"))
                GridHelper.FormatAsCurrency(dgvProducts, "CurrentStock");

            // تلوين الصفوف حسب الرصيد
            ColorRowsByStock();
        }

        /// <summary>
        /// تلوين الصفوف حسب الرصيد
        /// </summary>
        private void ColorRowsByStock()
        {
            dgvProducts.CellFormatting += (sender, e) =>
            {
                if (e.RowIndex < 0) return;

                var row = dgvProducts.Rows[e.RowIndex];
                var stock = Convert.ToDecimal(row.Cells["CurrentStock"].Value ?? 0);

                if (stock == 0)
                {
                    // نفد المخزون
                    row.DefaultCellStyle.BackColor = Color.FromArgb(255, 235, 235);
                }
            };
        }

        private void UpdateCount()
        {
            lblCount.Text = $"العدد: {GridHelper.GetVisibleRowCount(dgvProducts)}";
        }

        // ============================================
        // الأزرار
        // ============================================

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var form = new frmProductEdit();
            if (form.ShowDialog() == DialogResult.OK)
                LoadProducts();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow == null)
            {
                MessageHelper.ShowSelectItem();
                return;
            }

            int productId = GridHelper.GetSelectedValue<int>(dgvProducts, "ProductId");

            string error;
            var product = _productBLL.GetById(productId, out error);

            if (product == null)
            {
                MessageHelper.ShowError(error ?? "لم يتم العثور على المنتج");
                return;
            }

            var form = new frmProductEdit(product);
            if (form.ShowDialog() == DialogResult.OK)
                LoadProducts();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow == null)
            {
                MessageHelper.ShowSelectItem();
                return;
            }

            int productId = GridHelper.GetSelectedValue<int>(dgvProducts, "ProductId");
            string productName = GridHelper.GetSelectedValue<string>(dgvProducts, "Name");

            if (!MessageHelper.ConfirmDelete($"المنتج '{productName}'"))
                return;

            string error;
            if (_productBLL.Delete(productId, out error))
            {
                MessageHelper.ShowDeleteSuccess();
                LoadProducts();
            }
            else
            {
                MessageHelper.ShowError(error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            LoadProducts();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            GridHelper.FilterRows(dgvProducts, txtSearch.Text);
            UpdateCount();
        }

        private void dgvProducts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                btnEdit_Click(sender, e);
        }
    }
}