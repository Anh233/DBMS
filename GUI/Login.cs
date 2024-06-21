using Hobook_Software.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hobook_Software.GUI.Dashboard;

namespace Hobook_Software.GUI
{
    public partial class Login_form : Form
    {
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


        public Login_form()
        {
            InitializeComponent();
        }

        private void elementHost1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        private void bt_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bt_off_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void bt_show_Click(object sender, EventArgs e)
        {
            if (bt_show.Text == "Hiện")
            {
                tb_pass.UseSystemPasswordChar = false;
                bt_show.Text = "Ẩn";
            }
            else
            {
                tb_pass.UseSystemPasswordChar = true;
                bt_show.Text = "Hiện";
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_form_Load(object sender, EventArgs e)
        {

        }

        private void bt_login_Click(object sender, EventArgs e)
        {
            if (tb_acc.Text == "" | tb_pass.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Cảnh báo");
            }
            else
            {
                String result = BusinessLogicLayer.Check_Login(tb_acc.Text, tb_pass.Text);
                if (result != null)
                {
                    String[] s = result.Split('-');
                    this.Hide();
                    Dashboard_form form = new Dashboard_form(s[0], s[1]);
                    form.Owner = this;
                    form.ShowDialog();

                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu bạn nhập đã sai!", "Cảnh báo");
                }
            }
        }

    }
}
