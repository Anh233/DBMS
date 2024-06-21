namespace Hobook_Software.GUI.Dashboard
{
    partial class UC_Room
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
            this.panel_buttonRoom = new System.Windows.Forms.Panel();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.bt_sansang = new Guna.UI.WinForms.GunaButton();
            this.bt_dangthue = new Guna.UI.WinForms.GunaButton();
            this.bt_dacoc = new Guna.UI.WinForms.GunaButton();
            this.bt_ban = new Guna.UI.WinForms.GunaButton();
            this.SuspendLayout();
            // 
            // panel_buttonRoom
            // 
            this.panel_buttonRoom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_buttonRoom.AutoScroll = true;
            this.panel_buttonRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.panel_buttonRoom.Location = new System.Drawing.Point(0, 71);
            this.panel_buttonRoom.Name = "panel_buttonRoom";
            this.panel_buttonRoom.Size = new System.Drawing.Size(1176, 708);
            this.panel_buttonRoom.TabIndex = 0;
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 10;
            this.gunaElipse1.TargetControl = this;
            // 
            // bt_sansang
            // 
            this.bt_sansang.AnimationHoverSpeed = 0.07F;
            this.bt_sansang.AnimationSpeed = 0.03F;
            this.bt_sansang.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(129)))), ((int)(((byte)(87)))));
            this.bt_sansang.BorderColor = System.Drawing.Color.Black;
            this.bt_sansang.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_sansang.ForeColor = System.Drawing.Color.White;
            this.bt_sansang.Image = null;
            this.bt_sansang.ImageSize = new System.Drawing.Size(20, 20);
            this.bt_sansang.Location = new System.Drawing.Point(193, 15);
            this.bt_sansang.Name = "bt_sansang";
            this.bt_sansang.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bt_sansang.OnHoverBorderColor = System.Drawing.Color.Black;
            this.bt_sansang.OnHoverForeColor = System.Drawing.Color.White;
            this.bt_sansang.OnHoverImage = null;
            this.bt_sansang.OnPressedColor = System.Drawing.Color.Black;
            this.bt_sansang.Radius = 10;
            this.bt_sansang.Size = new System.Drawing.Size(132, 36);
            this.bt_sansang.TabIndex = 1;
            this.bt_sansang.Text = "Sẵn sàng (0)";
            this.bt_sansang.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.bt_sansang.Click += new System.EventHandler(this.bt_sansang_Click);
            // 
            // bt_dangthue
            // 
            this.bt_dangthue.AnimationHoverSpeed = 0.07F;
            this.bt_dangthue.AnimationSpeed = 0.03F;
            this.bt_dangthue.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(133)))), ((int)(((byte)(151)))));
            this.bt_dangthue.BorderColor = System.Drawing.Color.Black;
            this.bt_dangthue.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_dangthue.ForeColor = System.Drawing.Color.White;
            this.bt_dangthue.Image = null;
            this.bt_dangthue.ImageSize = new System.Drawing.Size(20, 20);
            this.bt_dangthue.Location = new System.Drawing.Point(407, 15);
            this.bt_dangthue.Name = "bt_dangthue";
            this.bt_dangthue.OnHoverBaseColor = System.Drawing.Color.Gray;
            this.bt_dangthue.OnHoverBorderColor = System.Drawing.Color.Black;
            this.bt_dangthue.OnHoverForeColor = System.Drawing.Color.White;
            this.bt_dangthue.OnHoverImage = null;
            this.bt_dangthue.OnPressedColor = System.Drawing.Color.Black;
            this.bt_dangthue.Radius = 10;
            this.bt_dangthue.Size = new System.Drawing.Size(132, 36);
            this.bt_dangthue.TabIndex = 1;
            this.bt_dangthue.Text = "Đang thuê (0)";
            this.bt_dangthue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.bt_dangthue.Click += new System.EventHandler(this.bt_dangthue_Click);
            // 
            // bt_dacoc
            // 
            this.bt_dacoc.AnimationHoverSpeed = 0.07F;
            this.bt_dacoc.AnimationSpeed = 0.03F;
            this.bt_dacoc.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(133)))), ((int)(((byte)(151)))));
            this.bt_dacoc.BorderColor = System.Drawing.Color.Black;
            this.bt_dacoc.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_dacoc.ForeColor = System.Drawing.Color.White;
            this.bt_dacoc.Image = null;
            this.bt_dacoc.ImageSize = new System.Drawing.Size(20, 20);
            this.bt_dacoc.Location = new System.Drawing.Point(623, 15);
            this.bt_dacoc.Name = "bt_dacoc";
            this.bt_dacoc.OnHoverBaseColor = System.Drawing.Color.Gray;
            this.bt_dacoc.OnHoverBorderColor = System.Drawing.Color.Black;
            this.bt_dacoc.OnHoverForeColor = System.Drawing.Color.White;
            this.bt_dacoc.OnHoverImage = null;
            this.bt_dacoc.OnPressedColor = System.Drawing.Color.Black;
            this.bt_dacoc.Radius = 10;
            this.bt_dacoc.Size = new System.Drawing.Size(132, 36);
            this.bt_dacoc.TabIndex = 1;
            this.bt_dacoc.Text = "Đặt trước (0)";
            this.bt_dacoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.bt_dacoc.Click += new System.EventHandler(this.bt_dacoc_Click);
            // 
            // bt_ban
            // 
            this.bt_ban.AnimationHoverSpeed = 0.07F;
            this.bt_ban.AnimationSpeed = 0.03F;
            this.bt_ban.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(133)))), ((int)(((byte)(151)))));
            this.bt_ban.BorderColor = System.Drawing.Color.Black;
            this.bt_ban.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_ban.ForeColor = System.Drawing.Color.White;
            this.bt_ban.Image = null;
            this.bt_ban.ImageSize = new System.Drawing.Size(20, 20);
            this.bt_ban.Location = new System.Drawing.Point(843, 15);
            this.bt_ban.Name = "bt_ban";
            this.bt_ban.OnHoverBaseColor = System.Drawing.Color.Gray;
            this.bt_ban.OnHoverBorderColor = System.Drawing.Color.Black;
            this.bt_ban.OnHoverForeColor = System.Drawing.Color.White;
            this.bt_ban.OnHoverImage = null;
            this.bt_ban.OnPressedColor = System.Drawing.Color.Black;
            this.bt_ban.Radius = 10;
            this.bt_ban.Size = new System.Drawing.Size(132, 36);
            this.bt_ban.TabIndex = 1;
            this.bt_ban.Text = "Bận (0)";
            this.bt_ban.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.bt_ban.Click += new System.EventHandler(this.bt_ban_Click);
            // 
            // UC_Room
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.Controls.Add(this.bt_ban);
            this.Controls.Add(this.bt_dacoc);
            this.Controls.Add(this.bt_dangthue);
            this.Controls.Add(this.bt_sansang);
            this.Controls.Add(this.panel_buttonRoom);
            this.Name = "UC_Room";
            this.Size = new System.Drawing.Size(1179, 782);
            this.Load += new System.EventHandler(this.UC_Room_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_buttonRoom;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaButton bt_sansang;
        private Guna.UI.WinForms.GunaButton bt_dangthue;
        private Guna.UI.WinForms.GunaButton bt_ban;
        private Guna.UI.WinForms.GunaButton bt_dacoc;
    }
}
