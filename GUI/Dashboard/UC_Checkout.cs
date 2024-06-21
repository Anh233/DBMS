using Hobook_Software.BLL;
using Hobook_Software.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hobook_Software.GUI.Dashboard
{
    public partial class UC_Checkout : UserControl
    {
        private List<Room> list_room_booked = new List<Room>();
        private List<Promotion> list_promotion = new List<Promotion>();

        private DateTime start;
        private DateTime end;
        private String pttt = "";
        public UC_Checkout()
        {
            InitializeComponent();
        }

        private string checkKM(DateTime NgayBatDau)
        {
            list_promotion.Clear();
            BusinessLogicLayer bll = new BusinessLogicLayer();
            list_promotion = bll.List_Promotion();
            for (int i = 0; i < list_promotion.Count; i++)
            {
                if (NgayBatDau >= list_promotion[i].NgayBatDau1)
                {
                    return list_promotion[i].GiaTriKM1.ToString();
                }
            }
            return null;
        }

        private void bt_hoadon_click(object sender, EventArgs e)
        {
            if(pttt == "")
            {
                MessageBox.Show("Vui lòng chọn phương thức thanh toán");
            }
            else
            {
                Guna.UI.WinForms.GunaButton a = (Guna.UI.WinForms.GunaButton)sender;
                string[] tag = a.Tag.ToString().Split('-');
                String MaDatPh = tag[0];
                Dashboard_form dbf = (Dashboard_form)this.ParentForm;
                HoaDon HD = new HoaDon(MaDatPh, start, end, pttt, dbf.user_name);
                HD.Owner = this.ParentForm;
                HD.ShowDialog();
                Loading(start, end);
            }
        }

        

        private void bt_pttt_click(object sender, EventArgs e)
        {
            Guna.UI.WinForms.GunaButton a = (Guna.UI.WinForms.GunaButton)sender;
            String MaDatPh = a.Tag.ToString();
            
            PTTT pttt_form = new PTTT(MaDatPh);
            pttt_form.ShowDialog();
            pttt = pttt_form.pttt;
        }
        public void Loading(DateTime timestart, DateTime timeend)
        {
            // Lấy dữ liệu phòng từ thời gian đầu cuối
            BusinessLogicLayer bll = new BusinessLogicLayer();
            start = timestart;
            end = timeend;
            list_room_booked = bll.List_Room_WithTime(start, end);


            // Xóa các control trong panel show
            panel_show.Controls.Clear();

            // Load các thông tin đặt phòng mới 
            int dem = 0;
            foreach (Room room in list_room_booked)
            {
                for (int i = 0; i < room.TrangThaiDon1.Count; i++)
                {
                    if (room.TrangThaiDon1[i] == "DangThue")
                    {
                        Guna.UI.WinForms.GunaElipsePanel panel = new Guna.UI.WinForms.GunaElipsePanel();
                        panel.Size = new Size(1098, 93);
                        panel.Location = new Point(18, 18 + dem * 110);
                        panel.Radius = 10;
                        panel.BackColor = Color.Transparent;
                        panel.BaseColor = Color.FromArgb(148, 210, 189);

                        PictureBox human = new PictureBox();
                        human.Size = new Size(60, 60);
                        human.Location = new Point(27, 15);
                        human.BackgroundImage = Hobook_Software.Properties.Resources.human;
                        human.BackgroundImageLayout = ImageLayout.Stretch;
                        panel.Controls.Add(human);

                        Customer customer = bll.Find_customer(room.MaKh1[i]);
                        Label name = new Label();
                        name.Font = new Font("Segoe UI", 12, FontStyle.Bold);
                        name.Location = new Point(107, 44);
                        name.Size = new Size(166, 31);
                        String[] name_arr = customer.HoTen1.Split(' ');

                        if (name_arr.Length > 3)
                        {
                            name.Text = name_arr[name_arr.Length - 3] + " " + name_arr[name_arr.Length - 2] + " " + name_arr[name_arr.Length - 1];
                        }
                        else
                        {
                            name.Text = customer.HoTen1;
                        }
                        panel.Controls.Add(name);

                        Label SoPh = new Label();
                        SoPh.BackColor = Color.FromArgb(221, 161, 94);
                        SoPh.Font = new Font("Segoe UI", 12, FontStyle.Bold);
                        SoPh.Location = new Point(324, 44);
                        SoPh.Text = room.SoPh1.ToString().Trim();
                        SoPh.Size = new Size(48, 31);
                        panel.Controls.Add(SoPh);

                        Label date = new Label();
                        date.Font = new Font("Segoe UI", 13, FontStyle.Bold);
                        date.Location = new Point(421, 44);
                        date.Size = new Size(287, 31);
                        date.Text = room.NgayBatDau1[i].ToString("dd/MM hh:ss") + " - " + room.NgayKetThuc1[i].ToString("dd/MM hh:ss");
                        panel.Controls.Add(date); 
                        

                        Guna.UI.WinForms.GunaButton nhanphong = new Guna.UI.WinForms.GunaButton();
                        nhanphong.Font = new Font("Segoe UI", 12, FontStyle.Bold);
                        nhanphong.Text = "PTTT";
                        nhanphong.Radius = 10;
                        nhanphong.BaseColor = Color.FromArgb(138, 129, 124);
                        nhanphong.OnHoverBaseColor = Color.FromArgb(70, 63, 58);
                        nhanphong.Cursor = Cursors.Hand;
                        nhanphong.Size = new Size(139, 31);
                        nhanphong.Location = new Point(760, 44);
                        nhanphong.TextAlign = HorizontalAlignment.Center;
                        nhanphong.Image = null;
                        nhanphong.Tag = room.MaDonDat1[i];
                        nhanphong.Click += bt_pttt_click;
                        panel.Controls.Add(nhanphong);

                        Guna.UI.WinForms.GunaButton xoadon = new Guna.UI.WinForms.GunaButton();
                        xoadon.Font = new Font("Segoe UI", 12, FontStyle.Bold);
                        xoadon.Text = "Hoá đơn";
                        xoadon.Radius = 10;
                        xoadon.BaseColor = Color.FromArgb(88, 129, 87);
                        xoadon.OnHoverBaseColor = Color.FromArgb(56, 102, 65);
                        xoadon.Cursor = Cursors.Hand;
                        xoadon.Size = new Size(139, 31);
                        xoadon.Location = new Point(932, 44);
                        xoadon.TextAlign = HorizontalAlignment.Center;
                        xoadon.Image = null;
                        xoadon.Tag = room.MaDonDat1[i] + "-" + room.NgayBatDau1[i].ToString("dd/MM/yyyy") + "-" + room.MaKh1[i];
                        xoadon.Click += bt_hoadon_click;
                        panel.Controls.Add(xoadon);
                        panel_show.Controls.Add(panel);
                        dem++;
                    }
                }
            }
        }

        private void UC_Checkout_Load(object sender, EventArgs e)
        {

        }
    }
}
