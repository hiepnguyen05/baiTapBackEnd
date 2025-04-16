using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1Lab1._3
{
    internal class CanBo
    {
        protected string ? hoTen ;
        protected int  namSinh ;
        protected string ? gioiTinh ;
        protected string? diaChi;

        // Ham tao 
        public CanBo() { }
        public  CanBo(string? hoTen, int namSinh, string? gioiTinh, string? diaChi)
        {
            this.hoTen = hoTen;
            this.namSinh = namSinh;
            this.gioiTinh = gioiTinh;
            this.diaChi = diaChi;
        }

       public string ? HoTen
        {
            get { return hoTen; }
            
        }



        // Phuong thuc nhap thong tin ;
        public virtual void Nhap()
        {
            try
            {
                Console.WriteLine("Nhap ho ten can bo: ");
                hoTen = Console.ReadLine();
                Console.WriteLine("Nhap nam sinh can bo: ");
                namSinh = int.Parse(Console.ReadLine() ?? " 0");
                Console.WriteLine("Nhap gioi tinh can bo: ");
                gioiTinh = Console.ReadLine();
                Console.WriteLine("Nhap dia chi can bo: ");
                diaChi = Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Nhap lieu khong hop le: " + ex.Message);
            }
        }
        // Phuong thuc hien thi thong tin 
        public virtual void Xuat()
        {
            Console.WriteLine("=============================");
            Console.WriteLine("           Thong tin         ");
            Console.WriteLine("=============================");
            Console.WriteLine($"Ho va ten: {hoTen}");
            Console.WriteLine($"Nam sinh: {namSinh}");
            Console.WriteLine($"Gioi tinh: {gioiTinh}");
            Console.WriteLine($"Dia chi: {diaChi}");
            Console.WriteLine("=============================");
        }
    }
}
