using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2Lab1._3
{
    internal class Sach : Taileu 
    {
        private string? tenTacGia;
        private int soTrang;
        public Sach()
        {

        }
        public Sach(string ? maTL , string tenNXB, int soBan,string? tenTacGia, int soTrang) : base(maTL,tenNXB,soBan)
        {   
    
            this.maTL = maTL;
            this.tenNXB = tenNXB;
            this.soBan = soBan;
            this.tenTacGia = tenTacGia;
            this.soTrang = soTrang;
        }
        public override void Nhap()
        {
            base.Nhap();
            Console.WriteLine("Ten tac gia: ");
            tenTacGia = Console.ReadLine();
            Console.WriteLine("So trang: ");
            soTrang = int.Parse(Console.ReadLine() ?? "0");

        }
        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine($"Ten tac gia: {tenTacGia}");
            Console.WriteLine($"So trang: {soTrang}");
        }
    }
}
