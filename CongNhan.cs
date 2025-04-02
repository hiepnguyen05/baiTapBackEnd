using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1Lab1._3
{
    internal class CongNhan : CanBo
    {
        private string ? capBac;
        public CongNhan() :base() { }
        public CongNhan(string hoTen, int namSinh, string gioiTinh, string diaChi ,string? capBac) : base(hoTen ,namSinh, gioiTinh, diaChi  )
        {
            this.hoTen = hoTen;
            this.namSinh = namSinh;
            this.gioiTinh = gioiTinh;
            this.diaChi = diaChi;
            this.capBac = capBac;
        }

        public override void Nhap() {
            base.Nhap();
            Console.WriteLine("Nhap cap bac cong nhan: ");
            capBac = Console.ReadLine();
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine($"Cap bac cong nhan la: {capBac}");
        }
    }
}
