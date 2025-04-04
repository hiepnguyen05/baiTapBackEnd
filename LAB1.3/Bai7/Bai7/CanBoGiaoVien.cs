using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai7
{
    internal class CanBoGiaoVien
    {
        private double luongCung;
        private double thuong;
        private double phat;
        private double luongThucLanh;
        private Nguoi thongTin;

        public CanBoGiaoVien() { }

       public CanBoGiaoVien (string hoTen, int namSinh, string queQuan, int soCMND, double luongCung, double thuong, double phat)
        {
            this.thongTin = new Nguoi(hoTen, namSinh, queQuan, soCMND);
            this.luongCung = luongCung;
            this.thuong = thuong;
            this.phat = phat;
        }
        public double LuongThucLanh
        {
            get { return luongThucLanh; }
            set { luongThucLanh = value; }
        }
        public double TinhLuongThucLanh()
        {
             return luongThucLanh = luongCung + thuong - phat;
        }
        public double LuongPhat
        {
            get { return phat; }
            set { phat = value; }
        }
        public double LuongThuong
        {
            get { return thuong; }
            set { thuong = value; }
        }
        public double LuongCung
        {
            get { return luongCung; }
            set { luongCung = value; }
        }

        public Nguoi ThongTin
        {
            get { return thongTin; }
            set { thongTin = value; }
        }
        public void Nhap()
        {
            thongTin = new Nguoi() ;
            thongTin.Nhap();
            Console.Write("Nhap luong cung: ");
            luongCung = double.Parse(Console.ReadLine());
            Console.Write("Nhap thuong: ");
            thuong = double.Parse(Console.ReadLine());
            Console.Write("Nhap phat: ");
            phat = double.Parse(Console.ReadLine());

        }
        public void Xuat()
        {
            Console.WriteLine("==============Thong tin can bo ======================");
            Console.WriteLine("Ho ten: " + thongTin.HoTen);
            Console.WriteLine("Nam sinh: " + thongTin.NamSinh);
            Console.WriteLine("Que quan: " + thongTin.QueQuan);
            Console.WriteLine("So CMND: " + thongTin.SoCMND);
            Console.WriteLine("Luong cung: " + luongCung);
            Console.WriteLine("Thuong: " + thuong);
            Console.WriteLine("Phat: " + phat);
            Console.WriteLine("Luong thuc lanh: " + luongThucLanh);
            Console.WriteLine("=====================================================");
        }
    }
}
