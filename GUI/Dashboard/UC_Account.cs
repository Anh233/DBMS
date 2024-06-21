using Hobook_Software.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hobook_Software.GUI.Dashboard
{
    public partial class UC_Account : UserControl
    {
        private DataTable source = new DataTable();

        public UC_Account()
        {
            InitializeComponent();
        }

        public void Filter(String find)
        {
            if (find == "" | find =="Tìm kiếm")
            {
                Loading();
            }
            else
            {
                DataTable result = source.Clone();
                foreach (DataRow row in source.Rows)
                {
                    if (row["Họ tên"].ToString().Contains(find) | row["Liên lạc"].ToString().Contains(find) | row["CCCD"].ToString().Contains(find) | row[3].ToString().Contains(find))
                    {
                        result.ImportRow(row);
                    }
                }
                DataGrid_Show(result);
            }
        }

        public void Loading()
        {
            BusinessLogicLayer bll = new BusinessLogicLayer();
            source = bll.Staff_Information();
            foreach (DataRow row in source.Rows)
            {
                if (row["Tài khoản"].ToString() == "sa" & row["Vai trò"].ToString() == "Admin")
                {
                    source.Rows.Remove(row);
                    break;
                }
            }
            tb_name.Text = "";
            tb_sdt.Text = "";
            tb_cccd.Text = "";
            tb_taikhoan.Text = "";
            tb_matkhau.Text = "";
            tb_matkhau2.Text = "";
            DataGrid_Show(source);
        }


        public void DataGrid_Show(DataTable s)
        {
            dg_customer.DataSource = s;
        }

        private void UC_Account_Load(object sender, EventArgs e)
        {
            cbb_vaitro.Items.Add("Nhân viên");
            cbb_vaitro.Items.Add("Chủ");
            cbb_vaitro.SelectedIndex = 0;
        }

        private void dg_customer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            BusinessLogicLayer bll = new BusinessLogicLayer();
            if (e.RowIndex >= 0 & e.ColumnIndex >= 0) 
            {
                if (dg_customer.Columns[e.ColumnIndex].Name == "Fix")
                {
                    String STT = dg_customer.Rows[e.RowIndex].Cells["STT"].Value.ToString();
                    String CCCD = dg_customer.Rows[e.RowIndex].Cells["cccd"].Value.ToString();
                    String matkhau = dg_customer.Rows[e.RowIndex].Cells["matkhau"].Value.ToString();
                    String vaitro = dg_customer.Rows[e.RowIndex].Cells["vaitro"].Value.ToString();
                    String Hoten = dg_customer.Rows[e.RowIndex].Cells["hoten"].Value.ToString();
                    String Lienlac = dg_customer.Rows[e.RowIndex].Cells["lienlac"].Value.ToString();
                    String taikhoan = dg_customer.Rows[e.RowIndex].Cells["taikhoan"].Value.ToString();

                    String notice = "Vui lòng nhập đầy đủ và chính xác các nội dung sau: \n";
                    if (Hoten == "") { notice += "- Thiếu thông tin họ tên\n"; }
                    if (Lienlac == "") { notice += "- Thiếu thông tin số điện thoại\n"; }
                    else
                    {
                        if (Lienlac.Length != 10 | !Lienlac.All(char.IsDigit)) { notice += "- Số điện thoại chỉ được chứa 10 ký tự số\n"; }
                    }
                    if (CCCD == "") { notice += "- Thiếu thông tin căn cước công dân\n"; }
                    else
                    {
                        if (CCCD.Length != 12 | !CCCD.All(char.IsDigit)) { notice += "- Căn cước công dân chỉ được chứa 12 ký tự số\n"; }
                    }
                    if (taikhoan == "") { notice += "- Thiếu thông tin tài khoản\n"; }
                    else
                    {
                        if (taikhoan.Contains(" ")) { notice += "- Không được có khoảng trắng trong tài khoản\n"; }
                    }
                    if (matkhau == "") { notice += "- Thiếu thông tin mật khẩu\n"; }
                    else
                    {
                        if (matkhau.Contains(" ")) { notice += "- Không được có khoảng trắng trong mật khẩu\n"; }
                    }
                    if (vaitro != "Nhân viên" & vaitro != "Chủ")
                    {
                        notice += "- Vai trò chỉ được là Chủ hoặc Nhân viên\n";
                    }

                    if (notice == "Vui lòng nhập đầy đủ và chính xác các nội dung sau: \n")
                    {
                        String role = (vaitro == "Nhân viên") ? ("NhanVien") : ("Chu");
                        matkhau = hasher.Decode(matkhau);
                        bll.Fix_StaffAccount(BusinessLogicLayer.MaNV[int.Parse(STT) - 1], Hoten, Lienlac, CCCD, role, taikhoan, matkhau);
                        Loading();
                    }
                    else
                    {
                        MessageBox.Show(notice, "Thông báo!");
                    }


                }
                if (dg_customer.Columns[e.ColumnIndex].Name == "Delete")
                {
                    String STT = dg_customer.Rows[e.RowIndex].Cells["STT"].Value.ToString();
                    bll.Delete_StaffAccount(BusinessLogicLayer.MaNV[int.Parse(STT)-1]);
                    Loading();
                }                
            }
        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            String notice = "Vui lòng nhập đầy đủ và chính xác các nội dung sau: \n";
            if (tb_name.Text == "") { notice += "- Thiếu thông tin họ tên\n"; }
            if (tb_sdt.Text == "") { notice += "- Thiếu thông tin số điện thoại\n"; }
            else
            {
                if (tb_sdt.Text.Length != 10 | !tb_sdt.Text.All(char.IsDigit)) { notice += "- Số điện thoại chỉ được chứa 10 ký tự số\n"; }
            }
            if (tb_cccd.Text == "") { notice += "- Thiếu thông tin căn cước công dân\n"; }
            else
            {
                if (tb_cccd.Text.Length != 12 | !tb_cccd.Text.All(char.IsDigit)) { notice += "- Căn cước công dân chỉ được chứa 12 ký tự số\n"; }
            }
            if (tb_taikhoan.Text == "") { notice += "- Thiếu thông tin tài khoản\n"; }
            else
            {
                if (tb_taikhoan.Text.Contains(" ")) { notice += "- Không được có khoảng trắng trong tài khoản\n"; }
            }
            if (tb_matkhau.Text == "") { notice += "- Thiếu thông tin mật khẩu\n"; }
            else
            {
                if (tb_matkhau.Text.Contains(" ")) { notice += "- Không được có khoảng trắng trong mật khẩu\n"; }
            }
            if (tb_matkhau.Text != "" & tb_matkhau2.Text == "") { notice += "- Thiếu thông tin nhập lại mật khẩu\n"; }
            else
            {
                if (tb_matkhau.Text != tb_matkhau2.Text) { notice += "- Thông tin mật khẩu và nhập lại mật khẩu không khớp\n"; }
            }
            if (notice == "Vui lòng nhập đầy đủ và chính xác các nội dung sau: \n")
            {
                BusinessLogicLayer bll = new BusinessLogicLayer();
                String role = (cbb_vaitro.Text == "Nhân viên") ? ("NhanVien") : ("Chu");
                String MaNV = bll.New_StaffID();
                bll.Add_StaffAccount(MaNV,tb_name.Text,tb_sdt.Text,tb_cccd.Text,role,tb_taikhoan.Text,tb_matkhau.Text);
                Loading();
            } else
            {
                MessageBox.Show(notice, "Lỗi!");
            }
        }

        private void dg_customer_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dg_customer_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (!check_edit_mk)
            {
                if (e.RowIndex >= 0 & e.ColumnIndex >= 0)
            {
                if (dg_customer.Columns[e.ColumnIndex].Name == "matkhau")
                {
                    // mã hóa 
                    String matkhau = hasher.Encode(dg_customer.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
                    dg_customer.Rows[e.RowIndex].Cells["matkhau"].Value = matkhau;
                }
            }
            }
            else
            {
                check_edit_mk = false;
            }
        }

        private bool check_edit_mk = false;

        private void dg_customer_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 & e.ColumnIndex >= 0)
            {
                if (dg_customer.Columns[e.ColumnIndex].Name == "matkhau")
                {
                    // giả mã 
                    String matkhau = hasher.Decode(dg_customer.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
                    dg_customer.Rows[e.RowIndex].Cells["matkhau"].Value = matkhau;
                }
            }
        }

        private void dg_customer_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 & e.ColumnIndex >= 0)
            {
                if (dg_customer.Columns[e.ColumnIndex].Name == "matkhau")
                {
                    // mã hóa 
                    String matkhau = hasher.Encode(dg_customer.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
                    dg_customer.Rows[e.RowIndex].Cells["matkhau"].Value = matkhau;
                    check_edit_mk = true;
                }
            }
        }
    }
}
