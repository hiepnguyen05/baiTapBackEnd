using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    internal class Nguoi
    {
        private int soCMND;
        private string? hoTen;
        private int tuoi;
        private int namSinh;
        private string? ngheNghiep;

        public Nguoi()
        {
        }
        public Nguoi(int soCMND, string hoTen, int tuoi, int namSinh, string ngheNghiep)
        {
            this.soCMND = soCMND;
            this.hoTen = hoTen;
            this.tuoi = tuoi;
            this.namSinh = namSinh;
            this.ngheNghiep = ngheNghiep;
        }

        public int SoCMND { get => soCMND; set => soCMND = value; }
        public string? HoTen { get => hoTen; set => hoTen = value; }

        public void Nhap()
        {
            Console.WriteLine("Nhap so CMND: ");
            soCMND = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap ho ten: ");
            hoTen = Console.ReadLine();
            Console.WriteLine("Nhap tuoi: ");
            tuoi = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap nam sinh: ");
            namSinh = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap nghe nghiep: ");
            ngheNghiep = Console.ReadLine();
        }

        public void Xuat()
        {
            Console.WriteLine("So CMND: " + soCMND);
            Console.WriteLine("Ho ten: " + hoTen);
            Console.WriteLine("Tuoi: " + tuoi);
            Console.WriteLine("Nam sinh: " + namSinh);
            Console.WriteLine("Nghe nghiep: " + ngheNghiep);
        }

    }
}
