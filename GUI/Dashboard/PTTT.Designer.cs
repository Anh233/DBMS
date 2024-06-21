namespace Hobook_Software.GUI.Dashboard
{
    partial class PTTT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PTTT));
            this.panel4 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_money = new System.Windows.Forms.RadioButton();
            this.btn_banking = new System.Windows.Forms.RadioButton();
            this.btn_momo = new System.Windows.Forms.RadioButton();
            this.btn_card = new System.Windows.Forms.RadioButton();
            this.bt_choose = new Guna.UI.WinForms.GunaButton();
            this.bt_out = new Guna.UI.WinForms.GunaButton();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(85)))), ((int)(((byte)(133)))));
            this.panel4.Controls.Add(this.label7);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(411, 62);
            this.panel4.TabIndex = 1;
            this.panel4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.head_panel_MouseDown);
            this.panel4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.head_panel_MouseMove);
            this.panel4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.head_panel_MouseUp);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(22, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(364, 41);
            this.label7.TabIndex = 2;
            this.label7.Text = "Phương thức thanh toán";
            this.label7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.head_panel_MouseDown);
            this.label7.MouseMove += new System.Windows.Forms.MouseEventHandler(this.head_panel_MouseMove);
            this.label7.MouseUp += new System.Windows.Forms.MouseEventHandler(this.head_panel_MouseUp);
            // 
            // btn_money
            // 
            this.btn_money.AutoSize = true;
            this.btn_money.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_money.Location = new System.Drawing.Point(19, 90);
            this.btn_money.Name = "btn_money";
            this.btn_money.Size = new System.Drawing.Size(154, 42);
            this.btn_money.TabIndex = 3;
            this.btn_money.TabStop = true;
            this.btn_money.Text = "Tiền mặt";
            this.btn_money.UseVisualStyleBackColor = true;
            this.btn_money.Click += new System.EventHandler(this.Clickbt);
            // 
            // btn_banking
            // 
            this.btn_banking.AutoSize = true;
            this.btn_banking.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_banking.Location = new System.Drawing.Point(19, 150);
            this.btn_banking.Name = "btn_banking";
            this.btn_banking.Size = new System.Drawing.Size(374, 42);
            this.btn_banking.TabIndex = 4;
            this.btn_banking.TabStop = true;
            this.btn_banking.Text = "Chuyển khoản ngân hàng";
            this.btn_banking.UseVisualStyleBackColor = true;
            this.btn_banking.Click += new System.EventHandler(this.Clickbt);
            // 
            // btn_momo
            // 
            this.btn_momo.AutoSize = true;
            this.btn_momo.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_momo.Location = new System.Drawing.Point(19, 208);
            this.btn_momo.Name = "btn_momo";
            this.btn_momo.Size = new System.Drawing.Size(125, 42);
            this.btn_momo.TabIndex = 8;
            this.btn_momo.TabStop = true;
            this.btn_momo.Text = "Momo";
            this.btn_momo.UseVisualStyleBackColor = true;
            this.btn_momo.Click += new System.EventHandler(this.Clickbt);
            // 
            // btn_card
            // 
            this.btn_card.AutoSize = true;
            this.btn_card.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_card.Location = new System.Drawing.Point(19, 272);
            this.btn_card.Name = "btn_card";
            this.btn_card.Size = new System.Drawing.Size(153, 42);
            this.btn_card.TabIndex = 9;
            this.btn_card.TabStop = true;
            this.btn_card.Text = "Quét thẻ";
            this.btn_card.UseVisualStyleBackColor = true;
            this.btn_card.Click += new System.EventHandler(this.Clickbt);
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
            this.bt_choose.Location = new System.Drawing.Point(229, 374);
            this.bt_choose.Name = "bt_choose";
            this.bt_choose.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(129)))), ((int)(((byte)(87)))));
            this.bt_choose.OnHoverBorderColor = System.Drawing.Color.Black;
            this.bt_choose.OnHoverForeColor = System.Drawing.Color.White;
            this.bt_choose.OnHoverImage = null;
            this.bt_choose.OnPressedColor = System.Drawing.Color.Black;
            this.bt_choose.Radius = 15;
            this.bt_choose.Size = new System.Drawing.Size(157, 52);
            this.bt_choose.TabIndex = 10;
            this.bt_choose.Text = "Chọn";
            this.bt_choose.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.bt_choose.Click += new System.EventHandler(this.bt_choose_Click);
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
            this.bt_out.Location = new System.Drawing.Point(19, 374);
            this.bt_out.Name = "bt_out";
            this.bt_out.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.bt_out.OnHoverBorderColor = System.Drawing.Color.Black;
            this.bt_out.OnHoverForeColor = System.Drawing.Color.White;
            this.bt_out.OnHoverImage = null;
            this.bt_out.OnPressedColor = System.Drawing.Color.Black;
            this.bt_out.Radius = 15;
            this.bt_out.Size = new System.Drawing.Size(157, 52);
            this.bt_out.TabIndex = 11;
            this.bt_out.Text = "Thoát";
            this.bt_out.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.bt_out.Click += new System.EventHandler(this.bt_out_Click);
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 10;
            this.gunaElipse1.TargetControl = this;
            // 
            // PTTT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 452);
            this.Controls.Add(this.bt_out);
            this.Controls.Add(this.bt_choose);
            this.Controls.Add(this.btn_card);
            this.Controls.Add(this.btn_momo);
            this.Controls.Add(this.btn_banking);
            this.Controls.Add(this.btn_money);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PTTT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PTTT";
            this.Load += new System.EventHandler(this.PTTT_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton btn_money;
        private System.Windows.Forms.RadioButton btn_banking;
        private System.Windows.Forms.RadioButton btn_momo;
        private System.Windows.Forms.RadioButton btn_card;
        public Guna.UI.WinForms.GunaButton bt_choose;
        private Guna.UI.WinForms.GunaButton bt_out;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
    }
}