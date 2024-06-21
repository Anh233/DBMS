using Hobook_Software.BLL;
using Hobook_Software.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Hobook_Software.GUI.Dashboard
{
    public partial class UC_Statistics : UserControl
    {
        private double total_room = 0;



        public UC_Statistics()
        {
            InitializeComponent();
            tb_timeenddoanhthu.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).AddMonths(1).AddDays(-1);
            this.tb_datecheckinout.onValueChanged += tb_datecheckinout_onValueChanged;
            this.tb_timestartdoanhthu.onValueChanged += Revenue_DatePicker_onValueChanged;
            this.tb_timeenddoanhthu.onValueChanged += Revenue_DatePicker_onValueChanged;
        }


        public void Loading_Statistic_Today()
        {
            BusinessLogicLayer bll = new BusinessLogicLayer();
            List<double> data = bll.Statistic_today();
            lb_doanhthu.Text = ((decimal)data[0]).ToString("N0") + " VNĐ";
            lb_checkintoday.Text = data[1].ToString() + " đơn đặt";
            lb_checkouttoday.Text = data[2].ToString() + " đơn đặt";
            total_room = data[3] + data[4] + data[5] + data[6];
            Task.Run(() => setting_readyroom(data[3]));
            Task.Run(() => setting_hiredroom(data[4]));
            Task.Run(() => setting_cleaningroom(data[5]));
            Task.Run(() => setting_fixingroom(data[6]));
            tb_datecheckinout.Value = DateTime.Now.AddDays(-7);
            tb_timestartdoanhthu.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
        } 

        public void setting_readyroom(double value)
        {
            Progress_readyroom.Value = 0;
            if (tb_readyroom.InvokeRequired)
            {
                // Nếu đang ở một luồng khác, thì sử dụng Invoke để thực hiện trên luồng chính
                tb_readyroom.Invoke(new Action(() => { tb_readyroom.Text = "0"; }));
            }
            else
            {
                // Nếu đã ở luồng chính, thì có thể thực hiện trực tiếp
                tb_readyroom.Text = "0";
            }
            if (value> 0)
            {
                int percent = (int)(value * 100 / total_room);
                do
                {
                    Thread.Sleep(15);
                    Progress_readyroom.Value++;
                    if (tb_readyroom.InvokeRequired)
                    {
                        // Nếu đang ở một luồng khác, thì sử dụng Invoke để thực hiện trên luồng chính
                        tb_readyroom.Invoke(new Action(() => { tb_readyroom.Text = ((int)(value / percent * Progress_readyroom.Value)).ToString(); }));
                    }
                    else
                    {
                        // Nếu đã ở luồng chính, thì có thể thực hiện trực tiếp
                        tb_readyroom.Text = ((int)(value / percent * Progress_readyroom.Value)).ToString();
                    }

                } while (Progress_readyroom.Value < percent);
            }
        }

        public void setting_hiredroom(double value)
        {
            Progress_hiredroom.Value = 0;
            if (tb_hiredroom.InvokeRequired)
            {
                // Nếu đang ở một luồng khác, thì sử dụng Invoke để thực hiện trên luồng chính
                tb_hiredroom.Invoke(new Action(() => { tb_hiredroom.Text = "0"; }));
            }
            else
            {
                // Nếu đã ở luồng chính, thì có thể thực hiện trực tiếp
                tb_hiredroom.Text = "0";
            }
            if (value > 0)
            {
                int percent = (int)(value * 100 / total_room);
                do
                {
                    Thread.Sleep(15);
                    Progress_hiredroom.Value++;
                    if (tb_hiredroom.InvokeRequired)
                    {
                        // Nếu đang ở một luồng khác, thì sử dụng Invoke để thực hiện trên luồng chính
                        tb_hiredroom.Invoke(new Action(() => { tb_hiredroom.Text = ((int)(value / percent * Progress_hiredroom.Value)).ToString(); }));
                    }
                    else
                    {
                        // Nếu đã ở luồng chính, thì có thể thực hiện trực tiếp
                        tb_hiredroom.Text = ((int)(value / percent * Progress_hiredroom.Value)).ToString();
                    }

                } while (Progress_hiredroom.Value < percent);
            }
        }

        public void setting_cleaningroom(double value)
        {
            Progress_cleaningroom.Value = 0;
            if (tb_cleaningroom.InvokeRequired)
            {
                // Nếu đang ở một luồng khác, thì sử dụng Invoke để thực hiện trên luồng chính
                tb_cleaningroom.Invoke(new Action(() => { tb_cleaningroom.Text = "0"; }));
            }
            else
            {
                // Nếu đã ở luồng chính, thì có thể thực hiện trực tiếp
                tb_cleaningroom.Text = "0";
            }
            if (value > 0)
            {
                int percent = (int)(value * 100 / total_room);
                do
                {
                    Thread.Sleep(15);
                    Progress_cleaningroom.Value++;
                    if (tb_cleaningroom.InvokeRequired)
                    {
                        // Nếu đang ở một luồng khác, thì sử dụng Invoke để thực hiện trên luồng chính
                        tb_cleaningroom.Invoke(new Action(() => { tb_cleaningroom.Text = ((int)(value / percent * Progress_cleaningroom.Value)).ToString(); }));
                    }
                    else
                    {
                        // Nếu đã ở luồng chính, thì có thể thực hiện trực tiếp
                        tb_cleaningroom.Text = ((int)(value / percent * Progress_cleaningroom.Value)).ToString();
                    }

                } while (Progress_cleaningroom.Value < percent);
            }
                
        }

        public void setting_fixingroom(double value)
        {
            Progress_fixingroom.Value = 0;
            if (tb_fixingroom.InvokeRequired)
            {
                // Nếu đang ở một luồng khác, thì sử dụng Invoke để thực hiện trên luồng chính
                tb_fixingroom.Invoke(new Action(() => { tb_fixingroom.Text = "0"; }));
            }
            else
            {
                // Nếu đã ở luồng chính, thì có thể thực hiện trực tiếp
                tb_fixingroom.Text = "0";
            }
            if (value > 0)
            {
                int percent = (int)(value * 100 / total_room);
                do
                {
                    Thread.Sleep(15);
                    Progress_fixingroom.Value++;
                    if (tb_fixingroom.InvokeRequired)
                    {
                        // Nếu đang ở một luồng khác, thì sử dụng Invoke để thực hiện trên luồng chính
                        tb_fixingroom.Invoke(new Action(() => { tb_fixingroom.Text = ((int)(value / percent * Progress_fixingroom.Value)).ToString(); }));
                    }
                    else
                    {
                        // Nếu đã ở luồng chính, thì có thể thực hiện trực tiếp
                        tb_fixingroom.Text = ((int)(value / percent * Progress_fixingroom.Value)).ToString();
                    }

                } while (Progress_fixingroom.Value < percent);
            }
        }

        private void UC_Statistics_Load(object sender, EventArgs e)
        {
            
        }

        private void Revenue_DatePicker_onValueChanged(object sender, EventArgs e)
        {
            BusinessLogicLayer bll = new BusinessLogicLayer();
            if (switch_daymonth.Checked == false)
            {
                Bunifu.Dataviz.WinForms.BunifuDatavizAdvanced.Canvas canvas1 = new Bunifu.Dataviz.WinForms.BunifuDatavizAdvanced.Canvas();
                canvas1 = bll.Statistic_Day_Revenue(tb_timestartdoanhthu.Value, tb_timeenddoanhthu.Value);
                chart_revenue.Render(canvas1);
                Bunifu.Dataviz.WinForms.BunifuDatavizBasic.Canvas canvas2 = bll.Statistic_NumberService_Circle(tb_timestartdoanhthu.Value, tb_timeenddoanhthu.Value);
                chart_service.Render(canvas2);
                DataTable data = bll.Statistic_NumberService_Datatable(tb_timestartdoanhthu.Value, tb_timeenddoanhthu.Value);
                dg_service.DataSource = data;
            } else
            {
                Bunifu.Dataviz.WinForms.BunifuDatavizAdvanced.Canvas canvas1 = new Bunifu.Dataviz.WinForms.BunifuDatavizAdvanced.Canvas();
                canvas1 = bll.Statistic_Month_Revenue(tb_timestartdoanhthu.Value, tb_timeenddoanhthu.Value);
                chart_revenue.Render(canvas1);

                DateTime start = new DateTime(tb_timestartdoanhthu.Value.Year, tb_timestartdoanhthu.Value.Month, 1);
                DateTime end = new DateTime(tb_timeenddoanhthu.Value.Year, tb_timeenddoanhthu.Value.Month, tb_timeenddoanhthu.Value.AddMonths(1).AddDays(-1).Day);
                Bunifu.Dataviz.WinForms.BunifuDatavizBasic.Canvas canvas2 = bll.Statistic_NumberService_Circle(start, end);
                chart_service.Render(canvas2);
                DataTable data = bll.Statistic_NumberService_Datatable(start, end);
                dg_service.DataSource = data;
            }
            bt_doanhthuservice.Text = BusinessLogicLayer.Tong_DichVu.ToString("N0") + " VNĐ";
            bt_doanhthu.Text = BusinessLogicLayer.Tong_DoanhThu.ToString("N0") + " VNĐ";
        }


        private void tb_datecheckinout_onValueChanged(object sender, EventArgs e)
        {
            BusinessLogicLayer bll = new BusinessLogicLayer();
            Bunifu.Dataviz.WinForms.BunifuDatavizAdvanced.Canvas canvas = bll.Statistic_BookingOrder(tb_datecheckinout.Value);
            chart_checkinout.Render(canvas);
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void switch_daymonth_CheckedChanged(object sender, EventArgs e)
        {
            BusinessLogicLayer bll = new BusinessLogicLayer();
            if (switch_daymonth.Checked == false)
            {
                Bunifu.Dataviz.WinForms.BunifuDatavizAdvanced.Canvas canvas1 = new Bunifu.Dataviz.WinForms.BunifuDatavizAdvanced.Canvas();
                canvas1 = bll.Statistic_Day_Revenue(tb_timestartdoanhthu.Value, tb_timeenddoanhthu.Value);
                chart_revenue.Render(canvas1);
                Bunifu.Dataviz.WinForms.BunifuDatavizBasic.Canvas canvas2 = bll.Statistic_NumberService_Circle(tb_timestartdoanhthu.Value, tb_timeenddoanhthu.Value);
                chart_service.Render(canvas2);
                DataTable data = bll.Statistic_NumberService_Datatable(tb_timestartdoanhthu.Value, tb_timeenddoanhthu.Value);
                dg_service.DataSource = data;

            }
            else
            {
                Bunifu.Dataviz.WinForms.BunifuDatavizAdvanced.Canvas canvas1 = new Bunifu.Dataviz.WinForms.BunifuDatavizAdvanced.Canvas();
                canvas1 = bll.Statistic_Month_Revenue(tb_timestartdoanhthu.Value, tb_timeenddoanhthu.Value);
                chart_revenue.Render(canvas1);

                DateTime start = new DateTime(tb_timestartdoanhthu.Value.Year, tb_timestartdoanhthu.Value.Month,1);
                DateTime end = new DateTime(tb_timeenddoanhthu.Value.Year, tb_timeenddoanhthu.Value.Month, tb_timeenddoanhthu.Value.AddMonths(1).AddDays(-1).Day);
                Bunifu.Dataviz.WinForms.BunifuDatavizBasic.Canvas canvas2 = bll.Statistic_NumberService_Circle(start,end);
                chart_service.Render(canvas2);
                DataTable data = bll.Statistic_NumberService_Datatable(start, end);
                dg_service.DataSource = data;
            }
            bt_doanhthuservice.Text = BusinessLogicLayer.Tong_DichVu.ToString("N0") + " VNĐ";
            bt_doanhthu.Text = BusinessLogicLayer.Tong_DoanhThu.ToString("N0") + " VNĐ";
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
