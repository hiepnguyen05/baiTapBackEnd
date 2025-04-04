using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    internal class KhoiA : ThiSinh
    {
        private double toan;
        private double ly;
        private double hoa;

        public double Toan
        {
            get => toan;
            set => toan = value;
        }
        public double Ly
        {
            get => ly;
            set => ly = value;
        }
        public double Hoa
        {
            get => hoa;
            set => hoa = value;
        }
        public KhoiA()
        {
        }
        public KhoiA(int soBaoDanh, string ? hoTen,string ? diaChi, bool uuTien, double toan, double ly, double hoa) : base(soBaoDanh, hoTen, diaChi, uuTien)
        {
            this.soBaoDanh = soBaoDanh;
            this.hoTen = hoTen;
            this.diaChi = diaChi;
            this.uuTien = uuTien;
            this.toan = toan;
            this.ly = ly;
            this.hoa = hoa;
        }

        public override void Nhap()
        {
            base.Nhap();
            Console.WriteLine("Nhap diem toan: ");
            toan = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap diem ly: ");
            ly = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap diem hoa: ");
            hoa = double.Parse(Console.ReadLine());
        }
        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("Diem toan: " + toan);
            Console.WriteLine("Diem ly: " + ly);
            Console.WriteLine("Diem hoa: " + hoa);
        }
    }
}
