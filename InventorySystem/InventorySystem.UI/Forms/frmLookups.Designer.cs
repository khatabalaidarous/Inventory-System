namespace InventorySystem.UI.Forms
{
    partial class frmLookups
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
            this.lblCount = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.cmbTable = new System.Windows.Forms.ComboBox();
            this.lblTable = new System.Windows.Forms.Label();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.pnlStats = new System.Windows.Forms.Panel();
            this.lblStats = new System.Windows.Forms.Label();
            this.lblTableType = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.pnlToolbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.pnlStats.SuspendLayout();
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
            this.lblTitle.Text = "📚 الجداول المرجعية";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlToolbar
            // 
            this.pnlToolbar.BackColor = System.Drawing.Color.White;
            this.pnlToolbar.Controls.Add(this.lblCount);
            this.pnlToolbar.Controls.Add(this.btnPrint);
            this.pnlToolbar.Controls.Add(this.btnExport);
            this.pnlToolbar.Controls.Add(this.btnRefresh);
            this.pnlToolbar.Controls.Add(this.btnSearch);
            this.pnlToolbar.Controls.Add(this.txtSearch);
            this.pnlToolbar.Controls.Add(this.lblSearch);
            this.pnlToolbar.Controls.Add(this.cmbTable);
            this.pnlToolbar.Controls.Add(this.lblTable);
            this.pnlToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlToolbar.Location = new System.Drawing.Point(0, 86);
            this.pnlToolbar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlToolbar.Name = "pnlToolbar";
            this.pnlToolbar.Size = new System.Drawing.Size(1400, 160);
            this.pnlToolbar.TabIndex = 1;
            // 
            // lblCount
            // 
            this.lblCount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblCount.Location = new System.Drawing.Point(35, 105);
            this.lblCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(292, 37);
            this.lblCount.TabIndex = 8;
            this.lblCount.Text = "📊 العدد: 0";
            this.lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(338, 98);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(152, 52);
            this.btnPrint.TabIndex = 7;
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
            this.btnExport.Location = new System.Drawing.Point(502, 98);
            this.btnExport.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(175, 52);
            this.btnExport.TabIndex = 6;
            this.btnExport.Text = "📤 تصدير Excel";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(688, 98);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(152, 52);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "🔄 تحديث";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(852, 98);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(152, 52);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "🔍 بحث";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtSearch.Location = new System.Drawing.Point(1015, 105);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(349, 34);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblSearch.Location = new System.Drawing.Point(1015, 68);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(350, 31);
            this.lblSearch.TabIndex = 2;
            this.lblSearch.Text = "🔍  بحث سريع:";
            this.lblSearch.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // cmbTable
            // 
            this.cmbTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTable.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.cmbTable.FormattingEnabled = true;
            this.cmbTable.Location = new System.Drawing.Point(35, 25);
            this.cmbTable.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbTable.Name = "cmbTable";
            this.cmbTable.Size = new System.Drawing.Size(1329, 36);
            this.cmbTable.TabIndex = 1;
            this.cmbTable.SelectedIndexChanged += new System.EventHandler(this.cmbTable_SelectedIndexChanged);
            // 
            // lblTable
            // 
            this.lblTable.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblTable.Location = new System.Drawing.Point(35, -6);
            this.lblTable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTable.Name = "lblTable";
            this.lblTable.Size = new System.Drawing.Size(1330, 31);
            this.lblTable.TabIndex = 0;
            this.lblTable.Text = "📋  اختر الجدول:";
            this.lblTable.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvData.BackgroundColor = System.Drawing.Color.White;
            this.dgvData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvData.ColumnHeadersHeight = 50;
            this.dgvData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvData.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dgvData.Location = new System.Drawing.Point(0, 246);
            this.dgvData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvData.MultiSelect = false;
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.RowHeadersVisible = false;
            this.dgvData.RowHeadersWidth = 51;
            this.dgvData.RowTemplate.Height = 45;
            this.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvData.Size = new System.Drawing.Size(1400, 591);
            this.dgvData.TabIndex = 2;
            // 
            // pnlStats
            // 
            this.pnlStats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.pnlStats.Controls.Add(this.lblStats);
            this.pnlStats.Controls.Add(this.lblTableType);
            this.pnlStats.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlStats.Location = new System.Drawing.Point(0, 837);
            this.pnlStats.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlStats.Name = "pnlStats";
            this.pnlStats.Size = new System.Drawing.Size(1400, 74);
            this.pnlStats.TabIndex = 3;
            // 
            // lblStats
            // 
            this.lblStats.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblStats.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblStats.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblStats.Location = new System.Drawing.Point(0, 0);
            this.lblStats.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStats.Name = "lblStats";
            this.lblStats.Padding = new System.Windows.Forms.Padding(23, 0, 0, 0);
            this.lblStats.Size = new System.Drawing.Size(817, 74);
            this.lblStats.TabIndex = 0;
            this.lblStats.Text = "الجدول: - | السجلات: 0 | الأعمدة: 0";
            this.lblStats.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTableType
            // 
            this.lblTableType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTableType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTableType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblTableType.Location = new System.Drawing.Point(0, 0);
            this.lblTableType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTableType.Name = "lblTableType";
            this.lblTableType.Padding = new System.Windows.Forms.Padding(0, 0, 23, 0);
            this.lblTableType.Size = new System.Drawing.Size(1400, 74);
            this.lblTableType.TabIndex = 1;
            this.lblTableType.Text = "النوع: -";
            this.lblTableType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmLookups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 911);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.pnlStats);
            this.Controls.Add(this.pnlToolbar);
            this.Controls.Add(this.pnlHeader);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmLookups";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الجداول المرجعية";
            this.Load += new System.EventHandler(this.frmLookups_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlToolbar.ResumeLayout(false);
            this.pnlToolbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.pnlStats.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlToolbar;
        private System.Windows.Forms.Label lblTable;
        private System.Windows.Forms.ComboBox cmbTable;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Panel pnlStats;
        private System.Windows.Forms.Label lblStats;
        private System.Windows.Forms.Label lblTableType;
    }
}