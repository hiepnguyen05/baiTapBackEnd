using System;
using System.Collections.Generic;
using System.Linq;

namespace Bai22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; 
            List<HocSinh> danhSachHocSinh = new List<HocSinh>();
            Console.Write("Nhập số lượng học sinh: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                HocSinh hocSinh = new HocSinh();
                Console.WriteLine($"\nNhập thông tin học sinh thứ {i + 1}:");
                Console.Write("Họ tên: ");
                hocSinh.HoTen = Console.ReadLine();
                Console.Write("Năm sinh: ");
                hocSinh.NamSinh = int.Parse(Console.ReadLine());
                Console.Write("Tổng điểm: ");
                hocSinh.TongDiem = float.Parse(Console.ReadLine());

                danhSachHocSinh.Add(hocSinh);
            }

            // Sắp xếp theo tổng điểm giảm dần, năm sinh nhỏ hơn đứng trước
            var danhSachSapXep = danhSachHocSinh
                .OrderByDescending(hs => hs.TongDiem)
                .ThenBy(hs => hs.NamSinh)
                .ToList();

            // In danh sách đã sắp xếp
            Console.WriteLine("\nDanh sách học sinh đã sắp xếp:");
            foreach (var hocSinh in danhSachSapXep)
            {
                hocSinh.In();
            }
        }
    }
}