namespace InventorySystem.UI.Forms
{
    partial class frmSettings
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
            this.tabSettings = new System.Windows.Forms.TabControl();
            this.tabGeneral = new System.Windows.Forms.TabPage();
            this.tabInventory = new System.Windows.Forms.TabPage();
            this.tabInvoices = new System.Windows.Forms.TabPage();
            this.tabSecurity = new System.Windows.Forms.TabPage();
            this.tabNotifications = new System.Windows.Forms.TabPage();
            this.tabDatabase = new System.Windows.Forms.TabPage();
            this.tabAdvanced = new System.Windows.Forms.TabPage();
            this.tabAbout = new System.Windows.Forms.TabPage();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.pnlBody.SuspendLayout();
            this.tabSettings.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(950, 70);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.lblTitle.Size = new System.Drawing.Size(950, 70);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "⚙️ إعدادات النظام";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlBody
            // 
            this.pnlBody.BackColor = System.Drawing.Color.White;
            this.pnlBody.Controls.Add(this.tabSettings);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(0, 70);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Padding = new System.Windows.Forms.Padding(15);
            this.pnlBody.Size = new System.Drawing.Size(950, 640);
            this.pnlBody.TabIndex = 1;
            // 
            // tabSettings
            // 
            this.tabSettings.Controls.Add(this.tabGeneral);
            this.tabSettings.Controls.Add(this.tabInventory);
            this.tabSettings.Controls.Add(this.tabInvoices);
            this.tabSettings.Controls.Add(this.tabSecurity);
            this.tabSettings.Controls.Add(this.tabNotifications);
            this.tabSettings.Controls.Add(this.tabDatabase);
            this.tabSettings.Controls.Add(this.tabAdvanced);
            this.tabSettings.Controls.Add(this.tabAbout);
            this.tabSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabSettings.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.tabSettings.Location = new System.Drawing.Point(15, 15);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabSettings.RightToLeftLayout = true;
            this.tabSettings.SelectedIndex = 0;
            this.tabSettings.Size = new System.Drawing.Size(920, 610);
            this.tabSettings.TabIndex = 0;
            // 
            // tabGeneral
            // 
            this.tabGeneral.AutoScroll = true;
            this.tabGeneral.BackColor = System.Drawing.Color.White;
            this.tabGeneral.Location = new System.Drawing.Point(4, 26);
            this.tabGeneral.Name = "tabGeneral";
            this.tabGeneral.Padding = new System.Windows.Forms.Padding(15);
            this.tabGeneral.Size = new System.Drawing.Size(912, 580);
            this.tabGeneral.TabIndex = 0;
            this.tabGeneral.Text = "🏢 عام";
            // 
            // tabInventory
            // 
            this.tabInventory.AutoScroll = true;
            this.tabInventory.BackColor = System.Drawing.Color.White;
            this.tabInventory.Location = new System.Drawing.Point(4, 26);
            this.tabInventory.Name = "tabInventory";
            this.tabInventory.Padding = new System.Windows.Forms.Padding(15);
            this.tabInventory.Size = new System.Drawing.Size(912, 580);
            this.tabInventory.TabIndex = 1;
            this.tabInventory.Text = "📦 المخزون";
            // 
            // tabInvoices
            // 
            this.tabInvoices.AutoScroll = true;
            this.tabInvoices.BackColor = System.Drawing.Color.White;
            this.tabInvoices.Location = new System.Drawing.Point(4, 26);
            this.tabInvoices.Name = "tabInvoices";
            this.tabInvoices.Padding = new System.Windows.Forms.Padding(15);
            this.tabInvoices.Size = new System.Drawing.Size(912, 580);
            this.tabInvoices.TabIndex = 2;
            this.tabInvoices.Text = "🧾 الفواتير";
            // 
            // tabSecurity
            // 
            this.tabSecurity.AutoScroll = true;
            this.tabSecurity.BackColor = System.Drawing.Color.White;
            this.tabSecurity.Location = new System.Drawing.Point(4, 26);
            this.tabSecurity.Name = "tabSecurity";
            this.tabSecurity.Padding = new System.Windows.Forms.Padding(15);
            this.tabSecurity.Size = new System.Drawing.Size(912, 580);
            this.tabSecurity.TabIndex = 3;
            this.tabSecurity.Text = "🔐 الأمان";
            // 
            // tabNotifications
            // 
            this.tabNotifications.AutoScroll = true;
            this.tabNotifications.BackColor = System.Drawing.Color.White;
            this.tabNotifications.Location = new System.Drawing.Point(4, 26);
            this.tabNotifications.Name = "tabNotifications";
            this.tabNotifications.Padding = new System.Windows.Forms.Padding(15);
            this.tabNotifications.Size = new System.Drawing.Size(912, 580);
            this.tabNotifications.TabIndex = 4;
            this.tabNotifications.Text = "🔔 الإشعارات";
            // 
            // tabDatabase
            // 
            this.tabDatabase.AutoScroll = true;
            this.tabDatabase.BackColor = System.Drawing.Color.White;
            this.tabDatabase.Location = new System.Drawing.Point(4, 26);
            this.tabDatabase.Name = "tabDatabase";
            this.tabDatabase.Padding = new System.Windows.Forms.Padding(15);
            this.tabDatabase.Size = new System.Drawing.Size(912, 580);
            this.tabDatabase.TabIndex = 5;
            this.tabDatabase.Text = "🗄️ قاعدة البيانات";
            // 
            // tabAdvanced
            // 
            this.tabAdvanced.AutoScroll = true;
            this.tabAdvanced.BackColor = System.Drawing.Color.White;
            this.tabAdvanced.Location = new System.Drawing.Point(4, 26);
            this.tabAdvanced.Name = "tabAdvanced";
            this.tabAdvanced.Padding = new System.Windows.Forms.Padding(15);
            this.tabAdvanced.Size = new System.Drawing.Size(912, 580);
            this.tabAdvanced.TabIndex = 6;
            this.tabAdvanced.Text = "📊 متقدم";
            // 
            // tabAbout
            // 
            this.tabAbout.BackColor = System.Drawing.Color.White;
            this.tabAbout.Location = new System.Drawing.Point(4, 26);
            this.tabAbout.Name = "tabAbout";
            this.tabAbout.Padding = new System.Windows.Forms.Padding(15);
            this.tabAbout.Size = new System.Drawing.Size(912, 580);
            this.tabAbout.TabIndex = 7;
            this.tabAbout.Text = "ℹ️ حول";
            // 
            // pnlFooter
            // 
            this.pnlFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.pnlFooter.Controls.Add(this.btnReset);
            this.pnlFooter.Controls.Add(this.btnCancel);
            this.pnlFooter.Controls.Add(this.btnSave);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 710);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(950, 80);
            this.pnlFooter.TabIndex = 2;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(30, 18);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(180, 45);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "🔄 استعادة الافتراضي";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(220, 18);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(160, 45);
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
            this.btnSave.Location = new System.Drawing.Point(750, 18);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(170, 45);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "💾 حفظ الإعدادات";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmSettings
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(950, 790);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSettings";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "إعدادات النظام";
            this.Load += new System.EventHandler(this.frmSettings_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlBody.ResumeLayout(false);
            this.tabSettings.ResumeLayout(false);
            this.pnlFooter.ResumeLayout(false);
            this.ResumeLayout(false);
        }



        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.TabControl tabSettings;
        private System.Windows.Forms.TabPage tabGeneral;
        private System.Windows.Forms.TabPage tabInventory;
        private System.Windows.Forms.TabPage tabInvoices;
        private System.Windows.Forms.TabPage tabSecurity;
        private System.Windows.Forms.TabPage tabNotifications;
        private System.Windows.Forms.TabPage tabDatabase;
        private System.Windows.Forms.TabPage tabAdvanced;
        private System.Windows.Forms.TabPage tabAbout;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
    }
}