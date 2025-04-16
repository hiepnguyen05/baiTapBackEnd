using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    internal class ThiSinh
    {
        protected int soBaoDanh;
        protected string ? hoTen;
        protected string ? diaChi;
        protected bool uuTien;

        public int SoBaoDanh
        {
            get => soBaoDanh;
            set => soBaoDanh = value;
        }
        public ThiSinh()
        {
            soBaoDanh = 0;
            hoTen = "";
            diaChi = "";
            uuTien = false;
        }
        public ThiSinh(int soBaoDanh, string hoTen, string diaChi, bool uuTien)
        {
            this.soBaoDanh = soBaoDanh;
            this.hoTen = hoTen;
            this.diaChi = diaChi;
            this.uuTien = uuTien;
        }

        public virtual void Nhap()
        {
            
            Console.WriteLine("Nhap so bao danh: ");
            soBaoDanh = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap ho ten: ");
            hoTen = Console.ReadLine();
            Console.WriteLine("Nhap dia chi: ");
            diaChi = Console.ReadLine();
            Console.WriteLine("Nhap uu tien: ");
            uuTien = bool.Parse(Console.ReadLine());
        }

        public virtual void Xuat()
        {
            Console.WriteLine("------Thong tin thi sinh------");
            Console.WriteLine("So bao danh: " + soBaoDanh);
            Console.WriteLine("Ho ten: " + hoTen);
            Console.WriteLine("Dia chi: " + diaChi);
            Console.WriteLine("Uu tien: " + uuTien);
            Console.WriteLine("------------------------------");
        }


    }
}
