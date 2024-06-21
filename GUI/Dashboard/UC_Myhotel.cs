using Hobook_Software.BLL;
using Hobook_Software.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Media3D;

namespace Hobook_Software.GUI.Dashboard
{
    public partial class UC_Myhotel : UserControl
    {
        public UC_Myhotel()
        {
            InitializeComponent();
        }

        #region Phòng 
        public void Load_DataGridView_Room()
        {
            BusinessLogicLayer bll = new BusinessLogicLayer();
            List<Room> list_room = bll.List_Room();
            DataTable source = new DataTable();
            source.Columns.Add("Số phòng", typeof(String));
            source.Columns.Add("Loại phòng", typeof(String));
            source.Columns.Add("Sức chứa", typeof(String));
            source.Columns.Add("Giá theo giờ", typeof(String));
            source.Columns.Add("Giá theo ngày", typeof(String));
            source.Columns.Add("Trạng thái", typeof(String));
            foreach (Room room in  list_room)
            {
                String loaiph = (room.LoaiPh1 == "BinhDan") ? ("Bình dân") : ("Cao cấp");
                String trangth="";
                if (room.TrangThai1 == "trong") { trangth = "Trống"; }
                if (room.TrangThai1 == "dangdondep") { trangth = "Dọn dẹp"; }
                if (room.TrangThai1 == "suachua") { trangth = "Sửa chữa"; }
                if (room.TrangThai1 == "dangchothue") { trangth = "Đang thuê"; }
                source.Rows.Add(room.SoPh1.ToString(), loaiph, room.SucChua1.ToString(), room.GiaTheoGio1.ToString("N0"),room.GiaTheoNgay1.ToString("N0"),trangth);
            }
            dg_room.DataSource = source;
        }

        private void dg_room_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 & e.ColumnIndex >= 0)
            {
                if (dg_room.Columns[e.ColumnIndex].Name == "Fix")
                {
                    String Soph = dg_room.Rows[e.RowIndex].Cells["sophong"].Value.ToString();
                    String Loaiph = dg_room.Rows[e.RowIndex].Cells["loaiphong"].Value.ToString();
                    String Succhua = dg_room.Rows[e.RowIndex].Cells["succhua"].Value.ToString();
                    String GiatheoH = dg_room.Rows[e.RowIndex].Cells["giatheogio"].Value.ToString().Replace(",", "");
                    String GiatheoNg = dg_room.Rows[e.RowIndex].Cells["giatheongay"].Value.ToString().Replace(",", "");

                    String notice = "Vui lòng nhập đủ và đúng các thông tin sai sau:\n";
                    if (Loaiph != "Bình dân" & Loaiph != "Cao cấp") { notice += "- Loại phòng chỉ có Bình dân và Cao cấp\n"; }
                    if (Succhua == "") { notice += "- Chưa nhập sức chứa\n"; }
                    else
                    {
                        if (!Succhua.All(char.IsDigit)) { notice += "- Sức chứa chỉ chứa ký tự số\n"; }
                    }
                    if (GiatheoH == "") { notice += "- Chưa nhập giá theo giờ\n"; }
                    else
                    {
                        if (!GiatheoH.All(char.IsDigit)) { notice += "- Giá theo giờ chỉ chứa ký tự số\n"; }
                    }
                    if (GiatheoNg == "") { notice += "- Chưa nhập giá theo ngày\n"; }
                    else
                    {
                        if (!GiatheoNg.All(char.IsDigit)) { notice += "- Giá theo ngày chỉ chứa ký tự số\n"; }
                    }

                    if (notice == "Vui lòng nhập đủ và đúng các thông tin sai sau:\n")
                    {
                        BusinessLogicLayer bll = new BusinessLogicLayer();
                        Loaiph = (Loaiph == "Cao cấp") ? ("CaoCap") : ("BinhDan");
                        bll.Fix_RoomInformation(Loaiph, int.Parse(Soph), GiatheoH, GiatheoNg, int.Parse(Succhua));
                        Load_DataGridView_Room();
                    }
                    else
                    {
                        MessageBox.Show(notice, "Thông báo!");
                    }
                }

            }


        }

        private void bt_addroom_Click(object sender, EventArgs e)
        {
            String notice = "Vui lòng nhập đủ và đúng các thông tin sai sau:\n";
            if (tb_soph.Text == "") { notice += "- Thiếu thông tin số phòng\n"; }
            else
            {
                if (!tb_soph.Text.All(char.IsDigit)) { notice += "- Số phòng chỉ bao gồm các ký tự số"; }
            }
            if (tb_succhua.Text == "") { notice += "- Thiếu thông tin sức chứa\n"; }
            else
            {
                if (!tb_succhua.Text.All(char.IsDigit)) { notice += "- Sức chứa chỉ bao gồm các ký tự số"; }
            }
            if (tb_giatheong.Text == "") { notice += "- Thiếu thông tin giá theo ngày\n"; }
            else
            {
                if (!tb_giatheong.Text.Replace(",", "").All(char.IsDigit)) { notice += "- Giá theo ngày chỉ bao gồm các ký tự số và dấu phẩy ngăn cách đơn vị"; }
            }
            if (tb_giatheoh.Text == "") { notice += "- Thiếu thông tin giá theo giờ\n"; }
            else
            {
                if (!tb_giatheoh.Text.Replace(",", "").All(char.IsDigit)) { notice += "- Giá theo giờ chỉ bao gồm các ký tự số và dấu phẩy ngăn cách đơn vị"; }
            }
            if (notice == "Vui lòng nhập đủ và đúng các thông tin sai sau:\n")
            {
                BusinessLogicLayer bll = new BusinessLogicLayer();
                String loaiph = (cb_loaiphong.Text == "Bình dân") ? ("BinhDan") : ("CaoCap");
                bll.Add_Room(loaiph, int.Parse(tb_soph.Text), decimal.Parse(tb_giatheoh.Text), decimal.Parse(tb_giatheong.Text), int.Parse(tb_succhua.Text));
                Load_DataGridView_Room();
                tb_soph.Text = "";
                tb_succhua.Text = "";
                tb_giatheong.Text = "";
                tb_giatheoh.Text = "";
            }
            else
            {
                MessageBox.Show(notice, "Thông báo");
            }
        }

        private void bt_room_Click(object sender, EventArgs e)
        {
            panel_promotion.Location = new Point(-1177, 62);
            panel_room.Location = new Point(0, 62);
            panel_service.Location = new Point(1178, 62);
            Load_DataGridView_Room();
        }

        #endregion





        #region Khuyến mãi
        private List<Promotion> list_promotion = new List<Promotion>();
        public void Load_DataGridView_Promotion()
        {
            BusinessLogicLayer bll = new BusinessLogicLayer();
            list_promotion = bll.List_Promotion();
            DataTable source = new DataTable();
            source.Columns.Add("STT", typeof(String));
            source.Columns.Add("Tên khuyến mãi", typeof(String));
            source.Columns.Add("Ngày bắt đầu", typeof(String));
            source.Columns.Add("Ngày kết thúc", typeof(String));
            source.Columns.Add("Giá trị khuyến mãi", typeof(String));

            int dem = 1;
            foreach (Promotion promotion in list_promotion)
            {
                source.Rows.Add(dem.ToString(),promotion.TenKM1, promotion.NgayBatDau1.ToString("dd/MM/yyyy"), promotion.NgayKetThuc1.ToString("dd/MM/yyyy"), promotion.GiaTriKM1.ToString());
                dem++;
            }
            dg_promotion.DataSource = source;
        }

        private void dg_promotion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 & e.ColumnIndex >= 0)
            {
                if (dg_promotion.Columns[e.ColumnIndex].Name == "sua")
                {
                    String tenkm = dg_promotion.Rows[e.RowIndex].Cells["tenkhuyenmai"].Value.ToString();
                    String ngaybatdau_str = dg_promotion.Rows[e.RowIndex].Cells["ngaybatdau"].Value.ToString();
                    String ngayketthuc_str = dg_promotion.Rows[e.RowIndex].Cells["ngayketthuc"].Value.ToString();
                    String giatrikm = dg_promotion.Rows[e.RowIndex].Cells["giatrikhuyenmai"].Value.ToString();

                    String notice = "Vui lòng nhập đủ và đúng các thông tin sai sau:\n";
                    if (tenkm == "") { notice += "- Tên khuyến mãi không được bỏ trống\n"; }
                    DateTime ngaybatdau = new DateTime();
                    DateTime ngayketthuc = new DateTime();
                    if (DateTime.TryParseExact(ngaybatdau_str,"dd/MM/yyyy" ,CultureInfo.InvariantCulture, DateTimeStyles.None, out ngaybatdau))
                    {

                    } else
                    {
                        notice += "- Ngày bắt đầu phải đúng định dạng dd/MM/yyyy\n";
                    }
                    if (DateTime.TryParseExact(ngayketthuc_str, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out ngayketthuc))
                    {

                    }
                    else
                    {
                        notice += "- Ngày kết thúc phải đúng định dạng dd/MM/yyyy\n";
                    }
                    if (giatrikm == "") { notice += "- Giá trị khuyến mãi không được bỏ trống!\n"; }
                    else
                    {
                        if (!giatrikm.Replace(".","").All(char.IsDigit))
                        {
                            notice += "- Giá trị khuyến mãi chỉ gồm ký tự số!\n";
                        }
                        else
                        {
                            if (double.Parse(giatrikm) <= 0 | double.Parse(giatrikm) >= 1)
                            {
                                notice += "- Giá trị khuyến mãi phải nằm trong khoảng (0,1)\n";
                            }
                        }
                    }
                    if (notice != "Vui lòng nhập đủ và đúng các thông tin sai sau:\n")
                    {
                        MessageBox.Show(notice, "Thông báo");
                    }
                    else
                    {
                        BusinessLogicLayer bll = new BusinessLogicLayer();
                        String index_str = dg_promotion.Rows[e.RowIndex].Cells["STT"].Value.ToString();
                        int index = int.Parse(index_str) - 1;
                        bll.Fix_Promotion(list_promotion[index].MaKM1, tenkm, ngaybatdau, ngayketthuc, double.Parse(giatrikm));
                        Load_DataGridView_Promotion();
                    }
                }
            }
        }
        private void bt_addpromotion_Click(object sender, EventArgs e)
        {
            String tenkm = tb_tenkm.Text;
            String giatrikm = tb_giatrikm.Text;
            String notice = "Vui lòng nhập đủ và đúng các thông tin sai sau:\n";
            if (tenkm == "") { notice += "- Tên khuyến mãi không được bỏ trống\n"; }
            if (giatrikm == "") { notice += "- Giá trị khuyến mãi không được bỏ trống!\n"; }
            else
            {
                if (!giatrikm.Replace(".", "").All(char.IsDigit))
                {
                    notice += "- Giá trị khuyến mãi chỉ gồm ký tự số!\n";
                }
                else
                {
                    if (double.Parse(giatrikm) <= 0 | double.Parse(giatrikm) >= 1)
                    {
                        notice += "- Giá trị khuyến mãi phải nằm trong khoảng (0,1)\n";
                    }
                }
            }
            if (notice != "Vui lòng nhập đủ và đúng các thông tin sai sau:\n")
            {
                MessageBox.Show(notice, "Thông báo");
            }
            else
            {
                BusinessLogicLayer bll = new BusinessLogicLayer();
                String MaKM = "";
                if (list_promotion.Count == 0)
                {
                    MaKM = "KM0001";
                }
                else
                {
                    MaKM = list_promotion[list_promotion.Count - 1].MaKM1.Replace("KM", "");
                    int number = int.Parse(MaKM);
                    number++;
                    String number_str = number.ToString();
                    while (number_str.Length < 4)
                    {
                        number_str = "0" + number_str;
                    }
                    MaKM = "KM" + number_str;
                }
                bll.Add_Promotion(MaKM, tenkm, tb_timestart.Value, tb_timeend.Value, double.Parse(giatrikm));
                Load_DataGridView_Promotion();
                tb_tenkm.Text = "";
                tb_giatrikm.Text = "";
                tb_timestart.Value = DateTime.Now;
                tb_timestart.Value = DateTime.Now.AddDays(1);
            }
        }
        private void bt_promote_Click(object sender, EventArgs e)
        {
            panel_room.Location = new Point(-1177, 62);
            panel_promotion.Location = new Point(0, 62);
            panel_service.Location = new Point(1178, 62);
            Load_DataGridView_Promotion();
        }

        #endregion


        #region Dịch vụ
        private List<Service> list_service = new List<Service>();
        public void Load_DataGridView_Service()
        {
            pb_image1.BackgroundImage = null;
            BusinessLogicLayer bll = new BusinessLogicLayer();
            list_service = bll.List_Service();
            DataTable source = new DataTable();
            source.Columns.Add("STT", typeof(String));
            source.Columns.Add("Tên dịch vụ", typeof(String));
            source.Columns.Add("Giá dịch vụ", typeof(String));
            source.Columns.Add("Loại", typeof(String));

            int dem = 1;
            foreach (Service service in list_service)
            {
                source.Rows.Add(dem.ToString(), service.Name, service.Gia.ToString("N0"), service.Category1);
                dem++;
            }

            dg_service.DataSource = source;
        }

        private void dg_service_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 & e.ColumnIndex >= 0)
            {
                BusinessLogicLayer bll = new BusinessLogicLayer();
                String index_str = dg_service.Rows[e.RowIndex].Cells["sttservice"].Value.ToString();
                int index = int.Parse(index_str) - 1;
                pb_image1.BackgroundImage = list_service[index].Img;
                if (dg_service.Columns[e.ColumnIndex].Name == "fixservice")
                {
                    String tendichvu = dg_service.Rows[e.RowIndex].Cells["tendichvu"].Value.ToString();
                    String giadichvu = dg_service.Rows[e.RowIndex].Cells["giadichvu"].Value.ToString().Replace(",","");
                    String loai = dg_service.Rows[e.RowIndex].Cells["loai"].Value.ToString();

                    String notice = "Vui lòng nhập đủ và đúng các thông tin sai sau:\n";
                    if (tendichvu == "") { notice += "- Không được để trống tên dịch vụ\n"; }
                    if (giadichvu == "") { notice += "- Chưa nhập giá dịch vụ\n"; }
                    else
                    {
                        if (!giadichvu.All(char.IsDigit)) { notice += "- Giá dịch vụ chỉ chứa ký tự số hoặc có dấu phẩy ngăn cách đơn vị\n"; }
                    }

                    if (loai == "") { notice += "- Chưa nhập loại dịch vụ\n"; }
                    else
                    {
                        if (loai!="Food" & loai!="Drink" & loai!="Room")
                        {
                            notice += "- Loại dịch vụ chỉ có thể là Room, Food và Drink!\n";
                        }
                    }

                    if (notice != "Vui lòng nhập đủ và đúng các thông tin sai sau:\n")
                    {
                        MessageBox.Show(notice, "Thông báo!");
                    }
                    else
                    {
                        bll.Fix_Service(list_service[index].MaDV, tendichvu, decimal.Parse(giadichvu), list_service[index].Db_name, loai);
                        using (OpenFileDialog openFileDialog = new OpenFileDialog())
                        {
                            openFileDialog.Filter = "PNG Files|*.png";
                            openFileDialog.Title = "Thay đổi ảnh cho dịch vụ!";

                            if (openFileDialog.ShowDialog() == DialogResult.OK)
                            {
                                String path = Directory.GetParent(Directory.GetParent(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).FullName).FullName).FullName;
                                string old_filePath = Path.Combine(path, "img/service/" + Service.ChuyenChuoi(tendichvu) + ".png");
                                try
                                {
                                    string selectedFilePath = openFileDialog.FileName;
                                    File.Copy(selectedFilePath, old_filePath, true);
                                    MessageBox.Show("Đổi ảnh thành công!", "Thông báo!");
                                } catch (Exception ex)
                                {
                                    MessageBox.Show("Có lỗi xảy ra!\n" + ex.Message);
                                }
                            }
                        }
                        Load_DataGridView_Service();
                    }
                    
                }
                if (dg_service.Columns[e.ColumnIndex].Name == "deleteservice")
                {
                    bll.Delete_Service(list_service[index].MaDV, list_service[index].Db_name);
                    Load_DataGridView_Service();
                }
            }
        }

        private void bt_addservice_Click(object sender, EventArgs e)
        {
            String tendichvu = tb_tendichvu.Text;
            String loai = cb_loaidichvu.Text;
            String giadichvu = tb_giadichvu.Text.Replace(",","");

            String notice = "Vui lòng nhập đủ và đúng các thông tin sai sau:\n";
            if (tendichvu == "") { notice += "- Không được để trống tên dịch vụ\n"; }
            if (giadichvu == "") { notice += "- Chưa nhập giá dịch vụ\n"; }
            else
            {
                if (!giadichvu.All(char.IsDigit)) { notice += "- Giá dịch vụ chỉ chứa ký tự số hoặc có dấu phẩy ngăn cách đơn vị\n"; }
            }

            if (loai == "") { notice += "- Chưa nhập loại dịch vụ\n"; }
            else
            {
                if (loai != "Food" & loai != "Drink" & loai != "Room")
                {
                    notice += "- Loại dịch vụ chỉ có thể là Room, Food và Drink!\n";
                }
            }


            if (notice != "Vui lòng nhập đủ và đúng các thông tin sai sau:\n")
            {
                MessageBox.Show(notice, "Thông báo!");
            } else
            {
                BusinessLogicLayer bll = new BusinessLogicLayer();
                bll.Add_Service(tendichvu,decimal.Parse(giadichvu),loai,tb_anhdichvu.Text);
                Load_DataGridView_Service();
                tb_tendichvu.Text = "";
                tb_giadichvu.Text = "";
                tb_anhdichvu.Text = "";
                pb_image2.BackgroundImage = null;
            }
        }

        private void bt_openimage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "PNG Files|*.png";
                openFileDialog.Title = "Chọn ảnh cho dịch vụ!";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    tb_anhdichvu.Text = openFileDialog.FileName;
                    pb_image2.BackgroundImage = Image.FromFile(openFileDialog.FileName);
                }
            }
        }

        #endregion






        private void UC_Myhotel_Load(object sender, EventArgs e)
        {
            cb_loaiphong.Items.Add("Bình dân");
            cb_loaiphong.Items.Add("Cao cấp");
            cb_loaiphong.SelectedIndex = 0;

            tb_timestart.Value = DateTime.Now;
            tb_timeend.Value = DateTime.Now.AddDays(7);

            cb_loaidichvu.Items.Add("Food");
            cb_loaidichvu.Items.Add("Drink");
            cb_loaidichvu.Items.Add("Room");
            cb_loaidichvu.SelectedIndex = 0;
        }

        private void bt_service_Click(object sender, EventArgs e)
        {
            panel_service.Location = new Point(0, 62);
            panel_promotion.Location = new Point(-1177, 62);
            panel_room.Location = new Point(1178, 62);
            Load_DataGridView_Service();
        }
    }
}
