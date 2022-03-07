using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            GoiData[] Data;
            int SoLuong = 0;
            SoLuong = SLuong();
            Console.WriteLine("NHẬP VÀO TỪNG GÓI");
            Data = NhapDanhSach(SoLuong);
            Console.WriteLine("CÁC GÓI VỪA NHẬP");
            XuatDanhSach(Data);
        }
        static void XuatDanhSach(GoiData[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine("Số thứ tự thứ: {0}",i + 1);
                XuatData(a[i]);
            }
        }
        static GoiData[] NhapDanhSach(int SoLuong)
        {
            GoiData[] a = new GoiData[SoLuong];
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine("Số thứ tự thứ {0}",i + 1);
                NhapCacGoi(out a[i]);
            }
            return a;
        }
        static int SLuong()
        {
            int n = 0;
            Console.WriteLine("Nhập vào số lượng các gói data:");
            n = int.Parse(Console.ReadLine());
            return n;
        }
        static void XuatData(GoiData a)
        {
            Console.WriteLine("Tên gói: {0}",a.TenGoi);
            Console.WriteLine("Chu kỳ gói: {0} ngày",a.ChuKyGoi);
            Console.WriteLine("Giá gói: {0}K",a.GiaGoi);
            Console.WriteLine("Vượt gói: {0}",a.VuotGoi);
        }
        static void NhapCacGoi(out GoiData Data)
        {
            Console.WriteLine("Nhập vào Tên gói cước:");
            Data.TenGoi = Console.ReadLine();
            Console.WriteLine("Nhập vào chu kỳ gói:");
            Data.ChuKyGoi = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập vào giá gói cước:");
            Data.GiaGoi = int.Parse(Console.ReadLine());
            Console.WriteLine("Gói cước này có vượt gói không?(0/1)");
            Data.VuotGoi = int.Parse(Console.ReadLine());
        }
        struct GoiData
        {
            public string TenGoi;
            public int ChuKyGoi;
            public double GiaGoi;
            public int VuotGoi;
        }
    }
}
