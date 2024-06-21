namespace Hobook_Software.GUI.Dashboard
{
    partial class UC_Checkout
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
            this.panel_show = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panel_show
            // 
            this.panel_show.AutoScroll = true;
            this.panel_show.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.panel_show.Location = new System.Drawing.Point(20, 23);
            this.panel_show.Name = "panel_show";
            this.panel_show.Size = new System.Drawing.Size(1139, 737);
            this.panel_show.TabIndex = 1;
            // 
            // UC_Checkout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.Controls.Add(this.panel_show);
            this.Name = "UC_Checkout";
            this.Size = new System.Drawing.Size(1179, 782);
            this.Load += new System.EventHandler(this.UC_Checkout_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_show;
    }
}
