using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai6
{
    internal class QuanLyHoSo
    {
        List<HoSoHocSinh> danhSachHoSo = new List<HoSoHocSinh>();
        HoSoHocSinh hs = new HoSoHocSinh();
        public void NhapDanhSach()
        {
            Console.Write("Nhap so luong ho so: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap thong tin ho so " + (i + 1) + ":");
                hs.Nhap();
                danhSachHoSo.Add(hs);
                Console.WriteLine("Them thanh cong ");
            }
        }
        public void XuatDanhSachHocSinhNuSinhNam1985()
        {
            Console.WriteLine("Danh sach hoc sinh nu sinh nam 1985:");
            foreach (var hs in danhSachHoSo)
            {
                if (hs.ThongTin.GioiTinh == "nu" && hs.ThongTin.NamSinh == 1985)
                {
                    hs.Xuat();
                }else
                {
                    Console.WriteLine("Khong co hoc sinh nu sinh nam 1985");
                }
            }
        }

        public void TimKiemTheoQueQuan(string queQuan)
        {
            Console.WriteLine("Danh sach hoc sinh co que quan " + queQuan + ":");
            foreach (var hs in danhSachHoSo)
            {
                if (hs.ThongTin.QueQuan == queQuan)
                {
                    hs.Xuat();
                }
                else
                {
                    Console.WriteLine("Khong co hoc sinh co que quan " + queQuan);
                }
            }
        }

    }
}
