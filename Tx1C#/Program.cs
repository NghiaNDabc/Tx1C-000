using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tx1C_
{
    internal class Program
    {
        static int choose()
        {
            int n;
            Console.Write("Moi nhap n: ");
            n = Convert.ToInt32(Console.ReadLine());
            return n;
        }
        static List<KhachHang> khachHangs = new List<KhachHang>();
        static void nhap()
        {
            Console.Write("Nhap ma khach hang: ");
            string maKH = Console.ReadLine();
            Console.Write("Nhap ten: ");
            string hoTen = Console.ReadLine();
            Console.Write("Nhap so luong mua: ");
            int slMua = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap don gia: ");
            float DonGia = Convert.ToSingle(Console.ReadLine());
            switch(choose())
            {
                case 1: KhachHang b = new KhachHang(maKH, hoTen, slMua, DonGia);
                    khachHangs.Add(b);
                    break;
                case 2: KhachHangVIP v = new KhachHangVIP(maKH, hoTen, slMua, DonGia);
                    khachHangs.Add(v);
                    break;
            }
        }
        static void xuat()
        {
            foreach (KhachHang khachHang in khachHangs)
            {
                Console.WriteLine(khachHang.ToString());
            }
        }
        static void ListKhMax()
        {
            int max  = khachHangs.Max((KhachHang kh) => kh.SlMua);

            //cach1
            var listKhMax = khachHangs.Where(kh => kh.SlMua == max);
            //cach2
            IEnumerable<KhachHang> truyVan =
                from kh in khachHangs
                where kh.SlMua == max
                orderby kh.HoTen
                select kh;
            foreach(var i in truyVan)
            {
                Console.WriteLine(i);
            }
            //foreach(var khachMax in listKhMax)
            //{
            //    Console.WriteLine(khachMax.ToString());
            //}
        }
        static void Main(string[] args)
        {
            Console.WriteLine("jhh");
            KhachHang k1 = new KhachHang("kh001", "Nguyen van a", 300, 25.75f);
            KhachHangVIP k2 = new KhachHangVIP("kh001", "Nguyen van a", 300, 25.75f);
            KhachHang k3 = new KhachHang("kh001", "Nguyen van a", 400, 25.75f);
            KhachHangVIP k4 = new KhachHangVIP("kh001", "Nguyen van a", 400, 25.75f);
            khachHangs.Add(k1);
            khachHangs.Add(k2);
            khachHangs.Add(k4);
            khachHangs.Add(k3);
            //xuat();
            ListKhMax();
            
            Console.ReadLine();
        }
    }
}
