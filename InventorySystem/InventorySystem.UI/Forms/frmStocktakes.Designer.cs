namespace InventorySystem.UI.Forms
{
    partial class frmStocktakes
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.dgvStocktakes = new System.Windows.Forms.DataGridView();
            this.pnlHeader.SuspendLayout();
            this.pnlToolbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStocktakes)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1100, 70);
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
            this.lblTitle.Size = new System.Drawing.Size(1100, 70);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "📋 الجرد";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlToolbar
            // 
            this.pnlToolbar.BackColor = System.Drawing.Color.White;
            this.pnlToolbar.Controls.Add(this.lblCount);
            this.pnlToolbar.Controls.Add(this.btnRefresh);
            this.pnlToolbar.Controls.Add(this.btnClose);
            this.pnlToolbar.Controls.Add(this.btnOpen);
            this.pnlToolbar.Controls.Add(this.btnNew);
            this.pnlToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlToolbar.Location = new System.Drawing.Point(0, 70);
            this.pnlToolbar.Name = "pnlToolbar";
            this.pnlToolbar.Size = new System.Drawing.Size(1100, 80);
            this.pnlToolbar.TabIndex = 1;
            // 
            // lblCount
            // 
            this.lblCount.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblCount.Location = new System.Drawing.Point(900, 30);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(180, 30);
            this.lblCount.TabIndex = 4;
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
            this.btnRefresh.Location = new System.Drawing.Point(780, 25);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(110, 42);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "🔄 تحديث";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(660, 25);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(110, 42);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "🔒 إغلاق الجرد";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btnOpen.FlatAppearance.BorderSize = 0;
            this.btnOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpen.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnOpen.ForeColor = System.Drawing.Color.White;
            this.btnOpen.Location = new System.Drawing.Point(540, 25);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(110, 42);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "📂 فتح";
            this.btnOpen.UseVisualStyleBackColor = false;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnNew.FlatAppearance.BorderSize = 0;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnNew.ForeColor = System.Drawing.Color.White;
            this.btnNew.Location = new System.Drawing.Point(420, 25);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(110, 42);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "➕ جرد جديد";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // dgvStocktakes
            // 
            this.dgvStocktakes.AllowUserToAddRows = false;
            this.dgvStocktakes.AllowUserToDeleteRows = false;
            this.dgvStocktakes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStocktakes.BackgroundColor = System.Drawing.Color.White;
            this.dgvStocktakes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvStocktakes.ColumnHeadersHeight = 45;
            this.dgvStocktakes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStocktakes.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dgvStocktakes.Location = new System.Drawing.Point(0, 150);
            this.dgvStocktakes.MultiSelect = false;
            this.dgvStocktakes.Name = "dgvStocktakes";
            this.dgvStocktakes.ReadOnly = true;
            this.dgvStocktakes.RowHeadersVisible = false;
            this.dgvStocktakes.RowTemplate.Height = 40;
            this.dgvStocktakes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStocktakes.Size = new System.Drawing.Size(1100, 550);
            this.dgvStocktakes.TabIndex = 2;
            this.dgvStocktakes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStocktakes_CellDoubleClick);
            // 
            // frmStocktakes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.dgvStocktakes);
            this.Controls.Add(this.pnlToolbar);
            this.Controls.Add(this.pnlHeader);
            this.Name = "frmStocktakes";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الجرد";
            this.Load += new System.EventHandler(this.frmStocktakes_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlToolbar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStocktakes)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlToolbar;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.DataGridView dgvStocktakes;
    }
}