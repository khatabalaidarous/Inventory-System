using InventorySystem.UI.Helpers;
using InventorySystem.UI.Models.Entities;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace InventorySystem.UI.Forms
{
    public partial class frmMovementDetails : Form
    {
        private readonly StockMovement _movement;

        public frmMovementDetails(StockMovement movement)
        {
            InitializeComponent();
            _movement = movement;
            StyleGrid();
        }

        private void StyleGrid()
        {
            dgvDetails.BackgroundColor = Color.White;
            dgvDetails.GridColor = Color.FromArgb(200, 200, 200);
            dgvDetails.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(41, 128, 185);
            dgvDetails.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvDetails.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dgvDetails.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDetails.EnableHeadersVisualStyles = false;
            dgvDetails.DefaultCellStyle.Font = new Font("Segoe UI", 12F);
            dgvDetails.DefaultCellStyle.ForeColor = Color.FromArgb(52, 73, 94);
            dgvDetails.DefaultCellStyle.SelectionBackColor = Color.FromArgb(52, 152, 219);
            dgvDetails.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvDetails.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDetails.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);
            dgvDetails.RightToLeft = RightToLeft.Yes;
        }

        private void frmMovementDetails_Load(object sender, EventArgs e)
        {
            LoadInfo();
            LoadDetails();
        }

        private void LoadInfo()
        {
            // نوع الحركة (في الأعلى)
            lblTypeValue.Text = $"🎯  {_movement.TypeName}";

            // معلومات الحركة
            lblTypeValue2.Text = _movement.TypeName ?? "-";
            lblDateValue.Text = _movement.MovementDate.ToString("dd/MM/yyyy HH:mm");
            lblUserValue.Text = _movement.UserName ?? "-";
            lblReferenceValue.Text = _movement.Reference ?? "-";

            // معلومات المستودع
            lblFromValue.Text = _movement.FromWarehouseName ?? "-";
            lblToValue.Text = _movement.ToWarehouseName ?? "-";
            lblPartnerValue.Text = _movement.PartnerName ?? "-";

            // الملاحظات
            lblNotesValue.Text = string.IsNullOrEmpty(_movement.Notes)
                ? "لا توجد ملاحظات"
                : _movement.Notes;
        }

        private void LoadDetails()
        {
            dgvDetails.DataSource = null;
            dgvDetails.DataSource = _movement.Details;

            if (dgvDetails.Columns.Count > 0)
            {
                GridHelper.HideColumns(dgvDetails,
                    "DetailId", "MovementId", "ProductId", "BatchId");

                GridHelper.SetColumnHeader(dgvDetails, "ProductCode", "🔖 الكود");
                GridHelper.SetColumnHeader(dgvDetails, "ProductName", "📦 المنتج");
                GridHelper.SetColumnHeader(dgvDetails, "BatchNumber", "🏷️ الدفعة");
                GridHelper.SetColumnHeader(dgvDetails, "Quantity", "📊 الكمية");
                GridHelper.SetColumnHeader(dgvDetails, "UnitPrice", "💰 السعر");
                GridHelper.SetColumnHeader(dgvDetails, "Total", "💵 الإجمالي");

                GridHelper.FormatAsCurrency(dgvDetails, "UnitPrice");
                GridHelper.FormatAsCurrency(dgvDetails, "Total");
                GridHelper.FormatAsCurrency(dgvDetails, "Quantity");
            }

            // الإحصائيات
            decimal totalQty = 0;
            decimal totalValue = 0;
            int totalItems = _movement.Details?.Count ?? 0;

            if (_movement.Details != null)
            {
                foreach (var d in _movement.Details)
                {
                    totalQty += d.Quantity;
                    totalValue += d.Total;
                }
            }

            lblTotalItems.Text = $"📦 عدد الأصناف: {totalItems}";
            lblTotalQty.Text = $"📊 إجمالي الكميات: {totalQty:N2}";
            lblTotalValue.Text = $"💰 القيمة الإجمالية: {totalValue:N2}";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}