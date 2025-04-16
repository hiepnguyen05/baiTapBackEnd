using System;
using System.Collections.Generic;
using System.Linq;

namespace Bai19
{
    
    class Program
    {
   
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;


            List<ThiSinh> danhSachThíSinh = new List<ThiSinh>();
            Console.Write("Nhập số lượng thí sinh: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                ThiSinh thiSinh = new ThiSinh();
                Console.WriteLine($"\nNhập thông tin thí sinh thứ {i + 1}:");

                // Nhập thông tin họ tên
                Console.Write("Họ: ");
                thiSinh.Ten.Ho = Console.ReadLine();
                Console.Write("Tên đệm: ");
                thiSinh.Ten.TenDem = Console.ReadLine();
                Console.Write("Tên: ");
                thiSinh.Ten.Ten = Console.ReadLine();

                // Nhập thông tin quê quán
                Console.Write("Xã: ");
                thiSinh.Que.Xa = Console.ReadLine();
                Console.Write("Huyện: ");
                thiSinh.Que.Huyen = Console.ReadLine();
                Console.Write("Tỉnh: ");
                thiSinh.Que.Tinh = Console.ReadLine();

                // Nhập thông tin trường, tuổi, số báo danh
                Console.Write("Trường: ");
                thiSinh.Truong = Console.ReadLine();
                Console.Write("Tuổi: ");
                thiSinh.Tuoi = int.Parse(Console.ReadLine());
                Console.Write("Số báo danh: ");
                thiSinh.SoBaoDanh = Console.ReadLine();

                // Nhập điểm thi
                Console.Write("Điểm Toán: ");
                thiSinh.Diem.Toan = float.Parse(Console.ReadLine());
                Console.Write("Điểm Lý: ");
                thiSinh.Diem.Ly = float.Parse(Console.ReadLine());
                Console.Write("Điểm Hóa: ");
                thiSinh.Diem.Hoa = float.Parse(Console.ReadLine());

                danhSachThíSinh.Add(thiSinh);
            }

            // Tìm kiếm và in ra các thí sinh có tổng điểm lớn hơn 15
            Console.WriteLine("\nCác thí sinh có tổng điểm lớn hơn 15:");
            foreach (var thiSinh in danhSachThíSinh)
            {
                if (thiSinh.TongDiem() > 15)
                {
                    thiSinh.In();
                }
            }

            // Sắp xếp danh sách theo tổng điểm giảm dần
            var danhSachSapXep = danhSachThíSinh.OrderByDescending(ts => ts.TongDiem()).ToList();
            Console.WriteLine("\nDanh sách thí sinh theo tổng điểm giảm dần:");
            Console.WriteLine($"{"Họ tên",-30} {"Quê quán",-30} {"Số báo danh",-15} {"Toán",-10} {"Lý",-10} {"Hóa",-10}");

            foreach (var thiSinh in danhSachSapXep)
            {
                Console.WriteLine($"{thiSinh.Ten.Ho} {thiSinh.Ten.TenDem} {thiSinh.Ten.Ten,-30} {thiSinh.Que.Xa}, {thiSinh.Que.Huyen}, {thiSinh.Que.Tinh,-30} {thiSinh.SoBaoDanh,-15} {thiSinh.Diem.Toan,-10} {thiSinh.Diem.Ly,-10} {thiSinh.Diem.Hoa,-10}");
            }
        }
    }
}