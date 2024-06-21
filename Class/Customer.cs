using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hobook_Software.Class
{
    public class Customer
    {
        private String MaKh;
        private String HoTen;
        private String DiaChi;
        private String CCCD;
        private String LienLac;
        private DateTime NgaySinh;

        public string MaKh1 { get => MaKh; set => MaKh = value; }
        public string HoTen1 { get => HoTen; set => HoTen = value; }
        public string DiaChi1 { get => DiaChi; set => DiaChi = value; }
        public string CCCD1 { get => CCCD; set => CCCD = value; }
        public string LienLac1 { get => LienLac; set => LienLac = value; }
        public DateTime NgaySinh1 { get => NgaySinh; set => NgaySinh = value; }

        public Customer()
        {

        }

        public Customer(String MaKh, String HoTen,String DiaChi, String CCCD, String LienLac, DateTime NgaySinh)
        {
            this.MaKh = MaKh;
            this.HoTen = HoTen;
            this.DiaChi = DiaChi;
            this.CCCD = CCCD;
            this.LienLac = LienLac;
            this.NgaySinh = NgaySinh;
        }

        public override string ToString()
        {
            return MaKh.ToString().TrimEnd() + "-" + HoTen.ToString() + "-" + DiaChi.ToString() + "-" + CCCD.ToString()+ "-" + LienLac.ToString() + "-" + NgaySinh.ToString("yyyy-MM-dd").Replace("-", "/");
        }
    }
}
