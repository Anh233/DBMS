using Hobook_Software.BLL;
using Hobook_Software.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hobook_Software.GUI.Dashboard
{
    public partial class InformationRoom : Form
    {
        private Room room_information = new Room();
        private UC_Room parent = new UC_Room();
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


        public InformationRoom(Room room, UC_Room parent)
        {
            this.room_information = room;
            InitializeComponent();
            this.parent = parent;
        }

        private void bt_out_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InformationRoom_Load(object sender, EventArgs e)
        {
            tb_SoPh.Text = "P" + room_information.SoPh1.ToString();
            tb_LoaiPh.Text = room_information.LoaiPh1.ToString();
            tb_Succhua.Text = room_information.SucChua1.ToString();
            tb_GiaTheoNgay.Text = room_information.GiaTheoNgay1.ToString();
            tb_GiaTheoGio.Text = room_information.GiaTheoGio1.ToString();
            ccb_Trangthai.Items.Add("Sẵn sàng");
            ccb_Trangthai.Items.Add("Dọn dẹp");
            ccb_Trangthai.Items.Add("Sửa chữa");
            if (room_information.TrangThai1 == "trong")
            {
                ccb_Trangthai.SelectedIndex = 0;
            }
            else
            {
                if (room_information.TrangThai1 == "dangdondep")
                {
                    ccb_Trangthai.SelectedIndex = 1;
                }
                else { ccb_Trangthai.SelectedIndex = 2; }
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void bt_choose_Click(object sender, EventArgs e)
        {
            if (room_information.TrangThai1 != "trong")
            {
                MessageBox.Show("Phòng phải trống để có thể chọn!", "Thông báo!");
            }
            else
            {
                if (bt_choose.Text == "Chọn")
                {
                    parent.rooms_choose.Add(room_information);
                    parent.Room_Chosing(Color.DarkOrange);
                }
                else
                {
                    parent.Room_Chosing(Color.FromArgb(88, 129, 87));
                    parent.rooms_choose.Remove(room_information);
                    parent.Room_Chosing(Color.DarkOrange);
                }
                this.Close();
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bt_save_Click(object sender, EventArgs e)
        {
            BusinessLogicLayer bll = new BusinessLogicLayer();
            String select = ccb_Trangthai.SelectedItem.ToString();
            if (select == "Sẵn sàng")
            {
                bll.Set_ReadyRoom(room_information.SoPh1);
            }
            else
            {
                if (this.parent.rooms_choose.Contains(room_information))
                {
                    MessageBox.Show("Phòng đang được chọn ! Vui lòng bỏ chọn để chỉnh trạng thái!", "Lỗi");
                }
                else
                {
                    if (select == "Dọn dẹp")
                    {
                        bll.Set_CleaningRoom(room_information.SoPh1);
                    }
                    else { bll.Set_FixingRoom(room_information.SoPh1); }
                }
                
            }
            Dashboard_form a = (Dashboard_form)this.parent.ParentForm;
            this.parent.Delete_show_room();
            List<Room> list_room = bll.List_Room_WithTime(a.tb_timestart.Value, a.tb_timeend.Value);
            this.parent.Show_room(list_room);
            this.parent.Filter();
            List<Room> save = new List<Room>();
            foreach (Room room in this.parent.rooms_choose)
            {
                foreach (Room room2 in list_room)
                {
                    if (room.SoPh1 == room2.SoPh1)
                    {
                        save.Add(room2);
                        break;
                    }
                }
            }
            this.parent.rooms_choose = save;
            foreach (Room room in list_room)
            {
                if (room_information.SoPh1 == room.SoPh1)
                {
                    room_information = room;
                    break;
                }
            }
            parent.Room_Chosing(Color.DarkOrange);
        }
    }
}
