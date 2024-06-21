namespace Hobook_Software.GUI
{
    partial class Login_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_form));
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.head_panel = new Guna.UI.WinForms.GunaElipsePanel();
            this.bt_off = new Guna.UI.WinForms.GunaButton();
            this.bt_minimize = new Guna.UI.WinForms.GunaButton();
            this.gunaCircleButton1 = new Guna.UI.WinForms.GunaCircleButton();
            this.lb_logo = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bt_show = new System.Windows.Forms.Button();
            this.tb_acc = new System.Windows.Forms.TextBox();
            this.tb_pass = new System.Windows.Forms.TextBox();
            this.bt_login = new Guna.UI.WinForms.GunaButton();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.head_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 10;
            this.gunaElipse1.TargetControl = this;
            // 
            // head_panel
            // 
            this.head_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.head_panel.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.head_panel.Controls.Add(this.bt_off);
            this.head_panel.Controls.Add(this.bt_minimize);
            this.head_panel.Controls.Add(this.gunaCircleButton1);
            this.head_panel.Controls.Add(this.lb_logo);
            this.head_panel.Location = new System.Drawing.Point(0, 0);
            this.head_panel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.head_panel.Name = "head_panel";
            this.head_panel.Radius = 10;
            this.head_panel.Size = new System.Drawing.Size(601, 34);
            this.head_panel.TabIndex = 1;
            this.head_panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.head_panel_MouseDown);
            this.head_panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.head_panel_MouseMove);
            this.head_panel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.head_panel_MouseUp);
            // 
            // bt_off
            // 
            this.bt_off.AnimationHoverSpeed = 0.07F;
            this.bt_off.AnimationSpeed = 0.03F;
            this.bt_off.BaseColor = System.Drawing.Color.Transparent;
            this.bt_off.BorderColor = System.Drawing.Color.Black;
            this.bt_off.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bt_off.ForeColor = System.Drawing.Color.White;
            this.bt_off.Image = global::Hobook_Software.Properties.Resources.x_letter_256x256;
            this.bt_off.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.bt_off.ImageSize = new System.Drawing.Size(16, 16);
            this.bt_off.Location = new System.Drawing.Point(555, 0);
            this.bt_off.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_off.Name = "bt_off";
            this.bt_off.OnHoverBaseColor = System.Drawing.Color.Red;
            this.bt_off.OnHoverBorderColor = System.Drawing.Color.Black;
            this.bt_off.OnHoverForeColor = System.Drawing.Color.White;
            this.bt_off.OnHoverImage = null;
            this.bt_off.OnPressedColor = System.Drawing.Color.Black;
            this.bt_off.Size = new System.Drawing.Size(35, 34);
            this.bt_off.TabIndex = 2;
            this.bt_off.Click += new System.EventHandler(this.bt_off_Click);
            // 
            // bt_minimize
            // 
            this.bt_minimize.AnimationHoverSpeed = 0.07F;
            this.bt_minimize.AnimationSpeed = 0.03F;
            this.bt_minimize.BaseColor = System.Drawing.Color.Transparent;
            this.bt_minimize.BorderColor = System.Drawing.Color.Black;
            this.bt_minimize.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bt_minimize.ForeColor = System.Drawing.Color.White;
            this.bt_minimize.Image = global::Hobook_Software.Properties.Resources.minus_256x43;
            this.bt_minimize.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.bt_minimize.ImageSize = new System.Drawing.Size(20, 3);
            this.bt_minimize.Location = new System.Drawing.Point(511, 0);
            this.bt_minimize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_minimize.Name = "bt_minimize";
            this.bt_minimize.OnHoverBaseColor = System.Drawing.Color.Silver;
            this.bt_minimize.OnHoverBorderColor = System.Drawing.Color.Black;
            this.bt_minimize.OnHoverForeColor = System.Drawing.Color.White;
            this.bt_minimize.OnHoverImage = null;
            this.bt_minimize.OnPressedColor = System.Drawing.Color.Black;
            this.bt_minimize.Size = new System.Drawing.Size(35, 34);
            this.bt_minimize.TabIndex = 2;
            this.bt_minimize.Click += new System.EventHandler(this.bt_minimize_Click);
            // 
            // gunaCircleButton1
            // 
            this.gunaCircleButton1.AnimationHoverSpeed = 0.07F;
            this.gunaCircleButton1.AnimationSpeed = 0.03F;
            this.gunaCircleButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gunaCircleButton1.BaseColor = System.Drawing.Color.Transparent;
            this.gunaCircleButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaCircleButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaCircleButton1.ForeColor = System.Drawing.Color.White;
            this.gunaCircleButton1.Image = global::Hobook_Software.Properties.Resources.Artboard4;
            this.gunaCircleButton1.ImageSize = new System.Drawing.Size(15, 15);
            this.gunaCircleButton1.Location = new System.Drawing.Point(12, 2);
            this.gunaCircleButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gunaCircleButton1.Name = "gunaCircleButton1";
            this.gunaCircleButton1.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.gunaCircleButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaCircleButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaCircleButton1.OnHoverImage = null;
            this.gunaCircleButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaCircleButton1.Size = new System.Drawing.Size(24, 28);
            this.gunaCircleButton1.TabIndex = 2;
            // 
            // lb_logo
            // 
            this.lb_logo.AutoSize = true;
            this.lb_logo.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_logo.Location = new System.Drawing.Point(39, 5);
            this.lb_logo.Name = "lb_logo";
            this.lb_logo.Size = new System.Drawing.Size(74, 23);
            this.lb_logo.TabIndex = 0;
            this.lb_logo.Text = "Hobook";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(143)))), ((int)(((byte)(175)))));
            this.gunaLabel1.Location = new System.Drawing.Point(163, 48);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(263, 81);
            this.gunaLabel1.TabIndex = 3;
            this.gunaLabel1.Text = "Hobook";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(152, 129);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(293, 38);
            this.gunaLabel2.TabIndex = 4;
            this.gunaLabel2.Text = "Đăng nhập tài khoản";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.Location = new System.Drawing.Point(25, 402);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(108, 28);
            this.gunaLabel3.TabIndex = 4;
            this.gunaLabel3.Text = "Tài khoản:";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.Location = new System.Drawing.Point(25, 469);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(107, 28);
            this.gunaLabel4.TabIndex = 4;
            this.gunaLabel4.Text = "Mật khẩu:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Hobook_Software.Properties.Resources.people_256x230;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(229, 226);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 153);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // bt_show
            // 
            this.bt_show.BackColor = System.Drawing.Color.Transparent;
            this.bt_show.Font = new System.Drawing.Font("Segoe UI", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_show.Location = new System.Drawing.Point(511, 469);
            this.bt_show.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_show.Name = "bt_show";
            this.bt_show.Size = new System.Drawing.Size(49, 28);
            this.bt_show.TabIndex = 9;
            this.bt_show.Text = "Hiện";
            this.bt_show.UseVisualStyleBackColor = false;
            this.bt_show.Click += new System.EventHandler(this.bt_show_Click);
            // 
            // tb_acc
            // 
            this.tb_acc.BackColor = System.Drawing.Color.White;
            this.tb_acc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_acc.Location = new System.Drawing.Point(139, 402);
            this.tb_acc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_acc.Name = "tb_acc";
            this.tb_acc.Size = new System.Drawing.Size(424, 34);
            this.tb_acc.TabIndex = 0;
            this.tb_acc.Tag = "";
            this.tb_acc.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tb_pass
            // 
            this.tb_pass.BackColor = System.Drawing.Color.White;
            this.tb_pass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_pass.Location = new System.Drawing.Point(139, 466);
            this.tb_pass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_pass.Name = "tb_pass";
            this.tb_pass.Size = new System.Drawing.Size(424, 34);
            this.tb_pass.TabIndex = 1;
            this.tb_pass.Tag = "";
            this.tb_pass.UseSystemPasswordChar = true;
            this.tb_pass.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // bt_login
            // 
            this.bt_login.AnimationHoverSpeed = 0.07F;
            this.bt_login.AnimationSpeed = 0.03F;
            this.bt_login.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(143)))), ((int)(((byte)(175)))));
            this.bt_login.BorderColor = System.Drawing.Color.Black;
            this.bt_login.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_login.ForeColor = System.Drawing.Color.White;
            this.bt_login.Image = null;
            this.bt_login.ImageSize = new System.Drawing.Size(20, 20);
            this.bt_login.Location = new System.Drawing.Point(29, 527);
            this.bt_login.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_login.Name = "bt_login";
            this.bt_login.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(109)))), ((int)(((byte)(130)))));
            this.bt_login.OnHoverBorderColor = System.Drawing.Color.Black;
            this.bt_login.OnHoverForeColor = System.Drawing.Color.White;
            this.bt_login.OnHoverImage = null;
            this.bt_login.OnPressedColor = System.Drawing.Color.Black;
            this.bt_login.Size = new System.Drawing.Size(532, 59);
            this.bt_login.TabIndex = 11;
            this.bt_login.Text = "Đăng nhập";
            this.bt_login.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.bt_login.Click += new System.EventHandler(this.bt_login_Click);
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel5.Location = new System.Drawing.Point(117, 768);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(374, 23);
            this.gunaLabel5.TabIndex = 4;
            this.gunaLabel5.Text = "Đồ án quản lý đặt phòng khách sạn - Nhóm 4";
            // 
            // Login_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(600, 800);
            this.Controls.Add(this.bt_login);
            this.Controls.Add(this.bt_show);
            this.Controls.Add(this.tb_pass);
            this.Controls.Add(this.tb_acc);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gunaLabel5);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.head_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Login_form";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_form_Load);
            this.head_panel.ResumeLayout(false);
            this.head_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaElipsePanel head_panel;
        private Guna.UI.WinForms.GunaLabel lb_logo;
        private Guna.UI.WinForms.GunaButton bt_minimize;
        private Guna.UI.WinForms.GunaButton bt_off;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private System.Windows.Forms.Button bt_show;
        private Guna.UI.WinForms.GunaCircleButton gunaCircleButton1;
        public System.Windows.Forms.TextBox tb_acc;
        public System.Windows.Forms.TextBox tb_pass;
        private Guna.UI.WinForms.GunaButton bt_login;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
    }
}