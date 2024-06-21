namespace Hobook_Software.GUI.Dashboard
{
    partial class UC_BookRoom
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_roomchoose = new System.Windows.Forms.Panel();
            this.tb_ngaysinh = new Guna.UI.WinForms.GunaTextBox();
            this.tb_sdt = new Guna.UI.WinForms.GunaTextBox();
            this.tb_diachi = new Guna.UI.WinForms.GunaTextBox();
            this.tb_hoten = new Guna.UI.WinForms.GunaTextBox();
            this.tb_minuteend = new Guna.UI.WinForms.GunaTextBox();
            this.tb_minutestart = new Guna.UI.WinForms.GunaTextBox();
            this.tb_hourend = new Guna.UI.WinForms.GunaTextBox();
            this.tb_hourstart = new Guna.UI.WinForms.GunaTextBox();
            this.tb_cccd = new Guna.UI.WinForms.GunaTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lb_timeend = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lb_timestart = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_datphong = new Guna.UI.WinForms.GunaButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 10;
            this.gunaElipse1.TargetControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(152)))), ((int)(((byte)(198)))));
            this.label1.Location = new System.Drawing.Point(396, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(381, 73);
            this.label1.TabIndex = 3;
            this.label1.Text = "Đặt phòng";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.panel1.Controls.Add(this.panel_roomchoose);
            this.panel1.Controls.Add(this.tb_ngaysinh);
            this.panel1.Controls.Add(this.tb_sdt);
            this.panel1.Controls.Add(this.tb_diachi);
            this.panel1.Controls.Add(this.tb_hoten);
            this.panel1.Controls.Add(this.tb_minuteend);
            this.panel1.Controls.Add(this.tb_minutestart);
            this.panel1.Controls.Add(this.tb_hourend);
            this.panel1.Controls.Add(this.tb_hourstart);
            this.panel1.Controls.Add(this.tb_cccd);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.lb_timeend);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.lb_timestart);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(45, 96);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1089, 539);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel_roomchoose
            // 
            this.panel_roomchoose.AutoScroll = true;
            this.panel_roomchoose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panel_roomchoose.Location = new System.Drawing.Point(594, 123);
            this.panel_roomchoose.Name = "panel_roomchoose";
            this.panel_roomchoose.Size = new System.Drawing.Size(458, 197);
            this.panel_roomchoose.TabIndex = 14;
            // 
            // tb_ngaysinh
            // 
            this.tb_ngaysinh.BaseColor = System.Drawing.Color.White;
            this.tb_ngaysinh.BorderColor = System.Drawing.Color.Gray;
            this.tb_ngaysinh.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_ngaysinh.FocusedBaseColor = System.Drawing.Color.White;
            this.tb_ngaysinh.FocusedBorderColor = System.Drawing.Color.SteelBlue;
            this.tb_ngaysinh.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.tb_ngaysinh.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ngaysinh.Location = new System.Drawing.Point(201, 421);
            this.tb_ngaysinh.Name = "tb_ngaysinh";
            this.tb_ngaysinh.PasswordChar = '\0';
            this.tb_ngaysinh.Radius = 15;
            this.tb_ngaysinh.Size = new System.Drawing.Size(308, 38);
            this.tb_ngaysinh.TabIndex = 11;
            this.tb_ngaysinh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_ngaysinh.TextChanged += new System.EventHandler(this.tb_ngaysinh_TextChanged);
            // 
            // tb_sdt
            // 
            this.tb_sdt.BaseColor = System.Drawing.Color.White;
            this.tb_sdt.BorderColor = System.Drawing.Color.Gray;
            this.tb_sdt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_sdt.FocusedBaseColor = System.Drawing.Color.White;
            this.tb_sdt.FocusedBorderColor = System.Drawing.Color.SteelBlue;
            this.tb_sdt.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.tb_sdt.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_sdt.Location = new System.Drawing.Point(201, 353);
            this.tb_sdt.Name = "tb_sdt";
            this.tb_sdt.PasswordChar = '\0';
            this.tb_sdt.Radius = 15;
            this.tb_sdt.Size = new System.Drawing.Size(308, 38);
            this.tb_sdt.TabIndex = 11;
            this.tb_sdt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_diachi
            // 
            this.tb_diachi.BaseColor = System.Drawing.Color.White;
            this.tb_diachi.BorderColor = System.Drawing.Color.Gray;
            this.tb_diachi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_diachi.FocusedBaseColor = System.Drawing.Color.White;
            this.tb_diachi.FocusedBorderColor = System.Drawing.Color.SteelBlue;
            this.tb_diachi.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.tb_diachi.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_diachi.Location = new System.Drawing.Point(201, 281);
            this.tb_diachi.Name = "tb_diachi";
            this.tb_diachi.PasswordChar = '\0';
            this.tb_diachi.Radius = 15;
            this.tb_diachi.Size = new System.Drawing.Size(308, 38);
            this.tb_diachi.TabIndex = 11;
            this.tb_diachi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_hoten
            // 
            this.tb_hoten.BaseColor = System.Drawing.Color.White;
            this.tb_hoten.BorderColor = System.Drawing.Color.Gray;
            this.tb_hoten.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_hoten.FocusedBaseColor = System.Drawing.Color.White;
            this.tb_hoten.FocusedBorderColor = System.Drawing.Color.SteelBlue;
            this.tb_hoten.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.tb_hoten.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_hoten.Location = new System.Drawing.Point(201, 214);
            this.tb_hoten.Name = "tb_hoten";
            this.tb_hoten.PasswordChar = '\0';
            this.tb_hoten.Radius = 15;
            this.tb_hoten.Size = new System.Drawing.Size(308, 38);
            this.tb_hoten.TabIndex = 11;
            this.tb_hoten.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_minuteend
            // 
            this.tb_minuteend.BaseColor = System.Drawing.Color.White;
            this.tb_minuteend.BorderColor = System.Drawing.Color.Gray;
            this.tb_minuteend.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_minuteend.FocusedBaseColor = System.Drawing.Color.White;
            this.tb_minuteend.FocusedBorderColor = System.Drawing.Color.SteelBlue;
            this.tb_minuteend.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.tb_minuteend.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_minuteend.Location = new System.Drawing.Point(933, 455);
            this.tb_minuteend.Name = "tb_minuteend";
            this.tb_minuteend.PasswordChar = '\0';
            this.tb_minuteend.Radius = 15;
            this.tb_minuteend.Size = new System.Drawing.Size(52, 38);
            this.tb_minuteend.TabIndex = 11;
            this.tb_minuteend.Text = "00";
            this.tb_minuteend.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_minutestart
            // 
            this.tb_minutestart.BaseColor = System.Drawing.Color.White;
            this.tb_minutestart.BorderColor = System.Drawing.Color.Gray;
            this.tb_minutestart.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_minutestart.FocusedBaseColor = System.Drawing.Color.White;
            this.tb_minutestart.FocusedBorderColor = System.Drawing.Color.SteelBlue;
            this.tb_minutestart.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.tb_minutestart.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_minutestart.Location = new System.Drawing.Point(933, 394);
            this.tb_minutestart.Name = "tb_minutestart";
            this.tb_minutestart.PasswordChar = '\0';
            this.tb_minutestart.Radius = 15;
            this.tb_minutestart.Size = new System.Drawing.Size(52, 38);
            this.tb_minutestart.TabIndex = 11;
            this.tb_minutestart.Text = "00";
            this.tb_minutestart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_hourend
            // 
            this.tb_hourend.BaseColor = System.Drawing.Color.White;
            this.tb_hourend.BorderColor = System.Drawing.Color.Gray;
            this.tb_hourend.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_hourend.FocusedBaseColor = System.Drawing.Color.White;
            this.tb_hourend.FocusedBorderColor = System.Drawing.Color.SteelBlue;
            this.tb_hourend.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.tb_hourend.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_hourend.Location = new System.Drawing.Point(819, 455);
            this.tb_hourend.Name = "tb_hourend";
            this.tb_hourend.PasswordChar = '\0';
            this.tb_hourend.Radius = 15;
            this.tb_hourend.Size = new System.Drawing.Size(52, 38);
            this.tb_hourend.TabIndex = 11;
            this.tb_hourend.Text = "12";
            this.tb_hourend.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_hourstart
            // 
            this.tb_hourstart.BaseColor = System.Drawing.Color.White;
            this.tb_hourstart.BorderColor = System.Drawing.Color.Gray;
            this.tb_hourstart.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_hourstart.FocusedBaseColor = System.Drawing.Color.White;
            this.tb_hourstart.FocusedBorderColor = System.Drawing.Color.SteelBlue;
            this.tb_hourstart.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.tb_hourstart.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_hourstart.Location = new System.Drawing.Point(819, 394);
            this.tb_hourstart.Name = "tb_hourstart";
            this.tb_hourstart.PasswordChar = '\0';
            this.tb_hourstart.Radius = 15;
            this.tb_hourstart.Size = new System.Drawing.Size(52, 38);
            this.tb_hourstart.TabIndex = 11;
            this.tb_hourstart.Text = "12";
            this.tb_hourstart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_cccd
            // 
            this.tb_cccd.BaseColor = System.Drawing.Color.White;
            this.tb_cccd.BorderColor = System.Drawing.Color.Gray;
            this.tb_cccd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_cccd.FocusedBaseColor = System.Drawing.Color.White;
            this.tb_cccd.FocusedBorderColor = System.Drawing.Color.SteelBlue;
            this.tb_cccd.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.tb_cccd.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_cccd.Location = new System.Drawing.Point(201, 155);
            this.tb_cccd.Name = "tb_cccd";
            this.tb_cccd.PasswordChar = '\0';
            this.tb_cccd.Radius = 15;
            this.tb_cccd.Size = new System.Drawing.Size(308, 38);
            this.tb_cccd.TabIndex = 11;
            this.tb_cccd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_cccd.TextChanged += new System.EventHandler(this.tb_cccd_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(44, 421);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(164, 38);
            this.label7.TabIndex = 7;
            this.label7.Text = "Ngày sinh: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(44, 353);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 38);
            this.label6.TabIndex = 7;
            this.label6.Text = "SĐT: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(44, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 38);
            this.label5.TabIndex = 7;
            this.label5.Text = "Địa chỉ: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(44, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 38);
            this.label4.TabIndex = 7;
            this.label4.Text = "Họ tên: ";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(991, 460);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(61, 31);
            this.label17.TabIndex = 7;
            this.label17.Text = "Phút";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(587, 455);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 38);
            this.label11.TabIndex = 7;
            this.label11.Text = "Đến:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(991, 399);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(61, 31);
            this.label15.TabIndex = 7;
            this.label15.Text = "Phút";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(877, 460);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(50, 31);
            this.label16.TabIndex = 7;
            this.label16.Text = "Giờ";
            // 
            // lb_timeend
            // 
            this.lb_timeend.AutoSize = true;
            this.lb_timeend.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_timeend.ForeColor = System.Drawing.Color.Black;
            this.lb_timeend.Location = new System.Drawing.Point(671, 460);
            this.lb_timeend.Name = "lb_timeend";
            this.lb_timeend.Size = new System.Drawing.Size(128, 31);
            this.lb_timeend.TabIndex = 7;
            this.lb_timeend.Text = "27/11/2023";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(877, 399);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(50, 31);
            this.label14.TabIndex = 7;
            this.label14.Text = "Giờ";
            // 
            // lb_timestart
            // 
            this.lb_timestart.AutoSize = true;
            this.lb_timestart.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_timestart.ForeColor = System.Drawing.Color.Black;
            this.lb_timestart.Location = new System.Drawing.Point(671, 399);
            this.lb_timestart.Name = "lb_timestart";
            this.lb_timestart.Size = new System.Drawing.Size(128, 31);
            this.lb_timestart.TabIndex = 7;
            this.lb_timestart.Text = "25/11/2023";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(587, 394);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 38);
            this.label10.TabIndex = 7;
            this.label10.Text = "Từ:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(44, 155);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 38);
            this.label8.TabIndex = 7;
            this.label8.Text = "CCCD: ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(552, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2, 458);
            this.panel2.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(152)))), ((int)(((byte)(198)))));
            this.label9.Location = new System.Drawing.Point(588, 353);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(200, 36);
            this.label9.TabIndex = 3;
            this.label9.Text = "Thời gian ở";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(152)))), ((int)(((byte)(198)))));
            this.label3.Location = new System.Drawing.Point(586, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(477, 48);
            this.label3.TabIndex = 3;
            this.label3.Text = "Thông tin phòng đặt";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(152)))), ((int)(((byte)(198)))));
            this.label2.Location = new System.Drawing.Point(17, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(512, 48);
            this.label2.TabIndex = 3;
            this.label2.Text = "Thông tin khách hàng";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bt_datphong
            // 
            this.bt_datphong.AnimationHoverSpeed = 0.07F;
            this.bt_datphong.AnimationSpeed = 0.03F;
            this.bt_datphong.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(163)))), ((int)(((byte)(92)))));
            this.bt_datphong.BorderColor = System.Drawing.Color.Black;
            this.bt_datphong.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_datphong.ForeColor = System.Drawing.Color.White;
            this.bt_datphong.Image = null;
            this.bt_datphong.ImageSize = new System.Drawing.Size(20, 20);
            this.bt_datphong.Location = new System.Drawing.Point(493, 690);
            this.bt_datphong.Name = "bt_datphong";
            this.bt_datphong.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bt_datphong.OnHoverBorderColor = System.Drawing.Color.Black;
            this.bt_datphong.OnHoverForeColor = System.Drawing.Color.White;
            this.bt_datphong.OnHoverImage = null;
            this.bt_datphong.OnPressedColor = System.Drawing.Color.Black;
            this.bt_datphong.Radius = 15;
            this.bt_datphong.Size = new System.Drawing.Size(187, 52);
            this.bt_datphong.TabIndex = 5;
            this.bt_datphong.Text = "Đặt phòng";
            this.bt_datphong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.bt_datphong.Click += new System.EventHandler(this.bt_datphong_Click);
            // 
            // UC_BookRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.Controls.Add(this.bt_datphong);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "UC_BookRoom";
            this.Size = new System.Drawing.Size(1179, 782);
            this.Load += new System.EventHandler(this.UC_BookRoom_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaButton bt_datphong;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaTextBox tb_ngaysinh;
        private Guna.UI.WinForms.GunaTextBox tb_sdt;
        private Guna.UI.WinForms.GunaTextBox tb_diachi;
        private Guna.UI.WinForms.GunaTextBox tb_hoten;
        private Guna.UI.WinForms.GunaTextBox tb_cccd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel_roomchoose;
        private Guna.UI.WinForms.GunaTextBox tb_hourstart;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lb_timeend;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lb_timestart;
        private System.Windows.Forms.Label label10;
        private Guna.UI.WinForms.GunaTextBox tb_minutestart;
        private System.Windows.Forms.Label label15;
        private Guna.UI.WinForms.GunaTextBox tb_minuteend;
        private Guna.UI.WinForms.GunaTextBox tb_hourend;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
    }
}
