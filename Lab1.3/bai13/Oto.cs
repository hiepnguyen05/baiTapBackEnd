using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai13
{
    internal class Oto : PhuongTien
    {
        protected string soChoNgoi { get; set; }
        protected string kieuDongCo { get; set; }

        //Phương thức nhập xuất thông tin
        public override void Nhap()
        {
            base.Nhap();
            Console.WriteLine("Nhập số chỗ ngồi: ");
            soChoNgoi = Console.ReadLine();
            Console.WriteLine("Nhập kiểu động cơ: ");
            kieuDongCo = Console.ReadLine();
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("Số chỗ ngồi: " + soChoNgoi);
            Console.WriteLine("Kiểu động cơ: " + kieuDongCo);
        }

    }
}
