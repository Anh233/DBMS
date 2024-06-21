using Hobook_Software.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hobook_Software.Class;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Net.NetworkInformation;
using System.Xml.XPath;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace Hobook_Software.BLL
{
    public class BusinessLogicLayer
    {
        #region Các View cần thiết
        // Hàm xử lý DataTable của View Khách hàng trả về một List<Customer>
        public List<Customer> List_Customer()
        {
            DataLayer dal = new DataLayer();
            DataTable table_customer = dal.View_Customer();
            List<Customer> list_customer = new List<Customer>();
            if (table_customer != null)
            {
                foreach (DataRow row in table_customer.Rows)
                {
                    String MaKh = row["MaKh"].ToString();
                    String HoTen = row["HoTen"].ToString();
                    String DiaChi = row["DiaChi"].ToString();
                    String CCCD = row["CCCD"].ToString();
                    String LienLac = row["LienLac"].ToString();
                    Object NgaySinh = row["NgaySinh"];
                    list_customer.Add(new Customer(MaKh, HoTen, DiaChi, CCCD, LienLac, (DateTime)NgaySinh));
                }
            }
            return list_customer;
        }

        // Hàm xử lý datatable từ View_Room trả về List<Room>
        public List<Room> List_Room()
        {
            DataLayer dal = new DataLayer();
            DataTable dataTable = dal.View_Room();
            List<Room> list_room = new List<Room>();
            if (dataTable != null)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    var SoPh = row["SoPh"];
                    var LoaiPh = row["LoaiPh"];
                    var TrangThai = row["TrangThai"];
                    var SucChua = row["SucChua"];
                    var GiaTheoGio = row["GiaTheoGio"];
                    var GiaTheoNgay = row["GiaTheoNgay"];
                    list_room.Add(new Room((int)SoPh, LoaiPh.ToString(), TrangThai.ToString(), (int)SucChua, (decimal)GiaTheoGio, (decimal)GiaTheoNgay));
                }
            }
            return list_room;

        }

        // Hàm xử lý dataTable từ view dịch vụ (tất cả dịch vụ có của khách sạn) trả về List<Service>
        public List<Service> List_Service()
        {
            DataLayer dal = new DataLayer();
            DataTable dataTable = dal.View_Service();
            List<Service> list_service = new List<Service>();
            if (dataTable != null)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    String db_name = row["TenDV"].ToString();
                    decimal gia = (decimal)row["GiaDV"];
                    Service a = new Service(db_name, 0, gia);
                    a.MaDV = row["MaDV"].ToString();
                    list_service.Add(a);
                }
            }
            return list_service;
        }

        public List<Promotion> List_Promotion()
        {
            DataLayer dal = new DataLayer();
            DataTable table_promotion = dal.View_Promotion();
            List<Promotion> list_promotion = new List<Promotion>();
            if (table_promotion != null)
            {
                foreach (DataRow row in table_promotion.Rows)
                {
                    String MaKM = row["MaKM"].ToString();
                    String TenKM = row["TenKM"].ToString();
                    DateTime NgayBatDau = (DateTime)row["NgayBatDau"];
                    DateTime NgayKetThuc = (DateTime)row["NgayKetThuc"];
                    double GiaTriKM = (double)row["GiaTriKM"];
                    list_promotion.Add(new Promotion(MaKM, TenKM, NgayBatDau, NgayKetThuc, GiaTriKM));
                }
            }
            return list_promotion;
        }
        

        #endregion


        // các tiến trình
        #region a. Phục vụ chức năng đặt phòng
        // Hàm xử lý để thêm một mã đặt phòng với các thông tin cần thiết (Dành cho khách đã có thông tin)
        public void Add_BookingOrder(String MaDatPh, String TenNV, String MaKH, DateTime NgayThue, DateTime NgayTra)
        {
            DataLayer dal = new DataLayer();
            int result = dal.Proc_AddBookingOrder(MaDatPh, TenNV, MaKH, NgayThue, NgayTra);
            if (result <= 0) { MessageBox.Show("Tác vụ thất bại!", "Lỗi!"); }
        }

        // Hàm xử lý để thêm một mã đặt phòng với các thông tin cần thiết (Dành cho khách chưa có thông tin) 
        public void Add_BookingOrder_WithInfor(String MaDatPh, String TenNV, String HoTenKh, String MaKh, String DiaChi, String LienLac, DateTime NgaySinh, String CCCD, DateTime NgayThue, DateTime NgayTra)
        {
            DataLayer dal = new DataLayer();
            int result = dal.Proc_AddBookingOrder_WithInfor(MaDatPh, TenNV, HoTenKh, MaKh, DiaChi, LienLac, NgaySinh, CCCD, NgayThue, NgayTra);
            if (result <= 0) { MessageBox.Show("Tác vụ thất bại!", "Lỗi!"); }
        }

        // Hàm xử lý để thêm phòng vào một mã đặt phòng (Chức năng đặt phòng)
        public void Add_RoomToOrder(String MaDatPh, List<Room> rooms_choose)
        {
            DataLayer dal = new DataLayer();
            foreach (Room room in rooms_choose)
            {
                int result = dal.Proc_AddRoomToOrder(MaDatPh, room.SoPh1);
                if (result <= 0)
                {
                    MessageBox.Show("Đã có lỗi khi đặt phòng: P" + room.SoPh1.ToString(), "Lỗi");
                }
            }
        }

        // Hàm xử lý để trả về một mã đơn đặt phòng chưa có (Chức năng đặt phòng cần một mã đặt phòng mới)
        public String New_BookingOrder()
        {
            DataLayer dal = new DataLayer();
            DataTable view = dal.View_BookingOrder();
            String DonDatPh;
            if (view != null)
            {
                if (view.Rows.Count == 0)
                {
                    return "DP0001";
                } else
                {
                    DonDatPh = (view.Rows[view.Rows.Count - 1])["MaDatPh"].ToString();
                    String number_str = new string(DonDatPh.Where(char.IsDigit).ToArray());
                    int number = int.Parse(number_str);
                    number++;
                    String result = number.ToString();
                    while (result.Length < 4)
                    {
                        result = "0" + result;
                    }
                    return "DP" + result;
                }
            }
            else
            {
                MessageBox.Show("Đã có lỗi xảy ra!", "Lỗi!");
                return null;
            }
        }

        public DataTable History_BookingOrder(String Makh)
        {
            DataLayer dal = new DataLayer();
            DataTable dataTable = dal.View_BookingOrder();
            if (dataTable != null)
            {
                DataTable result = dataTable.Clone();
                foreach (DataRow row in dataTable.Rows)
                {
                    if (row["MaKH"].ToString() == Makh)
                    {
                        result.ImportRow(row);
                    }
                }
                result.Columns["NgayThue"].ColumnName = "Ngày Thuê";
                result.Columns["NgayTra"].ColumnName = "Ngày Trả";
                result.Columns["TrangThDon"].ColumnName = "Trạng thái";
                result.Columns.Remove("MaDatPh");
                result.Columns.Remove("MaNV");
                result.Columns.Remove("MaKH");
                return result;
            }
            return new DataTable();
        }

        // Hàm xử lý để trả về một mã khách hàng mới
        public String New_CustomerCode()
        {
            List<Customer> customers = this.List_Customer();
            if (customers != null)
            {
                if (customers.Count ==0)
                {
                    return "KH0001";
                } else
                {
                    String number_str = new string(customers[customers.Count - 1].MaKh1.Where(char.IsDigit).ToArray());
                    int number = int.Parse(number_str);
                    number++;
                    String result = number.ToString();
                    while (result.Length < 4)
                    {
                        result = "0" + result;
                    }
                    return "KH" + result;
                }
            }
            else
            {
                MessageBox.Show("Đã có lỗi xảy ra!", "Lỗi!");
                return null;
            }

        }
        #endregion

        #region b. Phục vụ chức năng chuyển đổi trạng thái phòng
        // Hàm xử lý để điều chỉnh trạng thái phòng thành trống
        public void Set_ReadyRoom(int SoPh)
        {
            DataLayer dal = new DataLayer();
            int result = dal.Proc_UpdateRoomState("PhongSanSang", SoPh);
            if (result > 0)
            {
                MessageBox.Show("Bạn đã cập nhật phòng trống thành công!", "Thông báo!");
            }
            else
            {
                MessageBox.Show("Đã có lỗi xảy ra", "Thất bại");
            }
        }

        // Hàm xử lý để điều chỉnh trạng thái phòng thành sửa chữa
        public void Set_FixingRoom(int SoPh)
        {
            DataLayer dal = new DataLayer();
            int result = dal.Proc_UpdateRoomState("SuaChuaPhong", SoPh);
            if (result > 0)
            {
                MessageBox.Show("Bạn đã cập nhật phòng sửa chữa thành công!", "Thông báo!");
            }
            else
            {
                MessageBox.Show("Đã có lỗi xảy ra", "Thất bại");
            }
        }

        // Hàm xử lý để điều chỉnh trạng thái phòng thành dọn dẹp 
        public void Set_CleaningRoom(int SoPh)
        {
            DataLayer dal = new DataLayer();
            int result = dal.Proc_UpdateRoomState("DonDepPhong", SoPh);
            if (result > 0)
            {
                MessageBox.Show("Bạn đã cập nhật phòng dọn dẹp thành công!", "Thông báo!");
            }
            else
            {
                MessageBox.Show("Đã có lỗi xảy ra", "Thất bại");
            }
        }

        #endregion

        #region c. Phục vụ chức năng checkin đơn đặt phòng
        // Hàm nhận phòng (checkin) bằng MaDatPh
        public void Checkin_Room(String MaDatPh)
        {
            DataLayer dal = new DataLayer();
            int result = dal.Proc_RoomCheckin(MaDatPh);
            if (result > 0)
            {
                MessageBox.Show("Đã checkin thành công cho đơn đặt phòng này!", "Thông báo!");
            }
            else
            {
                MessageBox.Show("Đã có lỗi xảy ra", "Thất bại");
            }
        }

        // Hàm xóa đơn đặt phòng
        public void Delete_Checkin_Room(String MaDatPh)
        {
            DataLayer dal = new DataLayer();
            int result = dal.Proc_DeleteCheckin(MaDatPh);
            if (result != 0)
            {
                MessageBox.Show("Đã xóa thành công đơn đặt phòng này!", "Thông báo!");
            }
            else
            {
                MessageBox.Show("Đã có lỗi xảy ra", "Thất bại");
            }
        }
        #endregion

        #region d.Chức năng checkout phòng

        public String New_Invoice(String MaDonDat)
        {
            return MaDonDat.Replace("DP", "HD");
        }

        public void Addinvoice_room(String MaDatPh, String MaKM, String PTTT, Decimal tongHD)
        {
            DataLayer dal = new DataLayer();
            String newMaHD = New_Invoice(MaDatPh);
            int result = dal.PROC_Addinvoice(newMaHD, MaDatPh, MaKM, PTTT, tongHD);
            if (result == 0)
            {
                MessageBox.Show("Đã có lỗi xảy ra", "Thất bại");
            }
        }

        public void Checkout_room(String MaDatPh)
        {
            DataLayer dal = new DataLayer();
            int result = dal.PROC_Checkout(MaDatPh);
            if (result == 0)
            {
                MessageBox.Show("Đã có lỗi xảy ra", "Thất bại");
            }
        }


        public DataTable List_ServiceToRoomInvoice(String MaDonDat)
        {
            DataLayer dal = new DataLayer();
            DataTable dataTable = dal.Function_ServiceToRoom(MaDonDat);


            DataTable roomservice = new DataTable();

            // Thêm các cột vào DataTable
            roomservice.Columns.Add("STT", typeof(int));
            roomservice.Columns.Add("TenDV", typeof(string));
            roomservice.Columns.Add("SoLuong", typeof(int));
            roomservice.Columns.Add("DonGia", typeof(decimal));
            int i = 1;
            if (dataTable != null)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    String db_name = row["TenDV"].ToString();
                    int SoLuong = (int)row["SoLuong"];
                    decimal Gia = (decimal)row["DonGia"];
                    Service ser = new Service(db_name, SoLuong, Gia);

                    DataRow service_row = roomservice.NewRow();
                    service_row["STT"] = i;
                    service_row["TenDV"] = ser.Name;
                    service_row["SoLuong"] = ser.Soluong1;
                    service_row["DonGia"] = ser.Gia;
                    roomservice.Rows.Add(service_row);
                    i++;
                }
            }
            return roomservice;
        }

        public String MaHoaDon(String MaDatPh)
        {
            DataLayer dal = new DataLayer();
            DataTable view = dal.View_HoaDon();
            foreach(DataRow row in view.Rows)
            {
                if (row["MaDatPh"].ToString() == MaDatPh)
                {
                    return row["MaHD"].ToString();
                }
            }
            return null;
        }

        public String TinhTienDV(String MaDatPh)
        {
            List<Service> list_service = List_ServiceToRoom(MaDatPh);
            if(list_service.Count > 0)
            {
                DataLayer dal = new DataLayer();
                decimal tongtien = dal.FUNC_TinhTienDV(MaDatPh);
                return tongtien.ToString("N0");
            }
            return "0";
        }

        public String TinhTienPhong(String MaDatPh)
        {
            DataLayer dal = new DataLayer();
            decimal tongtien = dal.FUNC_TinhTienPhong(MaDatPh);       
            return tongtien.ToString("N0");
        }

        public decimal TinhTienHD(String MaDatPh, double GiaTriKM)
        {
            DataLayer dal = new DataLayer();
            decimal tongtien = dal.FUNC_TinhTienHD(MaDatPh, GiaTriKM);
            return tongtien;
        }
        #endregion

        #region e. Thêm dịch vụ cho đơn đặt phòng nếu khách có nhu cầu
        // Hảm xử lý để thêm một mã dịch vụ dưa trên mã đơn đặt phòng
        public void Add_ServiceOrder(String MaDonDat)
        {
            DataLayer dal = new DataLayer();
            int result = dal.Proc_AddServiceOrder(MaDonDat.Replace("DP", "DV"), MaDonDat);
            if (result <= 0)
            {
                MessageBox.Show("Đã có lỗi xảy ra", "Thất bại");
            }
        }

        // Hàm xử lý để thêm tuần tự các dịch vụ có trong List vào MaDatPh
        public void Add_Service(String MaDatPh, List<String> TenDV, List<int> SoLuong, DateTime NgayDat)
        {
            DataLayer dal = new DataLayer();
            for (int i = 0; i < TenDV.Count; i++)
            {
                int result = dal.Proc_AddServiceToOrder(MaDatPh, TenDV[i], SoLuong[i], NgayDat);
                if (result <= 0)
                {
                    MessageBox.Show("Đã có lỗi xảy ra khi thêm dịch vụ: " + TenDV[i], "Thất bại");
                }
            }
        }

        #endregion


        // Các chức năng
        #region a. Phục vụ chức năng Login
        // Hàm xử lý kiểm tra đăng nhập (trả về "Tên NV, Chức vụ)
        public static String Check_Login(String account, String password)
        {
            DataLayer.taikhoan = account;
            DataLayer.matkhau = password;
            DataLayer dal = new DataLayer();
            DataTable result = dal.Function_CheckLogin(account, password);
            if (result != null)
            {
                foreach (DataRow row in result.Rows)
                {
                    if (row["TenNV"] != DBNull.Value)
                    {
                        return row["TenNV"].ToString() + "-" + row["VaiTro"].ToString();
                    }
                }
            }
            return null;
        }
        #endregion

        #region b. Tìm kiếm khách hàng
        // Hàm xử lý để tìm thông tin khách hàng với CCCD (Để tìm khách đã có thông tin)
        public Customer Find_Customer_WithID(String CCCD)
        {
            DataLayer dal = new DataLayer();
            DataTable dataTable = dal.Function_FindCustomer_WithID(CCCD);
            if (dataTable != null)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    if (row["MaKh"] != DBNull.Value)
                    {
                        return new Customer(row["MaKh"].ToString(), row["HoTen"].ToString(), row["DiaChi"].ToString(), CCCD, row["LienLac"].ToString(), (DateTime)row["NgaySinh"]);
                    }
                }
            }
            return null;
        }


        // Hàm xử lý tìm khách hàng với Mã khách hàng
        public Customer Find_customer(String MaKh)
        {
            DataLayer dal = new DataLayer();
            DataTable table_customer = dal.Function_FindCustomer(MaKh);
            if (table_customer != null)
            {
                foreach (DataRow row in table_customer.Rows)
                {
                    String HoTen = row["HoTen"].ToString();
                    String DiaChi = row["DiaChi"].ToString();
                    String CCCD = row["CCCD"].ToString();
                    String LienLac = row["LienLac"].ToString();
                    Object NgaySinh = row["NgaySinh"];
                    return new Customer(MaKh, HoTen, DiaChi, CCCD, LienLac, (DateTime)NgaySinh);
                }
            }
            return new Customer("Unknown", "Unknown", "Unknown", "Unknown", "Unknown", DateTime.Now);
        }

        public Customer Find_customer_WithMaHD(String MaHD)
        {
            DataLayer dal = new DataLayer();
            DataTable table_customer = dal.Function_FindCustomer_WithMaHD(MaHD);
            if (table_customer != null)
            {
                foreach (DataRow row in table_customer.Rows)
                {
                    String HoTen = row["TenKH"].ToString();
                    String DiaChi = row["DiaChi"].ToString();
                    String CCCD = row["CCCD"].ToString();
                    String LienLac = row["LienLac"].ToString();
                    Object NgaySinh = row["NgaySinh"];
                    return new Customer("Unknown", HoTen, DiaChi, CCCD, LienLac, (DateTime)NgaySinh);
                }
            }
            return new Customer("Unknown", "Unknown", "Unknown", "Unknown", "Unknown", DateTime.Now);
        }

        #endregion

        #region c. Lấy thông tin danh sách các dịch vụ đã sử dụng theo đơn đặt phòng
        // Hàm xử lý để lấy các dịch vụ được sử dụng theo MaDonDat trả về List<Service>
        public List<Service> List_ServiceToRoom(String MaDonDat)
        {
            DataLayer dal = new DataLayer();
            DataTable dataTable = dal.Function_ServiceToRoom(MaDonDat);
            List<Service> list_service = new List<Service>();
            if (dataTable != null)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    String db_name = row["TenDV"].ToString();
                    int soluong = (int)row["SoLuong"];
                    decimal gia = (decimal)row["DonGia"];
                    list_service.Add(new Service(db_name, soluong, gia));
                }
            }
            return list_service;
        }

        #endregion

        #region d. Lấy thông tin đơn đặt phòng, phòng, khách hàng theo thời gian nhập vào
        // Hàm xử lý các thông tin phòng (Số phòng,...) được đặt trước hay đang thuê,... với input là khoảng thời gian cần biết 
        public List<Room> List_Room_WithTime(DateTime timestart, DateTime timeend)
        {
            DataLayer dal = new DataLayer();
            DataTable dataTable = dal.Function_ListRoomWithTime(timestart, timeend);
            List<Room> list_room = this.List_Room();
            if (dataTable != null)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    var SoPh = row["SoPh"];
                    var MaDonDat = row["MaDonDat"];
                    var NgayBatDau = row["NgayBatDau"];
                    var NgayKetThuc = row["NgayKetThuc"];
                    var MaKh = row["MaKh"];
                    var TrangThDon = row["TrangThDon"];
                    if (MaDonDat != DBNull.Value)
                    {
                        foreach (Room room in list_room)
                        {
                            if (room.SoPh1 == (int)SoPh)
                            {
                                room.Room_Booked((DateTime)NgayBatDau, (DateTime)NgayKetThuc, MaKh.ToString(), TrangThDon.ToString(), MaDonDat.ToString());
                                break;
                            }
                        }
                    }
                }
            }
            return list_room;
        }
        #endregion



        // For admin 
        #region a. Chức năng quản lý tài khoản
        // Hàm xử lý để lấy thông tin nhân viên cùng tài khoản
        public static List<String> MaNV = new List<String>();
        public DataTable Staff_Information()
        {
            MaNV = new List<String>();
            DataLayer dal = new DataLayer();
            DataTable dataTable = dal.View_Staff();
            if (dataTable!=null)
            {
                DataTable result = new DataTable();
                result.Columns.Add("STT");
                result.Columns.Add("Họ tên");
                result.Columns.Add("Liên lạc");
                result.Columns.Add("CCCD");
                result.Columns.Add("Tài khoản");
                result.Columns.Add("Mật khẩu");
                result.Columns.Add("Vai trò");
                int dem = 1;
                foreach (DataRow row in dataTable.Rows)
                {
                    String mk = hasher.Encode(row["MatKhau"].ToString());
                    String role = (row["VaiTro"].ToString() == "NhanVien") ? ("Nhân viên") : ((row["VaiTro"].ToString() == "admin") ? ("Admin") : ("Chủ"));
                    result.Rows.Add(dem.ToString(), row["TenNV"].ToString(), row["LienLac"].ToString(), row["CCCD"].ToString(), row["TenDN"].ToString(), mk, role);
                    dem++;
                    MaNV.Add(row["MaNV"].ToString());
                }
                return result;
            }
            return new DataTable();
        }

        // Hàm xử lý để thêm nhân viên với tài khoản vào hệ thống
        public void  Add_StaffAccount(String MaNV, String TenNV, String LienLac, String CCCD, String VaiTro, String TenDN, String MatKhau)
        {
            DataLayer dal = new DataLayer();
            int result = dal.Proc_AddStaffAccount(MaNV,TenNV,LienLac,CCCD,VaiTro,TenDN,MatKhau);
            if (result <= 0) { MessageBox.Show("Tác vụ thất bại!", "Lỗi!"); }
            else
            {
                MessageBox.Show("Thực hiện thành công!", "Thông báo!");
            }
        }

        // Hàm xử lý để sinh ra mã nhân viên mới từ View NhanVien
        public String New_StaffID()
        {
            DataLayer dal = new DataLayer();
            DataTable dataTable = dal.View_AllStaff();
            if (dataTable != null)
            {
                if (dataTable.Rows.Count==0)
                {
                    return "NV01";
                }
                else
                {
                    String MaNV = (dataTable.Rows[dataTable.Rows.Count - 1])["MaNV"].ToString();
                    int MaNV_number = int.Parse(new string(MaNV.Where(char.IsDigit).ToArray()));
                    MaNV_number += 1;
                    String result = MaNV_number.ToString();
                    while (result.Length < 2)
                    {
                        result = "0" + result;
                    }
                    return "NV" + result;
                }
            }else
            {
                MessageBox.Show("Đã có lỗi xảy ra!", "Lỗi!");
            return null;
            }
            
        }

        // Hàm xử lý để xóa một nhân viên 
        public void Delete_StaffAccount(String MaNV)
        {
            DataLayer dal = new DataLayer();
            int result = dal.Proc_DeleteStaffAccount(MaNV);
            if (result <= 0) { MessageBox.Show("Tác vụ thất bại!", "Lỗi!"); }
            else
            {
                MessageBox.Show("Thực hiện thành công!", "Thông báo!");
            }
        }


        // Hàm xử lý để sửa thông tin phòng hiện tại
        public void Fix_RoomInformation(String TenLoaiPh, int SoPh, String GiaPhH, String GiaPhNg, int SucChua)
        {
            DataLayer dal = new DataLayer();
            int result = dal.Proc_FixRoomInformation(TenLoaiPh, SoPh, GiaPhH, GiaPhNg, SucChua);
            if (result <= 0) { MessageBox.Show("Tác vụ thất bại!", "Lỗi!"); }
            else
            {
                MessageBox.Show("Thực hiện thành công!", "Thông báo!");
            }
        }

        // Hàm xử lý để lấy ra một mã phòng mới
        public String New_RoomID()
        {
            DataLayer dal = new DataLayer();
            DataTable view = dal.View_Room();
            String DonDatPh;
            if (view != null)
            {
                if (view.Rows.Count == 0)
                {
                    return "PH01";
                } else
                {
                    DonDatPh = (view.Rows[view.Rows.Count - 1])["MaPh"].ToString();
                    String number_str = new string(DonDatPh.Where(char.IsDigit).ToArray());
                    int number = int.Parse(number_str);
                    number++;
                    String result = number.ToString();
                    while (result.Length < 2)
                    {
                        result = "0" + result;
                    }
                    return "PH" + result;
                }
            }
            else
            {
                MessageBox.Show("Đã có lỗi xảy ra!", "Lỗi!");
                return null;
            }
        }

        // Hàm xử lý để thêm một phòng mới
        public void Add_Room(String TenLoaiPh, int SoPh, decimal GiaPhH, decimal GiaPhNg, int SucChua)
        {
            DataLayer dal = new DataLayer();
            String new_Maph = New_RoomID();
            int result = dal.Proc_AddRoom(new_Maph,TenLoaiPh, SoPh, GiaPhH, GiaPhNg, SucChua);
            if (result <= 0) { MessageBox.Show("Tác vụ thất bại!", "Lỗi!"); }
            else
            {
                MessageBox.Show("Thực hiện thành công!", "Thông báo!");
            }
        }

        // Hảm xử lý để sửa thông tin của khuyến mãi
        public void Fix_Promotion(String MaKM, String TenKM, DateTime NgayBatDau, DateTime NgayKetThuc, double GiaTriKM)
        {
            DataLayer dal = new DataLayer();
            int result = dal.Proc_FixPromotion(MaKM,TenKM,NgayBatDau, NgayKetThuc, GiaTriKM);
            if (result <= 0) { MessageBox.Show("Tác vụ thất bại!", "Lỗi!"); }
            else
            {
                MessageBox.Show("Thực hiện thành công!", "Thông báo!");
            }
        }

        // Hàm xử lý để thêm một khuyến mãi mới
        public void Add_Promotion(String MaKM, String TenKM, DateTime NgayBatDau, DateTime NgayKetThuc, double GiaTriKM)
        {
            DataLayer dal = new DataLayer();
            int result = dal.Proc_AddPromotion(MaKM, TenKM, NgayBatDau, NgayKetThuc, GiaTriKM);
            if (result <= 0) { MessageBox.Show("Tác vụ thất bại!", "Lỗi!"); }
            else
            {
                MessageBox.Show("Thực hiện thành công!", "Thông báo!");
            }
        }

        // Hàm xử lý để sửa thông tin của một dịch vụ
        public void Fix_Service(String MaDV, String NewTenDV, decimal NewGiaDV,String oldnameDB, String category)
        {
            DataLayer dal = new DataLayer();
            int result = dal.Proc_FixService(MaDV, Service.ChuyenChuoi(NewTenDV), NewGiaDV);
            if (result <= 0) { MessageBox.Show("Tác vụ thất bại!", "Lỗi!"); }
            else
            {
                int result2 = Service.Fix_to_Filetxt_Service(oldnameDB, NewTenDV,category);
                if (result2 == 1) { MessageBox.Show("Thực hiện thành công!", "Thông báo!"); }
            }
        }

        // Hàm xử lý để lấy một mã dịch vụ mới tùy thuộc theo loại dịch vụ
        public String New_ServiceID(String category)
        {
            DataLayer dal = new DataLayer();
            DataTable dataTable = dal.View_Service();
            if (dataTable != null)
            {
                List<int> list_MaDV = new List<int>();
                if (category == "Food" | category == "Drink") { category = "FD"; }
                else { category = "PH"; }
                foreach (DataRow row in dataTable.Rows)
                {
                    if (row["MaDV"].ToString().Contains(category))
                    {
                        String MaDV = row["MaDV"].ToString().Replace(category,"");
                        list_MaDV.Add(int.Parse(MaDV));
                    }
                }
                if (list_MaDV.Count>0)
                {
                    int result = 0;
                    for (int i = list_MaDV.Min(); i <= list_MaDV.Max(); i++)
                    {
                        if (!list_MaDV.Contains(i))
                        {
                            result = i;
                            break;
                        }
                    }

                    if (result == 0)
                    {
                        result = list_MaDV.Max() + 1;
                    }

                    String result_str = result.ToString();
                    while (result_str.Length <2)
                    {
                        result_str = "0" + result_str;
                    }
                    return category + result_str;


                } else
                {
                    return category + "01";
                }
            } 
            else { return null; }
        }


        // Hàm xử lý để thêm một dịch vụ mới
        public void Add_Service(String TenDV, decimal GiaDV,String category,String path)
        {
            DataLayer dal = new DataLayer();
            String MaDV = New_ServiceID(category);
            int result = dal.Proc_AddService(MaDV, Service.ChuyenChuoi(TenDV), GiaDV);
            if (result <= 0) { MessageBox.Show("Tác vụ thất bại!", "Lỗi!"); }
            else
            {
                int result2 = Service.Add_to_Filetxt_Service(TenDV, category,path);
                if (result2 == 1) { MessageBox.Show("Thực hiện thành công!", "Thông báo!"); }
            }
        }

        // Hàm xử lý để xóa một dịch vụ có sẵn
        public void Delete_Service(String MaDV,String oldnameDB)
        {
            DataLayer dal = new DataLayer();
            int result = dal.Proc_DeleteService(MaDV);
            if (result<=0) { MessageBox.Show("Tác vụ thất bại!", "Lỗi!"); }
            else
            {
                int result2 = Service.Delete_to_Filetxt_Service(oldnameDB);
                if (result2 == 1) { MessageBox.Show("Thực hiện thành công!", "Thông báo!"); }
            }
        }


        // Hàm xử lý để thống kê hóa đơn đặt phòng
        public Bunifu.Dataviz.WinForms.BunifuDatavizAdvanced.Canvas Statistic_BookingOrder(DateTime dateTime)
        {
            DataLayer dal = new DataLayer();
            DataTable dataTable = dal.Function_StatisticBookingOrder(dateTime,DateTime.Now);
            if (dataTable != null)
            {
                // DataPoint cho checkin
                Bunifu.Dataviz.WinForms.BunifuDatavizAdvanced.DataPoint checkin_point = new Bunifu.Dataviz.WinForms.BunifuDatavizAdvanced.DataPoint(Bunifu.Dataviz.WinForms.BunifuDatavizAdvanced._type.Bunifu_stackedArea);
                // DataPoint cho checkout
                Bunifu.Dataviz.WinForms.BunifuDatavizAdvanced.DataPoint checkout_point = new Bunifu.Dataviz.WinForms.BunifuDatavizAdvanced.DataPoint(Bunifu.Dataviz.WinForms.BunifuDatavizAdvanced._type.Bunifu_stackedArea);

                foreach (DataRow row in dataTable.Rows)
                {
                    DateTime day = DateTime.Parse(row["Ngay"].ToString());
                    int number_checkin = 0;
                    int number_checkout = 0;
                    if (row["SoLuongDonDat"] != DBNull.Value)
                    {
                        number_checkin = (int)row["SoLuongDonDat"];
                    }
                    if (row["SoLuongDonTra"] != DBNull.Value)
                    {
                        number_checkout = (int)row["SoLuongDonTra"];
                    }
                    checkin_point.addLabely(day.ToString("dd-MM-yyyy"),(int)number_checkin);
                    checkout_point.addLabely(day.ToString("dd-MM-yyyy"),(int)number_checkout);
                }

                Bunifu.Dataviz.WinForms.BunifuDatavizAdvanced.Canvas canvas = new Bunifu.Dataviz.WinForms.BunifuDatavizAdvanced.Canvas();
                canvas.addData(checkin_point);
                canvas.addData(checkout_point);
                return canvas;
            } else
            {
                return null;
            }
        }


        public static decimal Tong_DoanhThu = 0;

        // Hàm thống kê tổng doanh thu của từng phần đặt phòng và dịch và trả về một biểu đồ canvas theo ngày
        public Bunifu.Dataviz.WinForms.BunifuDatavizAdvanced.Canvas Statistic_Day_Revenue(DateTime timestart,DateTime timeend)
        {
            Tong_DoanhThu = 0;
            DataLayer dal = new DataLayer();
            DataTable dataTable = dal.Function_StatisticBookingOrder(timestart, timeend);
            if (dataTable != null)
            {
                // Tạo ra đối tượng datapoint
                Bunifu.Dataviz.WinForms.BunifuDatavizAdvanced.DataPoint datapoint1 = new Bunifu.Dataviz.WinForms.BunifuDatavizAdvanced.DataPoint(Bunifu.Dataviz.WinForms.BunifuDatavizAdvanced._type.Bunifu_stackedColumn);
                Bunifu.Dataviz.WinForms.BunifuDatavizAdvanced.DataPoint datapoint2 = new Bunifu.Dataviz.WinForms.BunifuDatavizAdvanced.DataPoint(Bunifu.Dataviz.WinForms.BunifuDatavizAdvanced._type.Bunifu_stackedColumn);
                foreach (DataRow row in dataTable.Rows)
                {
                    DateTime day = DateTime.Parse(row["Ngay"].ToString());
                    decimal HD = 0;
                    decimal DV = 0;
                    if (row["TongTienHD"] != DBNull.Value)
                    {
                        HD = (decimal)row["TongTienHD"];
                    }
                    if (row["TongTienDV"] != DBNull.Value)
                    {
                        DV = (decimal)row["TongTienDV"];
                    }
                    Tong_DoanhThu += HD + DV;
                    datapoint1.addLabely(day.ToString("dd-MM-yyyy"), HD);
                    datapoint2.addLabely(day.ToString("dd-MM-yyyy"), DV);
                }
             
                Bunifu.Dataviz.WinForms.BunifuDatavizAdvanced.Canvas canvas = new Bunifu.Dataviz.WinForms.BunifuDatavizAdvanced.Canvas();
                canvas.addData(datapoint1);
                canvas.addData(datapoint2);
                return canvas;
            }
            else
            {
                return null;
            }
        }

        // Hàm thống kê tổng doanh thu của từng phần đặt phòng và dịch và trả về một biểu đồ canvas theo tháng
        public Bunifu.Dataviz.WinForms.BunifuDatavizAdvanced.Canvas Statistic_Month_Revenue(DateTime timestart, DateTime timeend)
        {
            Tong_DoanhThu = 0;
            DataLayer dal = new DataLayer();
            Bunifu.Dataviz.WinForms.BunifuDatavizAdvanced.DataPoint datapoint1 = new Bunifu.Dataviz.WinForms.BunifuDatavizAdvanced.DataPoint(Bunifu.Dataviz.WinForms.BunifuDatavizAdvanced._type.Bunifu_stackedColumn);
            Bunifu.Dataviz.WinForms.BunifuDatavizAdvanced.DataPoint datapoint2 = new Bunifu.Dataviz.WinForms.BunifuDatavizAdvanced.DataPoint(Bunifu.Dataviz.WinForms.BunifuDatavizAdvanced._type.Bunifu_stackedColumn);
            for (DateTime currentDate = timestart; currentDate <= timeend; currentDate = currentDate.AddMonths(1))
            {
                DataTable dataTable = dal.Function_StatisticBookingOrder(new DateTime(currentDate.Year, currentDate.Month, 1), new DateTime(currentDate.Year, currentDate.Month, 1).AddMonths(1).AddDays(-1));
                if (dataTable != null)
                {
                    decimal HD = 0;
                    decimal DV = 0;
                    foreach (DataRow row in dataTable.Rows)
                    {
                        if (row["TongTienHD"] != DBNull.Value)
                        {
                            HD += (decimal)row["TongTienHD"];
                        }
                        if (row["TongTienDV"] != DBNull.Value)
                        {
                            DV += (decimal)row["TongTienDV"];
                        }
                    }
                    datapoint1.addLabely("Tháng " + currentDate.Month.ToString() + "/" + currentDate.Year.ToString(), HD);
                    datapoint2.addLabely("Tháng " + currentDate.Month.ToString() + "/" + currentDate.Year.ToString(), DV);
                    Tong_DoanhThu += HD + DV;
                }
            }

            Bunifu.Dataviz.WinForms.BunifuDatavizAdvanced.Canvas canvas = new Bunifu.Dataviz.WinForms.BunifuDatavizAdvanced.Canvas();
            canvas.addData(datapoint1);
            canvas.addData(datapoint2);
            return canvas;
        }

        // Hàm xử lý để thống kê và lấy ra các chỉ số như là doanh thu ngày, số checkin checkout,...
        public List<double> Statistic_today()
        {
            DataLayer dal = new DataLayer();

            double checkin = 0;
            double checkout = 0;
            double doanhthu = 0;
            DataTable dataTable = dal.Function_StatisticBookingOrder(DateTime.Now, DateTime.Now);
            if (dataTable != null)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    if (row["SoLuongDonDat"] != DBNull.Value) { checkin += int.Parse(row["SoLuongDonDat"].ToString()); }
                    if (row["SoLuongDonTra"] != DBNull.Value) { checkout += int.Parse(row["SoLuongDonTra"].ToString()); }
                    if (row["TongTienHD"] != DBNull.Value) { doanhthu += double.Parse(row["TongTienHD"].ToString()); }
                    if (row["TongTienDV"] != DBNull.Value) { doanhthu += double.Parse(row["TongTienDV"].ToString()); }
                }
            }

            double readyroom = 0;
            double hiredroom = 0;
            double cleaningroom = 0;
            double fixingroom = 0;
            List<Room> list_room = this.List_Room();
            foreach (Room room in list_room)
            {
                if (room.TrangThai1 == "trong") { readyroom++; }
                if (room.TrangThai1 == "dangsuachua") { fixingroom++; }
                if (room.TrangThai1 == "dangdondep") { cleaningroom++; }
                if (room.TrangThai1 == "dangchothue") { hiredroom++; }
            }

            return new List<double> { doanhthu, checkin, checkout, readyroom, hiredroom, cleaningroom, fixingroom };
        }


        // Hàm xử lý để thống kê dịch dụ được sử dụng trả về một canvas
        public Bunifu.Dataviz.WinForms.BunifuDatavizBasic.Canvas Statistic_NumberService_Circle(DateTime timestart, DateTime timeend)
        {
            DataLayer dal = new DataLayer();
            DataTable dataTable = dal.Function_StatisticService(timestart, timeend);
            Bunifu.Dataviz.WinForms.BunifuDatavizBasic.DataPoint datapoint = new Bunifu.Dataviz.WinForms.BunifuDatavizBasic.DataPoint(Bunifu.Dataviz.WinForms.BunifuDatavizBasic._type.Bunifu_pie);
            if (dataTable != null)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    String name = row["TenDV"].ToString();
                    int SoLuongDatDV = (row["SoLuongDatDV"] != DBNull.Value) ? (int.Parse(row["SoLuongDatDV"].ToString())) : (0);
                    datapoint.addLabely(name, SoLuongDatDV);
                }
            }
            Bunifu.Dataviz.WinForms.BunifuDatavizBasic.Canvas canvas = new Bunifu.Dataviz.WinForms.BunifuDatavizBasic.Canvas();
            canvas.addData(datapoint);
            return canvas;
        }

        public static decimal Tong_DichVu = 0;
        // Hàm xử lý để thống kê dịch dụ được sử dụng trả về một dataTable
        public DataTable Statistic_NumberService_Datatable(DateTime timestart, DateTime timeend)
        {
            Tong_DichVu = 0;
            DataLayer dal = new DataLayer();
            DataTable dataTable = dal.Function_StatisticService(timestart, timeend);
            if (dataTable != null)
            {
                foreach(DataRow row in dataTable.Rows)
                {
                    if (row["SoLuongDatDV"] == DBNull.Value)
                    {
                        row["SoLuongDatDV"] = "0";
                    }
                    if (row["TongTien"] == DBNull.Value)
                    {
                        row["TongTien"] = "0";
                    } else
                    {
                        Tong_DichVu += (decimal)row["TongTien"];
                    }

                }
                dataTable.Columns["TenDV"].ColumnName = "Tên dịch vụ";
                dataTable.Columns["SoLuongDatDV"].ColumnName = "Số lượng";
                dataTable.Columns["TongTien"].ColumnName = "Tổng tiền";
                return dataTable;
            }
            return new DataTable();
        }

        public void Fix_StaffAccount(String MaNV, String NewTenNV, String NewLienLac, String NewCCCD, String NewVaiTro, String NewTenDN, String NewMatKhau)
        {
            DataLayer dal = new DataLayer();
            int result = dal.Proc_FixStaffAccount(MaNV, NewTenNV, NewLienLac, NewCCCD, NewVaiTro, NewTenDN, NewMatKhau);
            if (result <= 0) { MessageBox.Show("Tác vụ thất bại!", "Lỗi!"); }
            else
            {
                MessageBox.Show("Thực hiện thành công!", "Thông báo!");
            }
        }


        #endregion

    }
}

