namespace Hobook_Software.GUI.Dashboard
{
    partial class UC_Customer
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
            this.panel_customer = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 10;
            this.gunaElipse1.TargetControl = this;
            // 
            // panel_customer
            // 
            this.panel_customer.AutoScroll = true;
            this.panel_customer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel_customer.Location = new System.Drawing.Point(3, 43);
            this.panel_customer.Name = "panel_customer";
            this.panel_customer.Size = new System.Drawing.Size(1173, 697);
            this.panel_customer.TabIndex = 0;
            // 
            // UC_Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_customer);
            this.Name = "UC_Customer";
            this.Size = new System.Drawing.Size(1179, 782);
            this.Load += new System.EventHandler(this.UC_Customer_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private System.Windows.Forms.Panel panel_customer;
    }
}
