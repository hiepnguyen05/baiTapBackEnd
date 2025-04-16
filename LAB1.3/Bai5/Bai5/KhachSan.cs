using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5
{
    internal class KhachSan
    {
        private int soNgayTheu;
        private string ? loaiPhong;
        private double giaPhong;
        private Nguoi? khach;
        public KhachSan() { }
        public KhachSan(int soNgayTheu, string loaiPhong, double giaPhong, Nguoi khach)
        {
            this.soNgayTheu = soNgayTheu;
            this.loaiPhong = loaiPhong;
            this.giaPhong = giaPhong;
            this.khach = khach;
        }
        public int SoNgayTheu
        {
            get { return soNgayTheu; }
            set { soNgayTheu = value; }
        }
        public string LoaiPhong
        {
            get { return loaiPhong; }
            set { loaiPhong = value; }
        }
        public double GiaPhong
        {
            get { return giaPhong; }
            set { giaPhong = value; }
        }
        public Nguoi Khach
        {
            get { return khach; }
            set { khach = value; }
        }

        public void Nhap()
        {
            Console.Write("Nhap so ngay theu: ");
            soNgayTheu = int.Parse(Console.ReadLine());
            Console.Write("Nhap loai phong: ");
            loaiPhong = Console.ReadLine();
            Console.Write("Nhap gia phong: ");
            giaPhong = double.Parse(Console.ReadLine());
            khach = new Nguoi();
            khach.Nhap();
        }

        public void Xuat()
        {
            Console.WriteLine("---------Thong tin phong------------");
            Console.WriteLine("So ngay theu: " + soNgayTheu);
            Console.WriteLine("Loai phong: " + loaiPhong);
            Console.WriteLine("Gia phong: " + giaPhong);
            Console.WriteLine("Thong tin khach:");
            khach.Xuat();
            Console.WriteLine("------------------------------------");
        }
    }
}
