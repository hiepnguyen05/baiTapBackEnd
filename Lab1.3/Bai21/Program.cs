using System;
using System.Collections.Generic;

namespace Bai21
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
                Console.Write("Giới tính (Nam/Nữ): ");
                hocSinh.GioiTinh = Console.ReadLine();

                Console.Write("Điểm Toán: ");
                hocSinh.DiemToan = float.Parse(Console.ReadLine());
                Console.Write("Điểm Lý: ");
                hocSinh.DiemLy = float.Parse(Console.ReadLine());
                Console.Write("Điểm Hóa: ");
                hocSinh.DiemHoa = float.Parse(Console.ReadLine());

                if (hocSinh.GioiTinh == "Nam")
                {
                    Console.Write("Điểm Kỹ thuật: ");
                    hocSinh.DiemKiThuat = float.Parse(Console.ReadLine());
                }
                else
                {
                    Console.Write("Điểm Nữ công: ");
                    hocSinh.DiemNuCong = float.Parse(Console.ReadLine());
                }

                danhSachHocSinh.Add(hocSinh);
            }

            // Hiển thị học sinh nam có điểm kỹ thuật không nhỏ hơn 8
            Console.WriteLine("\nHọc sinh nam có điểm môn Kỹ thuật không nhỏ hơn 8:");
            foreach (var hocSinh in danhSachHocSinh)
            {
                if (hocSinh.GioiTinh == "Nam" && hocSinh.DiemKiThuat >= 8)
                {
                    hocSinh.In();
                }
            }

            // In số liệu học sinh nam trước rồi đến học sinh nữ
            Console.WriteLine("\nDanh sách học sinh:");
            foreach (var hocSinh in danhSachHocSinh)
            {
                hocSinh.In();
            }
        }
    }
}