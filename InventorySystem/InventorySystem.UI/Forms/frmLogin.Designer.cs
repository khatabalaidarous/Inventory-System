namespace InventorySystem.UI.Forms
{
    partial class frmLogin
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.lblIconPassword = new System.Windows.Forms.Label();
            this.lblIconUser = new System.Windows.Forms.Label();
            this.chkShowPassword = new System.Windows.Forms.CheckBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.lblFooter = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.pnlHeader.SuspendLayout();
            this.pnlBody.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.pnlHeader.Controls.Add(this.lblSubtitle);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.picLogo);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(607, 271);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.White;
            this.lblSubtitle.Location = new System.Drawing.Point(0, 222);
            this.lblSubtitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(607, 31);
            this.lblSubtitle.TabIndex = 2;
            this.lblSubtitle.Text = "Inventory Management System";
            this.lblSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 178);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(607, 43);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "نظام إدارة المخزون والمستودعات";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlBody
            // 
            this.pnlBody.BackColor = System.Drawing.Color.White;
            this.pnlBody.Controls.Add(this.lblIconPassword);
            this.pnlBody.Controls.Add(this.lblIconUser);
            this.pnlBody.Controls.Add(this.chkShowPassword);
            this.pnlBody.Controls.Add(this.btnExit);
            this.pnlBody.Controls.Add(this.btnLogin);
            this.pnlBody.Controls.Add(this.txtPassword);
            this.pnlBody.Controls.Add(this.lblPassword);
            this.pnlBody.Controls.Add(this.txtUsername);
            this.pnlBody.Controls.Add(this.lblUsername);
            this.pnlBody.Controls.Add(this.lblError);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(0, 271);
            this.pnlBody.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(607, 379);
            this.pnlBody.TabIndex = 1;
            // 
            // lblIconPassword
            // 
            this.lblIconPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblIconPassword.Font = new System.Drawing.Font("Segoe UI Emoji", 16F);
            this.lblIconPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblIconPassword.Location = new System.Drawing.Point(512, 144);
            this.lblIconPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIconPassword.Name = "lblIconPassword";
            this.lblIconPassword.Size = new System.Drawing.Size(47, 43);
            this.lblIconPassword.TabIndex = 8;
            this.lblIconPassword.Text = "🔒";
            this.lblIconPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIconUser
            // 
            this.lblIconUser.BackColor = System.Drawing.Color.Transparent;
            this.lblIconUser.Font = new System.Drawing.Font("Segoe UI Emoji", 16F);
            this.lblIconUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblIconUser.Location = new System.Drawing.Point(512, 61);
            this.lblIconUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIconUser.Name = "lblIconUser";
            this.lblIconUser.Size = new System.Drawing.Size(47, 43);
            this.lblIconUser.TabIndex = 7;
            this.lblIconUser.Text = "👤";
            this.lblIconUser.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // chkShowPassword
            // 
            this.chkShowPassword.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.chkShowPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.chkShowPassword.Location = new System.Drawing.Point(72, 202);
            this.chkShowPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkShowPassword.Name = "chkShowPassword";
            this.chkShowPassword.Size = new System.Drawing.Size(432, 34);
            this.chkShowPassword.TabIndex = 4;
            this.chkShowPassword.Text = "👁️  إظهار كلمة المرور";
            this.chkShowPassword.UseVisualStyleBackColor = true;
            this.chkShowPassword.CheckedChanged += new System.EventHandler(this.chkShowPassword_CheckedChanged);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(82, 258);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(210, 62);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "❌  خروج";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(315, 258);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(210, 62);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "✅  دخول";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.txtPassword.Location = new System.Drawing.Point(73, 149);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(431, 36);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // lblPassword
            // 
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblPassword.Location = new System.Drawing.Point(77, 108);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(432, 31);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "🔒  كلمة المرور:";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.txtUsername.Location = new System.Drawing.Point(73, 68);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(431, 36);
            this.txtUsername.TabIndex = 1;
            // 
            // lblUsername
            // 
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblUsername.Location = new System.Drawing.Point(77, 33);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(432, 31);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "👤  اسم المستخدم:";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblError
            // 
            this.lblError.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.lblError.Location = new System.Drawing.Point(82, 326);
            this.lblError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(443, 31);
            this.lblError.TabIndex = 7;
            this.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblError.Visible = false;
            // 
            // pnlFooter
            // 
            this.pnlFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.pnlFooter.Controls.Add(this.lblFooter);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 650);
            this.pnlFooter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(607, 49);
            this.pnlFooter.TabIndex = 2;
            // 
            // lblFooter
            // 
            this.lblFooter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFooter.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblFooter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.lblFooter.Location = new System.Drawing.Point(0, 0);
            this.lblFooter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFooter.Name = "lblFooter";
            this.lblFooter.Size = new System.Drawing.Size(607, 49);
            this.lblFooter.TabIndex = 0;
            this.lblFooter.Text = "© 2026 - جميع الحقوق محفوظة";
            this.lblFooter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.Transparent;
            this.picLogo.Image = global::InventorySystem.Properties.Resources._1791225504223;
            this.picLogo.Location = new System.Drawing.Point(233, 18);
            this.picLogo.Margin = new System.Windows.Forms.Padding(4);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(140, 148);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // frmLogin
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(607, 699);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تسجيل الدخول";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLogin_FormClosing);
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlBody.ResumeLayout(false);
            this.pnlBody.PerformLayout();
            this.pnlFooter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

        }



        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Label lblIconUser;
        private System.Windows.Forms.Label lblIconPassword;
        private System.Windows.Forms.CheckBox chkShowPassword;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Label lblFooter;
    }
}