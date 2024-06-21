using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hobook_Software.Class
{
    public class Room
    {
        // Các thông tin phòng
        private int SoPh;
        private String LoaiPh;
        private String TrangThai;
        private int SucChua;
        private decimal GiaTheoGio;
        private decimal GiaTheoNgay;

        public Room() { }

        public Room(int SoPh, String LoaiPh,String TrangThai, int SucChua, decimal GiaTheoGio, decimal GiaTheoNgay)
        {
            this.SoPh = SoPh;
            this.LoaiPh = LoaiPh;
            this.TrangThai = TrangThai;
            this.SucChua = SucChua;
            this.GiaTheoGio = GiaTheoGio;
            this.GiaTheoNgay = GiaTheoNgay;
        }

        public void Room_split(Room room, int index)
        {
            this.SoPh = room.SoPh;
            this.LoaiPh = room.LoaiPh;
            this.TrangThai = room.TrangThai;
            this.SucChua = room.SucChua;
            this.GiaTheoGio = room.GiaTheoGio;
            this.GiaTheoNgay = room.GiaTheoNgay;

            this.NgayBatDau.Add(room.NgayBatDau[index]);
            this.NgayKetThuc.Add(room.NgayKetThuc[index]);
            this.MaKh.Add(room.MaKh[index]);
            this.TrangThaiDon.Add(room.TrangThaiDon[index]);
            this.MaDonDat.Add(room.MaDonDat[index]);
        }

        public int SoPh1 { get => SoPh; set => SoPh = value; }
        public string LoaiPh1 { get => LoaiPh; set => LoaiPh = value; }
        public string TrangThai1 { get => TrangThai; set => TrangThai = value; }
        public int SucChua1 { get => SucChua; set => SucChua = value; }
        public decimal GiaTheoGio1 { get => GiaTheoGio; set => GiaTheoGio = value; }
        public decimal GiaTheoNgay1 { get => GiaTheoNgay; set => GiaTheoNgay = value; }
        public List<DateTime> NgayBatDau1 { get => NgayBatDau; set => NgayBatDau = value; }
        public List<DateTime> NgayKetThuc1 { get => NgayKetThuc; set => NgayKetThuc = value; }
        public List<string> MaKh1 { get => MaKh; set => MaKh = value; }
        public List<string> TrangThaiDon1 { get => TrangThaiDon; set => TrangThaiDon = value; }
        public List<string> MaDonDat1 { get => MaDonDat; set => MaDonDat = value; }

        public override string ToString()
        {
            return SoPh.ToString() + "-" + LoaiPh + "-" +TrangThai + "-" + SucChua.ToString() + "-" + GiaTheoGio.ToString() + "-" + GiaTheoNgay.ToString();
        }


        // Các thông tin liên quan đến đơn đặt phòng nếu có
        private List<DateTime> NgayBatDau = new List<DateTime>();
        private List<DateTime> NgayKetThuc = new List<DateTime>();
        private List<String> MaKh = new List<string>();
        private List<String> TrangThaiDon = new List<string>();
        private List<String> MaDonDat = new List<string>();

        public void Room_Booked(DateTime time_start, DateTime time_end,String CustomerId,String Status,String MaDon)
        {
            NgayBatDau1.Add(time_start);
            NgayKetThuc1.Add(time_end);
            MaKh1.Add(CustomerId);
            TrangThaiDon1.Add(Status);
            MaDonDat1.Add(MaDon);
        }
    }
}
