using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Bai8
{
    internal class SinhVien
    {
        private string ? hoTen;
        private int namSinh;
        private string? lop;
        private int maSV;

        public SinhVien() { }
        public SinhVien(string hoTen, int namSinh, string lop, int maSV)
        {
            this.hoTen = hoTen;
            this.namSinh = namSinh;
            this.lop = lop;
            this.maSV = maSV;
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
        public string Lop
        {
            get { return lop; }
            set { lop = value; }
        }
        public int MaSV
        {
            get { return maSV; }
            set { maSV = value; }
        }

        public void Nhap()
        {
            try { 
            Console.Write("Nhap ho ten: ");
            hoTen = Console.ReadLine();
            Console.Write("Nhap nam sinh: ");
            namSinh = int.Parse(Console.ReadLine());
            Console.Write("Nhap lop: ");
            lop = Console.ReadLine();
            Console.Write("Nhap ma sinh vien: ");
            maSV = int.Parse(Console.ReadLine());
        }
            catch (FormatException)
            {
                Console.WriteLine("Nhap sai dinh dang, vui long nhap lai!");
                Nhap();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Loi: {ex.Message}");
            }
        }
        public void Xuat()
        {
            Console.WriteLine("Ho ten: " + hoTen);
            Console.WriteLine("Nam sinh: " + namSinh);
            Console.WriteLine("Lop: " + lop);
            Console.WriteLine("Ma sinh vien: " + maSV);
        }

    }
}
