using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using Hobook_Software.BLL;
using Hobook_Software.Class;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace Hobook_Software.GUI.Dashboard
{
    public partial class Dashboard_form : Form
    {
        private bool isDragging = false;
        private int mouseX, mouseY;
        public String user_name;
        public bool Admin_check = false;
        public int stage = 0;

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


        public Dashboard_form(string user_name, string role)
        {
            InitializeComponent();
            this.user_name = user_name;
            if (role == "admin" | role == "Chu") Admin_check = true;
            if (Admin_check)
            {
                
                lb_role.Text = "Admin";
            } else
            {
                lb_role.Text = "Nhân viên";
            }
            lb_namestaff.Text = user_name;


            // Xóa dòng này để ẩn các chức năng admin nhé
            bt_account.Visible = true;
            bt_myhotel.Visible = true;
            bt_statistic.Visible = true;
            Admin_check = true;
            //


            Task.Run(() => information_slip(1));
        }

        private void Dashboard_form_Load(object sender, EventArgs e)
        {
            tb_timestart.Value = DateTime.Now;
            tb_timeend.Value = DateTime.Now.AddDays(1);
        }

        private void bt_minimize_click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void tb_find_Click(object sender, EventArgs e)
        {
            if (tb_find.Text=="Tìm kiếm")
            {
                tb_find.Text = "";
            }
        }

        private void reset_bt()
        {
            bt_find.Visible = false;
            tb_find.Visible = false;
            tb_timestart.Visible = false;
            tb_timeend.Visible = false;
            bt_check.Visible = false;
            bt_bookroom.Visible = false;

            if (choosen_sym.Visible ==  false) { choosen_sym.Visible = true; }

            bt_room.BackColor = Color.FromArgb(241, 246, 249);
            UC_Room.Visible = false;
            UC_BookRoom.Visible = false;
            bt_bookroom.Visible = false;

            bt_checkin.BackColor = Color.FromArgb(241, 246, 249);
            UC_Checkin.Visible = false;

            UC_Checkout.Visible = false;
            bt_checkout.BackColor = Color.FromArgb(241, 246, 249);

            bt_customer.BackColor = Color.FromArgb(241, 246, 249);
            UC_Customer.Visible = false;

            bt_billsearch.BackColor = Color.FromArgb(241, 246, 249);
            UC_Bill.Visible = false;



            if (Admin_check)
            {
                bt_account.BackColor = Color.FromArgb(241, 246, 249);
                UC_Account.Visible = false;

                bt_myhotel.BackColor = Color.FromArgb(241, 246, 249);
                UC_Myhotel.Visible = false;

                bt_statistic.BackColor = Color.FromArgb(241, 246, 249);
                UC_Statistics.Visible = false;
            }
        }

        private void move_choosen_sym(int y)
        {
            int save = y;
            while (y<save+20)
            {
                y += 4;
                choosen_sym.Location = new Point(choosen_sym.Location.X, y);
                Thread.Sleep(1);
            }
            
            while (y > save)
            {
                y -= 4;
                choosen_sym.Location = new Point(choosen_sym.Location.X, y);
                Thread.Sleep(1);
            }
        }

      

        private void bt_room_Click(object sender, EventArgs e)
        {
            stage = 1;
            reset_bt();
            bt_find.Visible = true;
            tb_find.Visible = true;
            tb_timestart.Visible = true;
            tb_timeend.Visible = true;
            bt_check.Visible = true;
            bt_bookroom.Visible = true;
            UC_Room.Visible = true;
            UC_BookRoom.Visible = false;
            bt_room.BackColor = Color.Gainsboro;
            move_choosen_sym(118);
            
        }

        private void bt_checkin_Click(object sender, EventArgs e)
        {
            stage = 2;
            reset_bt();
            bt_find.Visible = true;
            tb_find.Visible = true;
            tb_timestart.Visible = true;
            tb_timeend.Visible = true;
            bt_check.Visible = true;
            bt_checkin.BackColor = Color.Gainsboro;
            move_choosen_sym(208);

            UC_Checkin.Visible = true;
        }

        private void bt_checkout_Click(object sender, EventArgs e)
        {
            stage = 3;
            reset_bt();
            bt_find.Visible = true;
            tb_find.Visible = true;
            tb_timestart.Visible = true;
            tb_timeend.Visible = true;
            bt_check.Visible = true;
            bt_checkout.BackColor = Color.Gainsboro;
            move_choosen_sym(290);
            UC_Checkout.Visible = true;
        }

        public void Quick_checkout()
        {
            stage = 3;
            reset_bt();
            bt_find.Visible = true;
            tb_find.Visible = true;
            tb_timestart.Visible = true;
            tb_timeend.Visible = true;
            bt_check.Visible = true;
            bt_checkout.BackColor = Color.Gainsboro;
            move_choosen_sym(290);
            UC_Checkout.Visible = true;
            UC_Checkout.Loading(tb_timestart.Value, tb_timeend.Value);

        }

        private void bt_customer_Click(object sender, EventArgs e)
        {
            stage = 4;
            reset_bt();
            bt_find.Visible = true;
            tb_find.Visible = true;
            UC_Customer.Visible = true;
            UC_Customer.Load_ViewCustomer();
            bt_customer.BackColor = Color.Gainsboro;
            move_choosen_sym(378);
        }

        public DateTime now = DateTime.Now;
        public void bt_check_Click(object sender, EventArgs e)
        {
            switch (stage) {
                case 1:
                    UC_Room.rooms_choose = new List<Room>();
                    bt_bookroom.Visible = true;
                    
                    bt_bookroom.Text = "Đặt phòng (0)";
                    bt_room.BackColor = Color.Gainsboro;
                    List<Room> list_room = new List<Room>();
                    BusinessLogicLayer bll = new BusinessLogicLayer();
                    DateTime time_start = tb_timestart.Value;
                    DateTime time_end = tb_timeend.Value;
                    if (tb_timestart.Value < now)
                    {
                        tb_timestart.Value = DateTime.Now;
                        MessageBox.Show("Không thể xem trạng thái phòng ở quá khứ!");
                    }
                    else
                    {
                        if (time_start > time_end)
                        {
                            MessageBox.Show("Vui lòng nhập lại thời gian hợp lệ!", "Lỗi!");
                        }
                        else
                        {
                            list_room = bll.List_Room_WithTime(time_start, time_end);
                            UC_Room.Show_room(list_room);
                            UC_Room.Visible = true;
                            UC_BookRoom.Visible = false;
                        }
                    }
                    break;

                case 2:
                    UC_Checkin.Loading(tb_timestart.Value,tb_timeend.Value);
                    break;

                case 3:
                    UC_Checkout.Loading(tb_timestart.Value, tb_timeend.Value);
                    break;
            }
            
        }

        private void UC_Room_Load(object sender, EventArgs e)
        {

        }

        private void head_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tb_timestart_onValueChanged(object sender, EventArgs e)
        {
            
        }

        private void bt_bookroom_Click(object sender, EventArgs e)
        {
            UC_BookRoom.Visible = true;
            UC_BookRoom.Setting(UC_Room.rooms_choose,tb_timestart.Value,tb_timeend.Value);
        }


        private void bt_billsearch_Click(object sender, EventArgs e)
        {
            stage = 5;
            reset_bt();
            UC_Bill.Visible = true;
            tb_find.Visible = true;
            bt_find.Visible = true;
            bt_billsearch.BackColor = Color.Gainsboro;
            move_choosen_sym(468);
        }

        private void Search()
        {
            BusinessLogicLayer bll = new BusinessLogicLayer();
            switch (stage)
            {
                case 1:
                    if (tb_find.Text != "")
                    {
                        UC_Room.Filter(tb_find.Text);
                    }
                    else
                    {
                        UC_Room.Show_room(bll.List_Room_WithTime(tb_timestart.Value,tb_timeend.Value));
                    }
                    break;

                case 2:
                    BusinessLogicLayer bll2 = new BusinessLogicLayer();
                    List<Room> list_room2 = bll2.List_Room_WithTime(tb_timestart.Value, tb_timeend.Value);

                    break;

                case 3:



                    break;

                case 4:
                    if (tb_find.Text != "")
                    {
                        UC_Customer.Filter(tb_find.Text);
                    }  
                    else
                    {
                        UC_Customer.Load_ViewCustomer();
                    }
                    break;

                case 5:
                    UC_Bill.Loading(tb_find.Text);
                    break;

                case 6:
                    UC_Account.Filter(tb_find.Text);
                    break;
            }
        }


        private void tb_find_Enter(object sender, EventArgs e)
        {
            if (tb_find.Text == "Tìm kiếm")
            {
                tb_find.Text = "";
            }
        }

        private void tb_find_Leave(object sender, EventArgs e)
        {
            if (tb_find.Text == "")
            {
                tb_find.Text = "Tìm kiếm";
            }
        }

        private void bt_find_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void tb_find_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void bt_account_Click(object sender, EventArgs e)
        {
            reset_bt();
            stage = 6;
            tb_find.Visible = true;
            bt_find.Visible = true;
            bt_account.BackColor = Color.Gainsboro;
            UC_Account.Visible = true;
            UC_Account.Loading();
            move_choosen_sym(548);


        }

        private void bt_myhotel_Click(object sender, EventArgs e)
        {
            reset_bt();
            UC_Myhotel.Visible = true;
            UC_Myhotel.Load_DataGridView_Service();
            stage = 7;
            bt_myhotel.BackColor = Color.Gainsboro;

            move_choosen_sym(635);
        }

        private void bt_statistic_Click(object sender, EventArgs e)
        {
            reset_bt();
            stage = 8;
            bt_statistic.BackColor = Color.Gainsboro;
            UC_Statistics.Visible = true;

            UC_Statistics.Loading_Statistic_Today();

            move_choosen_sym(722);
        }

        private void bt_logout_Click(object sender, EventArgs e)
        {
            this.Close();
        }




        private void information_slip(int wait_second)
        {
            int x = panel_information.Location.X;
            while (panel_information.Location.X < 0)
            {
                x += 10;
                Action<int> updatePanelLocationX = (X) =>
                {
                    panel_information.Location = new Point(x, panel_information.Location.Y);
                };

                // Sử dụng Invoke để chuyển đoạn mã đến luồng chính
                if (panel_information.InvokeRequired)
                {
                    panel_information.Invoke(updatePanelLocationX, new object[] { x });
                }
                else
                {
                    // Nếu đang ở luồng chính, thực hiện ngay tại đây
                    updatePanelLocationX(x);
                }

                Thread.Sleep(10);
            }

            Thread.Sleep(wait_second * 1000);

            while (panel_information.Location.X > -269)
            {
                x -= 7;
                Action<int> updatePanelLocationX = (X) =>
                {
                    panel_information.Location = new Point(x, panel_information.Location.Y);
                };

                // Sử dụng Invoke để chuyển đoạn mã đến luồng chính
                if (panel_information.InvokeRequired)
                {
                    panel_information.Invoke(updatePanelLocationX, new object[] { x });
                }
                else
                {
                    // Nếu đang ở luồng chính, thực hiện ngay tại đây
                    updatePanelLocationX(x);
                }
                Thread.Sleep(10);
            }
        }

        private void gunaCircleButton1_Click(object sender, EventArgs e)
        {
            Task.Run(() => information_slip(3));
        }

        private void Dashboard_form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Login_form a = (Login_form)this.Owner;
            a.tb_acc.Text = "";
            a.tb_pass.Text = "";
            a.Show();
        }

        private void bt_off_click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
