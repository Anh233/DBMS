namespace Hobook_Software.GUI.Dashboard
{
    partial class HoaDon
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HoaDon));
            this.Label_rp = new Guna.UI.WinForms.GunaLabel();
            this.Label_GG = new Guna.UI.WinForms.GunaLabel();
            this.Label_TT = new Guna.UI.WinForms.GunaLabel();
            this.Label_NgayCheckout = new Guna.UI.WinForms.GunaLabel();
            this.Label_NgayCheckin = new Guna.UI.WinForms.GunaLabel();
            this.Label_TenNV = new Guna.UI.WinForms.GunaLabel();
            this.Label_MaHD = new Guna.UI.WinForms.GunaLabel();
            this.Label_HoaDon = new Guna.UI.WinForms.GunaLabel();
            this.Label_diachiKS = new Guna.UI.WinForms.GunaLabel();
            this.Label_nameKS = new Guna.UI.WinForms.GunaLabel();
            this.panel_hoadon = new Guna.UI.WinForms.GunaPanel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.DGV_DV = new Guna.UI.WinForms.GunaDataGridView();
            this.stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.btn_thanhtoan = new Guna.UI.WinForms.GunaButton();
            this.btn_cancel = new Guna.UI.WinForms.GunaButton();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.label_sophong = new Guna.UI.WinForms.GunaButton();
            this.panel_hoadon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_DV)).BeginInit();
            this.SuspendLayout();
            // 
            // Label_rp
            // 
            this.Label_rp.AutoSize = true;
            this.Label_rp.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_rp.Location = new System.Drawing.Point(14, 561);
            this.Label_rp.Name = "Label_rp";
            this.Label_rp.Size = new System.Drawing.Size(101, 23);
            this.Label_rp.TabIndex = 12;
            this.Label_rp.Text = "Tiền phòng:";
            // 
            // Label_GG
            // 
            this.Label_GG.AutoSize = true;
            this.Label_GG.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_GG.Location = new System.Drawing.Point(13, 597);
            this.Label_GG.Name = "Label_GG";
            this.Label_GG.Size = new System.Drawing.Size(87, 23);
            this.Label_GG.TabIndex = 11;
            this.Label_GG.Text = "Giảm giá: ";
            // 
            // Label_TT
            // 
            this.Label_TT.AutoSize = true;
            this.Label_TT.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_TT.Location = new System.Drawing.Point(14, 663);
            this.Label_TT.Name = "Label_TT";
            this.Label_TT.Size = new System.Drawing.Size(234, 23);
            this.Label_TT.TabIndex = 10;
            this.Label_TT.Text = "Tổng tiền (đã bao gồm VAT): ";
            // 
            // Label_NgayCheckout
            // 
            this.Label_NgayCheckout.AutoSize = true;
            this.Label_NgayCheckout.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_NgayCheckout.Location = new System.Drawing.Point(319, 176);
            this.Label_NgayCheckout.Name = "Label_NgayCheckout";
            this.Label_NgayCheckout.Size = new System.Drawing.Size(163, 23);
            this.Label_NgayCheckout.TabIndex = 8;
            this.Label_NgayCheckout.Text = "10/10/2023 19:00:00";
            // 
            // Label_NgayCheckin
            // 
            this.Label_NgayCheckin.AutoSize = true;
            this.Label_NgayCheckin.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_NgayCheckin.Location = new System.Drawing.Point(319, 150);
            this.Label_NgayCheckin.Name = "Label_NgayCheckin";
            this.Label_NgayCheckin.Size = new System.Drawing.Size(163, 23);
            this.Label_NgayCheckin.TabIndex = 7;
            this.Label_NgayCheckin.Text = "09/10/2023 19:00:00";
            // 
            // Label_TenNV
            // 
            this.Label_TenNV.AutoSize = true;
            this.Label_TenNV.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_TenNV.Location = new System.Drawing.Point(14, 176);
            this.Label_TenNV.Name = "Label_TenNV";
            this.Label_TenNV.Size = new System.Drawing.Size(206, 23);
            this.Label_TenNV.TabIndex = 6;
            this.Label_TenNV.Text = "Nhân viên: Võ Hoài Trọng";
            // 
            // Label_MaHD
            // 
            this.Label_MaHD.AutoSize = true;
            this.Label_MaHD.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_MaHD.Location = new System.Drawing.Point(14, 150);
            this.Label_MaHD.Name = "Label_MaHD";
            this.Label_MaHD.Size = new System.Drawing.Size(98, 23);
            this.Label_MaHD.TabIndex = 5;
            this.Label_MaHD.Text = "Số: HD0002";
            // 
            // Label_HoaDon
            // 
            this.Label_HoaDon.AutoSize = true;
            this.Label_HoaDon.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_HoaDon.Location = new System.Drawing.Point(86, 67);
            this.Label_HoaDon.Name = "Label_HoaDon";
            this.Label_HoaDon.Size = new System.Drawing.Size(324, 45);
            this.Label_HoaDon.TabIndex = 2;
            this.Label_HoaDon.Text = "Hoá đơn đặt phòng";
            // 
            // Label_diachiKS
            // 
            this.Label_diachiKS.AutoSize = true;
            this.Label_diachiKS.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_diachiKS.Location = new System.Drawing.Point(184, 40);
            this.Label_diachiKS.Name = "Label_diachiKS";
            this.Label_diachiKS.Size = new System.Drawing.Size(114, 17);
            this.Label_diachiKS.TabIndex = 1;
            this.Label_diachiKS.Text = "Số 1 Võ Văn Ngân";
            // 
            // Label_nameKS
            // 
            this.Label_nameKS.AutoSize = true;
            this.Label_nameKS.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_nameKS.Location = new System.Drawing.Point(158, 9);
            this.Label_nameKS.Name = "Label_nameKS";
            this.Label_nameKS.Size = new System.Drawing.Size(167, 31);
            this.Label_nameKS.TabIndex = 0;
            this.Label_nameKS.Text = "Hobook Hotel";
            // 
            // panel_hoadon
            // 
            this.panel_hoadon.Controls.Add(this.label_sophong);
            this.panel_hoadon.Controls.Add(this.gunaLabel4);
            this.panel_hoadon.Controls.Add(this.DGV_DV);
            this.panel_hoadon.Controls.Add(this.gunaLabel1);
            this.panel_hoadon.Controls.Add(this.Label_rp);
            this.panel_hoadon.Controls.Add(this.Label_GG);
            this.panel_hoadon.Controls.Add(this.gunaLabel5);
            this.panel_hoadon.Controls.Add(this.Label_TT);
            this.panel_hoadon.Controls.Add(this.Label_NgayCheckout);
            this.panel_hoadon.Controls.Add(this.gunaLabel3);
            this.panel_hoadon.Controls.Add(this.gunaLabel2);
            this.panel_hoadon.Controls.Add(this.Label_NgayCheckin);
            this.panel_hoadon.Controls.Add(this.Label_TenNV);
            this.panel_hoadon.Controls.Add(this.Label_MaHD);
            this.panel_hoadon.Controls.Add(this.Label_HoaDon);
            this.panel_hoadon.Controls.Add(this.Label_diachiKS);
            this.panel_hoadon.Controls.Add(this.Label_nameKS);
            this.panel_hoadon.Location = new System.Drawing.Point(25, 12);
            this.panel_hoadon.Name = "panel_hoadon";
            this.panel_hoadon.Size = new System.Drawing.Size(500, 735);
            this.panel_hoadon.TabIndex = 2;
            this.panel_hoadon.MouseDown += new System.Windows.Forms.MouseEventHandler(this.head_panel_MouseDown);
            this.panel_hoadon.MouseMove += new System.Windows.Forms.MouseEventHandler(this.head_panel_MouseMove);
            this.panel_hoadon.MouseUp += new System.Windows.Forms.MouseEventHandler(this.head_panel_MouseUp);
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.Location = new System.Drawing.Point(14, 631);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(208, 23);
            this.gunaLabel4.TabIndex = 19;
            this.gunaLabel4.Text = "Phương thức thanh toán: ";
            // 
            // DGV_DV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.DGV_DV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_DV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV_DV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_DV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGV_DV.BackgroundColor = System.Drawing.Color.White;
            this.DGV_DV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGV_DV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGV_DV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_DV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGV_DV.ColumnHeadersHeight = 29;
            this.DGV_DV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stt,
            this.TenDV,
            this.SoLuong,
            this.DonGia});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_DV.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGV_DV.EnableHeadersVisualStyles = false;
            this.DGV_DV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.DGV_DV.Location = new System.Drawing.Point(17, 223);
            this.DGV_DV.Name = "DGV_DV";
            this.DGV_DV.ReadOnly = true;
            this.DGV_DV.RowHeadersVisible = false;
            this.DGV_DV.RowHeadersWidth = 51;
            this.DGV_DV.RowTemplate.Height = 30;
            this.DGV_DV.RowTemplate.ReadOnly = true;
            this.DGV_DV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_DV.Size = new System.Drawing.Size(465, 303);
            this.DGV_DV.TabIndex = 18;
            this.DGV_DV.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Light;
            this.DGV_DV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.DGV_DV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DGV_DV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DGV_DV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DGV_DV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DGV_DV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DGV_DV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.DGV_DV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.DGV_DV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGV_DV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DGV_DV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.DGV_DV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DGV_DV.ThemeStyle.HeaderStyle.Height = 29;
            this.DGV_DV.ThemeStyle.ReadOnly = true;
            this.DGV_DV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DGV_DV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGV_DV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DGV_DV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DGV_DV.ThemeStyle.RowsStyle.Height = 30;
            this.DGV_DV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.DGV_DV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // stt
            // 
            this.stt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.stt.DataPropertyName = "STT";
            this.stt.Frozen = true;
            this.stt.HeaderText = "STT";
            this.stt.MinimumWidth = 6;
            this.stt.Name = "stt";
            this.stt.ReadOnly = true;
            this.stt.Width = 67;
            // 
            // TenDV
            // 
            this.TenDV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenDV.DataPropertyName = "TenDV";
            this.TenDV.HeaderText = "Tên dịch vụ";
            this.TenDV.MinimumWidth = 6;
            this.TenDV.Name = "TenDV";
            this.TenDV.ReadOnly = true;
            // 
            // SoLuong
            // 
            this.SoLuong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.ReadOnly = true;
            this.SoLuong.Width = 112;
            // 
            // DonGia
            // 
            this.DonGia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DonGia.DataPropertyName = "DonGia";
            this.DonGia.HeaderText = "Thành tiền";
            this.DonGia.MinimumWidth = 6;
            this.DonGia.Name = "DonGia";
            this.DonGia.ReadOnly = true;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(14, 529);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(147, 23);
            this.gunaLabel1.TabIndex = 16;
            this.gunaLabel1.Text = "Tổng tiền dịch vụ:";
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel5.Location = new System.Drawing.Point(171, 701);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(164, 23);
            this.gunaLabel5.TabIndex = 10;
            this.gunaLabel5.Text = "Cảm ơn quý khách ";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.Location = new System.Drawing.Point(227, 176);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(74, 23);
            this.gunaLabel3.TabIndex = 7;
            this.gunaLabel3.Text = "Ngày ra:";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(227, 150);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(86, 23);
            this.gunaLabel2.TabIndex = 7;
            this.gunaLabel2.Text = "Ngày vào:";
            // 
            // btn_thanhtoan
            // 
            this.btn_thanhtoan.AnimationHoverSpeed = 0.07F;
            this.btn_thanhtoan.AnimationSpeed = 0.03F;
            this.btn_thanhtoan.BackColor = System.Drawing.Color.Transparent;
            this.btn_thanhtoan.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(167)))), ((int)(((byte)(112)))));
            this.btn_thanhtoan.BorderColor = System.Drawing.Color.Black;
            this.btn_thanhtoan.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thanhtoan.ForeColor = System.Drawing.Color.White;
            this.btn_thanhtoan.Image = null;
            this.btn_thanhtoan.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_thanhtoan.Location = new System.Drawing.Point(327, 753);
            this.btn_thanhtoan.Name = "btn_thanhtoan";
            this.btn_thanhtoan.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(129)))), ((int)(((byte)(87)))));
            this.btn_thanhtoan.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_thanhtoan.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_thanhtoan.OnHoverImage = null;
            this.btn_thanhtoan.OnPressedColor = System.Drawing.Color.Black;
            this.btn_thanhtoan.Radius = 10;
            this.btn_thanhtoan.Size = new System.Drawing.Size(160, 50);
            this.btn_thanhtoan.TabIndex = 18;
            this.btn_thanhtoan.Text = "Thanh toán";
            this.btn_thanhtoan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_thanhtoan.Click += new System.EventHandler(this.btn_thanhtoan_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.AnimationHoverSpeed = 0.07F;
            this.btn_cancel.AnimationSpeed = 0.03F;
            this.btn_cancel.BackColor = System.Drawing.Color.Transparent;
            this.btn_cancel.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.btn_cancel.BorderColor = System.Drawing.Color.Black;
            this.btn_cancel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.Color.White;
            this.btn_cancel.Image = null;
            this.btn_cancel.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_cancel.Location = new System.Drawing.Point(56, 753);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.btn_cancel.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_cancel.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_cancel.OnHoverImage = null;
            this.btn_cancel.OnPressedColor = System.Drawing.Color.Black;
            this.btn_cancel.Radius = 10;
            this.btn_cancel.Size = new System.Drawing.Size(160, 50);
            this.btn_cancel.TabIndex = 17;
            this.btn_cancel.Text = "Thoát";
            this.btn_cancel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 10;
            this.gunaElipse1.TargetControl = this;
            // 
            // label_sophong
            // 
            this.label_sophong.AnimationHoverSpeed = 0.07F;
            this.label_sophong.AnimationSpeed = 0.03F;
            this.label_sophong.BaseColor = System.Drawing.Color.Transparent;
            this.label_sophong.BorderColor = System.Drawing.Color.Transparent;
            this.label_sophong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_sophong.ForeColor = System.Drawing.Color.Black;
            this.label_sophong.Image = null;
            this.label_sophong.ImageSize = new System.Drawing.Size(20, 20);
            this.label_sophong.Location = new System.Drawing.Point(3, 115);
            this.label_sophong.Name = "label_sophong";
            this.label_sophong.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.label_sophong.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.label_sophong.OnHoverForeColor = System.Drawing.Color.Black;
            this.label_sophong.OnHoverImage = null;
            this.label_sophong.OnPressedColor = System.Drawing.Color.Black;
            this.label_sophong.Size = new System.Drawing.Size(494, 32);
            this.label_sophong.TabIndex = 20;
            this.label_sophong.Text = "Phòng 404";
            this.label_sophong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // HoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(550, 825);
            this.Controls.Add(this.btn_thanhtoan);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.panel_hoadon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HoaDon";
            this.Load += new System.EventHandler(this.HoaDon_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.head_panel_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.head_panel_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.head_panel_MouseUp);
            this.panel_hoadon.ResumeLayout(false);
            this.panel_hoadon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_DV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaLabel Label_rp;
        private Guna.UI.WinForms.GunaLabel Label_GG;
        private Guna.UI.WinForms.GunaLabel Label_TT;
        private Guna.UI.WinForms.GunaLabel Label_NgayCheckout;
        private Guna.UI.WinForms.GunaLabel Label_NgayCheckin;
        private Guna.UI.WinForms.GunaLabel Label_TenNV;
        private Guna.UI.WinForms.GunaLabel Label_MaHD;
        private Guna.UI.WinForms.GunaLabel Label_HoaDon;
        private Guna.UI.WinForms.GunaLabel Label_diachiKS;
        private Guna.UI.WinForms.GunaLabel Label_nameKS;
        private Guna.UI.WinForms.GunaPanel panel_hoadon;
        private Guna.UI.WinForms.GunaButton btn_thanhtoan;
        private Guna.UI.WinForms.GunaButton btn_cancel;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaDataGridView DGV_DV;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private Guna.UI.WinForms.GunaButton label_sophong;
    }
}