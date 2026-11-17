using InventorySystem.UI.Business;
using InventorySystem.UI.Helpers;
using InventorySystem.UI.Models.Entities;
using System;
using System.Data;
using System.Windows.Forms;

namespace InventorySystem.UI.Forms
{
    public partial class frmReports : Form
    {
        private readonly InventoryBLL _inventoryBLL;
        private readonly ProductBLL _productBLL;
        private readonly StockMovementBLL _movementBLL;
        private readonly BatchBLL _batchBLL;

        public frmReports()
        {
            InitializeComponent();
            _inventoryBLL = new InventoryBLL();
            _productBLL = new ProductBLL();
            _movementBLL = new StockMovementBLL();
            _batchBLL = new BatchBLL();
            GridHelper.StyleGrid(dgvReport);
        }

        private void frmReports_Load(object sender, EventArgs e)
        {
            LoadReportTypes();
        }

        private void LoadReportTypes()
        {
            cmbReport.Items.Clear();
            cmbReport.Items.Add("المخزون الحالي");
            cmbReport.Items.Add("المنتجات تحت الحد الأدنى");
            cmbReport.Items.Add("حركات المخزون");
            cmbReport.Items.Add("الدفعات القريبة من الانتهاء");
            cmbReport.Items.Add("الدفعات المنتهية");
            cmbReport.SelectedIndex = 0;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                string error=null;

                switch (cmbReport.SelectedIndex)
                {
                    case 0: // المخزون الحالي
                        var inventory = _inventoryBLL.GetAll(out error);
                        dgvReport.DataSource = null;
                        dgvReport.DataSource = inventory;
                        FormatInventoryGrid();
                        break;

                    case 1: // المنتجات تحت الحد الأدنى
                        var belowMin = _productBLL.GetBelowMinStock(out error);
                        dgvReport.DataSource = null;
                        dgvReport.DataSource = belowMin;
                        FormatProductsGrid();
                        break;

                    case 2: // الحركات
                        var movements = _movementBLL.GetAll(out error);
                        dgvReport.DataSource = null;
                        dgvReport.DataSource = movements;
                        FormatMovementsGrid();
                        break;

                    case 3: // الدفعات القريبة من الانتهاء
                        var expiring = _batchBLL.GetExpiringSoon(out error);
                        dgvReport.DataSource = null;
                        dgvReport.DataSource = expiring;
                        FormatBatchesGrid();
                        break;

                    case 4: // الدفعات المنتهية
                        var expired = _batchBLL.GetExpired(out error);
                        dgvReport.DataSource = null;
                        dgvReport.DataSource = expired;
                        FormatBatchesGrid();
                        break;

                }
                        if (!string.IsNullOrEmpty(error))
                            MessageHelper.ShowError(error);
                
            }
            catch (Exception ex)
            {
                LogHelper.LogError(ex, "frmReports.btnShow_Click");
                MessageHelper.ShowException(ex);
            }
        }

        private void FormatInventoryGrid()
        {
            GridHelper.HideColumns(dgvReport,
                "InventoryId", "ProductId", "WarehouseId", "ReservedQty", "LastUpdated");
            GridHelper.SetColumnHeader(dgvReport, "ProductCode", "الكود");
            GridHelper.SetColumnHeader(dgvReport, "ProductName", "المنتج");
            GridHelper.SetColumnHeader(dgvReport, "WarehouseName", "المستودع");
            GridHelper.SetColumnHeader(dgvReport, "Quantity", "الكمية");
            GridHelper.SetColumnHeader(dgvReport, "AvailableQuantity", "المتاح");
        }

        private void FormatProductsGrid()
        {
            GridHelper.HideColumns(dgvReport,
                "ProductId", "CategoryId", "UnitId", "MaxStock", "IsActive", "CreatedAt");
            GridHelper.SetColumnHeader(dgvReport, "Code", "الكود");
            GridHelper.SetColumnHeader(dgvReport, "Name", "المنتج");
            GridHelper.SetColumnHeader(dgvReport, "CategoryName", "التصنيف");
            GridHelper.SetColumnHeader(dgvReport, "UnitName", "الوحدة");
            GridHelper.SetColumnHeader(dgvReport, "MinStock", "الحد الأدنى");
            GridHelper.SetColumnHeader(dgvReport, "CurrentStock", "الرصيد");
        }

        private void FormatMovementsGrid()
        {
            GridHelper.HideColumns(dgvReport,
                "MovementId", "Type", "UserId", "FromWarehouseId", "ToWarehouseId", "PartnerId", "Details");
            GridHelper.SetColumnHeader(dgvReport, "MovementDate", "التاريخ");
            GridHelper.SetColumnHeader(dgvReport, "TypeName", "النوع");
            GridHelper.SetColumnHeader(dgvReport, "FromWarehouseName", "من");
            GridHelper.SetColumnHeader(dgvReport, "ToWarehouseName", "إلى");
            GridHelper.SetColumnHeader(dgvReport, "PartnerName", "الشريك");
            GridHelper.SetColumnHeader(dgvReport, "UserName", "المستخدم");
            GridHelper.FormatAsDateTime(dgvReport, "MovementDate");
        }

        private void FormatBatchesGrid()
        {
            GridHelper.HideColumns(dgvReport, "BatchId", "ProductId", "CreatedAt");
            GridHelper.SetColumnHeader(dgvReport, "ProductName", "المنتج");
            GridHelper.SetColumnHeader(dgvReport, "BatchNumber", "رقم الدفعة");
            GridHelper.SetColumnHeader(dgvReport, "ProductionDate", "الإنتاج");
            GridHelper.SetColumnHeader(dgvReport, "ExpiryDate", "الانتهاء");
            GridHelper.FormatAsDate(dgvReport, "ProductionDate");
            GridHelper.FormatAsDate(dgvReport, "ExpiryDate");
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (dgvReport.Rows.Count == 0)
            {
                MessageHelper.ShowWarning("لا توجد بيانات للتصدير");
                return;
            }

            ExportHelper.ExportToExcel(dgvReport, $"Report_{cmbReport.Text}");
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (dgvReport.Rows.Count == 0)
            {
                MessageHelper.ShowWarning("لا توجد بيانات للطباعة");
                return;
            }

            ExportHelper.PrintGrid(dgvReport, cmbReport.Text);
        }
    }
}