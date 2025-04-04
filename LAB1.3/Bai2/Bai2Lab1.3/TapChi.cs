using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2Lab1._3
{
    internal class TapChi : Taileu
    {
        private int soPhatHanh;
        private int thangPhatHanh;
        public TapChi()
        {
        }
        public TapChi(string? maTL, string tenNXB, int soBan, int soPhatHanh, int thangPhatHanh) : base(maTL, tenNXB, soBan)
        {
            this.maTL = maTL;
            this.tenNXB = tenNXB;
            this.soBan = soBan;
            this.soPhatHanh = soPhatHanh;
            this.thangPhatHanh = thangPhatHanh;
        }
        public override void Nhap()
        {
            base.Nhap();
            Console.WriteLine("So phat hanh: ");
            soPhatHanh = int.Parse(Console.ReadLine() ?? "0");
            Console.WriteLine("Thang phat hanh: ");
            thangPhatHanh = int.Parse(Console.ReadLine() ?? "0");
        }
        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine($"So phat hanh: {soPhatHanh}");
            Console.WriteLine($"Thang phat hanh: {thangPhatHanh}");
        }
    }
}

