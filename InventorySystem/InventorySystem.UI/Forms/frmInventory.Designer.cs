namespace InventorySystem.UI.Forms
{
    partial class frmInventory
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
            this.btnRefresh = new System.Windows.Forms.Button();
            this.cmbWarehouse = new System.Windows.Forms.ComboBox();
            this.lblWarehouse = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.dgvInventory = new System.Windows.Forms.DataGridView();
            this.pnlStats = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.pnlToolbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).BeginInit();
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
            this.pnlHeader.Size = new System.Drawing.Size(1283, 86);
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
            this.lblTitle.Size = new System.Drawing.Size(1283, 86);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "📦 عرض المخزون";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlToolbar
            // 
            this.pnlToolbar.BackColor = System.Drawing.Color.White;
            this.pnlToolbar.Controls.Add(this.btnRefresh);
            this.pnlToolbar.Controls.Add(this.cmbWarehouse);
            this.pnlToolbar.Controls.Add(this.lblWarehouse);
            this.pnlToolbar.Controls.Add(this.txtSearch);
            this.pnlToolbar.Controls.Add(this.lblSearch);
            this.pnlToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlToolbar.Location = new System.Drawing.Point(0, 86);
            this.pnlToolbar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlToolbar.Name = "pnlToolbar";
            this.pnlToolbar.Size = new System.Drawing.Size(1283, 98);
            this.pnlToolbar.TabIndex = 1;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(35, 31);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(152, 52);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "🔄 تحديث";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // cmbWarehouse
            // 
            this.cmbWarehouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWarehouse.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cmbWarehouse.FormattingEnabled = true;
            this.cmbWarehouse.Location = new System.Drawing.Point(688, 37);
            this.cmbWarehouse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbWarehouse.Name = "cmbWarehouse";
            this.cmbWarehouse.Size = new System.Drawing.Size(279, 33);
            this.cmbWarehouse.TabIndex = 3;
            this.cmbWarehouse.SelectedIndexChanged += new System.EventHandler(this.cmbWarehouse_SelectedIndexChanged);
            // 
            // lblWarehouse
            // 
            this.lblWarehouse.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblWarehouse.Location = new System.Drawing.Point(688, 0);
            this.lblWarehouse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWarehouse.Name = "lblWarehouse";
            this.lblWarehouse.Size = new System.Drawing.Size(280, 37);
            this.lblWarehouse.TabIndex = 2;
            this.lblWarehouse.Text = "🏪 المستودع:";
            this.lblWarehouse.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtSearch.Location = new System.Drawing.Point(980, 37);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(268, 34);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblSearch.Location = new System.Drawing.Point(980, 0);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(268, 37);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "🔍 بحث (بالمنتج أو الكود):";
            this.lblSearch.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // dgvInventory
            // 
            this.dgvInventory.AllowUserToAddRows = false;
            this.dgvInventory.AllowUserToDeleteRows = false;
            this.dgvInventory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInventory.BackgroundColor = System.Drawing.Color.White;
            this.dgvInventory.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvInventory.ColumnHeadersHeight = 45;
            this.dgvInventory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInventory.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dgvInventory.Location = new System.Drawing.Point(0, 184);
            this.dgvInventory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvInventory.MultiSelect = false;
            this.dgvInventory.Name = "dgvInventory";
            this.dgvInventory.ReadOnly = true;
            this.dgvInventory.RowHeadersVisible = false;
            this.dgvInventory.RowHeadersWidth = 51;
            this.dgvInventory.RowTemplate.Height = 40;
            this.dgvInventory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInventory.Size = new System.Drawing.Size(1283, 616);
            this.dgvInventory.TabIndex = 2;
            // 
            // pnlStats
            // 
            this.pnlStats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.pnlStats.Controls.Add(this.lblTotal);
            this.pnlStats.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlStats.Location = new System.Drawing.Point(0, 800);
            this.pnlStats.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlStats.Name = "pnlStats";
            this.pnlStats.Size = new System.Drawing.Size(1283, 62);
            this.pnlStats.TabIndex = 3;
            // 
            // lblTotal
            // 
            this.lblTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblTotal.Location = new System.Drawing.Point(0, 0);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Padding = new System.Windows.Forms.Padding(23, 0, 23, 0);
            this.lblTotal.Size = new System.Drawing.Size(1283, 62);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "الإجمالي: 0";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 862);
            this.Controls.Add(this.dgvInventory);
            this.Controls.Add(this.pnlStats);
            this.Controls.Add(this.pnlToolbar);
            this.Controls.Add(this.pnlHeader);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmInventory";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "عرض المخزون";
            this.Load += new System.EventHandler(this.frmInventory_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlToolbar.ResumeLayout(false);
            this.pnlToolbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).EndInit();
            this.pnlStats.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlToolbar;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblWarehouse;
        private System.Windows.Forms.ComboBox cmbWarehouse;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dgvInventory;
        private System.Windows.Forms.Panel pnlStats;
        private System.Windows.Forms.Label lblTotal;
    }
}