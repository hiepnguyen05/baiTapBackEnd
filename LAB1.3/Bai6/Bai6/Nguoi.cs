using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai6
{
    internal class Nguoi
    {
        private string? hoTen;
        private int tuoi;
        private int namSinh;
        private string? queQuan;
        private string? gioiTinh;

        public Nguoi()
        {
        }
        public Nguoi(string hoTen, int tuoi, int namSinh, string queQuan, string? gioiTinh)
        {
            this.hoTen = hoTen;
            this.tuoi = tuoi;
            this.namSinh = namSinh;
            this.queQuan = queQuan;
            this.gioiTinh = gioiTinh;
        }
        public string HoTen
        {
            get { return hoTen; }
            set { hoTen = value; }
        }
        public int Tuoi
        {
            get { return tuoi; }
            set { tuoi = value; }
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
        public string? GioiTinh
        {
            get { return gioiTinh; }
            set { gioiTinh = value; }
        }

        public void Nhap()
        {
            try
            {
                Console.Write("Nhap ho ten: ");
                hoTen = Console.ReadLine();
                Console.Write("Nhap tuoi: ");
                tuoi = int.Parse(Console.ReadLine());
                Console.Write("Nhap nam sinh: ");
                namSinh = int.Parse(Console.ReadLine());
                Console.Write("Nhap que quan: ");
                queQuan = Console.ReadLine();
                Console.Write("Nhap gioi tinh: ");
                gioiTinh = Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Loi nhap lieu: "+ex.Message);
            }
        }

        public void Xuat()
        {
            Console.WriteLine($"Ho ten: {hoTen}");
            Console.WriteLine($"Tuoi: {tuoi}");
            Console.WriteLine($"Nam sinh: {namSinh}");
            Console.WriteLine($"Que quan: {queQuan}");
            Console.WriteLine($"Gioi tinh: {gioiTinh}");
        }
    }
}
