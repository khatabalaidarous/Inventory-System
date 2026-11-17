namespace InventorySystem.UI.Forms
{
    partial class frmProductEdit
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
            this.pnlBody = new System.Windows.Forms.Panel();
            this.chkIsActive = new System.Windows.Forms.CheckBox();
            this.numMaxStock = new System.Windows.Forms.NumericUpDown();
            this.lblMaxStock = new System.Windows.Forms.Label();
            this.numMinStock = new System.Windows.Forms.NumericUpDown();
            this.lblMinStock = new System.Windows.Forms.Label();
            this.cmbUnit = new System.Windows.Forms.ComboBox();
            this.lblUnit = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.lblCode = new System.Windows.Forms.Label();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.pnlBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinStock)).BeginInit();
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
            this.pnlHeader.Size = new System.Drawing.Size(758, 86);
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
            this.lblTitle.Size = new System.Drawing.Size(758, 86);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "إضافة منتج";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlBody
            // 
            this.pnlBody.AutoScroll = true;
            this.pnlBody.BackColor = System.Drawing.Color.White;
            this.pnlBody.Controls.Add(this.chkIsActive);
            this.pnlBody.Controls.Add(this.numMaxStock);
            this.pnlBody.Controls.Add(this.lblMaxStock);
            this.pnlBody.Controls.Add(this.numMinStock);
            this.pnlBody.Controls.Add(this.lblMinStock);
            this.pnlBody.Controls.Add(this.cmbUnit);
            this.pnlBody.Controls.Add(this.lblUnit);
            this.pnlBody.Controls.Add(this.cmbCategory);
            this.pnlBody.Controls.Add(this.lblCategory);
            this.pnlBody.Controls.Add(this.txtName);
            this.pnlBody.Controls.Add(this.lblName);
            this.pnlBody.Controls.Add(this.txtCode);
            this.pnlBody.Controls.Add(this.lblCode);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(0, 86);
            this.pnlBody.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Padding = new System.Windows.Forms.Padding(47, 49, 47, 49);
            this.pnlBody.Size = new System.Drawing.Size(758, 567);
            this.pnlBody.TabIndex = 1;
            // 
            // chkIsActive
            // 
            this.chkIsActive.Checked = true;
            this.chkIsActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIsActive.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.chkIsActive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.chkIsActive.Location = new System.Drawing.Point(37, 514);
            this.chkIsActive.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkIsActive.Name = "chkIsActive";
            this.chkIsActive.Size = new System.Drawing.Size(665, 37);
            this.chkIsActive.TabIndex = 12;
            this.chkIsActive.Text = "✅  مفعّل";
            this.chkIsActive.UseVisualStyleBackColor = true;
            // 
            // numMaxStock
            // 
            this.numMaxStock.DecimalPlaces = 2;
            this.numMaxStock.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.numMaxStock.Location = new System.Drawing.Point(42, 459);
            this.numMaxStock.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numMaxStock.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numMaxStock.Name = "numMaxStock";
            this.numMaxStock.Size = new System.Drawing.Size(665, 34);
            this.numMaxStock.TabIndex = 11;
            this.numMaxStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblMaxStock
            // 
            this.lblMaxStock.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblMaxStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblMaxStock.Location = new System.Drawing.Point(42, 422);
            this.lblMaxStock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaxStock.Name = "lblMaxStock";
            this.lblMaxStock.Size = new System.Drawing.Size(665, 31);
            this.lblMaxStock.TabIndex = 10;
            this.lblMaxStock.Text = "📈  الحد الأقصى للمخزون:";
            this.lblMaxStock.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // numMinStock
            // 
            this.numMinStock.DecimalPlaces = 2;
            this.numMinStock.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.numMinStock.Location = new System.Drawing.Point(42, 373);
            this.numMinStock.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numMinStock.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numMinStock.Name = "numMinStock";
            this.numMinStock.Size = new System.Drawing.Size(665, 34);
            this.numMinStock.TabIndex = 9;
            this.numMinStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblMinStock
            // 
            this.lblMinStock.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblMinStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblMinStock.Location = new System.Drawing.Point(42, 336);
            this.lblMinStock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMinStock.Name = "lblMinStock";
            this.lblMinStock.Size = new System.Drawing.Size(665, 31);
            this.lblMinStock.TabIndex = 8;
            this.lblMinStock.Text = "📉  الحد الأدنى للمخزون:";
            this.lblMinStock.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // cmbUnit
            // 
            this.cmbUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUnit.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmbUnit.FormattingEnabled = true;
            this.cmbUnit.Location = new System.Drawing.Point(42, 287);
            this.cmbUnit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbUnit.Name = "cmbUnit";
            this.cmbUnit.Size = new System.Drawing.Size(664, 36);
            this.cmbUnit.TabIndex = 7;
            // 
            // lblUnit
            // 
            this.lblUnit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblUnit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblUnit.Location = new System.Drawing.Point(42, 250);
            this.lblUnit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(665, 31);
            this.lblUnit.TabIndex = 6;
            this.lblUnit.Text = "📏  الوحدة: *";
            this.lblUnit.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // cmbCategory
            // 
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(42, 201);
            this.cmbCategory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(664, 36);
            this.cmbCategory.TabIndex = 5;
            // 
            // lblCategory
            // 
            this.lblCategory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblCategory.Location = new System.Drawing.Point(42, 164);
            this.lblCategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(665, 31);
            this.lblCategory.TabIndex = 4;
            this.lblCategory.Text = "🏷️  التصنيف: *";
            this.lblCategory.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtName.Location = new System.Drawing.Point(42, 114);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(664, 34);
            this.txtName.TabIndex = 3;
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblName.Location = new System.Drawing.Point(42, 78);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(665, 31);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "📝  اسم المنتج: *";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtCode
            // 
            this.txtCode.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtCode.Location = new System.Drawing.Point(42, 41);
            this.txtCode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(664, 34);
            this.txtCode.TabIndex = 1;
            // 
            // lblCode
            // 
            this.lblCode.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblCode.Location = new System.Drawing.Point(42, 4);
            this.lblCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(665, 31);
            this.lblCode.TabIndex = 0;
            this.lblCode.Text = "🔖  كود المنتج: *";
            this.lblCode.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // pnlFooter
            // 
            this.pnlFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.pnlFooter.Controls.Add(this.btnCancel);
            this.pnlFooter.Controls.Add(this.btnSave);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 653);
            this.pnlFooter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(758, 98);
            this.pnlFooter.TabIndex = 2;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(47, 22);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(187, 55);
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
            this.btnSave.Location = new System.Drawing.Point(525, 22);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(187, 55);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "💾 حفظ";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmProductEdit
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(758, 751);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmProductEdit";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "منتج";
            this.Load += new System.EventHandler(this.frmProductEdit_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlBody.ResumeLayout(false);
            this.pnlBody.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinStock)).EndInit();
            this.pnlFooter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.ComboBox cmbUnit;
        private System.Windows.Forms.Label lblMinStock;
        private System.Windows.Forms.NumericUpDown numMinStock;
        private System.Windows.Forms.Label lblMaxStock;
        private System.Windows.Forms.NumericUpDown numMaxStock;
        private System.Windows.Forms.CheckBox chkIsActive;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}