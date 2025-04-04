using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5
{
    internal class QuanLyKhachSan
    {
        List<KhachSan> dsKhachSan = new List<KhachSan>();
        public void NhapDanhSach()
        {
            Console.Write("Nhap so luong khach san: ");
            int n = int.Parse(Console.ReadLine());
            KhachSan khachSan = new KhachSan();
            for (int i = 0; i < n; i++)
            {
                
                khachSan.Nhap();
                dsKhachSan.Add(khachSan);
                Console.WriteLine("Them thanh cong ");
            }
        }
        public void XuatDanhSach()
        {
            Console.WriteLine("Danh sach khach san:");
            foreach (KhachSan khachSan in dsKhachSan)
            {
                khachSan.Xuat();
                Console.WriteLine();
            }
        }
        public void TimKhachSanTheoHoTen(string hoTen)
        {
            Console.WriteLine("Danh sach khach san co ho ten " + hoTen + ":");
            foreach (KhachSan khachSan in dsKhachSan)
            {
                if (khachSan.Khach.HoTen == hoTen)
                {
                 
                    khachSan.Xuat();
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Khach san khong ton tai");
                }
            }
        }

        public void TinhTienKhiTra()
        {
            Console.WriteLine("Nhap vao so chung minh nhan dan khach muon tra phong :");
            int soCMND = int.Parse(Console.ReadLine());
            foreach (KhachSan khachSan in dsKhachSan)
            {
                if (khachSan.Khach.SoCMND == soCMND)
                {
                    double soTien = khachSan.GiaPhong * khachSan.SoNgayTheu;
                    Console.WriteLine("Khach san co ho ten " + khachSan.Khach.HoTen + " phai tra: " + soTien);
                }
                else
                {
                    Console.WriteLine("Khach san khong ton tai");

                }
            }
        }
    }
}
