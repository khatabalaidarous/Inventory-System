namespace InventorySystem.UI.Forms
{
    partial class frmWarehouses
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
            this.pnlToolbar = new System.Windows.Forms.Panel();
            this.lblCount = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.dgvWarehouses = new System.Windows.Forms.DataGridView();
            this.pnlHeader.SuspendLayout();
            this.pnlToolbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWarehouses)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(900, 60);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.lblTitle.Size = new System.Drawing.Size(900, 60);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "🏪 إدارة المستودعات";
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
            this.pnlToolbar.Controls.Add(this.txtSearch);
            this.pnlToolbar.Controls.Add(this.lblSearch);
            this.pnlToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlToolbar.Location = new System.Drawing.Point(0, 60);
            this.pnlToolbar.Name = "pnlToolbar";
            this.pnlToolbar.Size = new System.Drawing.Size(900, 70);
            this.pnlToolbar.TabIndex = 1;
            // 
            // lblCount
            // 
            this.lblCount.Font = new System.Drawing.Font("Arial", 10F);
            this.lblCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.lblCount.Location = new System.Drawing.Point(700, 25);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(180, 30);
            this.lblCount.TabIndex = 6;
            this.lblCount.Text = "العدد: 0";
            this.lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(580, 20);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(100, 38);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "🔄 تحديث";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(470, 20);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 38);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "🗑️ حذف";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(360, 20);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(100, 38);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "✏️ تعديل";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(250, 20);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 38);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "➕ إضافة";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Arial", 11F);
            this.txtSearch.Location = new System.Drawing.Point(30, 25);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(200, 24);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblSearch.Location = new System.Drawing.Point(30, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(200, 25);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "🔍 بحث:";
            // 
            // dgvWarehouses
            // 
            this.dgvWarehouses.AllowUserToAddRows = false;
            this.dgvWarehouses.AllowUserToDeleteRows = false;
            this.dgvWarehouses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvWarehouses.BackgroundColor = System.Drawing.Color.White;
            this.dgvWarehouses.ColumnHeadersHeight = 40;
            this.dgvWarehouses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvWarehouses.Location = new System.Drawing.Point(0, 130);
            this.dgvWarehouses.MultiSelect = false;
            this.dgvWarehouses.Name = "dgvWarehouses";
            this.dgvWarehouses.ReadOnly = true;
            this.dgvWarehouses.RowHeadersVisible = false;
            this.dgvWarehouses.RowTemplate.Height = 35;
            this.dgvWarehouses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvWarehouses.Size = new System.Drawing.Size(900, 470);
            this.dgvWarehouses.TabIndex = 2;
            this.dgvWarehouses.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWarehouses_CellDoubleClick);
            // 
            // frmWarehouses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.dgvWarehouses);
            this.Controls.Add(this.pnlToolbar);
            this.Controls.Add(this.pnlHeader);
            this.Name = "frmWarehouses";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إدارة المستودعات";
            this.Load += new System.EventHandler(this.frmWarehouses_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlToolbar.ResumeLayout(false);
            this.pnlToolbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWarehouses)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlToolbar;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.DataGridView dgvWarehouses;
    }
}