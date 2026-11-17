namespace InventorySystem.UI.Forms
{
    partial class frmPartnerEdit
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
            this.txtTaxNumber = new System.Windows.Forms.TextBox();
            this.lblTaxNumber = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.lblType = new System.Windows.Forms.Label();
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
            this.lblTitle.Text = "إضافة شريك";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlBody
            // 
            this.pnlBody.AutoScroll = true;
            this.pnlBody.BackColor = System.Drawing.Color.White;
            this.pnlBody.Controls.Add(this.chkIsActive);
            this.pnlBody.Controls.Add(this.txtTaxNumber);
            this.pnlBody.Controls.Add(this.lblTaxNumber);
            this.pnlBody.Controls.Add(this.txtAddress);
            this.pnlBody.Controls.Add(this.lblAddress);
            this.pnlBody.Controls.Add(this.txtEmail);
            this.pnlBody.Controls.Add(this.lblEmail);
            this.pnlBody.Controls.Add(this.txtPhone);
            this.pnlBody.Controls.Add(this.lblPhone);
            this.pnlBody.Controls.Add(this.cmbType);
            this.pnlBody.Controls.Add(this.lblType);
            this.pnlBody.Controls.Add(this.txtName);
            this.pnlBody.Controls.Add(this.lblName);
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
            this.chkIsActive.Location = new System.Drawing.Point(42, 521);
            this.chkIsActive.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkIsActive.Name = "chkIsActive";
            this.chkIsActive.Size = new System.Drawing.Size(665, 37);
            this.chkIsActive.TabIndex = 12;
            this.chkIsActive.Text = "✅  مفعّل";
            this.chkIsActive.UseVisualStyleBackColor = true;
            // 
            // txtTaxNumber
            // 
            this.txtTaxNumber.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtTaxNumber.Location = new System.Drawing.Point(42, 459);
            this.txtTaxNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTaxNumber.Name = "txtTaxNumber";
            this.txtTaxNumber.Size = new System.Drawing.Size(664, 34);
            this.txtTaxNumber.TabIndex = 11;
            // 
            // lblTaxNumber
            // 
            this.lblTaxNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTaxNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblTaxNumber.Location = new System.Drawing.Point(42, 422);
            this.lblTaxNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTaxNumber.Name = "lblTaxNumber";
            this.lblTaxNumber.Size = new System.Drawing.Size(665, 31);
            this.lblTaxNumber.TabIndex = 10;
            this.lblTaxNumber.Text = "🧾  الرقم الضريبي:";
            this.lblTaxNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtAddress.Location = new System.Drawing.Point(42, 373);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(664, 34);
            this.txtAddress.TabIndex = 9;
            // 
            // lblAddress
            // 
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblAddress.Location = new System.Drawing.Point(42, 336);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(665, 31);
            this.lblAddress.TabIndex = 8;
            this.lblAddress.Text = "📍  العنوان:";
            this.lblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtEmail.Location = new System.Drawing.Point(42, 287);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(664, 34);
            this.txtEmail.TabIndex = 7;
            // 
            // lblEmail
            // 
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblEmail.Location = new System.Drawing.Point(42, 250);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(665, 31);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "📧  البريد الإلكتروني:";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtPhone.Location = new System.Drawing.Point(42, 201);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(664, 34);
            this.txtPhone.TabIndex = 5;
            // 
            // lblPhone
            // 
            this.lblPhone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblPhone.Location = new System.Drawing.Point(42, 164);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(665, 31);
            this.lblPhone.TabIndex = 4;
            this.lblPhone.Text = "📞  رقم الهاتف:";
            this.lblPhone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbType
            // 
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(42, 114);
            this.cmbType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(664, 36);
            this.cmbType.TabIndex = 3;
            // 
            // lblType
            // 
            this.lblType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblType.Location = new System.Drawing.Point(42, 78);
            this.lblType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(665, 31);
            this.lblType.TabIndex = 2;
            this.lblType.Text = "🎯  النوع: *";
            this.lblType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtName.Location = new System.Drawing.Point(42, 41);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(664, 34);
            this.txtName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblName.Location = new System.Drawing.Point(42, 4);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(665, 31);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "📝  الاسم: *";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // frmPartnerEdit
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
            this.Name = "frmPartnerEdit";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "شريك";
            this.Load += new System.EventHandler(this.frmPartnerEdit_Load);
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
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblTaxNumber;
        private System.Windows.Forms.TextBox txtTaxNumber;
        private System.Windows.Forms.CheckBox chkIsActive;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}