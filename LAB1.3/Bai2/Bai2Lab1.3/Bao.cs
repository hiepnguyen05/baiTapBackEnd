using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2Lab1._3
{
    internal class Bao : Taileu
    {
        private int ngayPhatHanh;
        public Bao()
        {
        }
        public Bao(string? maTL, string tenNXB, int soBan, int ngayPhatHanh) : base(maTL, tenNXB, soBan)
        {
            this.maTL = maTL;
            this.tenNXB = tenNXB;
            this.soBan = soBan;
            this.ngayPhatHanh = ngayPhatHanh;
        }
        public override void Nhap()
        {
            base.Nhap();
            Console.WriteLine("Ngay phat hanh: ");
            ngayPhatHanh = int.Parse(Console.ReadLine() ?? "0");
        }
        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine($"Ngay phat hanh: {ngayPhatHanh}");
        }
    }
   
}
