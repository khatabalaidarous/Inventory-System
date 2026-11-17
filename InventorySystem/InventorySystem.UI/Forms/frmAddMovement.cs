using InventorySystem.UI.Business;
using InventorySystem.UI.Helpers;
using InventorySystem.UI.Models.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace InventorySystem.UI.Forms
{
    /// <summary>
    /// شاشة إضافة حركة مخزنية جديدة
    /// </summary>
    public partial class frmAddMovement : Form
    {
        // ============================================
        // المتغيرات
        // ============================================

        private readonly StockMovementBLL _movementBLL;
        private readonly ProductBLL _productBLL;
        private readonly WarehouseBLL _warehouseBLL;
        private readonly PartnerBLL _partnerBLL;

        private readonly StockMovement _movement;
        private readonly BindingList<StockMovementDetail> _details;

        // ============================================
        // Constructor
        // ============================================

        public frmAddMovement()
        {
            InitializeComponent();

            _movementBLL = new StockMovementBLL();
            _productBLL = new ProductBLL();
            _warehouseBLL = new WarehouseBLL();
            _partnerBLL = new PartnerBLL();

            _movement = new StockMovement
            {
                MovementDate = DateTime.Now,
                UserId = SessionManager.UserId
            };

            _details = new BindingList<StockMovementDetail>();
        }

        // ============================================
        // تحميل الشاشة
        // ============================================

        private void frmAddMovement_Load(object sender, EventArgs e)
        {
            LoadMovementTypes();
            LoadWarehouses();
            LoadProducts();
            LoadPartners();

            dgvDetails.DataSource = _details;
            FormatDetailsGrid();

            cmbType.SelectedIndex = 0;
            cmbPartner.SelectedIndex = 0;

            UpdateUI();
        }

        private void LoadMovementTypes()
        {
            cmbType.Items.Clear();
            cmbType.Items.Add("استلام من مورد (IN)");
            cmbType.Items.Add("صرف لعميل (OUT)");
            cmbType.Items.Add("تحويل بين مستودعين (TRANSFER)");
            cmbType.Items.Add("تسوية (ADJUST)");
        }

        private void LoadWarehouses()
        {
            string error;
            var warehouses = _warehouseBLL.GetActive(out error);

            ComboHelper.LoadFromList(cmbFromWarehouse, warehouses, "WarehouseId", "Name");
            ComboHelper.LoadFromList(cmbToWarehouse, warehouses, "WarehouseId", "Name");
        }

        private void LoadProducts()
        {
            string error;
            var products = _productBLL.GetActive(out error);

            var list = new List<Product>
            {
                new Product { ProductId = 0, Name = "— اختر منتج —" }
            };

            foreach (var p in products)
                list.Add(p);

            ComboHelper.LoadFromList(cmbProduct, list, "ProductId", "Name");
            cmbProduct.SelectedIndex = 0;
        }

        private void LoadPartners()
        {
            string error;
            var partners = _partnerBLL.GetAll(out error);

            var list = new List<Partner>
            {
                new Partner { PartnerId = 0, Name = "— بدون —" }
            };

            foreach (var p in partners)
                list.Add(p);

            ComboHelper.LoadFromList(cmbPartner, list, "PartnerId", "Name");
        }

        private void FormatDetailsGrid()
        {
            GridHelper.StyleGrid(dgvDetails);

            if (dgvDetails.Columns.Count == 0) return;

            GridHelper.HideColumns(dgvDetails, "DetailId", "MovementId", "ProductId", "BatchId", "UnitPrice", "Total");
            GridHelper.SetColumnHeader(dgvDetails, "ProductCode", "الكود");
            GridHelper.SetColumnHeader(dgvDetails, "ProductName", "المنتج");
            GridHelper.SetColumnHeader(dgvDetails, "Quantity", "الكمية");
        }

        // ============================================
        // تحديث الواجهة حسب نوع الحركة
        // ============================================

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateUI();
        }

        private void UpdateUI()
        {
            int typeIndex = cmbType.SelectedIndex;

            cmbFromWarehouse.SelectedIndex = -1;
            cmbToWarehouse.SelectedIndex = -1;
            cmbPartner.SelectedIndex = 0;

            switch (typeIndex)
            {
                case 0: // IN - استلام
                    cmbFromWarehouse.Enabled = false;
                    cmbToWarehouse.Enabled = true;
                    cmbPartner.Enabled = true;
                    lblFromWarehouse.Text = "من مستودع (غير مطلوب):";
                    lblToWarehouse.Text = "إلى مستودع: *";
                    lblPartner.Text = "المورد: *";
                    _movement.Type = "IN";
                    break;

                case 1: // OUT - صرف
                    cmbFromWarehouse.Enabled = true;
                    cmbToWarehouse.Enabled = false;
                    cmbPartner.Enabled = true;
                    lblFromWarehouse.Text = "من مستودع: *";
                    lblToWarehouse.Text = "إلى مستودع (غير مطلوب):";
                    lblPartner.Text = "العميل:";
                    _movement.Type = "OUT";
                    break;

                case 2: // TRANSFER - تحويل
                    cmbFromWarehouse.Enabled = true;
                    cmbToWarehouse.Enabled = true;
                    cmbPartner.Enabled = false;
                    lblFromWarehouse.Text = "من مستودع: *";
                    lblToWarehouse.Text = "إلى مستودع: *";
                    lblPartner.Text = "الشريك (غير مطلوب):";
                    _movement.Type = "TRANSFER";
                    break;

                case 3: // ADJUST - تسوية
                    cmbFromWarehouse.Enabled = false;
                    cmbToWarehouse.Enabled = true;
                    cmbPartner.Enabled = false;
                    lblFromWarehouse.Text = "من مستودع (غير مطلوب):";
                    lblToWarehouse.Text = "المستودع: *";
                    lblPartner.Text = "الشريك (غير مطلوب):";
                    _movement.Type = "ADJUST";
                    break;
            }
        }

        // ============================================
        // إضافة تفصيل
        // ============================================

        private void btnAddDetail_Click(object sender, EventArgs e)
        {
            int productId = ComboHelper.GetSelectedId(cmbProduct);

            if (productId == 0)
            {
                MessageHelper.ShowWarning("يجب اختيار منتج");
                return;
            }

            if (numQuantity.Value <= 0)
            {
                MessageHelper.ShowWarning("الكمية يجب أن تكون أكبر من صفر");
                return;
            }

            string error;
            var product = _productBLL.GetById(productId, out error);

            if (product == null)
            {
                MessageHelper.ShowError("لم يتم العثور على المنتج");
                return;
            }

            // التحقق من عدم التكرار
            foreach (var d in _details)
            {
                if (d.ProductId == productId)
                {
                    MessageHelper.ShowWarning("المنتج مضاف مسبقاً");
                    return;
                }
            }

            var detail = new StockMovementDetail
            {
                ProductId = productId,
                ProductName = product.Name,
                ProductCode = product.Code,
                Quantity = numQuantity.Value
            };

            _details.Add(detail);

            cmbProduct.SelectedIndex = 0;
            numQuantity.Value = 1;
            cmbProduct.Focus();

            UpdateTotal();
        }

        private void btnRemoveDetail_Click(object sender, EventArgs e)
        {
            if (dgvDetails.CurrentRow == null)
            {
                MessageHelper.ShowSelectItem();
                return;
            }

            if (!MessageHelper.Confirm("هل تريد حذف هذا الصنف؟"))
                return;

            var detail = dgvDetails.CurrentRow.DataBoundItem as StockMovementDetail;

            if (detail != null)
            {
                _details.Remove(detail);
                UpdateTotal();
            }
        }

        private void UpdateTotal()
        {
            lblTotal.Text = $"عدد الأصناف: {_details.Count}";
        }

        // ============================================
        // حفظ الحركة
        // ============================================

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbType.SelectedIndex < 0)
            {
                MessageHelper.ShowWarning("يجب اختيار نوع الحركة");
                return;
            }

            if (_details.Count == 0)
            {
                MessageHelper.ShowWarning("يجب إضافة منتج واحد على الأقل");
                return;
            }

            _movement.FromWarehouseId = ComboHelper.GetSelectedIdNullable(cmbFromWarehouse);
            _movement.ToWarehouseId = ComboHelper.GetSelectedIdNullable(cmbToWarehouse);

            int partnerId = ComboHelper.GetSelectedId(cmbPartner);
            _movement.PartnerId = partnerId > 0 ? (int?)partnerId : null;

            _movement.Reference = txtReference.Text.Trim();
            _movement.Notes = txtNotes.Text.Trim();

            if (_movement.Type == "IN" && !_movement.ToWarehouseId.HasValue)
            {
                MessageHelper.ShowWarning("يجب اختيار المستودع الهدف");
                return;
            }

            if (_movement.Type == "OUT" && !_movement.FromWarehouseId.HasValue)
            {
                MessageHelper.ShowWarning("يجب اختيار المستودع المصدر");
                return;
            }

            if (_movement.Type == "TRANSFER")
            {
                if (!_movement.FromWarehouseId.HasValue || !_movement.ToWarehouseId.HasValue)
                {
                    MessageHelper.ShowWarning("يجب اختيار المستودع المصدر والهدف");
                    return;
                }

                if (_movement.FromWarehouseId == _movement.ToWarehouseId)
                {
                    MessageHelper.ShowWarning("لا يمكن التحويل لنفس المستودع");
                    return;
                }
            }

            if (_movement.Type == "ADJUST" && !_movement.ToWarehouseId.HasValue)
            {
                MessageHelper.ShowWarning("يجب اختيار المستودع");
                return;
            }

            _movement.Details = new List<StockMovementDetail>(_details);

            string error;
            if (_movementBLL.Add(_movement, out error))
            {
                LogHelper.LogInfo($"حفظ حركة جديدة - النوع: {_movement.Type}");
                MessageHelper.ShowSuccess("تم حفظ الحركة بنجاح ✅");

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
            if (_details.Count > 0)
            {
                if (!MessageHelper.Confirm("هل تريد إلغاء الحركة؟"))
                    return;
            }

            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}