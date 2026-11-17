namespace InventorySystem.UI.Forms
{
    partial class frmBackup
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.grpRestore = new System.Windows.Forms.GroupBox();
            this.lstBackups = new System.Windows.Forms.ListBox();
            this.btnRestore = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.grpBackup = new System.Windows.Forms.GroupBox();
            this.lblBackupPath = new System.Windows.Forms.Label();
            this.lblBackupPathTitle = new System.Windows.Forms.Label();
            this.txtBackupName = new System.Windows.Forms.TextBox();
            this.lblBackupName = new System.Windows.Forms.Label();
            this.btnBackup = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.pnlBody.SuspendLayout();
            this.grpRestore.SuspendLayout();
            this.grpBackup.SuspendLayout();
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
            this.pnlHeader.Size = new System.Drawing.Size(933, 74);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Padding = new System.Windows.Forms.Padding(23, 0, 0, 0);
            this.lblTitle.Size = new System.Drawing.Size(933, 74);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "💾 النسخ الاحتياطي والاستعادة";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlBody
            // 
            this.pnlBody.AutoScroll = true;
            this.pnlBody.BackColor = System.Drawing.Color.White;
            this.pnlBody.Controls.Add(this.grpRestore);
            this.pnlBody.Controls.Add(this.grpBackup);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(0, 74);
            this.pnlBody.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Padding = new System.Windows.Forms.Padding(23, 25, 23, 25);
            this.pnlBody.Size = new System.Drawing.Size(933, 664);
            this.pnlBody.TabIndex = 1;
            // 
            // grpRestore
            // 
            this.grpRestore.Controls.Add(this.lstBackups);
            this.grpRestore.Controls.Add(this.btnRestore);
            this.grpRestore.Controls.Add(this.btnRefresh);
            this.grpRestore.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.grpRestore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.grpRestore.Location = new System.Drawing.Point(23, 320);
            this.grpRestore.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpRestore.Name = "grpRestore";
            this.grpRestore.Padding = new System.Windows.Forms.Padding(12, 12, 12, 12);
            this.grpRestore.Size = new System.Drawing.Size(887, 308);
            this.grpRestore.TabIndex = 1;
            this.grpRestore.TabStop = false;
            this.grpRestore.Text = "♻️ استعادة نسخة";
            // 
            // lstBackups
            // 
            this.lstBackups.Font = new System.Drawing.Font("Arial", 11F);
            this.lstBackups.FormattingEnabled = true;
            this.lstBackups.ItemHeight = 21;
            this.lstBackups.Location = new System.Drawing.Point(18, 37);
            this.lstBackups.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstBackups.Name = "lstBackups";
            this.lstBackups.Size = new System.Drawing.Size(851, 172);
            this.lstBackups.TabIndex = 0;
            // 
            // btnRestore
            // 
            this.btnRestore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnRestore.FlatAppearance.BorderSize = 0;
            this.btnRestore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestore.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.btnRestore.ForeColor = System.Drawing.Color.White;
            this.btnRestore.Location = new System.Drawing.Point(18, 234);
            this.btnRestore.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(210, 55);
            this.btnRestore.TabIndex = 2;
            this.btnRestore.Text = "♻️ استعادة";
            this.btnRestore.UseVisualStyleBackColor = false;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(659, 234);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(210, 55);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "🔄 تحديث القائمة";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // grpBackup
            // 
            this.grpBackup.Controls.Add(this.lblBackupPath);
            this.grpBackup.Controls.Add(this.lblBackupPathTitle);
            this.grpBackup.Controls.Add(this.txtBackupName);
            this.grpBackup.Controls.Add(this.lblBackupName);
            this.grpBackup.Controls.Add(this.btnBackup);
            this.grpBackup.Controls.Add(this.lblInfo);
            this.grpBackup.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.grpBackup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.grpBackup.Location = new System.Drawing.Point(23, 25);
            this.grpBackup.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpBackup.Name = "grpBackup";
            this.grpBackup.Padding = new System.Windows.Forms.Padding(12, 12, 12, 12);
            this.grpBackup.Size = new System.Drawing.Size(887, 283);
            this.grpBackup.TabIndex = 0;
            this.grpBackup.TabStop = false;
            this.grpBackup.Text = "💾 إنشاء نسخة احتياطية";
            // 
            // lblBackupPath
            // 
            this.lblBackupPath.Font = new System.Drawing.Font("Arial", 9F);
            this.lblBackupPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.lblBackupPath.Location = new System.Drawing.Point(18, 154);
            this.lblBackupPath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBackupPath.Name = "lblBackupPath";
            this.lblBackupPath.Size = new System.Drawing.Size(852, 31);
            this.lblBackupPath.TabIndex = 5;
            this.lblBackupPath.Text = "المسار:";
            this.lblBackupPath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblBackupPathTitle
            // 
            this.lblBackupPathTitle.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblBackupPathTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblBackupPathTitle.Location = new System.Drawing.Point(18, 123);
            this.lblBackupPathTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBackupPathTitle.Name = "lblBackupPathTitle";
            this.lblBackupPathTitle.Size = new System.Drawing.Size(852, 31);
            this.lblBackupPathTitle.TabIndex = 4;
            this.lblBackupPathTitle.Text = "مجلد النسخ الاحتياطي:";
            this.lblBackupPathTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtBackupName
            // 
            this.txtBackupName.Font = new System.Drawing.Font("Arial", 12F);
            this.txtBackupName.Location = new System.Drawing.Point(18, 80);
            this.txtBackupName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBackupName.Name = "txtBackupName";
            this.txtBackupName.Size = new System.Drawing.Size(851, 30);
            this.txtBackupName.TabIndex = 1;
            // 
            // lblBackupName
            // 
            this.lblBackupName.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblBackupName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblBackupName.Location = new System.Drawing.Point(18, 49);
            this.lblBackupName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBackupName.Name = "lblBackupName";
            this.lblBackupName.Size = new System.Drawing.Size(852, 31);
            this.lblBackupName.TabIndex = 0;
            this.lblBackupName.Text = "اسم النسخة:";
            this.lblBackupName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnBackup
            // 
            this.btnBackup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnBackup.FlatAppearance.BorderSize = 0;
            this.btnBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackup.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.btnBackup.ForeColor = System.Drawing.Color.White;
            this.btnBackup.Location = new System.Drawing.Point(18, 203);
            this.btnBackup.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(233, 62);
            this.btnBackup.TabIndex = 2;
            this.btnBackup.Text = "💾 إنشاء نسخة";
            this.btnBackup.UseVisualStyleBackColor = false;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.Font = new System.Drawing.Font("Arial", 9F);
            this.lblInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.lblInfo.Location = new System.Drawing.Point(268, 203);
            this.lblInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(601, 62);
            this.lblInfo.TabIndex = 3;
            this.lblInfo.Text = "ملاحظة: يتم إنشاء النسخة في مجلد Backup تلقائياً";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 738);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlHeader);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmBackup";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "النسخ الاحتياطي";
            this.Load += new System.EventHandler(this.frmBackup_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlBody.ResumeLayout(false);
            this.grpRestore.ResumeLayout(false);
            this.grpBackup.ResumeLayout(false);
            this.grpBackup.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.GroupBox grpBackup;
        private System.Windows.Forms.Label lblBackupName;
        private System.Windows.Forms.TextBox txtBackupName;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblBackupPathTitle;
        private System.Windows.Forms.Label lblBackupPath;
        private System.Windows.Forms.GroupBox grpRestore;
        private System.Windows.Forms.ListBox lstBackups;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.Button btnRefresh;
    }
}