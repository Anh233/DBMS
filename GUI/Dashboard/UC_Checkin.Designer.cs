namespace Hobook_Software.GUI.Dashboard
{
    partial class UC_Checkin
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
            this.panel_show = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 10;
            this.gunaElipse1.TargetControl = this;
            // 
            // panel_show
            // 
            this.panel_show.AutoScroll = true;
            this.panel_show.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.panel_show.Location = new System.Drawing.Point(19, 19);
            this.panel_show.Name = "panel_show";
            this.panel_show.Size = new System.Drawing.Size(1139, 737);
            this.panel_show.TabIndex = 0;
            // 
            // UC_Checkin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.Controls.Add(this.panel_show);
            this.Name = "UC_Checkin";
            this.Size = new System.Drawing.Size(1179, 782);
            this.Load += new System.EventHandler(this.UC_Checkin_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private System.Windows.Forms.Panel panel_show;
    }
}
