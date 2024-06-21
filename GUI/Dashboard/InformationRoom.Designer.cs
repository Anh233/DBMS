namespace Hobook_Software.GUI.Dashboard
{
    partial class InformationRoom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InformationRoom));
            this.panel3 = new System.Windows.Forms.Panel();
            this.bt_save = new Guna.UI.WinForms.GunaButton();
            this.bt_out = new Guna.UI.WinForms.GunaButton();
            this.bt_choose = new Guna.UI.WinForms.GunaButton();
            this.ccb_Trangthai = new Guna.UI.WinForms.GunaComboBox();
            this.tb_GiaTheoNgay = new Guna.UI.WinForms.GunaTextBox();
            this.tb_GiaTheoGio = new Guna.UI.WinForms.GunaTextBox();
            this.tb_SoPh = new Guna.UI.WinForms.GunaTextBox();
            this.tb_Succhua = new Guna.UI.WinForms.GunaTextBox();
            this.tb_LoaiPh = new Guna.UI.WinForms.GunaTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.panel3.Controls.Add(this.bt_save);
            this.panel3.Controls.Add(this.bt_out);
            this.panel3.Controls.Add(this.bt_choose);
            this.panel3.Controls.Add(this.ccb_Trangthai);
            this.panel3.Controls.Add(this.tb_GiaTheoNgay);
            this.panel3.Controls.Add(this.tb_GiaTheoGio);
            this.panel3.Controls.Add(this.tb_SoPh);
            this.panel3.Controls.Add(this.tb_Succhua);
            this.panel3.Controls.Add(this.tb_LoaiPh);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(403, 452);
            this.panel3.TabIndex = 1;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // bt_save
            // 
            this.bt_save.AnimationHoverSpeed = 0.07F;
            this.bt_save.AnimationSpeed = 0.03F;
            this.bt_save.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.bt_save.BorderColor = System.Drawing.Color.Black;
            this.bt_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_save.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_save.ForeColor = System.Drawing.Color.White;
            this.bt_save.Image = null;
            this.bt_save.ImageSize = new System.Drawing.Size(20, 20);
            this.bt_save.Location = new System.Drawing.Point(331, 297);
            this.bt_save.Name = "bt_save";
            this.bt_save.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.bt_save.OnHoverBorderColor = System.Drawing.Color.Black;
            this.bt_save.OnHoverForeColor = System.Drawing.Color.White;
            this.bt_save.OnHoverImage = null;
            this.bt_save.OnPressedColor = System.Drawing.Color.Black;
            this.bt_save.Radius = 15;
            this.bt_save.Size = new System.Drawing.Size(60, 35);
            this.bt_save.TabIndex = 4;
            this.bt_save.Text = "Lưu";
            this.bt_save.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.bt_save.Click += new System.EventHandler(this.bt_save_Click);
            // 
            // bt_out
            // 
            this.bt_out.AnimationHoverSpeed = 0.07F;
            this.bt_out.AnimationSpeed = 0.03F;
            this.bt_out.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.bt_out.BorderColor = System.Drawing.Color.Black;
            this.bt_out.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_out.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_out.ForeColor = System.Drawing.Color.White;
            this.bt_out.Image = null;
            this.bt_out.ImageSize = new System.Drawing.Size(20, 20);
            this.bt_out.Location = new System.Drawing.Point(20, 388);
            this.bt_out.Name = "bt_out";
            this.bt_out.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.bt_out.OnHoverBorderColor = System.Drawing.Color.Black;
            this.bt_out.OnHoverForeColor = System.Drawing.Color.White;
            this.bt_out.OnHoverImage = null;
            this.bt_out.OnPressedColor = System.Drawing.Color.Black;
            this.bt_out.Radius = 15;
            this.bt_out.Size = new System.Drawing.Size(157, 52);
            this.bt_out.TabIndex = 2;
            this.bt_out.Text = "Thoát";
            this.bt_out.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.bt_out.Click += new System.EventHandler(this.bt_out_Click);
            // 
            // bt_choose
            // 
            this.bt_choose.AnimationHoverSpeed = 0.07F;
            this.bt_choose.AnimationSpeed = 0.03F;
            this.bt_choose.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(167)))), ((int)(((byte)(112)))));
            this.bt_choose.BorderColor = System.Drawing.Color.Black;
            this.bt_choose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_choose.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_choose.ForeColor = System.Drawing.Color.White;
            this.bt_choose.Image = null;
            this.bt_choose.ImageSize = new System.Drawing.Size(20, 20);
            this.bt_choose.Location = new System.Drawing.Point(231, 388);
            this.bt_choose.Name = "bt_choose";
            this.bt_choose.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(129)))), ((int)(((byte)(87)))));
            this.bt_choose.OnHoverBorderColor = System.Drawing.Color.Black;
            this.bt_choose.OnHoverForeColor = System.Drawing.Color.White;
            this.bt_choose.OnHoverImage = null;
            this.bt_choose.OnPressedColor = System.Drawing.Color.Black;
            this.bt_choose.Radius = 15;
            this.bt_choose.Size = new System.Drawing.Size(157, 52);
            this.bt_choose.TabIndex = 2;
            this.bt_choose.Text = "Chọn";
            this.bt_choose.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.bt_choose.Click += new System.EventHandler(this.bt_choose_Click);
            // 
            // ccb_Trangthai
            // 
            this.ccb_Trangthai.BackColor = System.Drawing.Color.Transparent;
            this.ccb_Trangthai.BaseColor = System.Drawing.Color.White;
            this.ccb_Trangthai.BorderColor = System.Drawing.Color.Silver;
            this.ccb_Trangthai.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ccb_Trangthai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ccb_Trangthai.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ccb_Trangthai.ForeColor = System.Drawing.Color.Black;
            this.ccb_Trangthai.FormattingEnabled = true;
            this.ccb_Trangthai.Location = new System.Drawing.Point(174, 297);
            this.ccb_Trangthai.Name = "ccb_Trangthai";
            this.ccb_Trangthai.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ccb_Trangthai.OnHoverItemForeColor = System.Drawing.Color.White;
            this.ccb_Trangthai.Radius = 15;
            this.ccb_Trangthai.Size = new System.Drawing.Size(151, 35);
            this.ccb_Trangthai.TabIndex = 3;
            // 
            // tb_GiaTheoNgay
            // 
            this.tb_GiaTheoNgay.BaseColor = System.Drawing.Color.White;
            this.tb_GiaTheoNgay.BorderColor = System.Drawing.Color.Silver;
            this.tb_GiaTheoNgay.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_GiaTheoNgay.FocusedBaseColor = System.Drawing.Color.White;
            this.tb_GiaTheoNgay.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tb_GiaTheoNgay.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.tb_GiaTheoNgay.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_GiaTheoNgay.Location = new System.Drawing.Point(174, 254);
            this.tb_GiaTheoNgay.Name = "tb_GiaTheoNgay";
            this.tb_GiaTheoNgay.PasswordChar = '\0';
            this.tb_GiaTheoNgay.Radius = 15;
            this.tb_GiaTheoNgay.ReadOnly = true;
            this.tb_GiaTheoNgay.Size = new System.Drawing.Size(214, 37);
            this.tb_GiaTheoNgay.TabIndex = 2;
            this.tb_GiaTheoNgay.Text = "Thường";
            // 
            // tb_GiaTheoGio
            // 
            this.tb_GiaTheoGio.BaseColor = System.Drawing.Color.White;
            this.tb_GiaTheoGio.BorderColor = System.Drawing.Color.Silver;
            this.tb_GiaTheoGio.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_GiaTheoGio.FocusedBaseColor = System.Drawing.Color.White;
            this.tb_GiaTheoGio.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tb_GiaTheoGio.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.tb_GiaTheoGio.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_GiaTheoGio.Location = new System.Drawing.Point(174, 211);
            this.tb_GiaTheoGio.Name = "tb_GiaTheoGio";
            this.tb_GiaTheoGio.PasswordChar = '\0';
            this.tb_GiaTheoGio.Radius = 15;
            this.tb_GiaTheoGio.ReadOnly = true;
            this.tb_GiaTheoGio.Size = new System.Drawing.Size(214, 37);
            this.tb_GiaTheoGio.TabIndex = 2;
            this.tb_GiaTheoGio.Text = "Thường";
            // 
            // tb_SoPh
            // 
            this.tb_SoPh.BaseColor = System.Drawing.Color.White;
            this.tb_SoPh.BorderColor = System.Drawing.Color.Silver;
            this.tb_SoPh.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_SoPh.FocusedBaseColor = System.Drawing.Color.White;
            this.tb_SoPh.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tb_SoPh.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.tb_SoPh.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_SoPh.Location = new System.Drawing.Point(174, 76);
            this.tb_SoPh.Name = "tb_SoPh";
            this.tb_SoPh.PasswordChar = '\0';
            this.tb_SoPh.Radius = 15;
            this.tb_SoPh.ReadOnly = true;
            this.tb_SoPh.Size = new System.Drawing.Size(214, 37);
            this.tb_SoPh.TabIndex = 2;
            this.tb_SoPh.Text = "Thường";
            // 
            // tb_Succhua
            // 
            this.tb_Succhua.BaseColor = System.Drawing.Color.White;
            this.tb_Succhua.BorderColor = System.Drawing.Color.Silver;
            this.tb_Succhua.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Succhua.FocusedBaseColor = System.Drawing.Color.White;
            this.tb_Succhua.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tb_Succhua.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.tb_Succhua.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Succhua.Location = new System.Drawing.Point(174, 165);
            this.tb_Succhua.Name = "tb_Succhua";
            this.tb_Succhua.PasswordChar = '\0';
            this.tb_Succhua.Radius = 15;
            this.tb_Succhua.ReadOnly = true;
            this.tb_Succhua.Size = new System.Drawing.Size(214, 37);
            this.tb_Succhua.TabIndex = 2;
            this.tb_Succhua.Text = "Thường";
            // 
            // tb_LoaiPh
            // 
            this.tb_LoaiPh.BaseColor = System.Drawing.Color.White;
            this.tb_LoaiPh.BorderColor = System.Drawing.Color.Silver;
            this.tb_LoaiPh.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_LoaiPh.FocusedBaseColor = System.Drawing.Color.White;
            this.tb_LoaiPh.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tb_LoaiPh.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.tb_LoaiPh.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_LoaiPh.Location = new System.Drawing.Point(174, 119);
            this.tb_LoaiPh.Name = "tb_LoaiPh";
            this.tb_LoaiPh.PasswordChar = '\0';
            this.tb_LoaiPh.Radius = 15;
            this.tb_LoaiPh.ReadOnly = true;
            this.tb_LoaiPh.Size = new System.Drawing.Size(214, 37);
            this.tb_LoaiPh.TabIndex = 2;
            this.tb_LoaiPh.Text = "Thường";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(3, 254);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(155, 28);
            this.label10.TabIndex = 1;
            this.label10.Text = "Giá theo ngày: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(3, 211);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(140, 28);
            this.label9.TabIndex = 1;
            this.label9.Text = "Giá theo giờ: ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(3, 297);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 28);
            this.label11.TabIndex = 1;
            this.label11.Text = "Trạng thái:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Số phòng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(3, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sức chứa:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(3, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 28);
            this.label8.TabIndex = 1;
            this.label8.Text = "Loại phòng:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(85)))), ((int)(((byte)(133)))));
            this.panel4.Controls.Add(this.label7);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(402, 57);
            this.panel4.TabIndex = 0;
            this.panel4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.head_panel_MouseDown);
            this.panel4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.head_panel_MouseMove);
            this.panel4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.head_panel_MouseUp);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(70, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(256, 41);
            this.label7.TabIndex = 2;
            this.label7.Text = "Thông tin phòng";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 10;
            this.gunaElipse1.TargetControl = this;
            // 
            // InformationRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 452);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InformationRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InformationRoom";
            this.Load += new System.EventHandler(this.InformationRoom_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private Guna.UI.WinForms.GunaTextBox tb_GiaTheoNgay;
        private Guna.UI.WinForms.GunaTextBox tb_GiaTheoGio;
        private Guna.UI.WinForms.GunaTextBox tb_LoaiPh;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label7;
        private Guna.UI.WinForms.GunaTextBox tb_SoPh;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaTextBox tb_Succhua;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaComboBox ccb_Trangthai;
        public Guna.UI.WinForms.GunaButton bt_choose;
        private Guna.UI.WinForms.GunaButton bt_out;
        private Guna.UI.WinForms.GunaButton bt_save;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
    }
}