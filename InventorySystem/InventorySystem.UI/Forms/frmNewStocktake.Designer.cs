namespace InventorySystem.UI.Forms
{
    partial class frmNewStocktake
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
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.cmbWarehouse = new System.Windows.Forms.ComboBox();
            this.lblWarehouse = new System.Windows.Forms.Label();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.pnlBody.SuspendLayout();
            this.pnlFooter.SuspendLayout();
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
            this.pnlHeader.Size = new System.Drawing.Size(642, 86);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Padding = new System.Windows.Forms.Padding(23, 0, 0, 0);
            this.lblTitle.Size = new System.Drawing.Size(642, 86);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "➕ إنشاء جرد جديد";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlBody
            // 
            this.pnlBody.BackColor = System.Drawing.Color.White;
            this.pnlBody.Controls.Add(this.txtNotes);
            this.pnlBody.Controls.Add(this.lblNotes);
            this.pnlBody.Controls.Add(this.cmbWarehouse);
            this.pnlBody.Controls.Add(this.lblWarehouse);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(0, 86);
            this.pnlBody.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Padding = new System.Windows.Forms.Padding(47, 49, 47, 49);
            this.pnlBody.Size = new System.Drawing.Size(642, 222);
            this.pnlBody.TabIndex = 1;
            // 
            // txtNotes
            // 
            this.txtNotes.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtNotes.Location = new System.Drawing.Point(47, 160);
            this.txtNotes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(548, 34);
            this.txtNotes.TabIndex = 3;
            // 
            // lblNotes
            // 
            this.lblNotes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblNotes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblNotes.Location = new System.Drawing.Point(47, 123);
            this.lblNotes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(548, 31);
            this.lblNotes.TabIndex = 2;
            this.lblNotes.Text = "📝  ملاحظات:";
            this.lblNotes.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // cmbWarehouse
            // 
            this.cmbWarehouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWarehouse.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmbWarehouse.FormattingEnabled = true;
            this.cmbWarehouse.Location = new System.Drawing.Point(47, 74);
            this.cmbWarehouse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbWarehouse.Name = "cmbWarehouse";
            this.cmbWarehouse.Size = new System.Drawing.Size(548, 36);
            this.cmbWarehouse.TabIndex = 1;
            // 
            // lblWarehouse
            // 
            this.lblWarehouse.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblWarehouse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblWarehouse.Location = new System.Drawing.Point(47, 37);
            this.lblWarehouse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWarehouse.Name = "lblWarehouse";
            this.lblWarehouse.Size = new System.Drawing.Size(548, 31);
            this.lblWarehouse.TabIndex = 0;
            this.lblWarehouse.Text = "🏪  المستودع: *";
            this.lblWarehouse.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // pnlFooter
            // 
            this.pnlFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.pnlFooter.Controls.Add(this.btnCancel);
            this.pnlFooter.Controls.Add(this.btnCreate);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 308);
            this.pnlFooter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(642, 98);
            this.pnlFooter.TabIndex = 2;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(47, 22);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(187, 55);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "❌ إلغاء";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnCreate.FlatAppearance.BorderSize = 0;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnCreate.ForeColor = System.Drawing.Color.White;
            this.btnCreate.Location = new System.Drawing.Point(408, 22);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(187, 55);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "✅ إنشاء";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // frmNewStocktake
            // 
            this.AcceptButton = this.btnCreate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(642, 406);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNewStocktake";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "إنشاء جرد";
            this.Load += new System.EventHandler(this.frmNewStocktake_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlBody.ResumeLayout(false);
            this.pnlBody.PerformLayout();
            this.pnlFooter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Label lblWarehouse;
        private System.Windows.Forms.ComboBox cmbWarehouse;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnCancel;
    }
}