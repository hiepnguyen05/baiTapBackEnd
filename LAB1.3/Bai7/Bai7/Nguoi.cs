using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai7
{
    internal class Nguoi
    {
        private string? hoTen;
        private int namSinh;
        private string? queQuan;
        private int soCMND;

        public Nguoi() { }
        public Nguoi(string hoTen, int namSinh, string queQuan, int soCMND)
        {
            this.hoTen = hoTen;
            this.namSinh = namSinh;
            this.queQuan = queQuan;
            this.soCMND = soCMND;
        }
        public string HoTen
        {
            get { return hoTen; }
            set { hoTen = value; }
        }
        public int NamSinh
        {
            get { return namSinh; }
            set { namSinh = value; }
        }

        public string QueQuan
        {
            get { return queQuan; }
            set { queQuan = value; }
        }
        public int SoCMND
        {
            get { return soCMND; }
            set { soCMND = value; }
        }

        public void Nhap()
        {
            Console.Write("Nhap ho ten: ");
            hoTen = Console.ReadLine();
            Console.Write("Nhap nam sinh: ");
            namSinh = int.Parse(Console.ReadLine());
            Console.Write("Nhap que quan: ");
            queQuan = Console.ReadLine();
            Console.Write("Nhap so CMND: ");
            soCMND = int.Parse(Console.ReadLine());
        }

        public void Xuat()
        {
            Console.WriteLine("Ho ten: " + hoTen);
            Console.WriteLine("Nam sinh: " + namSinh);
            Console.WriteLine("Que quan: " + queQuan);
            Console.WriteLine("So CMND: " + soCMND);
        }
    }
}
