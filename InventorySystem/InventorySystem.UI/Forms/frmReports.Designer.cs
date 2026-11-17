namespace InventorySystem.UI.Forms
{
    partial class frmReports
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
            this.pnlToolbar = new System.Windows.Forms.Panel();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.cmbReport = new System.Windows.Forms.ComboBox();
            this.lblReport = new System.Windows.Forms.Label();
            this.dgvReport = new System.Windows.Forms.DataGridView();
            this.pnlHeader.SuspendLayout();
            this.pnlToolbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
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
            this.pnlHeader.Size = new System.Drawing.Size(1400, 86);
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
            this.lblTitle.Size = new System.Drawing.Size(1400, 86);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "📊 التقارير";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlToolbar
            // 
            this.pnlToolbar.BackColor = System.Drawing.Color.White;
            this.pnlToolbar.Controls.Add(this.btnPrint);
            this.pnlToolbar.Controls.Add(this.btnExport);
            this.pnlToolbar.Controls.Add(this.btnShow);
            this.pnlToolbar.Controls.Add(this.cmbReport);
            this.pnlToolbar.Controls.Add(this.lblReport);
            this.pnlToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlToolbar.Location = new System.Drawing.Point(0, 86);
            this.pnlToolbar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlToolbar.Name = "pnlToolbar";
            this.pnlToolbar.Size = new System.Drawing.Size(1400, 98);
            this.pnlToolbar.TabIndex = 1;
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(455, 31);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(152, 52);
            this.btnPrint.TabIndex = 4;
            this.btnPrint.Text = "🖨️ طباعة";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Location = new System.Drawing.Point(618, 31);
            this.btnExport.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(175, 52);
            this.btnExport.TabIndex = 3;
            this.btnExport.Text = "📤 تصدير Excel";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnShow.FlatAppearance.BorderSize = 0;
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShow.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnShow.ForeColor = System.Drawing.Color.White;
            this.btnShow.Location = new System.Drawing.Point(805, 31);
            this.btnShow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(152, 52);
            this.btnShow.TabIndex = 2;
            this.btnShow.Text = "🔍 عرض";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // cmbReport
            // 
            this.cmbReport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReport.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmbReport.FormattingEnabled = true;
            this.cmbReport.Location = new System.Drawing.Point(968, 37);
            this.cmbReport.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbReport.Name = "cmbReport";
            this.cmbReport.Size = new System.Drawing.Size(384, 36);
            this.cmbReport.TabIndex = 1;
            // 
            // lblReport
            // 
            this.lblReport.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblReport.Location = new System.Drawing.Point(968, 0);
            this.lblReport.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReport.Name = "lblReport";
            this.lblReport.Size = new System.Drawing.Size(385, 37);
            this.lblReport.TabIndex = 0;
            this.lblReport.Text = "📄 نوع التقرير:";
            this.lblReport.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // dgvReport
            // 
            this.dgvReport.AllowUserToAddRows = false;
            this.dgvReport.AllowUserToDeleteRows = false;
            this.dgvReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReport.BackgroundColor = System.Drawing.Color.White;
            this.dgvReport.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvReport.ColumnHeadersHeight = 45;
            this.dgvReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReport.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dgvReport.Location = new System.Drawing.Point(0, 184);
            this.dgvReport.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvReport.MultiSelect = false;
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.ReadOnly = true;
            this.dgvReport.RowHeadersVisible = false;
            this.dgvReport.RowHeadersWidth = 51;
            this.dgvReport.RowTemplate.Height = 40;
            this.dgvReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReport.Size = new System.Drawing.Size(1400, 678);
            this.dgvReport.TabIndex = 2;
            // 
            // frmReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 862);
            this.Controls.Add(this.dgvReport);
            this.Controls.Add(this.pnlToolbar);
            this.Controls.Add(this.pnlHeader);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmReports";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "التقارير";
            this.Load += new System.EventHandler(this.frmReports_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlToolbar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlToolbar;
        private System.Windows.Forms.Label lblReport;
        private System.Windows.Forms.ComboBox cmbReport;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.DataGridView dgvReport;
    }
}