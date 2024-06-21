namespace Hobook_Software.GUI.Dashboard
{
    partial class UC_Account
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.panel_account = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbb_vaitro = new Guna.UI.WinForms.GunaComboBox();
            this.tb_cccd = new Guna.UI.WinForms.GunaTextBox();
            this.tb_matkhau2 = new Guna.UI.WinForms.GunaTextBox();
            this.tb_matkhau = new Guna.UI.WinForms.GunaTextBox();
            this.tb_sdt = new Guna.UI.WinForms.GunaTextBox();
            this.tb_taikhoan = new Guna.UI.WinForms.GunaTextBox();
            this.tb_name = new Guna.UI.WinForms.GunaTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_add = new Guna.UI.WinForms.GunaButton();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn4 = new System.Windows.Forms.DataGridViewImageColumn();
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
            this.panel_account.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_customer)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 10;
            this.gunaElipse1.TargetControl = this;
            // 
            // panel_account
            // 
            this.panel_account.AutoScroll = true;
            this.panel_account.BackColor = System.Drawing.Color.AliceBlue;
            this.panel_account.Controls.Add(this.dg_customer);
            this.panel_account.Controls.Add(this.panel1);
            this.panel_account.Location = new System.Drawing.Point(3, 17);
            this.panel_account.Name = "panel_account";
            this.panel_account.Size = new System.Drawing.Size(1173, 743);
            this.panel_account.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.cbb_vaitro);
            this.panel1.Controls.Add(this.tb_cccd);
            this.panel1.Controls.Add(this.tb_matkhau2);
            this.panel1.Controls.Add(this.tb_matkhau);
            this.panel1.Controls.Add(this.tb_sdt);
            this.panel1.Controls.Add(this.tb_taikhoan);
            this.panel1.Controls.Add(this.tb_name);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.bt_add);
            this.panel1.Location = new System.Drawing.Point(15, 491);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1141, 237);
            this.panel1.TabIndex = 10;
            // 
            // cbb_vaitro
            // 
            this.cbb_vaitro.BackColor = System.Drawing.Color.Transparent;
            this.cbb_vaitro.BaseColor = System.Drawing.Color.White;
            this.cbb_vaitro.BorderColor = System.Drawing.Color.Silver;
            this.cbb_vaitro.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbb_vaitro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_vaitro.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbb_vaitro.ForeColor = System.Drawing.Color.Black;
            this.cbb_vaitro.FormattingEnabled = true;
            this.cbb_vaitro.Location = new System.Drawing.Point(964, 21);
            this.cbb_vaitro.Name = "cbb_vaitro";
            this.cbb_vaitro.OnHoverItemBaseColor = System.Drawing.Color.SteelBlue;
            this.cbb_vaitro.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbb_vaitro.Radius = 10;
            this.cbb_vaitro.Size = new System.Drawing.Size(160, 31);
            this.cbb_vaitro.TabIndex = 6;
            // 
            // tb_cccd
            // 
            this.tb_cccd.BaseColor = System.Drawing.Color.White;
            this.tb_cccd.BorderColor = System.Drawing.Color.Silver;
            this.tb_cccd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_cccd.FocusedBaseColor = System.Drawing.Color.White;
            this.tb_cccd.FocusedBorderColor = System.Drawing.Color.SteelBlue;
            this.tb_cccd.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.tb_cccd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_cccd.Location = new System.Drawing.Point(104, 152);
            this.tb_cccd.Name = "tb_cccd";
            this.tb_cccd.PasswordChar = '\0';
            this.tb_cccd.Radius = 10;
            this.tb_cccd.Size = new System.Drawing.Size(255, 32);
            this.tb_cccd.TabIndex = 2;
            // 
            // tb_matkhau2
            // 
            this.tb_matkhau2.BaseColor = System.Drawing.Color.White;
            this.tb_matkhau2.BorderColor = System.Drawing.Color.Silver;
            this.tb_matkhau2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_matkhau2.FocusedBaseColor = System.Drawing.Color.White;
            this.tb_matkhau2.FocusedBorderColor = System.Drawing.Color.SteelBlue;
            this.tb_matkhau2.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.tb_matkhau2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_matkhau2.Location = new System.Drawing.Point(588, 152);
            this.tb_matkhau2.Name = "tb_matkhau2";
            this.tb_matkhau2.PasswordChar = '●';
            this.tb_matkhau2.Radius = 10;
            this.tb_matkhau2.Size = new System.Drawing.Size(255, 32);
            this.tb_matkhau2.TabIndex = 5;
            this.tb_matkhau2.UseSystemPasswordChar = true;
            // 
            // tb_matkhau
            // 
            this.tb_matkhau.BaseColor = System.Drawing.Color.White;
            this.tb_matkhau.BorderColor = System.Drawing.Color.Silver;
            this.tb_matkhau.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_matkhau.FocusedBaseColor = System.Drawing.Color.White;
            this.tb_matkhau.FocusedBorderColor = System.Drawing.Color.SteelBlue;
            this.tb_matkhau.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.tb_matkhau.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_matkhau.Location = new System.Drawing.Point(587, 81);
            this.tb_matkhau.Name = "tb_matkhau";
            this.tb_matkhau.PasswordChar = '●';
            this.tb_matkhau.Radius = 10;
            this.tb_matkhau.Size = new System.Drawing.Size(255, 32);
            this.tb_matkhau.TabIndex = 4;
            this.tb_matkhau.UseSystemPasswordChar = true;
            // 
            // tb_sdt
            // 
            this.tb_sdt.BaseColor = System.Drawing.Color.White;
            this.tb_sdt.BorderColor = System.Drawing.Color.Silver;
            this.tb_sdt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_sdt.FocusedBaseColor = System.Drawing.Color.White;
            this.tb_sdt.FocusedBorderColor = System.Drawing.Color.SteelBlue;
            this.tb_sdt.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.tb_sdt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_sdt.Location = new System.Drawing.Point(104, 81);
            this.tb_sdt.Name = "tb_sdt";
            this.tb_sdt.PasswordChar = '\0';
            this.tb_sdt.Radius = 10;
            this.tb_sdt.Size = new System.Drawing.Size(255, 32);
            this.tb_sdt.TabIndex = 1;
            // 
            // tb_taikhoan
            // 
            this.tb_taikhoan.BaseColor = System.Drawing.Color.White;
            this.tb_taikhoan.BorderColor = System.Drawing.Color.Silver;
            this.tb_taikhoan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_taikhoan.FocusedBaseColor = System.Drawing.Color.White;
            this.tb_taikhoan.FocusedBorderColor = System.Drawing.Color.SteelBlue;
            this.tb_taikhoan.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.tb_taikhoan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_taikhoan.Location = new System.Drawing.Point(587, 17);
            this.tb_taikhoan.Name = "tb_taikhoan";
            this.tb_taikhoan.PasswordChar = '\0';
            this.tb_taikhoan.Radius = 10;
            this.tb_taikhoan.Size = new System.Drawing.Size(255, 32);
            this.tb_taikhoan.TabIndex = 3;
            // 
            // tb_name
            // 
            this.tb_name.BaseColor = System.Drawing.Color.White;
            this.tb_name.BorderColor = System.Drawing.Color.Silver;
            this.tb_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_name.FocusedBaseColor = System.Drawing.Color.White;
            this.tb_name.FocusedBorderColor = System.Drawing.Color.SteelBlue;
            this.tb_name.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.tb_name.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_name.Location = new System.Drawing.Point(104, 17);
            this.tb_name.Name = "tb_name";
            this.tb_name.PasswordChar = '\0';
            this.tb_name.Radius = 10;
            this.tb_name.Size = new System.Drawing.Size(255, 32);
            this.tb_name.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "CCCD:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(385, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(192, 28);
            this.label6.TabIndex = 2;
            this.label6.Text = "Nhập lại mật khẩu:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(863, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 28);
            this.label7.TabIndex = 2;
            this.label7.Text = "Vai trò:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(384, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 28);
            this.label5.TabIndex = 2;
            this.label5.Text = "Mật khẩu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "SĐT:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(384, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 28);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tài khoản:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Họ tên:";
            // 
            // bt_add
            // 
            this.bt_add.AnimationHoverSpeed = 0.07F;
            this.bt_add.AnimationSpeed = 0.03F;
            this.bt_add.BaseColor = System.Drawing.Color.DodgerBlue;
            this.bt_add.BorderColor = System.Drawing.Color.Black;
            this.bt_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_add.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_add.ForeColor = System.Drawing.Color.White;
            this.bt_add.Image = null;
            this.bt_add.ImageSize = new System.Drawing.Size(20, 20);
            this.bt_add.Location = new System.Drawing.Point(964, 182);
            this.bt_add.Name = "bt_add";
            this.bt_add.OnHoverBaseColor = System.Drawing.Color.RoyalBlue;
            this.bt_add.OnHoverBorderColor = System.Drawing.Color.Black;
            this.bt_add.OnHoverForeColor = System.Drawing.Color.White;
            this.bt_add.OnHoverImage = null;
            this.bt_add.OnPressedColor = System.Drawing.Color.Black;
            this.bt_add.Radius = 10;
            this.bt_add.Size = new System.Drawing.Size(160, 42);
            this.bt_add.TabIndex = 7;
            this.bt_add.Text = "Thêm";
            this.bt_add.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.bt_add.Click += new System.EventHandler(this.bt_add_Click);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Width = 125;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.dataGridViewImageColumn2.MinimumWidth = 6;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            this.dataGridViewImageColumn2.Width = 125;
            // 
            // dataGridViewImageColumn3
            // 
            this.dataGridViewImageColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn3.HeaderText = "";
            this.dataGridViewImageColumn3.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.dataGridViewImageColumn3.MinimumWidth = 6;
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            this.dataGridViewImageColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn3.Width = 125;
            // 
            // dataGridViewImageColumn4
            // 
            this.dataGridViewImageColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn4.HeaderText = "";
            this.dataGridViewImageColumn4.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.dataGridViewImageColumn4.MinimumWidth = 6;
            this.dataGridViewImageColumn4.Name = "dataGridViewImageColumn4";
            this.dataGridViewImageColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn4.Width = 125;
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
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.dg_customer.Location = new System.Drawing.Point(15, 3);
            this.dg_customer.Name = "dg_customer";
            this.dg_customer.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dg_customer.RowHeadersVisible = false;
            this.dg_customer.RowHeadersWidth = 51;
            this.dg_customer.RowTemplate.Height = 24;
            this.dg_customer.Size = new System.Drawing.Size(1141, 482);
            this.dg_customer.TabIndex = 11;
            this.dg_customer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_customer_CellContentClick);
            this.dg_customer.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_customer_CellEndEdit);
            this.dg_customer.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_customer_CellEnter);
            this.dg_customer.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_customer_CellLeave);
            // 
            // STT
            // 
            this.STT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.STT.DataPropertyName = "STT";
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.Width = 67;
            // 
            // hoten
            // 
            this.hoten.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.hoten.DataPropertyName = "Họ tên";
            this.hoten.HeaderText = "Họ tên";
            this.hoten.MinimumWidth = 6;
            this.hoten.Name = "hoten";
            // 
            // lienlac
            // 
            this.lienlac.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.lienlac.DataPropertyName = "Liên lạc";
            this.lienlac.HeaderText = "Liên lạc";
            this.lienlac.MinimumWidth = 6;
            this.lienlac.Name = "lienlac";
            // 
            // cccd
            // 
            this.cccd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cccd.DataPropertyName = "CCCD";
            this.cccd.HeaderText = "CCCD";
            this.cccd.MinimumWidth = 6;
            this.cccd.Name = "cccd";
            // 
            // taikhoan
            // 
            this.taikhoan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.taikhoan.DataPropertyName = "Tài khoản";
            this.taikhoan.HeaderText = "Tài khoản";
            this.taikhoan.MinimumWidth = 6;
            this.taikhoan.Name = "taikhoan";
            // 
            // matkhau
            // 
            this.matkhau.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.matkhau.DataPropertyName = "Mật khẩu";
            this.matkhau.HeaderText = "Mật khẩu";
            this.matkhau.MinimumWidth = 6;
            this.matkhau.Name = "matkhau";
            // 
            // vaitro
            // 
            this.vaitro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.vaitro.DataPropertyName = "Vai trò";
            this.vaitro.HeaderText = "Vai trò";
            this.vaitro.MinimumWidth = 6;
            this.vaitro.Name = "vaitro";
            // 
            // Fix
            // 
            this.Fix.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Fix.HeaderText = "Sửa";
            this.Fix.MinimumWidth = 6;
            this.Fix.Name = "Fix";
            this.Fix.ReadOnly = true;
            this.Fix.Width = 44;
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Delete.HeaderText = "Xóa";
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Width = 44;
            // 
            // UC_Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel_account);
            this.Name = "UC_Account";
            this.Size = new System.Drawing.Size(1179, 782);
            this.Load += new System.EventHandler(this.UC_Account_Load);
            this.panel_account.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_customer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private System.Windows.Forms.Panel panel_account;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn4;
        private Guna.UI.WinForms.GunaButton bt_add;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaTextBox tb_name;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaTextBox tb_cccd;
        private Guna.UI.WinForms.GunaTextBox tb_sdt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaTextBox tb_matkhau2;
        private Guna.UI.WinForms.GunaTextBox tb_matkhau;
        private Guna.UI.WinForms.GunaTextBox tb_taikhoan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private Guna.UI.WinForms.GunaComboBox cbb_vaitro;
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
