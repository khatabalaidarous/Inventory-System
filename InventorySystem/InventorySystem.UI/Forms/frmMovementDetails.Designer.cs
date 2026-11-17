namespace InventorySystem.UI.Forms
{
    partial class frmMovementDetails
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlMovementType = new System.Windows.Forms.Panel();
            this.lblTypeValue = new System.Windows.Forms.Label();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.grpNotes = new System.Windows.Forms.GroupBox();
            this.lblNotesValue = new System.Windows.Forms.Label();
            this.grpWarehouseInfo = new System.Windows.Forms.GroupBox();
            this.lblPartnerValue = new System.Windows.Forms.Label();
            this.lblPartnerLabel = new System.Windows.Forms.Label();
            this.lblToValue = new System.Windows.Forms.Label();
            this.lblToLabel = new System.Windows.Forms.Label();
            this.lblFromValue = new System.Windows.Forms.Label();
            this.lblFromLabel = new System.Windows.Forms.Label();
            this.grpMovementInfo = new System.Windows.Forms.GroupBox();
            this.lblReferenceValue = new System.Windows.Forms.Label();
            this.lblReferenceLabel = new System.Windows.Forms.Label();
            this.lblUserValue = new System.Windows.Forms.Label();
            this.lblUserLabel = new System.Windows.Forms.Label();
            this.lblDateValue = new System.Windows.Forms.Label();
            this.lblDateLabel = new System.Windows.Forms.Label();
            this.lblTypeValue2 = new System.Windows.Forms.Label();
            this.lblTypeLabel2 = new System.Windows.Forms.Label();
            this.pnlDetails = new System.Windows.Forms.Panel();
            this.grpDetails = new System.Windows.Forms.GroupBox();
            this.dgvDetails = new System.Windows.Forms.DataGridView();
            this.pnlStats = new System.Windows.Forms.Panel();
            this.lblTotalValue = new System.Windows.Forms.Label();
            this.lblTotalQty = new System.Windows.Forms.Label();
            this.lblTotalItems = new System.Windows.Forms.Label();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.pnlMovementType.SuspendLayout();
            this.pnlInfo.SuspendLayout();
            this.grpNotes.SuspendLayout();
            this.grpWarehouseInfo.SuspendLayout();
            this.grpMovementInfo.SuspendLayout();
            this.pnlDetails.SuspendLayout();
            this.grpDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).BeginInit();
            this.pnlStats.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1175, 86);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Padding = new System.Windows.Forms.Padding(23, 0, 0, 0);
            this.lblTitle.Size = new System.Drawing.Size(1175, 86);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "👁️ تفاصيل الحركة";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlMovementType
            // 
            this.pnlMovementType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.pnlMovementType.Controls.Add(this.lblTypeValue);
            this.pnlMovementType.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMovementType.Location = new System.Drawing.Point(0, 86);
            this.pnlMovementType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlMovementType.Name = "pnlMovementType";
            this.pnlMovementType.Size = new System.Drawing.Size(1175, 68);
            this.pnlMovementType.TabIndex = 1;
            // 
            // lblTypeValue
            // 
            this.lblTypeValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTypeValue.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTypeValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.lblTypeValue.Location = new System.Drawing.Point(0, 0);
            this.lblTypeValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTypeValue.Name = "lblTypeValue";
            this.lblTypeValue.Padding = new System.Windows.Forms.Padding(23, 0, 23, 0);
            this.lblTypeValue.Size = new System.Drawing.Size(1175, 68);
            this.lblTypeValue.TabIndex = 0;
            this.lblTypeValue.Text = "🎯 نوع الحركة";
            this.lblTypeValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlInfo
            // 
            this.pnlInfo.BackColor = System.Drawing.Color.White;
            this.pnlInfo.Controls.Add(this.grpNotes);
            this.pnlInfo.Controls.Add(this.grpWarehouseInfo);
            this.pnlInfo.Controls.Add(this.grpMovementInfo);
            this.pnlInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlInfo.Location = new System.Drawing.Point(0, 154);
            this.pnlInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Padding = new System.Windows.Forms.Padding(18, 18, 18, 18);
            this.pnlInfo.Size = new System.Drawing.Size(1175, 295);
            this.pnlInfo.TabIndex = 2;
            // 
            // grpNotes
            // 
            this.grpNotes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.grpNotes.Controls.Add(this.lblNotesValue);
            this.grpNotes.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.grpNotes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.grpNotes.Location = new System.Drawing.Point(18, 203);
            this.grpNotes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpNotes.Name = "grpNotes";
            this.grpNotes.Padding = new System.Windows.Forms.Padding(12, 12, 12, 12);
            this.grpNotes.Size = new System.Drawing.Size(1132, 80);
            this.grpNotes.TabIndex = 2;
            this.grpNotes.TabStop = false;
            this.grpNotes.Text = "📝  الملاحظات";
            // 
            // lblNotesValue
            // 
            this.lblNotesValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNotesValue.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblNotesValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblNotesValue.Location = new System.Drawing.Point(12, 37);
            this.lblNotesValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNotesValue.Name = "lblNotesValue";
            this.lblNotesValue.Size = new System.Drawing.Size(1108, 31);
            this.lblNotesValue.TabIndex = 0;
            this.lblNotesValue.Text = "-";
            this.lblNotesValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // grpWarehouseInfo
            // 
            this.grpWarehouseInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.grpWarehouseInfo.Controls.Add(this.lblPartnerValue);
            this.grpWarehouseInfo.Controls.Add(this.lblToValue);
            this.grpWarehouseInfo.Controls.Add(this.lblPartnerLabel);
            this.grpWarehouseInfo.Controls.Add(this.lblToLabel);
            this.grpWarehouseInfo.Controls.Add(this.lblFromValue);
            this.grpWarehouseInfo.Controls.Add(this.lblFromLabel);
            this.grpWarehouseInfo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.grpWarehouseInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.grpWarehouseInfo.Location = new System.Drawing.Point(589, 18);
            this.grpWarehouseInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpWarehouseInfo.Name = "grpWarehouseInfo";
            this.grpWarehouseInfo.Padding = new System.Windows.Forms.Padding(12, 12, 12, 12);
            this.grpWarehouseInfo.Size = new System.Drawing.Size(560, 178);
            this.grpWarehouseInfo.TabIndex = 1;
            this.grpWarehouseInfo.TabStop = false;
            this.grpWarehouseInfo.Text = "🏪  معلومات المستودع";
            // 
            // lblPartnerValue
            // 
            this.lblPartnerValue.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblPartnerValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblPartnerValue.Location = new System.Drawing.Point(0, 111);
            this.lblPartnerValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPartnerValue.Name = "lblPartnerValue";
            this.lblPartnerValue.Size = new System.Drawing.Size(356, 31);
            this.lblPartnerValue.TabIndex = 5;
            this.lblPartnerValue.Text = "-";
            this.lblPartnerValue.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblPartnerLabel
            // 
            this.lblPartnerLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblPartnerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblPartnerLabel.Location = new System.Drawing.Point(381, 111);
            this.lblPartnerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPartnerLabel.Name = "lblPartnerLabel";
            this.lblPartnerLabel.Size = new System.Drawing.Size(163, 31);
            this.lblPartnerLabel.TabIndex = 4;
            this.lblPartnerLabel.Text = "🤝  الشريك:";
            this.lblPartnerLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblToValue
            // 
            this.lblToValue.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblToValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblToValue.Location = new System.Drawing.Point(0, 74);
            this.lblToValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblToValue.Name = "lblToValue";
            this.lblToValue.Size = new System.Drawing.Size(356, 31);
            this.lblToValue.TabIndex = 3;
            this.lblToValue.Text = "-";
            this.lblToValue.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblToLabel
            // 
            this.lblToLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblToLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblToLabel.Location = new System.Drawing.Point(386, 72);
            this.lblToLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblToLabel.Name = "lblToLabel";
            this.lblToLabel.Size = new System.Drawing.Size(163, 31);
            this.lblToLabel.TabIndex = 2;
            this.lblToLabel.Text = "🏪  إلى مستودع:";
            this.lblToLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblFromValue
            // 
            this.lblFromValue.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblFromValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblFromValue.Location = new System.Drawing.Point(0, 37);
            this.lblFromValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFromValue.Name = "lblFromValue";
            this.lblFromValue.Size = new System.Drawing.Size(356, 31);
            this.lblFromValue.TabIndex = 1;
            this.lblFromValue.Text = "-";
            this.lblFromValue.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblFromLabel
            // 
            this.lblFromLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblFromLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblFromLabel.Location = new System.Drawing.Point(386, 37);
            this.lblFromLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFromLabel.Name = "lblFromLabel";
            this.lblFromLabel.Size = new System.Drawing.Size(163, 31);
            this.lblFromLabel.TabIndex = 0;
            this.lblFromLabel.Text = "🏪  من مستودع:";
            this.lblFromLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // grpMovementInfo
            // 
            this.grpMovementInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.grpMovementInfo.Controls.Add(this.lblReferenceValue);
            this.grpMovementInfo.Controls.Add(this.lblReferenceLabel);
            this.grpMovementInfo.Controls.Add(this.lblUserValue);
            this.grpMovementInfo.Controls.Add(this.lblDateValue);
            this.grpMovementInfo.Controls.Add(this.lblTypeValue2);
            this.grpMovementInfo.Controls.Add(this.lblUserLabel);
            this.grpMovementInfo.Controls.Add(this.lblDateLabel);
            this.grpMovementInfo.Controls.Add(this.lblTypeLabel2);
            this.grpMovementInfo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.grpMovementInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.grpMovementInfo.Location = new System.Drawing.Point(18, 18);
            this.grpMovementInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpMovementInfo.Name = "grpMovementInfo";
            this.grpMovementInfo.Padding = new System.Windows.Forms.Padding(12, 12, 12, 12);
            this.grpMovementInfo.Size = new System.Drawing.Size(560, 178);
            this.grpMovementInfo.TabIndex = 0;
            this.grpMovementInfo.TabStop = false;
            this.grpMovementInfo.Text = "📋  معلومات الحركة";
            // 
            // lblReferenceValue
            // 
            this.lblReferenceValue.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblReferenceValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblReferenceValue.Location = new System.Drawing.Point(16, 147);
            this.lblReferenceValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReferenceValue.Name = "lblReferenceValue";
            this.lblReferenceValue.Size = new System.Drawing.Size(356, 31);
            this.lblReferenceValue.TabIndex = 7;
            this.lblReferenceValue.Text = "-";
            this.lblReferenceValue.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblReferenceLabel
            // 
            this.lblReferenceLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblReferenceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblReferenceLabel.Location = new System.Drawing.Point(381, 142);
            this.lblReferenceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReferenceLabel.Name = "lblReferenceLabel";
            this.lblReferenceLabel.Size = new System.Drawing.Size(163, 31);
            this.lblReferenceLabel.TabIndex = 6;
            this.lblReferenceLabel.Text = "🔖  المرجع:";
            this.lblReferenceLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblUserValue
            // 
            this.lblUserValue.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblUserValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblUserValue.Location = new System.Drawing.Point(12, 111);
            this.lblUserValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserValue.Name = "lblUserValue";
            this.lblUserValue.Size = new System.Drawing.Size(356, 31);
            this.lblUserValue.TabIndex = 5;
            this.lblUserValue.Text = "-";
            this.lblUserValue.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblUserLabel
            // 
            this.lblUserLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblUserLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblUserLabel.Location = new System.Drawing.Point(381, 111);
            this.lblUserLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserLabel.Name = "lblUserLabel";
            this.lblUserLabel.Size = new System.Drawing.Size(163, 31);
            this.lblUserLabel.TabIndex = 4;
            this.lblUserLabel.Text = "👤  المستخدم:";
            this.lblUserLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblDateValue
            // 
            this.lblDateValue.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblDateValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblDateValue.Location = new System.Drawing.Point(12, 80);
            this.lblDateValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateValue.Name = "lblDateValue";
            this.lblDateValue.Size = new System.Drawing.Size(356, 31);
            this.lblDateValue.TabIndex = 3;
            this.lblDateValue.Text = "-";
            this.lblDateValue.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblDateLabel
            // 
            this.lblDateLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblDateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblDateLabel.Location = new System.Drawing.Point(381, 72);
            this.lblDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateLabel.Name = "lblDateLabel";
            this.lblDateLabel.Size = new System.Drawing.Size(163, 31);
            this.lblDateLabel.TabIndex = 2;
            this.lblDateLabel.Text = "📅  التاريخ:";
            this.lblDateLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblTypeValue2
            // 
            this.lblTypeValue2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTypeValue2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.lblTypeValue2.Location = new System.Drawing.Point(12, 37);
            this.lblTypeValue2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTypeValue2.Name = "lblTypeValue2";
            this.lblTypeValue2.Size = new System.Drawing.Size(356, 31);
            this.lblTypeValue2.TabIndex = 1;
            this.lblTypeValue2.Text = "-";
            this.lblTypeValue2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblTypeLabel2
            // 
            this.lblTypeLabel2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTypeLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblTypeLabel2.Location = new System.Drawing.Point(381, 37);
            this.lblTypeLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTypeLabel2.Name = "lblTypeLabel2";
            this.lblTypeLabel2.Size = new System.Drawing.Size(163, 31);
            this.lblTypeLabel2.TabIndex = 0;
            this.lblTypeLabel2.Text = "🎯  النوع:";
            this.lblTypeLabel2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // pnlDetails
            // 
            this.pnlDetails.BackColor = System.Drawing.Color.White;
            this.pnlDetails.Controls.Add(this.grpDetails);
            this.pnlDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDetails.Location = new System.Drawing.Point(0, 449);
            this.pnlDetails.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlDetails.Name = "pnlDetails";
            this.pnlDetails.Padding = new System.Windows.Forms.Padding(18, 18, 18, 18);
            this.pnlDetails.Size = new System.Drawing.Size(1175, 412);
            this.pnlDetails.TabIndex = 3;
            // 
            // grpDetails
            // 
            this.grpDetails.Controls.Add(this.dgvDetails);
            this.grpDetails.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.grpDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.grpDetails.Location = new System.Drawing.Point(18, 18);
            this.grpDetails.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpDetails.Name = "grpDetails";
            this.grpDetails.Padding = new System.Windows.Forms.Padding(12, 12, 12, 12);
            this.grpDetails.Size = new System.Drawing.Size(1132, 375);
            this.grpDetails.TabIndex = 0;
            this.grpDetails.TabStop = false;
            this.grpDetails.Text = "📦  الأصناف";
            // 
            // dgvDetails
            // 
            this.dgvDetails.AllowUserToAddRows = false;
            this.dgvDetails.AllowUserToDeleteRows = false;
            this.dgvDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetails.BackgroundColor = System.Drawing.Color.White;
            this.dgvDetails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDetails.ColumnHeadersHeight = 45;
            this.dgvDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDetails.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dgvDetails.Location = new System.Drawing.Point(12, 37);
            this.dgvDetails.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvDetails.MultiSelect = false;
            this.dgvDetails.Name = "dgvDetails";
            this.dgvDetails.ReadOnly = true;
            this.dgvDetails.RowHeadersVisible = false;
            this.dgvDetails.RowHeadersWidth = 51;
            this.dgvDetails.RowTemplate.Height = 40;
            this.dgvDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetails.Size = new System.Drawing.Size(1108, 326);
            this.dgvDetails.TabIndex = 0;
            // 
            // pnlStats
            // 
            this.pnlStats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.pnlStats.Controls.Add(this.lblTotalValue);
            this.pnlStats.Controls.Add(this.lblTotalQty);
            this.pnlStats.Controls.Add(this.lblTotalItems);
            this.pnlStats.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlStats.Location = new System.Drawing.Point(0, 861);
            this.pnlStats.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlStats.Name = "pnlStats";
            this.pnlStats.Size = new System.Drawing.Size(1175, 68);
            this.pnlStats.TabIndex = 4;
            // 
            // lblTotalValue
            // 
            this.lblTotalValue.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblTotalValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotalValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.lblTotalValue.Location = new System.Drawing.Point(787, 0);
            this.lblTotalValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalValue.Name = "lblTotalValue";
            this.lblTotalValue.Padding = new System.Windows.Forms.Padding(0, 0, 23, 0);
            this.lblTotalValue.Size = new System.Drawing.Size(388, 68);
            this.lblTotalValue.TabIndex = 2;
            this.lblTotalValue.Text = "💰 القيمة الإجمالية: 0";
            this.lblTotalValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalQty
            // 
            this.lblTotalQty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalQty.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotalQty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.lblTotalQty.Location = new System.Drawing.Point(388, 0);
            this.lblTotalQty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalQty.Name = "lblTotalQty";
            this.lblTotalQty.Size = new System.Drawing.Size(787, 68);
            this.lblTotalQty.TabIndex = 1;
            this.lblTotalQty.Text = "📊 إجمالي الكميات: 0";
            this.lblTotalQty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalItems
            // 
            this.lblTotalItems.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTotalItems.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotalItems.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblTotalItems.Location = new System.Drawing.Point(0, 0);
            this.lblTotalItems.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalItems.Name = "lblTotalItems";
            this.lblTotalItems.Padding = new System.Windows.Forms.Padding(23, 0, 0, 0);
            this.lblTotalItems.Size = new System.Drawing.Size(388, 68);
            this.lblTotalItems.TabIndex = 0;
            this.lblTotalItems.Text = "📦 عدد الأصناف: 0";
            this.lblTotalItems.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlFooter
            // 
            this.pnlFooter.BackColor = System.Drawing.Color.White;
            this.pnlFooter.Controls.Add(this.btnClose);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 929);
            this.pnlFooter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(1175, 80);
            this.pnlFooter.TabIndex = 5;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(467, 12);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(233, 55);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "❌ إغلاق";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmMovementDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(1175, 1009);
            this.Controls.Add(this.pnlDetails);
            this.Controls.Add(this.pnlStats);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.pnlInfo);
            this.Controls.Add(this.pnlMovementType);
            this.Controls.Add(this.pnlHeader);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmMovementDetails";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "تفاصيل الحركة";
            this.Load += new System.EventHandler(this.frmMovementDetails_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlMovementType.ResumeLayout(false);
            this.pnlInfo.ResumeLayout(false);
            this.grpNotes.ResumeLayout(false);
            this.grpWarehouseInfo.ResumeLayout(false);
            this.grpMovementInfo.ResumeLayout(false);
            this.pnlDetails.ResumeLayout(false);
            this.grpDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).EndInit();
            this.pnlStats.ResumeLayout(false);
            this.pnlFooter.ResumeLayout(false);
            this.ResumeLayout(false);

        }



        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlMovementType;
        private System.Windows.Forms.Label lblTypeValue;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.GroupBox grpMovementInfo;
        private System.Windows.Forms.Label lblTypeLabel2;
        private System.Windows.Forms.Label lblTypeValue2;
        private System.Windows.Forms.Label lblDateLabel;
        private System.Windows.Forms.Label lblDateValue;
        private System.Windows.Forms.Label lblUserLabel;
        private System.Windows.Forms.Label lblUserValue;
        private System.Windows.Forms.Label lblReferenceLabel;
        private System.Windows.Forms.Label lblReferenceValue;
        private System.Windows.Forms.GroupBox grpWarehouseInfo;
        private System.Windows.Forms.Label lblFromLabel;
        private System.Windows.Forms.Label lblFromValue;
        private System.Windows.Forms.Label lblToLabel;
        private System.Windows.Forms.Label lblToValue;
        private System.Windows.Forms.Label lblPartnerLabel;
        private System.Windows.Forms.Label lblPartnerValue;
        private System.Windows.Forms.GroupBox grpNotes;
        private System.Windows.Forms.Label lblNotesValue;
        private System.Windows.Forms.Panel pnlDetails;
        private System.Windows.Forms.GroupBox grpDetails;
        private System.Windows.Forms.DataGridView dgvDetails;
        private System.Windows.Forms.Panel pnlStats;
        private System.Windows.Forms.Label lblTotalItems;
        private System.Windows.Forms.Label lblTotalQty;
        private System.Windows.Forms.Label lblTotalValue;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Button btnClose;
    }
}