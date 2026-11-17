namespace InventorySystem.UI.Forms
{
    partial class frmPartners
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
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cmbFilter = new System.Windows.Forms.ComboBox();
            this.lblFilter = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.dgvPartners = new System.Windows.Forms.DataGridView();
            this.pnlHeader.SuspendLayout();
            this.pnlToolbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartners)).BeginInit();
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
            this.lblTitle.Text = "🤝 إدارة الشركاء (موردين وعملاء)";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlToolbar
            // 
            this.pnlToolbar.BackColor = System.Drawing.Color.White;
            this.pnlToolbar.Controls.Add(this.lblCount);
            this.pnlToolbar.Controls.Add(this.btnRefresh);
            this.pnlToolbar.Controls.Add(this.btnDelete);
            this.pnlToolbar.Controls.Add(this.btnEdit);
            this.pnlToolbar.Controls.Add(this.btnAdd);
            this.pnlToolbar.Controls.Add(this.cmbFilter);
            this.pnlToolbar.Controls.Add(this.lblFilter);
            this.pnlToolbar.Controls.Add(this.txtSearch);
            this.pnlToolbar.Controls.Add(this.lblSearch);
            this.pnlToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlToolbar.Location = new System.Drawing.Point(0, 86);
            this.pnlToolbar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlToolbar.Name = "pnlToolbar";
            this.pnlToolbar.Size = new System.Drawing.Size(1283, 98);
            this.pnlToolbar.TabIndex = 1;
            // 
            // lblCount
            // 
            this.lblCount.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblCount.Location = new System.Drawing.Point(1050, 37);
            this.lblCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(210, 37);
            this.lblCount.TabIndex = 8;
            this.lblCount.Text = "العدد: 0";
            this.lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(910, 31);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(128, 52);
            this.btnRefresh.TabIndex = 7;
            this.btnRefresh.Text = "🔄 تحديث";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(770, 31);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(128, 52);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "🗑️ حذف";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(630, 31);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(128, 52);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "✏️ تعديل";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(490, 31);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(128, 52);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "➕ إضافة";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cmbFilter
            // 
            this.cmbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilter.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cmbFilter.FormattingEnabled = true;
            this.cmbFilter.Location = new System.Drawing.Point(303, 37);
            this.cmbFilter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbFilter.Name = "cmbFilter";
            this.cmbFilter.Size = new System.Drawing.Size(163, 33);
            this.cmbFilter.TabIndex = 3;
            this.cmbFilter.SelectedIndexChanged += new System.EventHandler(this.cmbFilter_SelectedIndexChanged);
            // 
            // lblFilter
            // 
            this.lblFilter.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblFilter.Location = new System.Drawing.Point(303, 0);
            this.lblFilter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(163, 37);
            this.lblFilter.TabIndex = 2;
            this.lblFilter.Text = "🎯 النوع:";
            this.lblFilter.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtSearch.Location = new System.Drawing.Point(35, 37);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(256, 34);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblSearch.Location = new System.Drawing.Point(35, 0);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(257, 37);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "🔍 بحث (بالاسم أو الهاتف):";
            this.lblSearch.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // dgvPartners
            // 
            this.dgvPartners.AllowUserToAddRows = false;
            this.dgvPartners.AllowUserToDeleteRows = false;
            this.dgvPartners.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPartners.BackgroundColor = System.Drawing.Color.White;
            this.dgvPartners.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvPartners.ColumnHeadersHeight = 45;
            this.dgvPartners.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPartners.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dgvPartners.Location = new System.Drawing.Point(0, 184);
            this.dgvPartners.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvPartners.MultiSelect = false;
            this.dgvPartners.Name = "dgvPartners";
            this.dgvPartners.ReadOnly = true;
            this.dgvPartners.RowHeadersVisible = false;
            this.dgvPartners.RowHeadersWidth = 51;
            this.dgvPartners.RowTemplate.Height = 40;
            this.dgvPartners.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPartners.Size = new System.Drawing.Size(1283, 678);
            this.dgvPartners.TabIndex = 2;
            this.dgvPartners.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPartners_CellDoubleClick);
            // 
            // frmPartners
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 862);
            this.Controls.Add(this.dgvPartners);
            this.Controls.Add(this.pnlToolbar);
            this.Controls.Add(this.pnlHeader);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmPartners";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إدارة الشركاء";
            this.Load += new System.EventHandler(this.frmPartners_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlToolbar.ResumeLayout(false);
            this.pnlToolbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartners)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlToolbar;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.ComboBox cmbFilter;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.DataGridView dgvPartners;
    }
}