using Hobook_Software.Class;
using Hobook_Software.GUI.Dashboard;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Xml.Linq;

namespace Hobook_Software.DAL
{
    public class DataLayer
    {
        private SqlConnection sqlCon = null;
        private string strCon = @"";
        public static String taikhoan;
        public static String matkhau;

        public DataLayer()
        {
            
        }


        #region Kết nối Database và ngắt kết nối
        private void Connect()
        {
            string datasource = @"Data Source='26.46.117.205, 2703';Initial Catalog=test_QLKS;Persist Security Info=True";
            string username = @";User Id=" + taikhoan; // Nhập tài khoản truy cập SQL tại đây
            string password = @";Password=" + matkhau; // Nhập password truy cập SQL tại đây
            strCon = datasource + username + password; 
            try
            {
                if (sqlCon != null && sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
                sqlCon = new SqlConnection(strCon);
                if (sqlCon.State == ConnectionState.Closed)
                {
                    sqlCon.Open();
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show("Liên hệ kỹ thuật viên để được hỗ trợ!\n" + e.Message, "Lỗi truy vấn SQL Server!");
            }
        }

        private void Disconnect()
        {
            try
            {
                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show("Liên hệ kỹ thuật viên để được hỗ trợ!\n" + e.Message, "Lỗi truy vấn SQL Server!");
            }
        }

        #endregion

        #region Các View cần thiết
        // Hàm truy vấn View khách hàng
        public DataTable View_Customer()
        {
            try
            {
                Connect();
                if (sqlCon.State == ConnectionState.Open)
                {
                    string ex = "SELECT * FROM dbo.VIEW_ThongTinKhachHang";
                    using (SqlCommand command = new SqlCommand(ex, sqlCon))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable result = new DataTable();
                            adapter.Fill(result);
                            Disconnect();
                            return result;
                        }
                    }
                }
                else
                {
                    return null;
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show("Liên hệ kỹ thuật viên để được hỗ trợ!\n" + e.Message, "Lỗi truy vấn SQL Server!");
                return null;
            }

        }

        // Hàm truy vấn view thông tin phòng ở thời điểm hiện tại
        public DataTable View_Room()
        {
            try
            {
                Connect();
                if (sqlCon.State == ConnectionState.Open)
                {
                    string ex = "SELECT * FROM dbo.VIEW_ThongTinPhong";
                    using (SqlDataAdapter adapter = new SqlDataAdapter(ex, sqlCon))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        Disconnect();
                        return dataTable;
                    }
                }
                else
                {
                    return null;
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show("Liên hệ kỹ thuật viên để được hỗ trợ!\n" + e.Message, "Lỗi truy vấn SQL Server!");
                return null;
            }

        }

        // Hàm truy vấn View dịch vụ
        public DataTable View_Service()
        {
            try
            {
                Connect();
                if (sqlCon.State == ConnectionState.Open)
                {
                    String ex = "SELECT * FROM dbo.VIEW_DichVu";
                    using (SqlCommand command = new SqlCommand(ex, sqlCon))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            Disconnect();
                            return dataTable;
                        }
                    }
                }
                else
                {
                    return null;
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show("Liên hệ kỹ thuật viên để được hỗ trợ!\n" + e.Message, "Lỗi truy vấn SQL Server!");
                return null;
            }
        }

        public DataTable View_Promotion()
        {
            try
            {
                Connect();
                if (sqlCon.State == ConnectionState.Open)
                {
                    String ex = "SELECT * FROM dbo.VIEW_KhuyenMai";
                    using (SqlCommand command = new SqlCommand(ex, sqlCon))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            Disconnect();
                            return dataTable;
                        }
                    }
                }
                else
                {
                    return null;
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show("Liên hệ kỹ thuật viên để được hỗ trợ!\n" + e.Message, "Lỗi truy vấn SQL Server!");
                return null;
            }
        }

        // Hàm truy vấn View Nhân viên (tài khoản)
        public DataTable View_Staff()
        {
            try
            {
                Connect();
                if (sqlCon.State == ConnectionState.Open)
                {
                    string ex = "SELECT * FROM dbo.VIEW_NhanVien";
                    using (SqlCommand command = new SqlCommand(ex, sqlCon))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable result = new DataTable();
                            adapter.Fill(result);
                            Disconnect();
                            return result;
                        }
                    }
                }
                else
                {
                    return null;
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show("Liên hệ kỹ thuật viên để được hỗ trợ!\n" + e.Message, "Lỗi truy vấn SQL Server!");
                return null;
            }

        }

        // Hàm truy vấn View toàn bộ nhân viên (kể cả nhân viên từng nghỉ)
        public DataTable View_AllStaff()
        {
            try
            {
                Connect();
                if (sqlCon.State == ConnectionState.Open)
                {
                    string ex = "SELECT * FROM dbo.VIEW_ToanBoNhanVien";
                    using (SqlCommand command = new SqlCommand(ex, sqlCon))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable result = new DataTable();
                            adapter.Fill(result);
                            Disconnect();
                            return result;
                        }
                    }
                }
                else
                {
                    return null;
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show("Liên hệ kỹ thuật viên để được hỗ trợ!\n" + e.Message, "Lỗi truy vấn SQL Server!");
                return null;
            }

        }

        #endregion


        // Các tiến trình
        #region a. Phục vụ chức năng đặt phòng
        // Hàm thêm đơn đặt phòng đối với khách đã có thông tin trong SQlServer
        public int Proc_AddBookingOrder(String MaDatPh, String TenNV, String MaKH, DateTime NgayThue, DateTime NgayTra)
        {
            try
            {
                Connect();
                if (sqlCon.State == ConnectionState.Open)
                {
                    String proc_name = "PROC_themdondatphong_dacottkh" + " @MaDatPh, @TenNV, @MaKH, @NgayThue, @NgayTra";
                    using (SqlCommand command = new SqlCommand(proc_name, sqlCon))
                    {
                        // Set parameters
                        command.Parameters.AddWithValue("@MaDatPh", MaDatPh);
                        command.Parameters.AddWithValue("@TenNV", TenNV);
                        command.Parameters.AddWithValue("@MaKH", MaKH);
                        command.Parameters.AddWithValue("@NgayThue", NgayThue.ToString("yyyy-MM-dd HH:mm:ss"));
                        command.Parameters.AddWithValue("@NgayTra", NgayTra.ToString("yyyy-MM-dd HH:mm:ss"));


                        // Thực thi 
                        int result = command.ExecuteNonQuery();

                        Disconnect();
                        return result;
                    }
                }
                else
                {
                    return 0;
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show("Liên hệ kỹ thuật viên để được hỗ trợ!\n" + e.Message, "Lỗi truy vấn SQL Server!");
                return 0;
            }

        }

        // Hàm thêm đơn đặt phòng đối với khách chưa có thông tin trong SQlServer
        public int Proc_AddBookingOrder_WithInfor(String MaDatPh, String TenNV, String HoTenKh, String MaKh, String DiaChi, String LienLac, DateTime NgaySinh, String CCCD, DateTime NgayThue, DateTime NgayTra)
        {
            try
            {
                Connect();
                if (sqlCon.State == ConnectionState.Open)
                {
                    String proc_name = "PROC_themdondatphong_chuacottkh" + " @MaDatPh, @TenNV, @HoTenKH, @MaKh, @DiaChi, @LienLac, @NgaySinh, @CCCD, @NgayThue, @NgayTra";
                    using (SqlCommand command = new SqlCommand(proc_name, sqlCon))
                    {
                        // Set parameters
                        command.Parameters.AddWithValue("@MaDatPh", MaDatPh);
                        command.Parameters.AddWithValue("@TenNV", TenNV);
                        command.Parameters.AddWithValue("@HoTenKH", HoTenKh);
                        command.Parameters.AddWithValue("@MaKh", MaKh);
                        command.Parameters.AddWithValue("@DiaChi", DiaChi);
                        command.Parameters.AddWithValue("@LienLac", LienLac);
                        command.Parameters.AddWithValue("@NgaySinh", NgaySinh.ToString("yyyy-MM-dd"));
                        command.Parameters.AddWithValue("@CCCD", CCCD);
                        command.Parameters.AddWithValue("@NgayThue", NgayThue.ToString("yyyy-MM-dd HH:mm:ss"));
                        command.Parameters.AddWithValue("@NgayTra", NgayTra.ToString("yyyy-MM-dd HH:mm:ss"));
                        // Thực thi 
                        int result = command.ExecuteNonQuery();

                        Disconnect();
                        return result;
                    }
                }
                else
                {
                    return 0;
                }
            }
            catch
            {
                MessageBox.Show("Liên hệ kỹ thuật viên để được hỗ trợ!", "Lỗi truy vấn SQL Server!");
                return 0;
            }
        }

        // Hàm thêm phòng vào đơn đặt phòng
        public int Proc_AddRoomToOrder(String MaDatPh, int SoPh)
        {
            try
            {
                Connect();
                if (sqlCon.State == ConnectionState.Open)
                {
                    String proc_name = "PROC_ThemPhongVaoDon" + " @MaDatPh, @SoPh";
                    using (SqlCommand command = new SqlCommand(proc_name, sqlCon))
                    {
                        // Set parameters
                        command.Parameters.AddWithValue("@MaDatPh", MaDatPh);
                        command.Parameters.AddWithValue("@SoPh", SoPh);

                        // Thực thi 
                        int result = command.ExecuteNonQuery();

                        Disconnect();
                        return result;
                    }
                }
                else
                {
                    return 0;
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show("Liên hệ kỹ thuật viên để được hỗ trợ!\n" + e.Message, "Lỗi truy vấn SQL Server!");
                return 0;
            }
        }

        // Hàm truy vấn các mã đơn đặt phòng
        public DataTable View_BookingOrder()
        {
            try
            {
                Connect();
                if (sqlCon.State == ConnectionState.Open)
                {
                    string ex = "SELECT * FROM dbo.VIEW_MaDonDatPh";
                    using (SqlDataAdapter adapter = new SqlDataAdapter(ex, sqlCon))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        Disconnect();
                        return dataTable;
                    }
                }
                else
                {
                    return null;
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show("Liên hệ kỹ thuật viên để được hỗ trợ!\n" + e.Message, "Lỗi truy vấn SQL Server!");
                return null;
            }
        }
        #endregion

        #region b. Phục vụ chức năng chuyển đổi trạng thái phòng
        // Hàm update trạng thái phòng qua 3 proc: PhongSanSang, DonDepPhong, SuaChuaPhong
        public int Proc_UpdateRoomState(String name, int SoPh)
        {
            try
            {
                Connect();
                if (sqlCon.State == ConnectionState.Open)
                {
                    String proc_name = "PROC_" + name + " @SoPh";
                    using (SqlCommand command = new SqlCommand(proc_name, sqlCon))
                    {
                        // Set parameters
                        command.Parameters.AddWithValue("@SoPh", SoPh);


                        // Thực thi 
                        int result = command.ExecuteNonQuery();

                        Disconnect();
                        return result;
                    }
                }
                else
                {
                    return 0;
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show("Liên hệ kỹ thuật viên để được hỗ trợ!\n" + e.Message, "Lỗi truy vấn SQL Server!");
                return 0;
            }
        }
        #endregion

        #region c. Phục vụ chức năng Checkin đơn đặt phòng
        // Hàm nhận phòng thông qua Proc_NhanPhong @MaDatPh
        public int Proc_RoomCheckin(String MaDatPh)
        {
            try
            {
                Connect();
                if (sqlCon.State == ConnectionState.Open)
                {
                    String proc_name = "PROC_NhanPhong" + " @MaDatPh";
                    using (SqlCommand command = new SqlCommand(proc_name, sqlCon))
                    {
                        // Set parameters
                        command.Parameters.AddWithValue("@MaDatPh", MaDatPh);


                        // Thực thi 
                        int result = command.ExecuteNonQuery();
                        Disconnect();
                        return result;
                    }
                }
                else
                {
                    return 0;
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show("Liên hệ kỹ thuật viên để được hỗ trợ!\n" + e.Message, "Lỗi truy vấn SQL Server!");
                return 0;
            }
        }



        // Hàm xóa đơn đặt phòng thông qua Proc_XoaDonDP @MaDatPh
        public int Proc_DeleteCheckin(String MaDatPh)
        {
            try
            {
                Connect();
                if (sqlCon.State == ConnectionState.Open)
                {
                    String proc_name = "PROC_XoaDonDP" + " @MaDatPh";
                    using (SqlCommand command = new SqlCommand(proc_name, sqlCon))
                    {
                        // Set parameters
                        command.Parameters.AddWithValue("@MaDatPh", MaDatPh);


                        // Thực thi 
                        int result = command.ExecuteNonQuery();
                        Disconnect();
                        return result;
                    }
                }
                else
                {
                    return 0;
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show("Liên hệ kỹ thuật viên để được hỗ trợ!\n" + e.Message, "Lỗi truy vấn SQL Server!");
                return 0;
            }
        }
        #endregion

        #region d. Thêm dịch vụ cho đơn đặt phòng nếu khách có nhu cầu
        // Hàm thêm đơn dịch vụ vào phòng
        public int Proc_AddServiceOrder(String MaDonDV, String MaDatPh)
        {
            try
            {
                Connect();
                if (sqlCon.State == ConnectionState.Open)
                {
                    String proc_name = "PROC_ThemDonDV" + " @MaDonDV, @MaDatPh";
                    using (SqlCommand command = new SqlCommand(proc_name, sqlCon))
                    {
                        // Set parameters
                        command.Parameters.AddWithValue("@MaDonDV", MaDonDV);
                        command.Parameters.AddWithValue("@MaDatPh", MaDatPh);


                        // Thực thi 
                        int result = command.ExecuteNonQuery();

                        Disconnect();
                        return result;
                    }
                }
                else
                {
                    return 0;
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show("Liên hệ kỹ thuật viên để được hỗ trợ!\n" + e.Message, "Lỗi truy vấn SQL Server!");
                return 0;
            }
        }

        // Hàm thêm dịch vụ vào đơn đặt phòng khi đã có mã dịch vụ
        public int Proc_AddServiceToOrder(String MaDatPh, String TenDV, int SoLuong, DateTime NgayDat)
        {
            try
            {
                Connect();
                if (sqlCon.State == ConnectionState.Open)
                {
                    String proc_name = "PROC_" + "ThemDV" + " @MaDatPh, @TenDV, @SoLuong, @NgayDat";
                    using (SqlCommand command = new SqlCommand(proc_name, sqlCon))
                    {
                        // Set parameters
                        command.Parameters.AddWithValue("@MaDatPh", MaDatPh);
                        command.Parameters.AddWithValue("@TenDV", TenDV);
                        command.Parameters.AddWithValue("@SoLuong", SoLuong);
                        command.Parameters.AddWithValue("@NgayDat", NgayDat.ToString("yyyy-MM-dd HH:mm:ss"));

                        // Thực thi 
                        int result = command.ExecuteNonQuery();

                        Disconnect();
                        return result;
                    }
                }
                else
                {
                    return 0;
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show("Liên hệ kỹ thuật viên để được hỗ trợ!\n" + e.Message, "Lỗi truy vấn SQL Server!");
                return 0;
            }
        }
        #endregion

        #region e. Thêm hoá đơn và checkout
        public DataTable View_HoaDon()
        {
            try
            {
                Connect();
                if (sqlCon.State == ConnectionState.Open)
                {
                    string ex = "SELECT * FROM dbo.VIEW_HoaDon";
                    using (SqlDataAdapter adapter = new SqlDataAdapter(ex, sqlCon))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        Disconnect();
                        return dataTable;
                    }
                }
                else
                {
                    return null;
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show("Liên hệ kỹ thuật viên để được hỗ trợ!\n" + e.Message, "Lỗi truy vấn SQL Server!");
                return null;
            }
        }

        public decimal FUNC_TinhTienDV(String MaDatPh)
        {
            try
            {
                Connect();
                if (sqlCon.State == ConnectionState.Open)
                {
                    String func_name = "SELECT dbo.FUNC_TinhTienDV(@MaDatPh)";
                    using (SqlCommand command = new SqlCommand(func_name, sqlCon))
                    {
                        // Set parameters
                        command.Parameters.AddWithValue("@MaDatPh", MaDatPh);
                        // Thực thi 
                        object result = command.ExecuteScalar();
                        Disconnect();
                        return (decimal)result;
                    }
                }
                else
                {
                    return 0;
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show("Liên hệ kỹ thuật viên để được hỗ trợ!\n" + e.Message, "Lỗi truy vấn SQL Server!");
                return 0;
            }
        }

        public decimal FUNC_TinhTienPhong(String MaDatPh)
        {
            try
            {
                Connect();
                if (sqlCon.State == ConnectionState.Open)
                {
                    String func_name = "SELECT dbo.FUNC_TinhTienPhong(@MaDatPh)";
                    using (SqlCommand command = new SqlCommand(func_name, sqlCon))
                    {
                        // Set parameters
                        command.Parameters.AddWithValue("@MaDatPh", MaDatPh);
                        // Thực thi 
                        decimal result = (decimal)command.ExecuteScalar();

                        Disconnect();
                        return result;
                    }
                }
                else
                {
                    return 0;
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show("Liên hệ kỹ thuật viên để được hỗ trợ!\n" + e.Message, "Lỗi truy vấn SQL Server!");
                return 0;
            }
        }

        public decimal FUNC_TinhTienHD(String MaDatPh, double GiaTriKM)
        {
            try
            {
                Connect();
                if (sqlCon.State == ConnectionState.Open)
                {
                    String func_name = "SELECT dbo.FUNC_TinhTongHoaDon(@MaDatPh, @GiaTriKM)";
                    using (SqlCommand command = new SqlCommand(func_name, sqlCon))
                    {
                        // Set parameters
                        command.Parameters.AddWithValue("@MaDatPh", MaDatPh);
                        command.Parameters.AddWithValue("@GiaTriKM", GiaTriKM);
                        // Thực thi 
                        decimal result = (decimal)command.ExecuteScalar();

                        Disconnect();
                        return result;
                    }
                }
                else
                {
                    return 0;
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show("Liên hệ kỹ thuật viên để được hỗ trợ!\n" + e.Message, "Lỗi truy vấn SQL Server!");
                return 0;
            }
        }

        // Thêm hoá đơn
        public int PROC_Addinvoice(String MaHD, String MaDatPh, String MaKM, String PTTT, Decimal tongHD)
        {
            try
            {
             
                Connect();
                if (sqlCon.State == ConnectionState.Open)
                {
                    String proc_name = "PROC_ThemHoaDon" + " @MaHD, @MaDatPh, @MaKM, @PhuongThucTT, @TongHD";
                    using (SqlCommand command = new SqlCommand(proc_name, sqlCon))
                    {
                        // Set parameters
                        command.Parameters.AddWithValue("@MaHD", MaHD);
                        command.Parameters.AddWithValue("@MaDatPh", MaDatPh);
                        if(MaKM != null)
                        {
                            command.Parameters.AddWithValue("@MaKM", MaKM);
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@MaKM", DBNull.Value);
                        }
                        command.Parameters.AddWithValue("@PhuongThucTT", PTTT);
                        command.Parameters.AddWithValue("@TongHD", tongHD);

                        // Thực thi 
                        int result = command.ExecuteNonQuery();

                        Disconnect();
                        return result;
                    }
                }
                else
                {
                    return 0;
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show("Liên hệ kỹ thuật viên để được hỗ trợ!\n" + e.Message, "Lỗi truy vấn SQL Server!");
                return 0;
            }
        }
        
        
        public int PROC_Checkout(String MaDatPh)
        {
            try
            {
                Connect();
                if (sqlCon.State == ConnectionState.Open)
                {
                    String proc_name = "PROC_" + "Checkout" + " @MaDatPh";
                    using (SqlCommand command = new SqlCommand(proc_name, sqlCon))
                    {
                        // Set parameters
                        command.Parameters.AddWithValue("@MaDatPh", MaDatPh);


                        // Thực thi 
                        int result = command.ExecuteNonQuery();

                        Disconnect();
                        return result;
                    }
                }
                else
                {
                    return 0;
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show("Liên hệ kỹ thuật viên để được hỗ trợ!\n" + e.Message, "Lỗi truy vấn SQL Server!");
                return 0;
            }
        }

        #endregion
        
        
        // Các chức năng
        #region a. Phục vụ chức năng Login
        // Hàm kiểm tra đăng nhập
        public DataTable Function_CheckLogin(String input1, String input2)
        {
            try
            {
                Connect();
                if (sqlCon.State == ConnectionState.Open)
                {
                    string ex = "SELECT * FROM dbo.FUNC_kiemtradangnhap" + "(@input1,@input2)";
                    using (SqlCommand command = new SqlCommand(ex, sqlCon))
                    {
                        // Thay đổi tên function và tham số tương ứng
                        command.Parameters.AddWithValue("@input1", input1);
                        command.Parameters.AddWithValue("@input2", input2);
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable result = new DataTable();
                            adapter.Fill(result);
                            Disconnect();
                            return result;
                        }
                    }
                }
                else
                {
                    return null;
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show("Liên hệ kỹ thuật viên để được hỗ trợ!\n" + e.Message, "Lỗi truy vấn SQL Server!");
                return null;
            }
        }
        #endregion

        #region b. Tìm kiếm khách hàng
        // Hàm tìm thông tin khách hàng với CCCD
        public DataTable Function_FindCustomer_WithID(String CCCD)
        {
            try
            {
                Connect();
                if (sqlCon.State == ConnectionState.Open)
                {
                    String ex = "SELECT * FROM dbo.FUNC_TimKiemKhachHang(@input1)";
                    using (SqlCommand command = new SqlCommand(ex, sqlCon))
                    {
                        command.Parameters.AddWithValue("@input1", CCCD);
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            Disconnect();
                            return dataTable;
                        }
                    }
                }
                else
                {
                    return null;
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show("Liên hệ kỹ thuật viên để được hỗ trợ!\n" + e.Message, "Lỗi truy vấn SQL Server!");
                return null;
            }
        }

        // Hàm truy vấn thông tin khách hàng với mã khách hàng
        public DataTable Function_FindCustomer(String MaKh)
        {
            try
            {
                Connect();
                if (sqlCon.State == ConnectionState.Open)
                {
                    string ex = "SELECT * FROM dbo." + "FUNC_TimKiemMaKH" + "(@input1)";
                    using (SqlCommand command = new SqlCommand(ex, sqlCon))
                    {
                        // Thay đổi tên function và tham số tương ứng
                        command.Parameters.AddWithValue("@input1", MaKh);
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable result = new DataTable();
                            adapter.Fill(result);
                            Disconnect();
                            return result;
                        }
                    }
                }
                else
                {
                    return null;
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show("Liên hệ kỹ thuật viên để được hỗ trợ!\n" + e.Message, "Lỗi truy vấn SQL Server!");
                return null;
            }
        }

        // Hàm truy vấn thông tin khách hàng với mã hóa đơn
        public DataTable Function_FindCustomer_WithMaHD(String MaHD)
        {
            try
            {
                Connect();
                if (sqlCon.State == ConnectionState.Open)
                {
                    string ex = "SELECT * FROM dbo." + "FUNC_TraCuuHoaDonKhachHang" + "(@input1)";
                    using (SqlCommand command = new SqlCommand(ex, sqlCon))
                    {
                        // Thay đổi tên function và tham số tương ứng
                        command.Parameters.AddWithValue("@input1", MaHD);
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable result = new DataTable();
                            adapter.Fill(result);
                            Disconnect();
                            return result;
                        }
                    }
                }
                else
                {
                    return null;
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show("Liên hệ kỹ thuật viên để được hỗ trợ!\n" + e.Message, "Lỗi truy vấn SQL Server!");
                return null;
            }
        }

        #endregion

        #region c. Lấy thông tin danh sách các dịch vụ đã sử dụng theo đơn đặt phòng
        // Hàm truy vấn Những dịch vụ được sử dụng theo đơn đặt phòng
        public DataTable Function_ServiceToRoom(String MaDonDat)
        {
            try
            {
                Connect();
                if (sqlCon.State == ConnectionState.Open)
                {
                    String ex = "SELECT * FROM dbo.FUNC_DSDVTheoDonDP(@input1)";
                    using (SqlCommand command = new SqlCommand(ex, sqlCon))
                    {
                        command.Parameters.AddWithValue("@input1", MaDonDat);
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            Disconnect();
                            return dataTable;
                        }
                    }
                }
                else
                {
                    return null;
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show("Liên hệ kỹ thuật viên để được hỗ trợ!\n" + e.Message, "Lỗi truy vấn SQL Server!");
                return null;
            }
        }


        #endregion

        #region d. Lấy thông tin đơn đặt phòng, phòng, khách hàng theo thời gian nhập vào
        // Hàm truy vấn thông tin phòng với thông tin đầu vào (thời gian bắt đầu, kết thúc). Để biết Phòng có đang được thuê có được cọc hay không 
        public DataTable Function_ListRoomWithTime(DateTime timestart, DateTime timeend)
        {
            try
            {
                Connect();
                if (sqlCon.State == ConnectionState.Open)
                {
                    string ex = "SELECT * FROM dbo.FUNC_PhongTheoTG" + "(@input1,@input2) ORDER BY SoPh";
                    using (SqlCommand command = new SqlCommand(ex, sqlCon))
                    {
                        // Thay đổi tên function và tham số tương ứng
                        command.Parameters.AddWithValue("@input1", timestart.ToString("yyyy-MM-dd HH:mm:ss"));
                        command.Parameters.AddWithValue("@input2", timeend.ToString("yyyy-MM-dd HH:mm:ss"));

                        // Thực hiện truy vấn
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            Disconnect();
                            return dataTable;
                        }
                    }
                }
                else
                {
                    return null;
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show("Liên hệ kỹ thuật viên để được hỗ trợ!\n" + e.Message, "Lỗi truy vấn SQL Server!");
                return null;
            }
        }
        #endregion


        // Hàm thêm một nhân viên cùng tài khoản vào SQLServer
        public int Proc_AddStaffAccount(String MaNV, String TenNV, String LienLac, String CCCD, String VaiTro,String TenDN,String MatKhau)
        {
            try
            {
                Connect();
                if (sqlCon.State == ConnectionState.Open)
                {
                    String proc_name = "PROC_ThemNhanVien" + " @MaNV, @TenNV, @LienLac, @CCCD, @VaiTro, @TenDN, @MatKhau";
                    using (SqlCommand command = new SqlCommand(proc_name, sqlCon))
                    {
                        // Set parameters
                        command.Parameters.AddWithValue("@MaNV", MaNV);
                        command.Parameters.AddWithValue("@TenNV", TenNV);
                        command.Parameters.AddWithValue("@LienLac", LienLac);
                        command.Parameters.AddWithValue("@CCCD", CCCD);
                        command.Parameters.AddWithValue("@VaiTro", VaiTro);
                        command.Parameters.AddWithValue("@TenDN", TenDN);
                        command.Parameters.AddWithValue("@MatKhau", MatKhau);


                        // Thực thi 
                        int result = command.ExecuteNonQuery();

                        Disconnect();
                        return result;
                    }
                }
                else
                {
                    return 0;
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show("Liên hệ kỹ thuật viên để được hỗ trợ!\n" + e.Message, "Lỗi truy vấn SQL Server!");
                return 0;
            }

        }

        
        
        // Hàm xóa một nhân viên trong SQlServer
        public int Proc_DeleteStaffAccount(String MaNV)
        {
            try
            {
                Connect();
                if (sqlCon.State == ConnectionState.Open)
                {
                    String proc_name = "PROC_XoaNhanVien" + " @MaNV";
                    using (SqlCommand command = new SqlCommand(proc_name, sqlCon))
                    {
                        // Set parameters
                        command.Parameters.AddWithValue("@MaNV", MaNV);

                        // Thực thi 
                        int result = command.ExecuteNonQuery();

                        Disconnect();
                        return result;
                    }
                }
                else
                {
                    return 0;
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show("Liên hệ kỹ thuật viên để được hỗ trợ!\n" + e.Message, "Lỗi truy vấn SQL Server!");
                return 0;
            }
        }

        // Hàm để thêm một phòng trong SQLServer
        public int Proc_AddRoom(String MaPh,String TenLoaiPh,int SoPh,decimal GiaPhH,decimal GiaPhNg,int SucChua)
        {
            try
            {
                Connect();
                if (sqlCon.State == ConnectionState.Open)
                {
                    String proc_name = "PROC_ThemPhong" + " @MaPh, @TenLoaiPh, @SoPh, @GiaPhH, @GiaPhNg, @SucChua";
                    using (SqlCommand command = new SqlCommand(proc_name, sqlCon))
                    {
                        // Set parameters
                        command.Parameters.AddWithValue("@MaPh", MaPh);
                        command.Parameters.AddWithValue("@TenLoaiPh", TenLoaiPh);
                        command.Parameters.AddWithValue("@SoPh", SoPh);
                        command.Parameters.AddWithValue("@GiaPhH", GiaPhH);
                        command.Parameters.AddWithValue("@GiaPhNg", GiaPhNg);
                        command.Parameters.AddWithValue("@SucChua", SucChua);

                        // Thực thi 
                        int result = command.ExecuteNonQuery();

                        Disconnect();
                        return result;
                    }
                }
                else
                {
                    return 0;
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show("Liên hệ kỹ thuật viên để được hỗ trợ!\n" + e.Message, "Lỗi truy vấn SQL Server!");
                return 0;
            }
        }


        // Hàm để sửa một thông tin phòng trong SQlServer
        public int Proc_FixRoomInformation(String TenLoaiPh,int SoPh,String GiaPhH,String GiaPhNg,int SucChua)
        {
            try
            {
                Connect();
                if (sqlCon.State == ConnectionState.Open)
                {
                    String proc_name = "PROC_SuaPhong" + " @TenLoaiPh, @SoPh, @GiaPhH, @GiaPhNg, @SucChua";
                    using (SqlCommand command = new SqlCommand(proc_name, sqlCon))
                    {
                        // Set parameters
                        command.Parameters.AddWithValue("@TenLoaiPh", TenLoaiPh);
                        command.Parameters.AddWithValue("@SoPh", SoPh);
                        command.Parameters.AddWithValue("@GiaPhH", GiaPhH);
                        command.Parameters.AddWithValue("@GiaPhNg", GiaPhNg);
                        command.Parameters.AddWithValue("@SucChua", SucChua);

                        // Thực thi 
                        int result = command.ExecuteNonQuery();

                        Disconnect();
                        return result;
                    }
                }
                else
                {
                    return 0;
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show("Liên hệ kỹ thuật viên để được hỗ trợ!\n" + e.Message, "Lỗi truy vấn SQL Server!");
                return 0;
            }
        }


        // Hàm để sửa thông tin khuyến mãi hiện tại
        public int Proc_FixPromotion(String MaKM, String TenKM,DateTime NgayBatDau,DateTime NgayKetThuc,double GiaTriKM)
        {
            try
            {
                Connect();
                if (sqlCon.State == ConnectionState.Open)
                {
                    String proc_name = "PROC_SuaKhuyenMai" + " @MaKM, @TenKM, @NgayBatDau, @NgayKetThuc, @GiaTriKM";
                    using (SqlCommand command = new SqlCommand(proc_name, sqlCon))
                    {
                        // Set parameters
                        command.Parameters.AddWithValue("@MaKM", MaKM);
                        command.Parameters.AddWithValue("@TenKM", TenKM);
                        command.Parameters.AddWithValue("@NgayBatDau", NgayBatDau.ToString("yyyy-MM-dd"));
                        command.Parameters.AddWithValue("@NgayKetThuc", NgayKetThuc.ToString("yyyy-MM-dd"));
                        command.Parameters.AddWithValue("@GiaTriKM", GiaTriKM);

                        // Thực thi 
                        int result = command.ExecuteNonQuery();

                        Disconnect();
                        return result;
                    }
                }
                else
                {
                    return 0;
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show("Liên hệ kỹ thuật viên để được hỗ trợ!\n" + e.Message, "Lỗi truy vấn SQL Server!");
                return 0;
            }
        }

        // Hàm để thêm một khuyến mãi mới
        public int Proc_AddPromotion(String MaKM, String TenKM, DateTime NgayBatDau, DateTime NgayKetThuc, double GiaTriKM)
        {
            try
            {
                Connect();
                if (sqlCon.State == ConnectionState.Open)
                {
                    String proc_name = "PROC_ThemKhuyenMai" + " @MaKM, @TenKM, @NgayBatDau, @NgayKetThuc, @GiaTriKM";
                    using (SqlCommand command = new SqlCommand(proc_name, sqlCon))
                    {
                        // Set parameters
                        command.Parameters.AddWithValue("@MaKM", MaKM);
                        command.Parameters.AddWithValue("@TenKM", TenKM);
                        command.Parameters.AddWithValue("@NgayBatDau", NgayBatDau.ToString("yyyy-MM-dd"));
                        command.Parameters.AddWithValue("@NgayKetThuc", NgayKetThuc.ToString("yyyy-MM-dd"));
                        command.Parameters.AddWithValue("@GiaTriKM", GiaTriKM);

                        // Thực thi 
                        int result = command.ExecuteNonQuery();

                        Disconnect();
                        return result;
                    }
                }
                else
                {
                    return 0;
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show("Liên hệ kỹ thuật viên để được hỗ trợ!\n" + e.Message, "Lỗi truy vấn SQL Server!");
                return 0;
            }
        }

        // Hàm sửa thông tin của một dịch vụ trong SQlServer
        public int Proc_FixService(String MaDV, String NewTenDV, decimal NewGiaDV)
        {
            try
            {
                Connect();
                if (sqlCon.State == ConnectionState.Open)
                {
                    String proc_name = "PROC_SuaDV" + " @MaDV, @NewTenDV, @NewGiaDV";
                    using (SqlCommand command = new SqlCommand(proc_name, sqlCon))
                    {
                        // Set parameters
                        command.Parameters.AddWithValue("@MaDV", MaDV);
                        command.Parameters.AddWithValue("@NewTenDV", NewTenDV);
                        command.Parameters.AddWithValue("@NewGiaDV", NewGiaDV);

                        // Thực thi 
                        int result = command.ExecuteNonQuery();

                        Disconnect();
                        return result;
                    }
                }
                else
                {
                    return 0;
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show("Liên hệ kỹ thuật viên để được hỗ trợ!\n" + e.Message, "Lỗi truy vấn SQL Server!");
                return 0;
            }
        }

        // Hàm thêm một dịch vụ mới trong SQlServer
        public int Proc_AddService(String MaDV, String TenDV, decimal GiaDV)
        {
            try
            {
                Connect();
                if (sqlCon.State == ConnectionState.Open)
                {
                    String proc_name = "PROC_BoSungDV" + " @MaDV, @TenDV, @GiaDV";
                    using (SqlCommand command = new SqlCommand(proc_name, sqlCon))
                    {
                        // Set parameters
                        command.Parameters.AddWithValue("@MaDV", MaDV);
                        command.Parameters.AddWithValue("@TenDV", TenDV);
                        command.Parameters.AddWithValue("@GiaDV", GiaDV);

                        // Thực thi 
                        int result = command.ExecuteNonQuery();

                        Disconnect();
                        return result;
                    }
                }
                else
                {
                    return 0;
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show("Liên hệ kỹ thuật viên để được hỗ trợ!\n" + e.Message, "Lỗi truy vấn SQL Server!");
                return 0;
            }
        }

        // Hàm xóa một dịch vụ trong SQL Server 
        public int Proc_DeleteService(String MaDV)
        {
            try
            {
                Connect();
                if (sqlCon.State == ConnectionState.Open)
                {
                    String proc_name = "PROC_XoaDV" + " @MaDV";
                    using (SqlCommand command = new SqlCommand(proc_name, sqlCon))
                    {
                        // Set parameters
                        command.Parameters.AddWithValue("@MaDV", MaDV);

                        // Thực thi 
                        int result = command.ExecuteNonQuery();

                        Disconnect();
                        return result;
                    }
                }
                else
                {
                    return 0;
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show("Liên hệ kỹ thuật viên để được hỗ trợ!\n" + e.Message, "Lỗi truy vấn SQL Server!");
                return 0;
            }
        }



        // Hàm lấy dữ liệu thống kê về đặt phòng trong SQLServer
        public DataTable Function_StatisticBookingOrder(DateTime NgayBatDau, DateTime NgayKetThuc)
        {
            try
            {
                Connect();
                if (sqlCon.State == ConnectionState.Open)
                {
                    String func_name = "SELECT * FROM dbo.FUNC_ThongKeHoaDon(@NgayBatDau, @NgayKetThuc)";
                    using (SqlCommand command = new SqlCommand(func_name, sqlCon))
                    {
                        // Set parameters
                        command.Parameters.AddWithValue("@NgayBatDau", NgayBatDau.ToString("yyyy-MM-dd"));
                        command.Parameters.AddWithValue("@NgayKetThuc", NgayKetThuc.ToString("yyyy-MM-dd"));
                        // Thực thi 
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable result = new DataTable();
                            adapter.Fill(result);
                            Disconnect();
                            return result;
                        }
                    }
                }
                else
                {
                    return null;
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show("Liên hệ kỹ thuật viên để được hỗ trợ!\n" + e.Message, "Lỗi truy vấn SQL Server!");
                return null;
            }
        }

        // Hàm lấy dữ liệu thống kê về dịch vụ trong SQLServer
        public DataTable Function_StatisticService(DateTime NgayBatDau, DateTime NgayKetThuc)
        {
            try
            {
                Connect();
                if (sqlCon.State == ConnectionState.Open)
                {
                    String func_name = "SELECT * FROM dbo.FUNC_ThongKeDichVu(@NgayBatDau, @NgayKetThuc)";
                    using (SqlCommand command = new SqlCommand(func_name, sqlCon))
                    {
                        // Set parameters
                        command.Parameters.AddWithValue("@NgayBatDau", NgayBatDau.ToString("yyyy-MM-dd"));
                        command.Parameters.AddWithValue("@NgayKetThuc", NgayKetThuc.ToString("yyyy-MM-dd"));
                        // Thực thi 
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable result = new DataTable();
                            adapter.Fill(result);
                            Disconnect();
                            return result;
                        }
                    }
                }
                else
                {
                    return null;
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show("Liên hệ kỹ thuật viên để được hỗ trợ!\n" + e.Message, "Lỗi truy vấn SQL Server!");
                return null;
            }
        }

        // Hàm chỉnh sửa thông tin của một tài khoản nhân viên trong SQLServer
        public int Proc_FixStaffAccount(String MaNV, String NewTenNV, String NewLienLac, String NewCCCD, String NewVaiTro,String NewTenDN,String NewMatKhau)
        {
            try
            {
                Connect();
                if (sqlCon.State == ConnectionState.Open)
                {
                    String proc_name = "PROC_SuaNV" + " @MaNV, @NewTenNV, @NewLienLac, @NewCCCD, @NewTenDN, @NewMatKhau, @NewVaiTro";
                    using (SqlCommand command = new SqlCommand(proc_name, sqlCon))
                    {
                        // Set parameters
                        command.Parameters.AddWithValue("@MaNV", MaNV);
                        command.Parameters.AddWithValue("@NewTenNV", NewTenNV);
                        command.Parameters.AddWithValue("@NewLienLac", NewLienLac);
                        command.Parameters.AddWithValue("@NewCCCD", NewCCCD);
                        command.Parameters.AddWithValue("@NewVaiTro", NewVaiTro);
                        command.Parameters.AddWithValue("@NewTenDN", NewTenDN);
                        command.Parameters.AddWithValue("@NewMatKhau", NewMatKhau);

                        // Thực thi 
                        int result = command.ExecuteNonQuery();

                        Disconnect();
                        return result;
                    }
                }
                else
                {
                    return 0;
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show("Liên hệ kỹ thuật viên để được hỗ trợ!\n" + e.Message, "Lỗi truy vấn SQL Server!");
                return 0;
            }
        }
    }
}
