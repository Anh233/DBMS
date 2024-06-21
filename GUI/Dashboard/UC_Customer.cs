using Hobook_Software.BLL;
using Hobook_Software.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Navigation;

namespace Hobook_Software.GUI.Dashboard
{
    public partial class UC_Customer : UserControl
    {
        private List<Customer> list_customer = new List<Customer>();

        public UC_Customer()
        {
            InitializeComponent();
        }

        public void Load_ViewCustomer()
        {
            BusinessLogicLayer bll = new BusinessLogicLayer();
            list_customer = bll.List_Customer();
            Create_panel_customer(list_customer);
        }

        public void Create_panel_customer(List<Customer> list_customer_current)
        {
            panel_customer.Controls.Clear();
            int dem = 0;
            foreach (Customer customer in list_customer_current)
            {


                Panel cus = new Panel();
                cus.Size = new Size(1120, 174);
                cus.Location = new Point(19, 20 + (dem * 200));
                cus.BackColor = Color.Azure;

                PictureBox pic = new PictureBox();
                pic.Size = new Size(120, 120);
                pic.Location = new Point(24, 22);
                pic.BackgroundImage = Hobook_Software.Properties.Resources.user_avatar_filled_256x256;
                pic.BackgroundImageLayout = ImageLayout.Stretch;
                cus.Controls.Add(pic);

                Label name = new Label();
                name.Size = new Size(405, 38);
                name.Location = new Point(201, 22);
                name.Font = new Font("Segoe UI", 16, FontStyle.Bold);
                name.Text = customer.HoTen1;
                cus.Controls.Add(name);

                Label sdt = new Label();
                sdt.Size = new Size(166, 28);
                sdt.Location = new Point(167, 71);
                sdt.Font = new Font("Segoe UI", 12, FontStyle.Regular);
                sdt.Text = "SĐT: " + customer.LienLac1;
                cus.Controls.Add(sdt);

                Label cccd = new Label();
                cccd.Size = new Size(201, 28);
                cccd.Location = new Point(167, 114);
                cccd.Font = new Font("Segoe UI", 12, FontStyle.Regular);
                cccd.Text = "CCCD: " + customer.CCCD1;
                cus.Controls.Add(cccd);

                Label date = new Label();
                date.Size = new Size(212, 28);
                date.Location = new Point(418, 71);
                date.Font = new Font("Segoe UI", 12, FontStyle.Regular);
                date.Text = "Ngày sinh: " + customer.NgaySinh1.ToString("dd/MM/yyyy");
                cus.Controls.Add(date);

                Label addr = new Label();
                addr.Size = new Size(385, 28);
                addr.Location = new Point(418, 114);
                addr.Font = new Font("Segoe UI", 12, FontStyle.Regular);
                addr.Text = "Địa chỉ: " + customer.DiaChi1;
                cus.Controls.Add(addr);

                Guna.UI.WinForms.GunaButton his = new Guna.UI.WinForms.GunaButton();
                his.Size = new Size(171, 54);
                his.Location = new Point(921, 60);
                his.Text = "Lịch sử thuê phòng";
                his.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                his.ForeColor = Color.White;
                his.BaseColor = Color.SteelBlue;
                his.Image = null;
                his.TextAlign = HorizontalAlignment.Center;
                his.OnHoverBaseColor = Color.SteelBlue;
                his.Cursor = Cursors.Hand;
                his.Tag = customer.MaKh1;
                his.Click += Show_history;
                cus.Controls.Add(his);

                panel_customer.Controls.Add(cus);
                dem++;

            }
        }

        public void Show_history(object sender, EventArgs e) {
            Guna.UI.WinForms.GunaButton a = (Guna.UI.WinForms.GunaButton)sender;
            if (a.Text == "Lịch sử thuê phòng")
            {
                a.Text = "Trở về";
                Panel parent = (Panel)a.Parent;
                foreach (Control c in parent.Controls)
                {
                    if (c is Label)
                    {
                        c.Visible = false;
                    }
                }
                Bunifu.Framework.UI.BunifuCustomDataGrid dg_customer = new Bunifu.Framework.UI.BunifuCustomDataGrid();
                dg_customer.Size = new Size(631, 121);
                dg_customer.Location = new Point(172, 21);
                dg_customer.BackgroundColor = Color.Azure;
                dg_customer.RowHeadersVisible = false;
                dg_customer.GridColor = Color.LightSkyBlue;
                dg_customer.HeaderBgColor = Color.SteelBlue;
                dg_customer.HeaderForeColor = Color.White;
                dg_customer.AllowUserToResizeColumns = false;
                dg_customer.AllowUserToResizeRows = false;
                dg_customer.ScrollBars = ScrollBars.Both;
                //dg_customer.Dock = DockStyle.Fill;
                dg_customer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                BusinessLogicLayer bll = new BusinessLogicLayer();
                dg_customer.DataSource = bll.History_BookingOrder(a.Tag.ToString());
                Bunifu.Framework.UI.BunifuElipse be = new Bunifu.Framework.UI.BunifuElipse();
                be.TargetControl = dg_customer;
                parent.Controls.Add(dg_customer);
            }
            else
            {
                a.Text = "Lịch sử thuê phòng";
                Panel parent = (Panel)a.Parent;
                foreach (Control c in parent.Controls)
                {
                    if (c is Label)
                    {
                        c.Visible = true;
                    }
                    if (c is Bunifu.Framework.UI.BunifuCustomDataGrid)
                    {
                        parent.Controls.Remove(c);
                    }
                }
            }
            
        }


        public void Filter(String fitler)
        {
            if (fitler=="" | fitler == "Tìm kiếm")
            {
                Load_ViewCustomer();
            }
            else
            {
                List<Customer> list_customer_current = new List<Customer>();
                if (fitler.All(char.IsDigit))
                {
                    foreach (Customer customer in list_customer)
                    {
                        if (customer.CCCD1.Contains(fitler) | customer.LienLac1.Contains(fitler))
                        {
                            list_customer_current.Add(customer);
                        }
                    }
                }
                else
                {
                    foreach (Customer customer in list_customer)
                    {
                        if (customer.HoTen1.Contains(fitler.ToString()))
                        {
                            list_customer_current.Add(customer);
                        }
                    }
                }
                Create_panel_customer(list_customer_current);
            }
        }


        private void UC_Customer_Load(object sender, EventArgs e)
        {

        }
    }
}
