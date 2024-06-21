using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hobook_Software.BLL;
using Hobook_Software.Class;


namespace Hobook_Software.GUI.Dashboard
{
    public partial class UC_Room : UserControl
    {
        private List<Room> listroom_current = new List<Room>();
        private List<Room> listroom_show = new List<Room>();
        public List<Room> rooms_choose = new List<Room>();
        public int sort_state = -1;

        public UC_Room()
        {
            InitializeComponent();
        }

        public void Delete_show_room()
        {
            this.panel_buttonRoom.Controls.Clear();
        }

        public void Count_roomstate()
        {
            int trong = 0;
            int dangchothue = 0;
            int dattruoc = 0;
            int ban = 0;
            foreach (Room room in listroom_current)
            {
                if (room.TrangThaiDon1.Count > 0)
                {
                    if (room.TrangThaiDon1[0] == "DangThue")
                    {
                        dangchothue += 1;
                    }

                    if (room.TrangThaiDon1[0] == "DatTruoc")
                    {
                        dattruoc += 1;
                    }
                }
                else
                {
                    if (room.TrangThai1 == "trong")
                    {
                        trong += 1;
                    }
                    if (room.TrangThai1 == "dangsuachua" | room.TrangThai1 == "dangdondep")
                    {
                        ban += 1;
                    }
                    if (room.TrangThai1 == "dangchothue")
                    {
                        dangchothue += 1;
                    }
                }
            }

            bt_sansang.Text = "Sẵn sàng (" + trong.ToString() + ")";
            bt_dangthue.Text = "Đang thuê (" + dangchothue.ToString() + ")";
            bt_dacoc.Text = "Đặt trước (" + dattruoc.ToString() + ")";
            bt_ban.Text = "Bận (" + ban.ToString() + ")";
        }

        public void Show_room(List<Room> list_room)
        {
            foreach (Room room in list_room)
            {
                for (int i = 0; i< room.TrangThaiDon1.Count;i++)
                    if (room.TrangThaiDon1[i] == "HoanTat")
                    {
                        room.TrangThaiDon1.RemoveAt(i);
                        room.NgayBatDau1.RemoveAt(i);
                        room.NgayKetThuc1.RemoveAt(i);
                        room.MaKh1.RemoveAt(i);
                        room.MaDonDat1.RemoveAt(i);
                        i--;
                    }
            }

            this.listroom_show = list_room;
            this.listroom_current = list_room;
            Create_panel_room();
        }

        public void Room_Chosing(Color color)
        {
            foreach (Room room in rooms_choose)
            {
                foreach (Control c in panel_buttonRoom.Controls)
                {
                    if (int.Parse(c.Tag.ToString()) == room.SoPh1)
                    {
                        c.BackColor = color;
                        break;
                    }
                }
            }
            Dashboard_form dashboard_Form = (Dashboard_form)this.ParentForm;
            dashboard_Form.bt_bookroom.Text = "Đặt phòng (" + rooms_choose.Count.ToString() + ")";
        }


        public void Create_panel_room()
        {
            Delete_show_room();
            Count_roomstate();
            List<Room> list_room = this.listroom_show;
            int number = 3;
            for (int i = 0; i < list_room.Count; i++)
            {
                int x = i % number;
                int y = i / number;
                int locationX = 30 + (x + 1) * 130 + x * 195;
                int locationY = (y + 1) * 40 + y * 127;
                Room room = list_room[i];
                Panel p = new Panel();
                p.Location = new Point(locationX, locationY);
                p.Size = new Size(195, 127);

                if (room.TrangThaiDon1.Count > 0)
                {
                    p.Tag = room.SoPh1.ToString();
                    p.Click += Open_BookedRoom;
                    if (room.TrangThaiDon1[0] == "DangThue")
                    {
                        p.BackColor = Color.FromArgb(125, 133, 151);
                        PictureBox guest = new PictureBox();
                        guest.BackgroundImage = Hobook_Software.Properties.Resources.human;
                        guest.BackgroundImageLayout = ImageLayout.Stretch;
                        guest.Size = new Size(52, 52);
                        guest.Location = new Point(140, 48);
                        p.Controls.Add(guest);

                        Label guest_name = new Label();
                        guest_name.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                        guest_name.ForeColor = Color.White;
                        guest_name.Location = new Point(4, 82);
                        guest_name.Size = new Size(140, 20);
                        BusinessLogicLayer bll = new BusinessLogicLayer();
                        Customer g = bll.Find_customer(room.MaKh1[0]);
                        String[] name = g.HoTen1.Split(' ');
                        if (name.Length > 3)
                        {
                            guest_name.Text = name[name.Length - 3] + " " + name[name.Length - 2] + " " + name[name.Length - 1] + " (" + (room.MaKh1.Count - 1).ToString() + ")";
                        }
                        else
                        {
                            guest_name.Text = g.HoTen1 + " (" + (room.MaKh1.Count - 1).ToString() + ")";
                        }

                        p.Controls.Add(guest_name);
                    }
                    if (room.TrangThaiDon1[0] == "DatTruoc")
                    {
                        p.BackColor = Color.FromArgb(125, 133, 151);
                        PictureBox guest = new PictureBox();
                        guest.BackgroundImage = Hobook_Software.Properties.Resources.forbidden;
                        guest.BackgroundImageLayout = ImageLayout.Stretch;
                        guest.Size = new Size(52, 52);
                        guest.Location = new Point(140, 48);
                        p.Controls.Add(guest);

                        Label thoigian = new Label();
                        thoigian.Font = new Font("Segoe UI", 6, FontStyle.Bold);
                        thoigian.ForeColor = Color.White;
                        thoigian.Location = new Point(3, 85);
                        thoigian.Size = new Size(171, 17);
                        thoigian.Text = room.NgayBatDau1[0].ToString("HH:mm dd/MM") + " " + room.NgayKetThuc1[0].ToString("HH:mm dd/MM") + "(" + (room.NgayBatDau1.Count - 1).ToString() + ")";
                        p.Controls.Add(thoigian);
                    }

                }
                else
                {
                    
                    p.Tag = room.SoPh1.ToString();
                    p.Click += Open_InformationRoom;
                    if (room.TrangThai1 == "trong" | room.TrangThai1 == "dangchothue")
                    {
                        p.BackColor = Color.FromArgb(88, 129, 87);
                    }
                    if (room.TrangThai1 == "dangsuachua" | room.TrangThai1 == "dangdondep")
                    {
                        p.BackColor = Color.FromArgb(125, 133, 151);
                        PictureBox guest = new PictureBox();
                        guest.BackgroundImage = Hobook_Software.Properties.Resources.settings;
                        guest.BackgroundImageLayout = ImageLayout.Stretch;
                        guest.Size = new Size(52, 52);
                        guest.Location = new Point(140, 48);
                        p.Controls.Add(guest);
                    }
                }



                //label số phòng
                Label Soph = new Label();
                Soph.Location = new Point(2, 9);
                Soph.BackColor = Color.Transparent;
                Soph.ForeColor = Color.White;
                Soph.Font = new Font("Segoe UI", 17, FontStyle.Bold);
                Soph.Text = "P" + room.SoPh1.ToString();
                Soph.Size = new Size(111, 51);
                p.Controls.Add(Soph);

                //Picture caocap
                if (room.LoaiPh1 == "CaoCap")
                {
                    PictureBox caocap = new PictureBox();
                    caocap.Size = new Size(25, 25);
                    caocap.BackgroundImage = Hobook_Software.Properties.Resources.crown;
                    caocap.BackgroundImageLayout = ImageLayout.Stretch;
                    caocap.Location = new Point(164, 2);
                    p.Controls.Add(caocap);
                }


                //Panel thanh trạng thái
                Panel trangthai = new Panel();
                trangthai.Size = new Size(195, 22);
                trangthai.Location = new Point(0, 105);
                trangthai.BackColor = Color.FromArgb(198, 197, 185);
                // Picture box (đồng hồ) trong panel thanh trạng thái
                PictureBox dongho = new PictureBox();
                dongho.BackgroundImage = Hobook_Software.Properties.Resources.clock;
                dongho.BackgroundImageLayout = ImageLayout.Stretch;
                dongho.Size = new Size(18, 18);
                dongho.Location = new Point(12, 2);
                trangthai.Controls.Add(dongho);




                //label time trong thanh trạng thái
                Label time = new Label();
                time.Location = new Point(33, 2);
                time.Size = new Size(63, 18);
                time.Font = new Font("Segoe UI", 8, FontStyle.Bold);
                

                if (room.TrangThaiDon1.Count > 0)
                {
                    if (room.TrangThaiDon1[0] == "DangThue")
                    {
                        TimeSpan sub = room.NgayKetThuc1[0] - DateTime.Now;
                        time.Text = Math.Round(sub.TotalHours,1).ToString() + " giờ";
                    }
                    if (room.TrangThaiDon1[0] == "DatTruoc")
                    {
                        TimeSpan sub = room.NgayBatDau1[0] - DateTime.Now;
                        if (sub.TotalDays > 1)
                        {
                            time.Text = Math.Round(sub.TotalDays,0).ToString() + " ngày";
                        }
                        else
                        {
                            time.Text = Math.Round(sub.TotalHours, 1).ToString() + " giờ";
                        }
                    }
                }
                else
                {
                    time.Text = "0 giờ";
                }
                trangthai.Controls.Add(time);
                //label trang thai
                Label lb_trangthai = new Label();
                lb_trangthai.Font = new Font("Segoe UI", 8, FontStyle.Bold);

                if (room.TrangThaiDon1.Count > 0)
                {
                    if (room.TrangThaiDon1[0] == "DangThue")
                    {
                        lb_trangthai.Text = "Đang cho thuê";
                        lb_trangthai.Location = new Point(90, 2);
                        lb_trangthai.Size = new Size(110, 18);
                    }
                    if (room.TrangThaiDon1[0] == "DatTruoc")
                    {
                        lb_trangthai.Text = "Đặt trước";
                        lb_trangthai.Location = new Point(120, 2);
                    }
                }
                else
                {
                    if (room.TrangThai1 == "trong" | room.TrangThai1 == "dangchothue")
                    {
                        lb_trangthai.Text = "Sẵn sàng";
                        lb_trangthai.Location = new Point(120, 2);
                    }
                    if (room.TrangThai1 == "dangsuachua")
                    {
                        lb_trangthai.Text = "Đang sửa";
                        lb_trangthai.Location = new Point(120, 2);
                    }
                    if (room.TrangThai1 == "dangdondep")
                    {
                        lb_trangthai.Text = "Dọn dẹp";
                        lb_trangthai.Location = new Point(120, 2);
                    }


                }
                trangthai.Controls.Add(lb_trangthai);
                p.Controls.Add(trangthai);
                panel_buttonRoom.Controls.Add(p);
                this.Controls.Add(panel_buttonRoom);
            }
        }

        private void Open_InformationRoom(object sender, EventArgs e)
        {
            Panel panel = (Panel)sender;
            int SoPh = int.Parse(panel.Tag.ToString());
            Room infor_room = new Room();
            foreach (Room room in listroom_current)
            {
                if (room.SoPh1 == SoPh)
                {
                    infor_room = room;
                    break;
                }
            }
            InformationRoom IR = new InformationRoom(infor_room, this);
            if (rooms_choose.Contains(infor_room))
            {
                IR.bt_choose.Text = "Bỏ chọn";
            }
            IR.ShowDialog();
        }

        private void Open_BookedRoom(object sender, EventArgs e)
        {
            Panel panel = (Panel)sender;
            int SoPh = int.Parse(panel.Tag.ToString());
            Room booked_room = new Room();
            foreach (Room room in listroom_current)
            {
                if (room.SoPh1 == SoPh)
                {
                    booked_room = room;
                    break;
                }
            }
            BusinessLogicLayer bll = new BusinessLogicLayer();
            Customer cus = bll.Find_customer(booked_room.MaKh1[0]);
            BookedRoom BR = new BookedRoom(booked_room, cus);
            BR.Owner = (Dashboard_form) this.ParentForm;
            BR.ShowDialog();
        }

        private void UC_Room_Load(object sender, EventArgs e)
        {

        }

        public void bt_sansang_Click(object sender, EventArgs e)
        {
            sort_state = 0;
            Filter();
        }

        public void bt_dangthue_Click(object sender, EventArgs e)
        {
            sort_state = 1;
            Filter();
        }

        public void bt_dacoc_Click(object sender, EventArgs e)
        {
            sort_state = 2;
            Filter();
        }

        public void bt_ban_Click(object sender, EventArgs e)
        {
            sort_state = 3;
            Filter();
        }

        public void Filter()
        {
            if (sort_state == 0)
            {
                List<Room> listroom_temp = new List<Room>();
                foreach (Room room in listroom_current)
                {
                    if (room.TrangThai1 == "trong" & room.TrangThaiDon1.Count == 0)
                    {
                        listroom_temp.Add(room);
                    }
                }
                listroom_show = listroom_temp;
                Create_panel_room();
            }
            if (sort_state == 1)
            {
                List<Room> listroom_temp = new List<Room>();
                foreach (Room room in listroom_current)
                {
                    if (room.TrangThaiDon1.Count > 0)
                    {
                        if (room.TrangThaiDon1[0] == "DangThue")
                        {
                            listroom_temp.Add(room);
                        }

                    }
                    else
                    {
                        if (room.TrangThai1 == "dangchothue")
                        {
                            listroom_temp.Add(room);
                        }
                    }
                }
                listroom_show = listroom_temp;
                Create_panel_room();
            }
            if (sort_state == 2)
            {
                List<Room> listroom_temp = new List<Room>();
                foreach (Room room in listroom_current)
                {
                    if (room.TrangThaiDon1.Count > 0)
                    {
                        if (room.TrangThaiDon1[0] == "DatTruoc")
                        {
                            listroom_temp.Add(room);
                        }
                    }
                }
                listroom_show = listroom_temp;
                Create_panel_room();
            }
            if (sort_state == 3)
            {
                List<Room> listroom_temp = new List<Room>();
                foreach (Room room in listroom_current)
                {
                    if (room.TrangThaiDon1.Count == 0)
                    {
                        if (room.TrangThai1 == "dangsuachua" | room.TrangThai1 == "dangdondep")
                        {
                            listroom_temp.Add(room);
                        }


                    }
                }
                listroom_show = listroom_temp;
                Create_panel_room();
            }
        }

        public void Filter (String find)
        {
            List<Room> fill = new List<Room> ();
            if (find.All(char.IsDigit))
            {
                foreach (Room room in listroom_current)
                {
                    if (room.SoPh1.ToString().Contains(find))
                    {
                        fill.Add(room);
                    }
                }
            }
            listroom_show = fill;
            Create_panel_room();
            Room_Chosing(Color.DarkOrange);
        }

    }
}