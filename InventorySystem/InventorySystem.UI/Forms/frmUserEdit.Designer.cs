namespace InventorySystem.UI.Forms
{
    partial class frmUserEdit
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
            this.grpRoles = new System.Windows.Forms.GroupBox();
            this.clbRoles = new System.Windows.Forms.CheckedListBox();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lblFullName = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.pnlBody.SuspendLayout();
            this.grpRoles.SuspendLayout();
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
            this.pnlHeader.Size = new System.Drawing.Size(817, 86);
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
            this.lblTitle.Size = new System.Drawing.Size(817, 86);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "إضافة مستخدم";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlBody
            // 
            this.pnlBody.BackColor = System.Drawing.Color.White;
            this.pnlBody.Controls.Add(this.chkIsActive);
            this.pnlBody.Controls.Add(this.grpRoles);
            this.pnlBody.Controls.Add(this.txtConfirmPassword);
            this.pnlBody.Controls.Add(this.lblConfirmPassword);
            this.pnlBody.Controls.Add(this.txtPassword);
            this.pnlBody.Controls.Add(this.lblPassword);
            this.pnlBody.Controls.Add(this.txtFullName);
            this.pnlBody.Controls.Add(this.lblFullName);
            this.pnlBody.Controls.Add(this.txtUsername);
            this.pnlBody.Controls.Add(this.lblUsername);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(0, 86);
            this.pnlBody.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Padding = new System.Windows.Forms.Padding(35, 37, 35, 37);
            this.pnlBody.Size = new System.Drawing.Size(817, 653);
            this.pnlBody.TabIndex = 1;
            // 
            // chkIsActive
            // 
            this.chkIsActive.Checked = true;
            this.chkIsActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIsActive.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.chkIsActive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.chkIsActive.Location = new System.Drawing.Point(35, 542);
            this.chkIsActive.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkIsActive.Name = "chkIsActive";
            this.chkIsActive.Size = new System.Drawing.Size(747, 37);
            this.chkIsActive.TabIndex = 8;
            this.chkIsActive.Text = "✅  مفعّل";
            this.chkIsActive.UseVisualStyleBackColor = true;
            // 
            // grpRoles
            // 
            this.grpRoles.Controls.Add(this.clbRoles);
            this.grpRoles.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.grpRoles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.grpRoles.Location = new System.Drawing.Point(35, 308);
            this.grpRoles.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpRoles.Name = "grpRoles";
            this.grpRoles.Padding = new System.Windows.Forms.Padding(12, 12, 12, 12);
            this.grpRoles.Size = new System.Drawing.Size(747, 222);
            this.grpRoles.TabIndex = 7;
            this.grpRoles.TabStop = false;
            this.grpRoles.Text = "🎭  الأدوار";
            // 
            // clbRoles
            // 
            this.clbRoles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clbRoles.CheckOnClick = true;
            this.clbRoles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clbRoles.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.clbRoles.FormattingEnabled = true;
            this.clbRoles.Location = new System.Drawing.Point(12, 39);
            this.clbRoles.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.clbRoles.Name = "clbRoles";
            this.clbRoles.Size = new System.Drawing.Size(723, 171);
            this.clbRoles.TabIndex = 0;
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtConfirmPassword.Location = new System.Drawing.Point(35, 258);
            this.txtConfirmPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(746, 34);
            this.txtConfirmPassword.TabIndex = 6;
            this.txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblConfirmPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblConfirmPassword.Location = new System.Drawing.Point(35, 228);
            this.lblConfirmPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(747, 31);
            this.lblConfirmPassword.TabIndex = 5;
            this.lblConfirmPassword.Text = "🔒  تأكيد كلمة المرور:";
            this.lblConfirmPassword.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtPassword.Location = new System.Drawing.Point(35, 185);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(746, 34);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // lblPassword
            // 
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblPassword.Location = new System.Drawing.Point(35, 154);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(747, 31);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "🔒  كلمة المرور:";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtFullName
            // 
            this.txtFullName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtFullName.Location = new System.Drawing.Point(35, 111);
            this.txtFullName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(746, 34);
            this.txtFullName.TabIndex = 2;
            // 
            // lblFullName
            // 
            this.lblFullName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblFullName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblFullName.Location = new System.Drawing.Point(35, 80);
            this.lblFullName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(747, 31);
            this.lblFullName.TabIndex = 1;
            this.lblFullName.Text = "📝  الاسم الكامل: *";
            this.lblFullName.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtUsername.Location = new System.Drawing.Point(35, 37);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(746, 34);
            this.txtUsername.TabIndex = 0;
            // 
            // lblUsername
            // 
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblUsername.Location = new System.Drawing.Point(35, 6);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(747, 31);
            this.lblUsername.TabIndex = 9;
            this.lblUsername.Text = "👤  اسم المستخدم: *";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // pnlFooter
            // 
            this.pnlFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.pnlFooter.Controls.Add(this.btnCancel);
            this.pnlFooter.Controls.Add(this.btnSave);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 739);
            this.pnlFooter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(817, 98);
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
            this.btnCancel.Location = new System.Drawing.Point(35, 22);
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
            this.btnSave.Location = new System.Drawing.Point(583, 22);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(187, 55);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "💾 حفظ";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmUserEdit
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(817, 837);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUserEdit";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "مستخدم";
            this.Load += new System.EventHandler(this.frmUserEdit_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlBody.ResumeLayout(false);
            this.pnlBody.PerformLayout();
            this.grpRoles.ResumeLayout(false);
            this.pnlFooter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.GroupBox grpRoles;
        private System.Windows.Forms.CheckedListBox clbRoles;
        private System.Windows.Forms.CheckBox chkIsActive;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}