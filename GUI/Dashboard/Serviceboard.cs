using Hobook_Software.BLL;
using Hobook_Software.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hobook_Software.GUI.Dashboard
{
    public partial class Serviceboard : Form
    {
        private List<Service> list_service;
        private List<Service> list_service_show = new List<Service>();
        private bool have_order = false;
        private String MaDonDat;
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

        public Serviceboard(String MaDonDat,bool have_order)
        {
            InitializeComponent();
            BusinessLogicLayer bll = new BusinessLogicLayer();
            list_service = bll.List_Service();
            this.have_order = have_order;
            this.MaDonDat = MaDonDat;
        }

        

        private void Serviceboard_Load(object sender, EventArgs e)
        {
            
        }

        private void number_plus(object sender, EventArgs e)
        {
            Guna.UI.WinForms.GunaCircleButton add = (Guna.UI.WinForms.GunaCircleButton)sender;
            Panel parent = (Panel)add.Parent;
            foreach (Control a in parent.Controls)
            {
                if (a is Guna.UI.WinForms.GunaTextBox)
                {
                    int number = int.Parse(a.Text);
                    number++;
                    a.Text = number.ToString();
                    break;
                }
            }
        }

        private void number_subtract(object sender, EventArgs e)
        {
            Guna.UI.WinForms.GunaCircleButton subtract = (Guna.UI.WinForms.GunaCircleButton)sender;
            Panel parent = (Panel)subtract.Parent;
            foreach (Control a in parent.Controls)
            {
                if (a is Guna.UI.WinForms.GunaTextBox)
                {
                    int number = int.Parse(a.Text);
                    if (number>0)
                    {
                        number -= 1;
                    }
                    a.Text = number.ToString();
                    break;
                }
            }
        }

        private void Add(object sender, EventArgs e)
        {
            Button add = (Button)sender;
            Panel parent = (Panel)add.Parent;
            foreach (Control a in parent.Controls)
            {
                if (a is Guna.UI.WinForms.GunaTextBox)
                {
                    int number = int.Parse(a.Text);
                    foreach (Service ser in list_service)
                    {
                        if (ser.Name == (String)parent.Tag)
                        {
                            ser.Soluong1 = number;
                            break;
                        }
                    }
                    break;
                }
            }
            CapNhat_Service();
        }

        private void CapNhat_Service()
        {
            panel_serviceadd.Controls.Clear();
            int dem = 0;
            int number = 0;
            decimal total = 0;
            foreach (Service service in list_service)
            {
                if (service.Soluong1 >0)
                {
                    number += service.Soluong1;
                    total += service.Gia * service.Soluong1;
                    Panel panel = new Panel();
                    panel.Size = new Size(395, 37);
                    panel.Location = new Point(15, 4 + dem * 43);
                    panel.BackColor = Color.White;
                    Label name = new Label();
                    name.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                    name.Text = service.Name;
                    name.Location = new Point(3, 7);
                    panel.Controls.Add(name);
                    Label soluong = new Label();
                    soluong.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                    soluong.Text = service.Soluong1.ToString();
                    soluong.Location = new Point(144, 7);
                    soluong.TextAlign = ContentAlignment.MiddleCenter;
                    panel.Controls.Add(soluong);
                    Label giatien = new Label();
                    giatien.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                    giatien.Text = (service.Gia * service.Soluong1).ToString();
                    giatien.Location = new Point(287, 7);
                    giatien.TextAlign = ContentAlignment.MiddleRight;
                    panel.Controls.Add(giatien);
                    panel_serviceadd.Controls.Add(panel);
                    dem++;
                }
            }
            Panel panel2 = new Panel();
            panel2.Size = new Size(395, 37);
            panel2.Location = new Point(15, 4 + dem * 43);
            panel2.BackColor = Color.White;
            Label name2 = new Label();
            name2.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            name2.Text = "Tổng cộng:";
            name2.Location = new Point(3, 7);
            name2.ForeColor = Color.SteelBlue;
            panel2.Controls.Add(name2);
            Label soluong2 = new Label();
            soluong2.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            soluong2.Text = number.ToString();
            soluong2.Location = new Point(144, 7);
            soluong2.TextAlign = ContentAlignment.MiddleCenter;
            soluong2.ForeColor = Color.SteelBlue;
            panel2.Controls.Add(soluong2);
            Label giatien2 = new Label();
            giatien2.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            giatien2.Text = total.ToString();
            giatien2.Location = new Point(287, 7);
            giatien2.TextAlign = ContentAlignment.MiddleRight;
            giatien2.ForeColor = Color.SteelBlue;
            panel2.Controls.Add(giatien2);
            panel_serviceadd.Controls.Add(panel2);
        }

        // Chưa xong
        private void Show_Service()
        {
            int dem = 0;
            foreach (Service service in list_service_show) 
            {
                Panel panel = new Panel();
                panel.Tag = service.Name;
                panel.Size = new Size(658, 143);
                panel.Location = new Point(15,16 + dem * 162);
                panel.BackColor = Color.White;
                PictureBox pictureBox = new PictureBox();
                pictureBox.Location = new Point(0,0);
                pictureBox.Size = new Size(143, 143);
                pictureBox.BackgroundImage = service.Img;
                pictureBox.BackgroundImageLayout = ImageLayout.Stretch;
                panel.Controls.Add(pictureBox);
                Label name = new Label();
                name.Font = new Font("Segoe UI", 28, FontStyle.Bold);
                name.Text = service.Name;
                name.Size = new Size(322, 62);
                name.Location = new Point(149, 9);
                panel.Controls.Add(name);
                Label price = new Label();
                price.Font = new Font("Segoe UI", 18, FontStyle.Bold);
                price.Text = service.Gia.ToString() + " VNĐ";
                price.Location = new Point(468, 26);
                price.Size = new Size(187, 41);
                panel.Controls.Add(price);
                Guna.UI.WinForms.GunaCircleButton subtract = new Guna.UI.WinForms.GunaCircleButton();
                subtract.Size = new Size(30, 30);
                subtract.Location = new Point(177, 98);
                subtract.BaseColor = Color.Crimson;
                subtract.OnHoverBaseColor = Color.Crimson;
                subtract.Cursor = Cursors.Hand;
                subtract.Image = Hobook_Software.Properties.Resources.minus_256x43;
                subtract.ImageSize = new Size(18, 6);
                subtract.Click += number_subtract;
                panel.Controls.Add(subtract);
                Guna.UI.WinForms.GunaCircleButton add = new Guna.UI.WinForms.GunaCircleButton();
                add.Size = new Size(30, 30);
                add.Location = new Point(289, 98);
                add.BaseColor = Color.Lime;
                add.OnHoverBaseColor = Color.Lime;
                add.Cursor = Cursors.Hand;
                add.Image = Hobook_Software.Properties.Resources.plus_256x256;
                add.ImageSize = new Size(18, 18);
                add.Click += number_plus;
                panel.Controls.Add(add);
                Guna.UI.WinForms.GunaTextBox number = new Guna.UI.WinForms.GunaTextBox();
                number.Font = new Font("Segoe UI", 10);
                number.FocusedBorderColor = Color.SteelBlue;
                number.Radius = 10;
                number.Size = new Size(70, 34);
                number.Text = service.Soluong1.ToString();
                number.TextAlign = HorizontalAlignment.Center;
                number.Location = new Point(213, 97);
                panel.Controls.Add(number);
                Button bt_add = new Button();
                bt_add.Size = new Size(119, 34);
                bt_add.Location = new Point(498, 97);
                bt_add.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                bt_add.Text = "Add";
                bt_add.TextAlign = ContentAlignment.MiddleCenter;
                bt_add.BackColor = Color.DarkOrange;
                bt_add.Click += Add;
                panel.Controls.Add(bt_add);
                panel_service.Controls.Add(panel);
                dem++;
            }
        }

        private void Move_panel_move(int x2)
        {
            if (panel_move.Visible == false) { panel_move.Visible = true; }
            int x1 = panel_move.Location.X;
            if (x1 < x2)
            {
                while (x1 < x2)
                {
                    x1 += 41;
                    panel_move.Location = new Point(x1, panel_move.Location.Y);
                    Thread.Sleep(1);
                }
                panel_move.Location = new Point(x2, panel_move.Location.Y);
            }
            else
            {
                while (x1 > x2)
                {
                    x1 -= 41;
                    panel_move.Location = new Point(x1, panel_move.Location.Y);
                    Thread.Sleep(1);
                }
                panel_move.Location = new Point(x2, panel_move.Location.Y);
            }
        }

        private void bt_food_Click(object sender, EventArgs e)
        {
            Move_panel_move(bt_food.Location.X);
            panel_service.Controls.Clear();
            list_service_show = new List<Service>();
            foreach (Service service in list_service)
            {
                if (service.Category1 == "Food")
                {
                    list_service_show.Add(service);
                }
            }
            Show_Service();
        }

        private void bt_drink_Click(object sender, EventArgs e)
        {
            Move_panel_move(bt_drink.Location.X);
            panel_service.Controls.Clear();
            list_service_show = new List<Service>();
            foreach (Service service in list_service)
            {
                if (service.Category1 == "Drink")
                {
                    list_service_show.Add(service);
                }
            }
            Show_Service();
        }

        private void bt_room_Click(object sender, EventArgs e)
        {
            Move_panel_move(bt_room.Location.X);
            panel_service.Controls.Clear();
            list_service_show = new List<Service>();
            foreach (Service service in list_service)
            {
                if (service.Category1 == "Room")
                {
                    list_service_show.Add(service);
                }
            }
            Show_Service();
        }

        private void bt_another_Click(object sender, EventArgs e)
        {
            Move_panel_move(bt_another.Location.X);
            panel_service.Controls.Clear();
            list_service_show = new List<Service>();
            foreach (Service service in list_service)
            {
                if (service.Category1 == "Other")
                {
                    list_service_show.Add(service);
                }
            }
            Show_Service();
        }

        private void bt_bookservice_Click(object sender, EventArgs e)
        {
            BusinessLogicLayer bll = new BusinessLogicLayer();
            if (have_order==false)
            {
                bll.Add_ServiceOrder(MaDonDat);
            } 
            List<String> TenDV = new List<String>();
            List<int> Soluong = new List<int>();
            foreach (Service service in list_service)
            {
                if (service.Soluong1 > 0)
                {
                    TenDV.Add(service.Db_name);
                    Soluong.Add(service.Soluong1);
                }
            }
            bll.Add_Service(MaDonDat, TenDV,Soluong,DateTime.Now);
            have_order = true;
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bt_out_Click(object sender, EventArgs e)
        {
            this.Close();
        }



    }
}
