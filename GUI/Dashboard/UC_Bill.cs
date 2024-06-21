using Hobook_Software.BLL;
using Hobook_Software.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hobook_Software.GUI.Dashboard
{
    public partial class UC_Bill : UserControl
    {
        public UC_Bill()
        {
            InitializeComponent();
        }

        public void Loading(String MaHD)
        {
            if (MaHD.Length == 6 & MaHD.Contains("HD"))
            {
                BusinessLogicLayer bll = new BusinessLogicLayer();
                Customer customer = bll.Find_customer_WithMaHD(MaHD);
                tb_hoten.Text = customer.HoTen1;
                tb_cccd.Text = customer.CCCD1;
                tb_diachi.Text = customer.DiaChi1;
                tb_ngaysinh.Text = customer.NgaySinh1.ToString("dd/MM/yyyy");
                tb_sdt.Text = customer.LienLac1;
                String path = Directory.GetParent(Directory.GetParent(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).FullName).FullName).FullName;
                path = Path.Combine(path, "img/bill/" + MaHD + ".jpg");
                if (File.Exists(path))
                {
                    pictureBox1.BackgroundImage = Image.FromFile(path);
                }
            } else
            {
                tb_hoten.Text = "";
                tb_cccd.Text = "";
                tb_diachi.Text = "";
                tb_ngaysinh.Text = "";
                tb_sdt.Text = "";
                pictureBox1.BackgroundImage = null;
            }
        }



        private void UC_Bill_Load(object sender, EventArgs e)
        {

        }
    }
}
