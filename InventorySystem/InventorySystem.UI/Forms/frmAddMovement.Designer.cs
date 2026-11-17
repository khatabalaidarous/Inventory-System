namespace InventorySystem.UI.Forms
{
    partial class frmAddMovement
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
            this.pnlTop = new System.Windows.Forms.Panel();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.txtReference = new System.Windows.Forms.TextBox();
            this.lblReference = new System.Windows.Forms.Label();
            this.cmbPartner = new System.Windows.Forms.ComboBox();
            this.lblPartner = new System.Windows.Forms.Label();
            this.cmbToWarehouse = new System.Windows.Forms.ComboBox();
            this.lblToWarehouse = new System.Windows.Forms.Label();
            this.cmbFromWarehouse = new System.Windows.Forms.ComboBox();
            this.lblFromWarehouse = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.lblType = new System.Windows.Forms.Label();
            this.pnlDetails = new System.Windows.Forms.Panel();
            this.dgvDetails = new System.Windows.Forms.DataGridView();
            this.pnlAddDetail = new System.Windows.Forms.Panel();
            this.btnRemoveDetail = new System.Windows.Forms.Button();
            this.btnAddDetail = new System.Windows.Forms.Button();
            this.numQuantity = new System.Windows.Forms.NumericUpDown();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.cmbProduct = new System.Windows.Forms.ComboBox();
            this.lblProduct = new System.Windows.Forms.Label();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.pnlDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).BeginInit();
            this.pnlAddDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            this.pnlFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1167, 80);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Padding = new System.Windows.Forms.Padding(23, 0, 0, 0);
            this.lblTitle.Size = new System.Drawing.Size(1167, 80);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "➕ إضافة حركة جديدة";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.White;
            this.pnlTop.Controls.Add(this.txtNotes);
            this.pnlTop.Controls.Add(this.lblNotes);
            this.pnlTop.Controls.Add(this.txtReference);
            this.pnlTop.Controls.Add(this.lblReference);
            this.pnlTop.Controls.Add(this.cmbPartner);
            this.pnlTop.Controls.Add(this.lblPartner);
            this.pnlTop.Controls.Add(this.cmbToWarehouse);
            this.pnlTop.Controls.Add(this.lblToWarehouse);
            this.pnlTop.Controls.Add(this.cmbFromWarehouse);
            this.pnlTop.Controls.Add(this.lblFromWarehouse);
            this.pnlTop.Controls.Add(this.cmbType);
            this.pnlTop.Controls.Add(this.lblType);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 80);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Padding = new System.Windows.Forms.Padding(23, 25, 23, 25);
            this.pnlTop.Size = new System.Drawing.Size(1167, 222);
            this.pnlTop.TabIndex = 1;
            // 
            // txtNotes
            // 
            this.txtNotes.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtNotes.Location = new System.Drawing.Point(23, 166);
            this.txtNotes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(1119, 34);
            this.txtNotes.TabIndex = 11;
            // 
            // lblNotes
            // 
            this.lblNotes.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblNotes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblNotes.Location = new System.Drawing.Point(23, 135);
            this.lblNotes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(1120, 31);
            this.lblNotes.TabIndex = 10;
            this.lblNotes.Text = "📝  ملاحظات:";
            this.lblNotes.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtReference
            // 
            this.txtReference.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtReference.Location = new System.Drawing.Point(595, 98);
            this.txtReference.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtReference.Name = "txtReference";
            this.txtReference.Size = new System.Drawing.Size(548, 34);
            this.txtReference.TabIndex = 9;
            // 
            // lblReference
            // 
            this.lblReference.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblReference.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblReference.Location = new System.Drawing.Point(595, 68);
            this.lblReference.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReference.Name = "lblReference";
            this.lblReference.Size = new System.Drawing.Size(548, 31);
            this.lblReference.TabIndex = 8;
            this.lblReference.Text = "🔖  المرجع:";
            this.lblReference.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // cmbPartner
            // 
            this.cmbPartner.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPartner.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmbPartner.FormattingEnabled = true;
            this.cmbPartner.Location = new System.Drawing.Point(23, 98);
            this.cmbPartner.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbPartner.Name = "cmbPartner";
            this.cmbPartner.Size = new System.Drawing.Size(559, 36);
            this.cmbPartner.TabIndex = 7;
            // 
            // lblPartner
            // 
            this.lblPartner.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblPartner.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblPartner.Location = new System.Drawing.Point(23, 68);
            this.lblPartner.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPartner.Name = "lblPartner";
            this.lblPartner.Size = new System.Drawing.Size(560, 31);
            this.lblPartner.TabIndex = 6;
            this.lblPartner.Text = "🤝  الشريك:";
            this.lblPartner.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // cmbToWarehouse
            // 
            this.cmbToWarehouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbToWarehouse.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmbToWarehouse.FormattingEnabled = true;
            this.cmbToWarehouse.Location = new System.Drawing.Point(793, 25);
            this.cmbToWarehouse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbToWarehouse.Name = "cmbToWarehouse";
            this.cmbToWarehouse.Size = new System.Drawing.Size(349, 36);
            this.cmbToWarehouse.TabIndex = 5;
            // 
            // lblToWarehouse
            // 
            this.lblToWarehouse.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblToWarehouse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblToWarehouse.Location = new System.Drawing.Point(793, -6);
            this.lblToWarehouse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblToWarehouse.Name = "lblToWarehouse";
            this.lblToWarehouse.Size = new System.Drawing.Size(350, 31);
            this.lblToWarehouse.TabIndex = 4;
            this.lblToWarehouse.Text = "🏪  إلى مستودع:";
            this.lblToWarehouse.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // cmbFromWarehouse
            // 
            this.cmbFromWarehouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFromWarehouse.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmbFromWarehouse.FormattingEnabled = true;
            this.cmbFromWarehouse.Location = new System.Drawing.Point(420, 25);
            this.cmbFromWarehouse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbFromWarehouse.Name = "cmbFromWarehouse";
            this.cmbFromWarehouse.Size = new System.Drawing.Size(349, 36);
            this.cmbFromWarehouse.TabIndex = 3;
            // 
            // lblFromWarehouse
            // 
            this.lblFromWarehouse.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblFromWarehouse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblFromWarehouse.Location = new System.Drawing.Point(420, -6);
            this.lblFromWarehouse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFromWarehouse.Name = "lblFromWarehouse";
            this.lblFromWarehouse.Size = new System.Drawing.Size(350, 31);
            this.lblFromWarehouse.TabIndex = 2;
            this.lblFromWarehouse.Text = "🏪  من مستودع:";
            this.lblFromWarehouse.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // cmbType
            // 
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(23, 25);
            this.cmbType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(373, 36);
            this.cmbType.TabIndex = 1;
            this.cmbType.SelectedIndexChanged += new System.EventHandler(this.cmbType_SelectedIndexChanged);
            // 
            // lblType
            // 
            this.lblType.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblType.Location = new System.Drawing.Point(23, -6);
            this.lblType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(373, 31);
            this.lblType.TabIndex = 0;
            this.lblType.Text = "🎯  نوع الحركة: *";
            this.lblType.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // pnlDetails
            // 
            this.pnlDetails.Controls.Add(this.dgvDetails);
            this.pnlDetails.Controls.Add(this.pnlAddDetail);
            this.pnlDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDetails.Location = new System.Drawing.Point(0, 302);
            this.pnlDetails.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlDetails.Name = "pnlDetails";
            this.pnlDetails.Padding = new System.Windows.Forms.Padding(23, 25, 23, 25);
            this.pnlDetails.Size = new System.Drawing.Size(1167, 437);
            this.pnlDetails.TabIndex = 2;
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
            this.dgvDetails.Location = new System.Drawing.Point(23, 123);
            this.dgvDetails.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvDetails.MultiSelect = false;
            this.dgvDetails.Name = "dgvDetails";
            this.dgvDetails.ReadOnly = true;
            this.dgvDetails.RowHeadersVisible = false;
            this.dgvDetails.RowHeadersWidth = 51;
            this.dgvDetails.RowTemplate.Height = 40;
            this.dgvDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetails.Size = new System.Drawing.Size(1121, 289);
            this.dgvDetails.TabIndex = 0;
            // 
            // pnlAddDetail
            // 
            this.pnlAddDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.pnlAddDetail.Controls.Add(this.btnRemoveDetail);
            this.pnlAddDetail.Controls.Add(this.btnAddDetail);
            this.pnlAddDetail.Controls.Add(this.numQuantity);
            this.pnlAddDetail.Controls.Add(this.lblQuantity);
            this.pnlAddDetail.Controls.Add(this.cmbProduct);
            this.pnlAddDetail.Controls.Add(this.lblProduct);
            this.pnlAddDetail.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAddDetail.Location = new System.Drawing.Point(23, 25);
            this.pnlAddDetail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlAddDetail.Name = "pnlAddDetail";
            this.pnlAddDetail.Size = new System.Drawing.Size(1121, 98);
            this.pnlAddDetail.TabIndex = 1;
            // 
            // btnRemoveDetail
            // 
            this.btnRemoveDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnRemoveDetail.FlatAppearance.BorderSize = 0;
            this.btnRemoveDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveDetail.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnRemoveDetail.ForeColor = System.Drawing.Color.White;
            this.btnRemoveDetail.Location = new System.Drawing.Point(12, 25);
            this.btnRemoveDetail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRemoveDetail.Name = "btnRemoveDetail";
            this.btnRemoveDetail.Size = new System.Drawing.Size(140, 55);
            this.btnRemoveDetail.TabIndex = 5;
            this.btnRemoveDetail.Text = "🗑️ حذف";
            this.btnRemoveDetail.UseVisualStyleBackColor = false;
            this.btnRemoveDetail.Click += new System.EventHandler(this.btnRemoveDetail_Click);
            // 
            // btnAddDetail
            // 
            this.btnAddDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnAddDetail.FlatAppearance.BorderSize = 0;
            this.btnAddDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDetail.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnAddDetail.ForeColor = System.Drawing.Color.White;
            this.btnAddDetail.Location = new System.Drawing.Point(163, 25);
            this.btnAddDetail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddDetail.Name = "btnAddDetail";
            this.btnAddDetail.Size = new System.Drawing.Size(140, 55);
            this.btnAddDetail.TabIndex = 4;
            this.btnAddDetail.Text = "➕ إضافة";
            this.btnAddDetail.UseVisualStyleBackColor = false;
            this.btnAddDetail.Click += new System.EventHandler(this.btnAddDetail_Click);
            // 
            // numQuantity
            // 
            this.numQuantity.DecimalPlaces = 2;
            this.numQuantity.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.numQuantity.Location = new System.Drawing.Point(327, 34);
            this.numQuantity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numQuantity.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numQuantity.Name = "numQuantity";
            this.numQuantity.Size = new System.Drawing.Size(152, 34);
            this.numQuantity.TabIndex = 3;
            this.numQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblQuantity
            // 
            this.lblQuantity.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblQuantity.Location = new System.Drawing.Point(327, 0);
            this.lblQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(152, 31);
            this.lblQuantity.TabIndex = 2;
            this.lblQuantity.Text = "🔢  الكمية:";
            this.lblQuantity.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // cmbProduct
            // 
            this.cmbProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProduct.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmbProduct.FormattingEnabled = true;
            this.cmbProduct.Location = new System.Drawing.Point(502, 34);
            this.cmbProduct.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbProduct.Name = "cmbProduct";
            this.cmbProduct.Size = new System.Drawing.Size(606, 36);
            this.cmbProduct.TabIndex = 1;
            // 
            // lblProduct
            // 
            this.lblProduct.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblProduct.Location = new System.Drawing.Point(502, 0);
            this.lblProduct.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(607, 31);
            this.lblProduct.TabIndex = 0;
            this.lblProduct.Text = "📦  المنتج:";
            this.lblProduct.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // pnlFooter
            // 
            this.pnlFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.pnlFooter.Controls.Add(this.lblTotal);
            this.pnlFooter.Controls.Add(this.btnCancel);
            this.pnlFooter.Controls.Add(this.btnSave);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 739);
            this.pnlFooter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(1167, 98);
            this.pnlFooter.TabIndex = 3;
            // 
            // lblTotal
            // 
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblTotal.Location = new System.Drawing.Point(467, 25);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(677, 55);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "عدد الأصناف: 0";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(23, 22);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(198, 62);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "❌ إلغاء";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(233, 22);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(210, 62);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "💾 حفظ الحركة";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmAddMovement
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(1167, 837);
            this.Controls.Add(this.pnlDetails);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddMovement";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "حركة جديدة";
            this.Load += new System.EventHandler(this.frmAddMovement_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).EndInit();
            this.pnlAddDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            this.pnlFooter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label lblFromWarehouse;
        private System.Windows.Forms.ComboBox cmbFromWarehouse;
        private System.Windows.Forms.Label lblToWarehouse;
        private System.Windows.Forms.ComboBox cmbToWarehouse;
        private System.Windows.Forms.Label lblPartner;
        private System.Windows.Forms.ComboBox cmbPartner;
        private System.Windows.Forms.Label lblReference;
        private System.Windows.Forms.TextBox txtReference;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Panel pnlDetails;
        private System.Windows.Forms.DataGridView dgvDetails;
        private System.Windows.Forms.Panel pnlAddDetail;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.ComboBox cmbProduct;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.NumericUpDown numQuantity;
        private System.Windows.Forms.Button btnAddDetail;
        private System.Windows.Forms.Button btnRemoveDetail;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblTotal;
    }
}