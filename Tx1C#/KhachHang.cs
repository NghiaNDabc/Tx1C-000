using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tx1C_
{
    internal class KhachHang
    {
        private string maKH;
        private string hoTen;
        private int slMua;
        private float donGia;
        public string MaKH {  get { return maKH; } set {  maKH = value; } }
        public string HoTen { get {  return hoTen; } set {  hoTen = value; } }
        public int SlMua { get {  return slMua; } set {  slMua = value; } }
        public float DonGia { get {  return donGia; } set {  donGia = value; } }

        public KhachHang()
        {

        }
        public KhachHang(string maKH, string hoTen, int slMua, float donGia)
        {
            this.MaKH = maKH;
            this.HoTen = hoTen;
            this.SlMua = slMua;
            this.DonGia = donGia;
        }
        public virtual void xuat()
        {
            Console.WriteLine(String.Format("{0,-10}{1,20}{2,5}{3,5}", maKH, hoTen, SlMua, DonGia));
        }
        public override string ToString()
        {
            return String.Format("{0,-10}{1,20}{2,5}{3,5}", maKH, hoTen, SlMua, DonGia);
        }
        public float tinhTongTien()
        {
            return SlMua * DonGia;
        }
    }
}
