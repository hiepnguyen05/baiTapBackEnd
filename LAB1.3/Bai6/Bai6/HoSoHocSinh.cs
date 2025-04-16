using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai6
{
    
    internal class HoSoHocSinh
    {
        private string lop;
        private string? khoaHoc;
        private int kiHoc;
        private Nguoi thongTin;

        public HoSoHocSinh()
        {
        }
        public HoSoHocSinh(string lop, string? khoaHoc, int kiHoc, Nguoi thongTin)
        {
            this.lop = lop;
            this.khoaHoc = khoaHoc;
            this.kiHoc = kiHoc;
            this.thongTin = thongTin;
        }
        public string Lop
        {
            get { return lop; }
            set { lop = value; }
        }
        public string? KhoaHoc
        {
            get { return khoaHoc; }
            set { khoaHoc = value; }
        }
        public int  KiHoc
        {
            get { return kiHoc; }
            set { kiHoc = value; }
        }
        public Nguoi ThongTin
        {
            get { return thongTin; }
            set { thongTin = value; }
        }

        public void Nhap()
        {
            Console.Write("Nhap lop: ");
            lop = Console.ReadLine();
            Console.Write("Nhap khoa hoc: ");
            khoaHoc = Console.ReadLine();
            Console.Write("Nhap ki hoc: ");
            kiHoc = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap thong tin: ");

            thongTin = new Nguoi();
            thongTin.Nhap();
        }
        public void Xuat()
        {
            Console.WriteLine("------Thong tin-------");
            Console.WriteLine("Lop: " + lop);
            Console.WriteLine("Khoa hoc: " + khoaHoc);
            Console.WriteLine("Ki hoc: " + kiHoc);
            Console.WriteLine("Thong tin: ");
            thongTin.Xuat();
            Console.WriteLine("----------------------");
        }

    }

}
