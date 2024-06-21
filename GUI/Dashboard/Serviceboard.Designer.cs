namespace Hobook_Software.GUI.Dashboard
{
    partial class Serviceboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Serviceboard));
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.panel_service = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel_move = new System.Windows.Forms.Panel();
            this.bt_another = new Guna.UI.WinForms.GunaButton();
            this.bt_room = new Guna.UI.WinForms.GunaButton();
            this.bt_drink = new Guna.UI.WinForms.GunaButton();
            this.bt_food = new Guna.UI.WinForms.GunaButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_out = new Guna.UI.WinForms.GunaButton();
            this.bt_bookservice = new Guna.UI.WinForms.GunaButton();
            this.panel_serviceadd = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 10;
            this.gunaElipse1.TargetControl = this;
            // 
            // panel_service
            // 
            this.panel_service.AutoScroll = true;
            this.panel_service.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.panel_service.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_service.Location = new System.Drawing.Point(12, 90);
            this.panel_service.Name = "panel_service";
            this.panel_service.Size = new System.Drawing.Size(696, 648);
            this.panel_service.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panel_move);
            this.panel2.Controls.Add(this.bt_another);
            this.panel2.Controls.Add(this.bt_room);
            this.panel2.Controls.Add(this.bt_drink);
            this.panel2.Controls.Add(this.bt_food);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(696, 72);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel_move
            // 
            this.panel_move.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(69)))), ((int)(((byte)(95)))));
            this.panel_move.Location = new System.Drawing.Point(15, 61);
            this.panel_move.Name = "panel_move";
            this.panel_move.Size = new System.Drawing.Size(160, 3);
            this.panel_move.TabIndex = 2;
            this.panel_move.Visible = false;
            // 
            // bt_another
            // 
            this.bt_another.AnimationHoverSpeed = 0.07F;
            this.bt_another.AnimationSpeed = 0.03F;
            this.bt_another.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(112)))), ((int)(((byte)(156)))));
            this.bt_another.BorderColor = System.Drawing.Color.Black;
            this.bt_another.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_another.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_another.ForeColor = System.Drawing.Color.White;
            this.bt_another.Image = null;
            this.bt_another.ImageSize = new System.Drawing.Size(20, 20);
            this.bt_another.Location = new System.Drawing.Point(513, 16);
            this.bt_another.Name = "bt_another";
            this.bt_another.OnHoverBaseColor = System.Drawing.Color.SteelBlue;
            this.bt_another.OnHoverBorderColor = System.Drawing.Color.Black;
            this.bt_another.OnHoverForeColor = System.Drawing.Color.White;
            this.bt_another.OnHoverImage = null;
            this.bt_another.OnPressedColor = System.Drawing.Color.Black;
            this.bt_another.Radius = 10;
            this.bt_another.Size = new System.Drawing.Size(160, 42);
            this.bt_another.TabIndex = 0;
            this.bt_another.Text = "Khác";
            this.bt_another.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.bt_another.Click += new System.EventHandler(this.bt_another_Click);
            // 
            // bt_room
            // 
            this.bt_room.AnimationHoverSpeed = 0.07F;
            this.bt_room.AnimationSpeed = 0.03F;
            this.bt_room.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(112)))), ((int)(((byte)(156)))));
            this.bt_room.BorderColor = System.Drawing.Color.Black;
            this.bt_room.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_room.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_room.ForeColor = System.Drawing.Color.White;
            this.bt_room.Image = null;
            this.bt_room.ImageSize = new System.Drawing.Size(20, 20);
            this.bt_room.Location = new System.Drawing.Point(347, 16);
            this.bt_room.Name = "bt_room";
            this.bt_room.OnHoverBaseColor = System.Drawing.Color.SteelBlue;
            this.bt_room.OnHoverBorderColor = System.Drawing.Color.Black;
            this.bt_room.OnHoverForeColor = System.Drawing.Color.White;
            this.bt_room.OnHoverImage = null;
            this.bt_room.OnPressedColor = System.Drawing.Color.Black;
            this.bt_room.Radius = 10;
            this.bt_room.Size = new System.Drawing.Size(160, 42);
            this.bt_room.TabIndex = 0;
            this.bt_room.Text = "Phòng";
            this.bt_room.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.bt_room.Click += new System.EventHandler(this.bt_room_Click);
            // 
            // bt_drink
            // 
            this.bt_drink.AnimationHoverSpeed = 0.07F;
            this.bt_drink.AnimationSpeed = 0.03F;
            this.bt_drink.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(112)))), ((int)(((byte)(156)))));
            this.bt_drink.BorderColor = System.Drawing.Color.Black;
            this.bt_drink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_drink.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_drink.ForeColor = System.Drawing.Color.White;
            this.bt_drink.Image = null;
            this.bt_drink.ImageSize = new System.Drawing.Size(20, 20);
            this.bt_drink.Location = new System.Drawing.Point(181, 16);
            this.bt_drink.Name = "bt_drink";
            this.bt_drink.OnHoverBaseColor = System.Drawing.Color.SteelBlue;
            this.bt_drink.OnHoverBorderColor = System.Drawing.Color.Black;
            this.bt_drink.OnHoverForeColor = System.Drawing.Color.White;
            this.bt_drink.OnHoverImage = null;
            this.bt_drink.OnPressedColor = System.Drawing.Color.Black;
            this.bt_drink.Radius = 10;
            this.bt_drink.Size = new System.Drawing.Size(160, 42);
            this.bt_drink.TabIndex = 0;
            this.bt_drink.Text = "Nước uống";
            this.bt_drink.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.bt_drink.Click += new System.EventHandler(this.bt_drink_Click);
            // 
            // bt_food
            // 
            this.bt_food.AnimationHoverSpeed = 0.07F;
            this.bt_food.AnimationSpeed = 0.03F;
            this.bt_food.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(112)))), ((int)(((byte)(156)))));
            this.bt_food.BorderColor = System.Drawing.Color.Black;
            this.bt_food.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_food.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_food.ForeColor = System.Drawing.Color.White;
            this.bt_food.Image = null;
            this.bt_food.ImageSize = new System.Drawing.Size(20, 20);
            this.bt_food.Location = new System.Drawing.Point(15, 16);
            this.bt_food.Name = "bt_food";
            this.bt_food.OnHoverBaseColor = System.Drawing.Color.SteelBlue;
            this.bt_food.OnHoverBorderColor = System.Drawing.Color.Black;
            this.bt_food.OnHoverForeColor = System.Drawing.Color.White;
            this.bt_food.OnHoverImage = null;
            this.bt_food.OnPressedColor = System.Drawing.Color.Black;
            this.bt_food.Radius = 10;
            this.bt_food.Size = new System.Drawing.Size(160, 42);
            this.bt_food.TabIndex = 0;
            this.bt_food.Text = "Thức ăn";
            this.bt_food.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.bt_food.Click += new System.EventHandler(this.bt_food_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Azure;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(714, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(424, 72);
            this.panel4.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.label1.Font = new System.Drawing.Font("Verdana", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(27, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hobook - Dịch vụ";
            // 
            // bt_out
            // 
            this.bt_out.AnimationHoverSpeed = 0.07F;
            this.bt_out.AnimationSpeed = 0.03F;
            this.bt_out.BaseColor = System.Drawing.Color.Crimson;
            this.bt_out.BorderColor = System.Drawing.Color.Black;
            this.bt_out.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_out.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_out.ForeColor = System.Drawing.Color.White;
            this.bt_out.Image = null;
            this.bt_out.ImageSize = new System.Drawing.Size(20, 20);
            this.bt_out.Location = new System.Drawing.Point(750, 696);
            this.bt_out.Name = "bt_out";
            this.bt_out.OnHoverBaseColor = System.Drawing.Color.Crimson;
            this.bt_out.OnHoverBorderColor = System.Drawing.Color.Black;
            this.bt_out.OnHoverForeColor = System.Drawing.Color.White;
            this.bt_out.OnHoverImage = null;
            this.bt_out.OnPressedColor = System.Drawing.Color.Black;
            this.bt_out.Radius = 10;
            this.bt_out.Size = new System.Drawing.Size(160, 42);
            this.bt_out.TabIndex = 0;
            this.bt_out.Text = "Hủy";
            this.bt_out.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.bt_out.Click += new System.EventHandler(this.bt_out_Click);
            // 
            // bt_bookservice
            // 
            this.bt_bookservice.AnimationHoverSpeed = 0.07F;
            this.bt_bookservice.AnimationSpeed = 0.03F;
            this.bt_bookservice.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(163)))), ((int)(((byte)(92)))));
            this.bt_bookservice.BorderColor = System.Drawing.Color.Black;
            this.bt_bookservice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_bookservice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_bookservice.ForeColor = System.Drawing.Color.White;
            this.bt_bookservice.Image = null;
            this.bt_bookservice.ImageSize = new System.Drawing.Size(20, 20);
            this.bt_bookservice.Location = new System.Drawing.Point(950, 696);
            this.bt_bookservice.Name = "bt_bookservice";
            this.bt_bookservice.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(90)))), ((int)(((byte)(64)))));
            this.bt_bookservice.OnHoverBorderColor = System.Drawing.Color.Black;
            this.bt_bookservice.OnHoverForeColor = System.Drawing.Color.White;
            this.bt_bookservice.OnHoverImage = null;
            this.bt_bookservice.OnPressedColor = System.Drawing.Color.Black;
            this.bt_bookservice.Radius = 10;
            this.bt_bookservice.Size = new System.Drawing.Size(160, 42);
            this.bt_bookservice.TabIndex = 0;
            this.bt_bookservice.Text = "Thêm";
            this.bt_bookservice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.bt_bookservice.Click += new System.EventHandler(this.bt_bookservice_Click);
            // 
            // panel_serviceadd
            // 
            this.panel_serviceadd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.panel_serviceadd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_serviceadd.Location = new System.Drawing.Point(714, 90);
            this.panel_serviceadd.Name = "panel_serviceadd";
            this.panel_serviceadd.Size = new System.Drawing.Size(424, 584);
            this.panel_serviceadd.TabIndex = 3;
            // 
            // Serviceboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.ClientSize = new System.Drawing.Size(1150, 750);
            this.Controls.Add(this.bt_out);
            this.Controls.Add(this.bt_bookservice);
            this.Controls.Add(this.panel_serviceadd);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel_service);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Serviceboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Serviceboard";
            this.Load += new System.EventHandler(this.Serviceboard_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.head_panel_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.head_panel_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.head_panel_MouseUp);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private System.Windows.Forms.Panel panel_service;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI.WinForms.GunaButton bt_drink;
        private Guna.UI.WinForms.GunaButton bt_food;
        private Guna.UI.WinForms.GunaButton bt_another;
        private Guna.UI.WinForms.GunaButton bt_room;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel_move;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaButton bt_out;
        private Guna.UI.WinForms.GunaButton bt_bookservice;
        private System.Windows.Forms.Panel panel_serviceadd;
    }
}