namespace InventorySystem.UI.Forms
{
    partial class frmStocktakeDetails
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
            this.lblWarehouseValue = new System.Windows.Forms.Label();
            this.lblWarehouse = new System.Windows.Forms.Label();
            this.dgvDetails = new System.Windows.Forms.DataGridView();
            this.pnlHeader.SuspendLayout();
            this.pnlToolbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).BeginInit();
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
            this.lblTitle.Text = "📋 تفاصيل الجرد - أدخل الكميات الفعلية";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlToolbar
            // 
            this.pnlToolbar.BackColor = System.Drawing.Color.White;
            this.pnlToolbar.Controls.Add(this.btnRefresh);
            this.pnlToolbar.Controls.Add(this.lblWarehouseValue);
            this.pnlToolbar.Controls.Add(this.lblWarehouse);
            this.pnlToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlToolbar.Location = new System.Drawing.Point(0, 70);
            this.pnlToolbar.Name = "pnlToolbar";
            this.pnlToolbar.Size = new System.Drawing.Size(1100, 70);
            this.pnlToolbar.TabIndex = 1;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(30, 15);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(150, 42);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "💾 حفظ";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblWarehouseValue
            // 
            this.lblWarehouseValue.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblWarehouseValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblWarehouseValue.Location = new System.Drawing.Point(450, 20);
            this.lblWarehouseValue.Name = "lblWarehouseValue";
            this.lblWarehouseValue.Size = new System.Drawing.Size(400, 30);
            this.lblWarehouseValue.TabIndex = 2;
            this.lblWarehouseValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblWarehouse
            // 
            this.lblWarehouse.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblWarehouse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblWarehouse.Location = new System.Drawing.Point(860, 20);
            this.lblWarehouse.Name = "lblWarehouse";
            this.lblWarehouse.Size = new System.Drawing.Size(200, 30);
            this.lblWarehouse.TabIndex = 1;
            this.lblWarehouse.Text = "🏪  المستودع:";
            this.lblWarehouse.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dgvDetails
            // 
            this.dgvDetails.AllowUserToAddRows = false;
            this.dgvDetails.AllowUserToDeleteRows = false;
            this.dgvDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetails.BackgroundColor = System.Drawing.Color.White;
            this.dgvDetails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDetails.ColumnHeadersHeight = 45;
            this.dgvDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDetails.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dgvDetails.Location = new System.Drawing.Point(0, 140);
            this.dgvDetails.MultiSelect = false;
            this.dgvDetails.Name = "dgvDetails";
            this.dgvDetails.RowHeadersVisible = false;
            this.dgvDetails.RowTemplate.Height = 40;
            this.dgvDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetails.Size = new System.Drawing.Size(1100, 560);
            this.dgvDetails.TabIndex = 2;
            // 
            // frmStocktakeDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.dgvDetails);
            this.Controls.Add(this.pnlToolbar);
            this.Controls.Add(this.pnlHeader);
            this.Name = "frmStocktakeDetails";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "تفاصيل الجرد";
            this.Load += new System.EventHandler(this.frmStocktakeDetails_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlToolbar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlToolbar;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblWarehouse;
        private System.Windows.Forms.Label lblWarehouseValue;
        private System.Windows.Forms.DataGridView dgvDetails;
    }
}