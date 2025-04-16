using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai7
{
    internal class QuanLyCanBo
    {
        List<CanBoGiaoVien> danhSachCanBo = new List<CanBoGiaoVien>();

        public void NhapDanhSach()
        {
            Console.Write("Nhap so luong can bo: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                CanBoGiaoVien canBo = new CanBoGiaoVien();
                canBo.Nhap();
                canBo.TinhLuongThucLanh();
                danhSachCanBo.Add(canBo);
            }
        }
        public void TimKiemCanBo()
        {
            Console.WriteLine("Nhap vao que can bo can tim: ");
            string que = Console.ReadLine();
            bool found = false;
            foreach (var canBo in danhSachCanBo)
            {
                if (string.Equals(canBo.ThongTin.QueQuan.Trim(), que.Trim(), StringComparison.OrdinalIgnoreCase))
                {
                    canBo.Xuat();
                    found = true;
                }
            }
            if (!found)
            {
                Console.WriteLine("Khong tim thay can bo co ten: " + que);
            }
        }

        public void CanBoCoLuongTren1Jack()
        {
            foreach (var canBo in danhSachCanBo)
            {
                if (canBo.LuongThucLanh > 5000000)
                {
                    canBo.Xuat();
                }
                else
                {
                    Console.WriteLine("Khong co can bo nao co luong tren 5 trieu");
                }
            }
        }
        public void XuatDanhSach()
        {
            Console.WriteLine("Danh sach can bo:");
            foreach (var canBo in danhSachCanBo)
            {
                canBo.Xuat();
                Console.WriteLine();
            }
        }
    }
}
