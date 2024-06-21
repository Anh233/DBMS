using Hobook_Software.BLL;
using Hobook_Software.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System.IO;
using System.Drawing.Imaging;
using PdfSharp.Pdf.Advanced;
using System.Diagnostics;

namespace Hobook_Software.GUI.Dashboard
{
     
    public partial class HoaDon : Form
    {
        private String MaHD;
        private List<Room> list_room_booked = new List<Room>();
        private List<Promotion> list_promotion = new List<Promotion>();

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


        private String pttt = null;
        private String MaKM = null;
        private String MaDatPh;
        private decimal tongtienHD;

        private double checkPromotion(DateTime NgayBatDau)
        {
            BusinessLogicLayer bll = new BusinessLogicLayer();
            list_promotion.Clear();
            list_promotion = bll.List_Promotion();
            foreach(Promotion pro in list_promotion)
            {
                if(NgayBatDau > pro.NgayBatDau1 & NgayBatDau < pro.NgayKetThuc1)
                {
                    MaKM = pro.MaKM1;
                    return pro.GiaTriKM1;
                }
            }
            return 0;
        }


        public HoaDon(String MaDatPh, DateTime start, DateTime end, String pttt_c, String TenNV)
        {
            InitializeComponent();
            pttt = pttt_c;
            this.MaDatPh = MaDatPh;
            Label Label_priceroom = new Label();
            Label_priceroom.Size = new Size(99, 23);
            Label_priceroom.Location = new Point(383, 663);
            Label_priceroom.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            Label_priceroom.TextAlign = ContentAlignment.MiddleRight;


            Label Label_promotion = new Label();
            Label_promotion.Size = new Size(99, 23);
            Label_promotion.Location = new Point(383, 597);
            Label_promotion.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            Label_promotion.TextAlign = ContentAlignment.MiddleRight;

            Label Label_roomprice = new Label();
            Label_roomprice.Size = new Size(99, 23);
            Label_roomprice.Location = new Point(383, 561);
            Label_roomprice.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            Label_roomprice.TextAlign = ContentAlignment.MiddleRight;

            Label Label_pttt = new Label();
            Label_pttt.Size = new Size(208, 23);
            Label_pttt.Location = new Point(274, 631);
            Label_pttt.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            Label_pttt.TextAlign = ContentAlignment.MiddleRight;



            Label Label_SumDV = new Label();
            Label_SumDV.Size = new Size(99, 23);
            Label_SumDV.Location = new Point(383, 529);
            Label_SumDV.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            Label_SumDV.TextAlign = ContentAlignment.MiddleRight;

            panel_hoadon.Controls.Add(Label_priceroom);
            panel_hoadon.Controls.Add(Label_promotion);
            panel_hoadon.Controls.Add(Label_SumDV);
            panel_hoadon.Controls.Add(Label_roomprice);
            panel_hoadon.Controls.Add(Label_pttt);

            BusinessLogicLayer bll = new BusinessLogicLayer();
            list_room_booked.Clear();
            list_room_booked = bll.List_Room_WithTime(start, end);
            String ngaybatdau = null;
            String ngayketthuc = null;
            List<String> SoPh = new List<string>();
            double GiaTriKM = 0;
            tongtienHD = bll.TinhTienHD(MaDatPh, GiaTriKM);


            Dashboard_form df = (Dashboard_form)this.Owner;
            foreach(Room room in list_room_booked)
            {
                for(int i = 0; i<room.MaDonDat1.Count; i++)
                {
                    if (room.MaDonDat1[i] == MaDatPh)
                    {
                        ngaybatdau = room.NgayBatDau1[i].ToString("dd/MM/yyyy hh:ss");
                        ngayketthuc = room.NgayKetThuc1[i].ToString("dd/MM/yyyy hh:ss");
                        SoPh.Add(room.SoPh1.ToString());
                        GiaTriKM = checkPromotion(room.NgayBatDau1[i]);
                    }
                }
            }


            DGV_DV.DataSource = bll.List_ServiceToRoomInvoice(MaDatPh);

            DGV_DV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            label_sophong.Text = "Phòng ";
            for (int i=0;i<SoPh.Count;i++)
            {
                if (i<SoPh.Count-1)
                {
                    label_sophong.Text += SoPh[i] + ", ";
                } else
                {
                    label_sophong.Text += SoPh[i];
                }
                
            }
            Label_NgayCheckin.Text = ngaybatdau;
            Label_NgayCheckout.Text = ngayketthuc;

            Label_TenNV.Text = "Nhân viên: " + TenNV;

            Label_SumDV.Text = bll.TinhTienDV(MaDatPh);
            Label_roomprice.Text = bll.TinhTienPhong(MaDatPh);
            Label_MaHD.Text = "HD số: " + bll.MaHoaDon(MaDatPh);
            if(GiaTriKM != 0)
            {
                Label_promotion.Text = (GiaTriKM * 100).ToString() + "%";
            }
            Label_promotion.Text = "0%";
            Label_priceroom.Text = tongtienHD.ToString("N0");
            MaHD = bll.New_Invoice(MaDatPh).Trim();
            Label_MaHD.Text = "HD số: " + MaHD;
            Label_pttt.Text = pttt;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_thanhtoan_Click(object sender, EventArgs e)
        {
            Take_a_pdf();
            BusinessLogicLayer bll = new BusinessLogicLayer();
            bll.Addinvoice_room(this.MaDatPh, this.MaKM, this.pttt, this.tongtienHD);
            bll.Checkout_room(this.MaDatPh);
            this.Close();
        }

        private void HoaDon_Load(object sender, EventArgs e)
        {

        }

        
        private void Take_a_jpg()
        {
            String path = Directory.GetParent(Directory.GetParent(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).FullName).FullName).FullName;
            path = Path.Combine(path, "img/bill/" + MaHD + ".jpg");


            ScreenCapture sc = new ScreenCapture();
            // capture entire screen, and save it to a file
            Image img = sc.CaptureScreen();
            // capture this window, and save it
            sc.CaptureWindowToFile(this.panel_hoadon.Handle, path, ImageFormat.Jpeg);
        }

        private void Take_a_pdf()
        {
            String path = Directory.GetParent(Directory.GetParent(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).FullName).FullName).FullName;
            path = Path.Combine(path, "img/bill/" + MaHD + ".jpg");
            Take_a_jpg();

            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                folderBrowserDialog.Description = "Chọn thư mục để lưu hóa đơn (PDF)";

                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFolderPath = folderBrowserDialog.SelectedPath;
                    var doc = new PdfDocument();

                    var oPage = new PdfPage();
                    oPage.Width = XUnit.FromInch(((double)panel_hoadon.Width / panel_hoadon.DeviceDpi) / 125 * 100);
                    oPage.Height = XUnit.FromInch(((double)panel_hoadon.Height / panel_hoadon.DeviceDpi) / 125 * 100);
                    doc.Pages.Add(oPage);
                    var xgr = XGraphics.FromPdfPage(oPage);
                    var img = XImage.FromFile(path);

                    xgr.DrawImage(img, 0, 0);
                    doc.Save(Path.Combine(selectedFolderPath,MaHD + ".pdf"));
                    Process.Start(Path.Combine(selectedFolderPath, MaHD + ".pdf"));
                    doc.Close();
                }
            }
        }

    }
}
