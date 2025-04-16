using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai8
{
    internal class QuanLyThuVien
    {
        List<TheMuon> dsMuon = new List<TheMuon>();

        public void Nhap()
        {
            Console.Write("Nhap so luong the muon: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                TheMuon tm = new TheMuon();
                tm.Nhap();
                dsMuon.Add(tm);
            }
        }
        public void Xuat()
        {
            Console.WriteLine("Danh sach the muon:");
            foreach (var item in dsMuon)
            {
                item.Xuat();
            }
        }

        public void SinhVienDenHan()
        {
            Console.WriteLine("Danh sach sinh vien den han tra sach:");
            foreach (var item in dsMuon)
            {
                if (item.HanTra < DateOnly.FromDateTime(DateTime.Now))
                {
                    item.Xuat();
                }
                else
                {
                    Console.WriteLine("Khong co sinh vien nao den han tra sach");
                }
            }
        }
        public void TimKiem()
        {
            Console.Write("Nhap ma sinh vien  can tim: ");
            string maSV = Console.ReadLine();
            bool found = false;
            foreach (var item in dsMuon)
            {
                if (item.ThongTin.MaSV.ToString().ToLower().Replace(" ", "") == maSV)
                {
                    item.Xuat();
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                Console.WriteLine("Khong tim thay sinh vien co ma " + maSV);
            }

        }
    }
}
