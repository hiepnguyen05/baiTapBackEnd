using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2Lab1._3
{
    internal class Taileu
    {
        protected string? maTL;
        protected string? tenNXB;
        protected int soBan;
        public Taileu()
        {
            
        }
        public Taileu(string ? maTL, string? tenNXB, int soBan)
        {
            this.maTL = maTL;
            this.tenNXB = tenNXB;
            this.soBan = soBan;
        }

        public string MaTL { get => maTL; set => maTL = value; }

        // Nhap thong tin tai lieu 
        public virtual void Nhap() {
            Console.WriteLine("Nhap ma tai lieu ");
            maTL = Console.ReadLine();
            Console.WriteLine("Nhap ten nha xuat ban  ");
            tenNXB = Console.ReadLine();
            Console.WriteLine("Nhap so ban  ");
            soBan = int .Parse(Console.ReadLine() ?? "0");
        }
        // Hien thi thong tin 
        public virtual void Xuat()
        {
            Console.WriteLine($"Ma tai lieu la {maTL}");
            Console.WriteLine($"Ten nha xuat ban {tenNXB}");
            Console.WriteLine($"So ban {soBan}");
        }
    };

    
}
