using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    internal class KhoiC :  ThiSinh
    {
        private double van;
        private double su;
        private double dia;
        public double Van
        {
            get => van;
            set => van = value;
        }
        public double Su
        {
            get => su;
            set => su = value;
        }
        public double Dia
        {
            get => dia;
            set => dia = value;
        }
        public KhoiC()
        {
        }
        public KhoiC(int soBaoDanh, string? hoTen, string? diaChi, bool uuTien, double van, double su, double dia) : base(soBaoDanh, hoTen, diaChi, uuTien)
        {
            this.soBaoDanh = soBaoDanh;
            this.hoTen = hoTen;
            this.diaChi = diaChi;
            this.uuTien = uuTien;
            this.van = van;
            this.su = su;
            this.dia = dia;
        }
        public override void Nhap()
        {
            base.Nhap();
            Console.WriteLine("Nhap diem van: ");
            van = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap diem su: ");
            su = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap diem dia: ");
            dia = double.Parse(Console.ReadLine());
        }
        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("Diem van: " + van);
            Console.WriteLine("Diem su: " + su);
            Console.WriteLine("Diem dia: " + dia);
        }      
    }
}
