using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace KTLT2_CHUONG_3
{
    internal class Program
    {
        struct ThongTinNhanVien
        {
            public string HoTen;
            public DateTime NgaySinh;
            public double LuongCoBan;
            public double HeSoLuong;
            public int MaSo;
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            DateTime Present = DateTime.Now;
            int NgayPhaiTra = 0;
            int ThangPhaiTra = 0;
            int NamPhaiTra = 0;

            int NgayTra = 0;
            int ThangTra = 0;
            int NamTra = 0;

            DateTime date1;
            DateTime date2;

            ThongTinNhanVien NV = new ThongTinNhanVien();
            Console.WriteLine("Ngày hiện tại: {0}",Present.ToString("d"));
            Console.WriteLine(Present.DayOfWeek);
            Console.WriteLine("Hôm qua: {0}",Present.AddDays(-1).ToString("d"));
            Console.WriteLine("Ngày mai: {0}", Present.AddDays(1).ToString("d"));

            //Mượn
            Console.WriteLine("Nhập vào ngày bạn phải trả sách:");
            NgayPhaiTra = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhập vào tháng bạn phải trả sách:");
            ThangPhaiTra = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhập vào năm bạn phải trả sách:");
            NamPhaiTra = int.Parse(Console.ReadLine());

            date1 = new DateTime(NamPhaiTra, ThangPhaiTra, NgayPhaiTra);
            Console.WriteLine("=> Bạn phải trả sách vào ngày: {0}",date1.ToString("d"));

            //Trả
            Console.WriteLine("Nhập vào ngày bạn trả sách:");
            NgayTra = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhập vào tháng bạn trả sách:");
            ThangTra = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhập vào năm bạn trả sách:");
            NamTra = int.Parse(Console.ReadLine());

            date2 = new DateTime(NamTra, ThangTra, NgayTra);
            Console.WriteLine("=> Bạn trả sách vào ngày: {0}",date2.ToString("d"));

            //Số ngày trễ
            TimeSpan date3 = date2 - date1;
            
            if (date3 <= TimeSpan.Zero)
            {
                Console.WriteLine("==> Bạn ko trả trễ sách.");
            } 
            else
            {
                Console.WriteLine("==> Bạn đã trả sách trễ {0} ngày.",date3.TotalDays);
            }
            Console.WriteLine("\n\nBT DANH SÁCH NHÂN VIÊN");
            NhapThongTinNhanVien(out NV);
            XuatThongTinNhanVien(NV);
        }
        static void XuatThongTinNhanVien(ThongTinNhanVien NV)
        {
            Console.WriteLine("Mã Số: {0}",NV.MaSo);
            Console.WriteLine("Họ tên: {0}",NV.HoTen);
            Console.WriteLine("Ngày sinh: {0}",NV.NgaySinh.ToString("d"));
            Console.WriteLine("Lương cơ bản: {0}",NV.LuongCoBan);
            Console.WriteLine("Hệ số lương: {0}",NV.HeSoLuong);
        }
        static void NhapThongTinNhanVien(out ThongTinNhanVien NV)
        {
            int Day = 0;
            int Month = 0;
            int year = 0;
            Console.WriteLine("Nhập Mã Số:");
            NV.MaSo = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhập vào tên của nhân viên:");
            NV.HoTen = Console.ReadLine();

            Console.WriteLine("Nhập vào ngày sinh:");
            Day = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhập vào tháng sinh:");
            Month = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhập vào năm sinh:");
            year = int.Parse(Console.ReadLine());

            NV.NgaySinh = new DateTime(year, Month, Day);

            Console.WriteLine("Nhập vào lương cơ bản:");
            NV.LuongCoBan = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhập vào hệ số lương:");
            NV.HeSoLuong = int.Parse(Console.ReadLine());
        }
    }
}
