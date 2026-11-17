namespace InventorySystem.UI.Forms
{
    partial class frmWarehouseEdit
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
            this.cmbManager = new System.Windows.Forms.ComboBox();
            this.lblManager = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.lblLocation = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.pnlBody.SuspendLayout();
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
            this.pnlHeader.Size = new System.Drawing.Size(642, 86);
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
            this.lblTitle.Size = new System.Drawing.Size(642, 86);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "إضافة مستودع";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlBody
            // 
            this.pnlBody.BackColor = System.Drawing.Color.White;
            this.pnlBody.Controls.Add(this.chkIsActive);
            this.pnlBody.Controls.Add(this.cmbManager);
            this.pnlBody.Controls.Add(this.lblManager);
            this.pnlBody.Controls.Add(this.txtLocation);
            this.pnlBody.Controls.Add(this.lblLocation);
            this.pnlBody.Controls.Add(this.txtName);
            this.pnlBody.Controls.Add(this.lblName);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(0, 86);
            this.pnlBody.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Padding = new System.Windows.Forms.Padding(47, 49, 47, 49);
            this.pnlBody.Size = new System.Drawing.Size(642, 321);
            this.pnlBody.TabIndex = 1;
            // 
            // chkIsActive
            // 
            this.chkIsActive.Checked = true;
            this.chkIsActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIsActive.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.chkIsActive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.chkIsActive.Location = new System.Drawing.Point(47, 258);
            this.chkIsActive.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkIsActive.Name = "chkIsActive";
            this.chkIsActive.Size = new System.Drawing.Size(548, 37);
            this.chkIsActive.TabIndex = 6;
            this.chkIsActive.Text = "✅  مفعّل";
            this.chkIsActive.UseVisualStyleBackColor = true;
            // 
            // cmbManager
            // 
            this.cmbManager.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbManager.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmbManager.FormattingEnabled = true;
            this.cmbManager.Location = new System.Drawing.Point(47, 209);
            this.cmbManager.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbManager.Name = "cmbManager";
            this.cmbManager.Size = new System.Drawing.Size(548, 36);
            this.cmbManager.TabIndex = 5;
            // 
            // lblManager
            // 
            this.lblManager.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblManager.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblManager.Location = new System.Drawing.Point(47, 172);
            this.lblManager.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblManager.Name = "lblManager";
            this.lblManager.Size = new System.Drawing.Size(548, 31);
            this.lblManager.TabIndex = 4;
            this.lblManager.Text = "👤  المدير (اختياري):";
            this.lblManager.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtLocation
            // 
            this.txtLocation.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtLocation.Location = new System.Drawing.Point(47, 123);
            this.txtLocation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(548, 34);
            this.txtLocation.TabIndex = 3;
            // 
            // lblLocation
            // 
            this.lblLocation.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblLocation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblLocation.Location = new System.Drawing.Point(47, 86);
            this.lblLocation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(548, 31);
            this.lblLocation.TabIndex = 2;
            this.lblLocation.Text = "📍  الموقع:";
            this.lblLocation.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtName.Location = new System.Drawing.Point(47, 37);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(548, 34);
            this.txtName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblName.Location = new System.Drawing.Point(47, 0);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(548, 31);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "📝  اسم المستودع: *";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // pnlFooter
            // 
            this.pnlFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.pnlFooter.Controls.Add(this.btnCancel);
            this.pnlFooter.Controls.Add(this.btnSave);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 407);
            this.pnlFooter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(642, 98);
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
            this.btnSave.Location = new System.Drawing.Point(408, 22);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(187, 55);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "💾 حفظ";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmWarehouseEdit
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(642, 505);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmWarehouseEdit";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "مستودع";
            this.Load += new System.EventHandler(this.frmWarehouseEdit_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlBody.ResumeLayout(false);
            this.pnlBody.PerformLayout();
            this.pnlFooter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Label lblManager;
        private System.Windows.Forms.ComboBox cmbManager;
        private System.Windows.Forms.CheckBox chkIsActive;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}