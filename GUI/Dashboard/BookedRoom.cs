using Hobook_Software.BLL;
using Hobook_Software.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hobook_Software.GUI.Dashboard
{
    public partial class BookedRoom : Form
    {
        private Room room = new Room();
        private Customer customer = new Customer();
        private List<Service> list_services = new List<Service>();


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

        public BookedRoom(Room room,Customer customer)
        {
            InitializeComponent();
            BusinessLogicLayer bll = new BusinessLogicLayer();
            this.list_services = bll.List_ServiceToRoom(room.MaDonDat1[0]);
            this.room = room;
            this.customer = customer;
            String[] name = customer.HoTen1.Split(' ');
            if (name.Length > 3)
            {
                lb_tenkhachhang.Text = name[name.Length - 3] + " " + name[name.Length - 2] + " " + name[name.Length - 1];
            } else { lb_tenkhachhang.Text = customer.HoTen1; }

            lb_ngaybatdau.Text = room.NgayBatDau1[0].ToString("dd/MM/yyyy hh:mm tt");
            if ((room.TrangThaiDon1[0] == "DangThue")) {
                TimeSpan ngayo = DateTime.Now - room.NgayBatDau1[0];
                lb_time.Text = (ngayo.Days > 0) ? (ngayo.Days.ToString() + " ngày") : (ngayo.Hours.ToString() + " giờ");
            } else
            {
                bt_thanhtoan.Text = "Checkin";
                TimeSpan ngayo = room.NgayBatDau1[0] - DateTime.Now;
                lb_time.Text = (ngayo.Days > 0) ? (ngayo.Days.ToString() + " ngày") : (ngayo.Hours.ToString() + " giờ");
            }
            lb_SoPh.Text = "P" + room.SoPh1.ToString();
            lb_succhua.Text = room.SucChua1.ToString() + " người";
            tb_LoaiPh.Text = (room.LoaiPh1 == "CaoCap") ? ("Cao cấp") : ("Thường");
            tb_GiaTheoH.Text = room.GiaTheoGio1.ToString();
            tb_GiaTheoNg.Text = room.GiaTheoNgay1.ToString();
            tb_trangthai.Text = ((room.TrangThaiDon1[0] == "DangThue") ? ("Đang cho thuê ") : ("Đã đặt trước ")) + (((room.TrangThaiDon1.Count-1) >0) ? ("(+" + (room.TrangThaiDon1.Count - 1).ToString() + " Đã cọc)") : (""));

            CapNhat_Service();
        }

        public void CapNhat_Service()
        {
            BusinessLogicLayer bll = new BusinessLogicLayer();
            this.list_services = bll.List_ServiceToRoom(room.MaDonDat1[0]);
            panel_service.Controls.Clear();
            int dem = 0;
            int number = 0;
            decimal total = 0;
            foreach (Service service in list_services)
            {
                number += service.Soluong1;
                total += service.Gia;
                Panel panel = new Panel();
                panel.Size = new Size(395, 37);
                panel.Location = new Point(4, 4 + dem * 43);
                panel.BackColor = Color.WhiteSmoke;
                Label name = new Label();
                name.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                name.Text = service.Name;
                name.Location = new Point(3,7);
                name.AutoSize = true;
                panel.Controls.Add(name);
                Label soluong = new Label();
                soluong.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                soluong.Text = service.Soluong1.ToString();
                soluong.Location = new Point(144, 7);
                soluong.TextAlign = ContentAlignment.MiddleCenter;
                panel.Controls.Add(soluong);
                Label giatien = new Label();
                giatien.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                giatien.Text = service.Gia.ToString();
                giatien.Location = new Point(277,7);
                giatien.TextAlign = ContentAlignment.MiddleRight;
                panel.Controls.Add(giatien);
                panel_service.Controls.Add(panel);
                dem++;
            }
            Panel panel2 = new Panel();
            panel2.Size = new Size(395, 37);
            panel2.Location = new Point(4, 4 + dem * 43);
            panel2.BackColor = Color.WhiteSmoke;
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
            giatien2.Location = new Point(277, 7);
            giatien2.TextAlign = ContentAlignment.MiddleRight;
            giatien2.ForeColor = Color.SteelBlue;
            panel2.Controls.Add(giatien2);
            panel_service.Controls.Add(panel2);
        }

        private void bt_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_themService_Click(object sender, EventArgs e)
        {
            if (room.TrangThaiDon1.ToString()!="DatTruoc")
            {
                bool have_order = false;
                if (list_services.Count > 0)
                {
                    have_order = true;
                }
                Serviceboard SB = new Serviceboard(room.MaDonDat1[0], have_order);
                SB.ShowDialog();
                CapNhat_Service();
            }
        }

        private void bt_thanhtoan_Click(object sender, EventArgs e)
        {
            if(bt_thanhtoan.Text == "Checkin")
            {
                bt_thanhtoan.Text = "Thanh toán";
                BusinessLogicLayer bll = new BusinessLogicLayer();
                bll.Checkin_Room(this.room.MaDonDat1[0]);
                Dashboard_form a = (Dashboard_form)this.Owner;
                a.UC_Room.Show_room(bll.List_Room_WithTime((DateTime)a.tb_timestart.Value,(DateTime)a.tb_timeend.Value));
                this.Close();
            } else
            {
                Dashboard_form owner = (Dashboard_form)this.Owner;
                owner.Quick_checkout();
                this.Close();
            }
        }

        private void BookedRoom_Load(object sender, EventArgs e)
        {
           
        }
    }
}
