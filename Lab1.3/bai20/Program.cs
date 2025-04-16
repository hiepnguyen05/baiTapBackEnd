using System;
using System.Collections.Generic;
using System.Linq;

namespace Bai20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; 
            List<HoiVien> danhSachHoiVien = new List<HoiVien>();
            Console.Write("Nhập số lượng hội viên: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\nNhập thông tin hội viên thứ {i + 1}:");
                Console.Write("Họ tên: ");
                string hoTen = Console.ReadLine();
                Console.Write("Địa chỉ: ");
                string diaChi = Console.ReadLine();

                Console.Write("Có gia đình? (1: Có, 0: Không): ");
                int coGiaDinh = int.Parse(Console.ReadLine());

                if (coGiaDinh == 1)
                {
                    HoiVienDaKetHon hoiVien = new HoiVienDaKetHon
                    {
                        HoTen = hoTen,
                        DiaChi = diaChi
                    };

                    Console.Write("Họ tên vợ: ");
                    hoiVien.HoTenVo = Console.ReadLine();
                    Console.Write("Ngày cưới (dd.MM.yyyy): ");
                    hoiVien.NgayCuoi = DateTime.Parse(Console.ReadLine());

                    danhSachHoiVien.Add(hoiVien);
                }
                else
                {
                    Console.Write("Có người yêu? (1: Có, 0: Không): ");
                    int coNguoiYeu = int.Parse(Console.ReadLine());

                    if (coNguoiYeu == 1)
                    {
                        HoiVienCoNguoiYeu hoiVien = new HoiVienCoNguoiYeu
                        {
                            HoTen = hoTen,
                            DiaChi = diaChi
                        };

                        Console.Write("Họ tên người yêu: ");
                        hoiVien.HoTenNguoiYeu = Console.ReadLine();
                        Console.Write("Số điện thoại: ");
                        hoiVien.SoDienThoai = Console.ReadLine();

                        danhSachHoiVien.Add(hoiVien);
                    }
                    else
                    {
                        HoiVien hoiVien = new HoiVien
                        {
                            HoTen = hoTen,
                            DiaChi = diaChi
                        };

                        danhSachHoiVien.Add(hoiVien);
                    }
                }
            }

            // Tìm kiếm hội viên có ngày cưới là 11.11.2011
            Console.WriteLine("\nHội viên có ngày cưới là 11.11.2011:");
            foreach (var hoiVien in danhSachHoiVien.OfType<HoiVienDaKetHon>())
            {
                if (hoiVien.NgayCuoi == new DateTime(2011, 11, 11))
                {
                    hoiVien.In();
                }
            }

            // Hiển thị thông tin cho những người đã có người yêu nhưng chưa lập gia đình
            Console.WriteLine("\nHội viên đã có người yêu nhưng chưa lập gia đình:");
            foreach (var hoiVien in danhSachHoiVien.OfType<HoiVienCoNguoiYeu>())
            {
                hoiVien.In();
            }
        }
    }
}