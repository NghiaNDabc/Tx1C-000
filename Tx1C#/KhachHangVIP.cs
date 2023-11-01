using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tx1C_
{
    internal class KhachHangVIP : KhachHang
    {
        public KhachHangVIP() : base()
        {
        }
        public KhachHangVIP(string maKH, string hoTen, int slMua, float donGia) : base(maKH, hoTen, slMua, donGia)
        {
           
        }
        public override string ToString()
        {
            return base.ToString() + String.Format("{0,20}", Coupon());
        }
        public string Coupon()
        {
            if (tinhTongTien() < 1000) return "Coupon 100";
            else if (tinhTongTien() >= 1000 && tinhTongTien() <= 5000) return "Coupon 200";
            else return "Coupon 500";
        }

    }
}
