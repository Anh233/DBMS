using Hobook_Software.BLL;
using Hobook_Software.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace Hobook_Software.GUI.Dashboard
{
    public partial class UC_BookRoom : UserControl
    {
        public Customer customer = null;
        public List<Room> rooms_choose = new List<Room>();
        public DateTime timestart = new DateTime();
        public DateTime timeend = new DateTime();

        public UC_BookRoom()
        {
            InitializeComponent();
        }

        private void Delete_Room_Choose(object sender, EventArgs e)
        {
            Guna.UI.WinForms.GunaCircleButton a = (Guna.UI.WinForms.GunaCircleButton)sender;
            String SoPh = a.Tag.ToString();
            foreach (Room room in rooms_choose)
            {
                if (room.SoPh1.ToString() == SoPh)
                {
                    rooms_choose.Remove(room);
                    Update_panel_roomchoose();
                    Dashboard_form db = (Dashboard_form)this.ParentForm;
                    db.UC_Room.Create_panel_room();
                    db.UC_Room.rooms_choose = rooms_choose;
                    db.UC_Room.Room_Chosing(Color.DarkOrange);
                    break;
                }
            }
        }


        public void Clear_textbox()
        {
            tb_cccd.Text = "";
            tb_hoten.Text = "";
            tb_diachi.Text = "";
            tb_sdt.Text = "";
            tb_ngaysinh.Text = "";
        }

        public void Setting(List<Room> rc,DateTime start,DateTime end)
        {
            this.rooms_choose = rc;
            this.timestart = start;
            this.timeend = end;
            lb_timestart.Text = timestart.ToString("dd/MM/yyyy");
            tb_hourstart.Text = timestart.Hour.ToString();
            tb_minutestart.Text = timestart.Minute.ToString();
            lb_timeend.Text = timeend.ToString("dd/MM/yyyy");
            tb_hourend.Text = timeend.Hour.ToString();
            tb_minuteend.Text = timeend.Minute.ToString();
            Update_panel_roomchoose();
        }

        private void Update_panel_roomchoose()
        {
            panel_roomchoose.Controls.Clear();
            int dem = 0;
            foreach (Room room in rooms_choose)
            {
                Panel panel = new Panel();
                panel.Size = new Size(446, 37);
                panel.Location = new Point(5, 4 + dem * 43);
                panel.BackColor = Color.White;
                Label name = new Label();
                name.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                name.Text = "P" + room.SoPh1;
                name.Location = new Point(3, 7);
                panel.Controls.Add(name);
                Label succhua = new Label();
                succhua.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                succhua.Text = room.SucChua1.ToString() + " người";
                succhua.Location = new Point(144, 7);
                succhua.TextAlign = ContentAlignment.MiddleCenter;
                panel.Controls.Add(succhua);
                Label loaiphong = new Label();
                loaiphong.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                loaiphong.Text = (room.LoaiPh1 == "CaoCap") ? ("Cao cấp") : ("Thường");
                loaiphong.Location = new Point(287, 7);
                loaiphong.TextAlign = ContentAlignment.MiddleRight;
                panel.Controls.Add(loaiphong);
                Guna.UI.WinForms.GunaCircleButton delete = new Guna.UI.WinForms.GunaCircleButton();
                delete.Size = new Size(22, 22);
                delete.Location = new Point(410, 7);
                delete.BaseColor = Color.Crimson;
                delete.OnHoverBaseColor = Color.Crimson;
                delete.Cursor = Cursors.Hand;
                delete.Image = Hobook_Software.Properties.Resources.minus_256x43;
                delete.ImageSize = new Size(12, 4);
                delete.Tag = room.SoPh1.ToString();
                delete.Click += Delete_Room_Choose;
                panel.Controls.Add(delete);
                panel_roomchoose.Controls.Add(panel);
                dem++;
            }
        }


        private void tb_cccd_TextChanged(object sender, EventArgs e)
        {
            if (tb_cccd.Text.Length == 12)
            {
                BusinessLogicLayer bll = new BusinessLogicLayer();
                Customer result = bll.Find_Customer_WithID(tb_cccd.Text);
                if (result != null)
                {
                    tb_hoten.ReadOnly = true;
                    tb_diachi.ReadOnly = true;
                    tb_sdt.ReadOnly = true;
                    tb_ngaysinh.ReadOnly = true;
                    tb_hoten.Text = result.HoTen1;
                    tb_diachi.Text = result.DiaChi1;
                    tb_sdt.Text = result.LienLac1;
                    tb_ngaysinh.Text = result.NgaySinh1.ToString("dd/MM/yyyy");
                    customer = result;
                }
                else { 
                    MessageBox.Show("Khách chưa thuê bao giờ!", "Thông báo!");
                    tb_hoten.Text = "";
                    tb_diachi.Text = "";
                    tb_sdt.Text = "";
                    tb_ngaysinh.Text = "";
                    customer = null;
                }
            }
            else
            {
                tb_hoten.ReadOnly = false;
                tb_diachi.ReadOnly = false;
                tb_sdt.ReadOnly = false;
                tb_ngaysinh.ReadOnly = false;
                customer = null;
            }
            
        }

        private String ngaysinh_save = "";
        private void tb_ngaysinh_TextChanged(object sender, EventArgs e)
        {
            if (tb_ngaysinh.Text.Length > ngaysinh_save.Length)
            {
                if (tb_ngaysinh.Text.Length == 2 | tb_ngaysinh.Text.Length == 5) { 
                    tb_ngaysinh.Text += "/";
                    for (int i=1;i<= tb_ngaysinh.Text.Length;i++)
                    {
                        SendKeys.Send("{RIGHT}");
                    } 
                }
            }
            ngaysinh_save = tb_ngaysinh.Text;
        }

        private void UC_BookRoom_Load(object sender, EventArgs e)
        {

        }

        private void bt_datphong_Click(object sender, EventArgs e)
        {
            if (rooms_choose.Count == 0)
            {
                MessageBox.Show("Hãy chọn phòng trước nhé!", "Thông báo!");
            }
            else
            {
                String notice = "Vui lòng điền đầy đủ và đúng các nội dung sau: \n";

                if (tb_cccd.Text.Length != 12 | !tb_cccd.Text.All(char.IsDigit)) { notice += "- CCCD gồm đúng 12 ký tự số\n"; }
                notice += (tb_hoten.Text == "") ? ("- Họ tên\n") : ("");
                notice += (tb_diachi.Text == "") ? ("- Địa chỉ\n") : ("");
                if (tb_sdt.Text.Length != 10 | !tb_sdt.Text.All(char.IsDigit)) { notice += "- Số điện thoại gồm đúng 10 ký tự số\n"; }
/*                DateTime ngaysinh;
                if (!DateTime.TryParseExact(tb_ngaysinh.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out ngaysinh))
                {
                    notice += "- Ngày sinh phải đúng định dạng ví dụ 30/01/2022\n";
                }*/
                if (!tb_hourstart.Text.All(char.IsDigit) | !tb_hourend.Text.All(char.IsDigit) | !tb_minutestart.Text.All(char.IsDigit) | !tb_minuteend.Text.All(char.IsDigit) | tb_hourstart.Text == "" | tb_minutestart.Text == "" | tb_hourend.Text == "" | tb_minuteend.Text == "") { notice += "- Giờ và phút phải nhập ký tự số\n"; }
                else
                {
                    if (int.Parse(tb_hourstart.Text) < 0 | int.Parse(tb_hourstart.Text) >= 24) { notice += "- Giờ bắt đầu không hợp lệ!\n"; }
                    if (int.Parse(tb_minutestart.Text) < 0 | int.Parse(tb_minutestart.Text) >= 60) { notice += "- Phút bắt đầu không hợp lệ!\n"; }
                    if (int.Parse(tb_hourend.Text) < 0 | int.Parse(tb_hourend.Text) >= 24) { notice += "- Giờ kết thúc không hợp lệ!\n"; }
                    if (int.Parse(tb_minuteend.Text) < 0 | int.Parse(tb_minuteend.Text) >= 60) { notice += "- Phút bắt đầu không hợp lệ!\n"; }
                }


                if (notice != "Vui lòng điền đầy đủ và đúng các nội dung sau: \n")
                {
                    MessageBox.Show(notice, "Cảnh báo!");
                }
                else
                {
                    BusinessLogicLayer bll = new BusinessLogicLayer();
                    String MaDatPh = bll.New_BookingOrder();
                    if (MaDatPh != null)
                    {
                        String TenNV = ((Dashboard_form)this.ParentForm).user_name;
                        DateTime start = new DateTime(timestart.Year, timestart.Month, timestart.Day, int.Parse(tb_hourstart.Text), int.Parse(tb_minutestart.Text),0);
                        DateTime end = new DateTime(timeend.Year, timeend.Month, timeend.Day, int.Parse(tb_hourend.Text), int.Parse(tb_minuteend.Text),0);

                        // Khi tất cả điều kiện đã thỏa tiến hành đặt phòng
                        if (customer != null)
                        {
                            // Dành cho khách hàng đã có thông tin
                            bll.Add_BookingOrder(MaDatPh, TenNV, customer.MaKh1, start, end);
                            bll.Add_RoomToOrder(MaDatPh, rooms_choose);
                        }
                        else
                        {
                            String new_MaKh = bll.New_CustomerCode();
                            if (new_MaKh != null)
                            {
                                bll.Add_BookingOrder_WithInfor(MaDatPh, TenNV, tb_hoten.Text, new_MaKh, tb_diachi.Text, tb_sdt.Text, DateTime.ParseExact(tb_ngaysinh.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture), tb_cccd.Text, start, end);
                                bll.Add_RoomToOrder(MaDatPh, rooms_choose);
                            }

                        }
                        Dashboard_form a = (Dashboard_form)this.ParentForm;
                        a.bt_bookroom.Text = "Đặt phòng (0)";
                        MessageBox.Show("Đã thực hiện xong!","Thông báo!");
                    }
                    Clear_textbox();
                    Setting(new List<Room>(), DateTime.Now, DateTime.Now.AddDays(1));
                    Dashboard_form dbf = (Dashboard_form)this.ParentForm;
                    dbf.UC_Room.Show_room(bll.List_Room_WithTime((DateTime)dbf.tb_timestart.Value, (DateTime)dbf.tb_timestart.Value));
                }
            }
            
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
