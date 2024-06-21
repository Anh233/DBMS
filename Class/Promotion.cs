using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hobook_Software.Class
{
    public class Promotion
    {
        private String MaKM;
        private String TenKM;
        private DateTime NgayBatDau;
        private DateTime NgayKetThuc;
        private double GiaTriKM;
        
        public string MaKM1 { get => MaKM; set => MaKM = value; }
        public string TenKM1 { get => TenKM; set => TenKM = value; }
        public DateTime NgayBatDau1 { get => NgayBatDau; set => NgayBatDau = value; }
        public DateTime NgayKetThuc1 { get => NgayKetThuc; set => NgayKetThuc = value; }
        public double GiaTriKM1 { get => GiaTriKM; set => GiaTriKM = value; }

        public Promotion() { }

        public Promotion(string maKM, string tenKM, DateTime ngayBatDau, DateTime ngayKetThuc, double giaTriKM)
        {
            this.MaKM = maKM;
            this.TenKM = tenKM;
            this.NgayBatDau = ngayBatDau;
            this.NgayKetThuc = ngayKetThuc;
            this.GiaTriKM = giaTriKM;
        }


    }
}
