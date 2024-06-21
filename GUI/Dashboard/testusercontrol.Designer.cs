namespace Hobook_Software.GUI.Dashboard
{
    partial class testusercontrol
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(testusercontrol));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dg_customer = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lienlac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cccd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taikhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matkhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vaitro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fix = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dg_customer)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn1.FillWeight = 50F;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewImageColumn1.Width = 125;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn2.Image")));
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.dataGridViewImageColumn2.MinimumWidth = 6;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn2.Width = 125;
            // 
            // dataGridViewImageColumn3
            // 
            this.dataGridViewImageColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn3.HeaderText = "";
            this.dataGridViewImageColumn3.Image = global::Hobook_Software.Properties.Resources.bin;
            this.dataGridViewImageColumn3.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.dataGridViewImageColumn3.MinimumWidth = 6;
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            this.dataGridViewImageColumn3.ReadOnly = true;
            this.dataGridViewImageColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn3.Width = 125;
            // 
            // dg_customer
            // 
            this.dg_customer.AllowUserToAddRows = false;
            this.dg_customer.AllowUserToDeleteRows = false;
            this.dg_customer.AllowUserToOrderColumns = true;
            this.dg_customer.AllowUserToResizeColumns = false;
            this.dg_customer.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dg_customer.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dg_customer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_customer.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dg_customer.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dg_customer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dg_customer.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_customer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dg_customer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_customer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.hoten,
            this.lienlac,
            this.cccd,
            this.taikhoan,
            this.matkhau,
            this.vaitro,
            this.Fix,
            this.Delete});
            this.dg_customer.DoubleBuffered = true;
            this.dg_customer.EnableHeadersVisualStyles = false;
            this.dg_customer.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.dg_customer.HeaderBgColor = System.Drawing.Color.SteelBlue;
            this.dg_customer.HeaderForeColor = System.Drawing.Color.Honeydew;
            this.dg_customer.Location = new System.Drawing.Point(48, 51);
            this.dg_customer.Name = "dg_customer";
            this.dg_customer.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_customer.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dg_customer.RowHeadersVisible = false;
            this.dg_customer.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dg_customer.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dg_customer.RowTemplate.Height = 24;
            this.dg_customer.Size = new System.Drawing.Size(1141, 128);
            this.dg_customer.TabIndex = 1;
            // 
            // STT
            // 
            this.STT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.STT.DataPropertyName = "STT";
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.STT.Width = 74;
            // 
            // hoten
            // 
            this.hoten.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.hoten.DataPropertyName = "Họ tên";
            this.hoten.FillWeight = 87.55538F;
            this.hoten.HeaderText = "Họ tên";
            this.hoten.MinimumWidth = 6;
            this.hoten.Name = "hoten";
            // 
            // lienlac
            // 
            this.lienlac.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.lienlac.DataPropertyName = "Liên lạc";
            this.lienlac.FillWeight = 87.55538F;
            this.lienlac.HeaderText = "Liên lạc";
            this.lienlac.MinimumWidth = 6;
            this.lienlac.Name = "lienlac";
            // 
            // cccd
            // 
            this.cccd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cccd.DataPropertyName = "CCCD";
            this.cccd.FillWeight = 87.55538F;
            this.cccd.HeaderText = "CCCD";
            this.cccd.MinimumWidth = 6;
            this.cccd.Name = "cccd";
            // 
            // taikhoan
            // 
            this.taikhoan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.taikhoan.DataPropertyName = "Tài khoản";
            this.taikhoan.FillWeight = 87.55538F;
            this.taikhoan.HeaderText = "Tài khoản";
            this.taikhoan.MinimumWidth = 6;
            this.taikhoan.Name = "taikhoan";
            // 
            // matkhau
            // 
            this.matkhau.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.matkhau.DataPropertyName = "Mật khẩu";
            this.matkhau.FillWeight = 87.55538F;
            this.matkhau.HeaderText = "Mật khẩu";
            this.matkhau.MinimumWidth = 6;
            this.matkhau.Name = "matkhau";
            // 
            // vaitro
            // 
            this.vaitro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.vaitro.DataPropertyName = "Vai trò";
            this.vaitro.FillWeight = 87.55538F;
            this.vaitro.HeaderText = "Vai trò";
            this.vaitro.MinimumWidth = 6;
            this.vaitro.Name = "vaitro";
            // 
            // Fix
            // 
            this.Fix.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Fix.DataPropertyName = "Fix";
            this.Fix.HeaderText = "Sửa";
            this.Fix.MinimumWidth = 6;
            this.Fix.Name = "Fix";
            this.Fix.ReadOnly = true;
            this.Fix.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Fix.Width = 51;
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Delete.DataPropertyName = "Delete";
            this.Delete.HeaderText = "Xóa";
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Delete.Width = 52;
            // 
            // testusercontrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 1055);
            this.Controls.Add(this.dg_customer);
            this.Name = "testusercontrol";
            this.Text = "testusercontrol";
            this.Load += new System.EventHandler(this.testusercontrol_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_customer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dg_customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn lienlac;
        private System.Windows.Forms.DataGridViewTextBoxColumn cccd;
        private System.Windows.Forms.DataGridViewTextBoxColumn taikhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn matkhau;
        private System.Windows.Forms.DataGridViewTextBoxColumn vaitro;
        private System.Windows.Forms.DataGridViewButtonColumn Fix;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}