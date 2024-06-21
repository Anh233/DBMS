using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Hobook_Software.GUI.Dashboard
{
    public partial class PTTT : Form
    {
        public String pttt;

        private bool isDragging = false;
        private int mouseX, mouseY;


        private void head_panel_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
            mouseX = Cursor.Position.X - this.Left;
            mouseY = Cursor.Position.Y - this.Top;
        }

        private void head_panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                int x = Cursor.Position.X - mouseX;
                int y = Cursor.Position.Y - mouseY;

                this.Location = new System.Drawing.Point(x, y);
            }
        }

        private void head_panel_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }



        public PTTT(String MaDatPh)
        {
            InitializeComponent();
        }

        private Boolean check_chose()
        {
            int count = 0;
            foreach (RadioButton radioButton in this.Controls.OfType<RadioButton>())
            {
                if (radioButton.Checked)
                {
                    count++;
                }
            }
            if(count > 0)
            {
                return true;
            }
            else { return false; }
        }

        private void bt_choose_Click(object sender, EventArgs e)
        {
            foreach (RadioButton radioButton in this.Controls.OfType<RadioButton>())
            {
                if (radioButton.Checked)
                {
                    pttt = radioButton.Text;
                }
            }
            if (check_chose() == true)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn phương thức thanh toán cho đơn này");
            }
        }

        private void bt_out_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Clickbt(object sender, EventArgs e)
        {
            RadioButton a = (RadioButton)sender;
            foreach (RadioButton radioButton in this.Controls.OfType<RadioButton>())
            {
                if (radioButton != a)
                {
                    radioButton.Checked = false;
                }
            }
            a.Checked = true;
        }

        private void PTTT_Load(object sender, EventArgs e)
        {

        }
    }
}
