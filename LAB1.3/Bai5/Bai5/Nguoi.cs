using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5
{
    internal class Nguoi
    {
        protected string ? hoTen;
        protected int namSinh;
        protected int soCMND;

        public Nguoi() { }
        public Nguoi(string hoTen, int namSinh, int soCMND)
        {
            this.hoTen = hoTen;
            this.namSinh = namSinh;
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
        public int SoCMND
        {
            get { return soCMND; }
            set { soCMND = value; }
        }

        public virtual void Nhap()
        {
            Console.Write("Nhap ho ten: ");
            hoTen = Console.ReadLine();
            Console.Write("Nhap nam sinh: ");
            namSinh = int.Parse(Console.ReadLine());
            Console.Write("Nhap so CMND: ");
            soCMND = int.Parse(Console.ReadLine());
        }
        public virtual void Xuat()
        {
            Console.WriteLine("Ho ten: " + hoTen);
            Console.WriteLine("Nam sinh: " + namSinh);
            Console.WriteLine("So CMND: " + soCMND);
        }


    }
}
