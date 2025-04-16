using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai13
{
    internal class XeMay : PhuongTien
    {
        protected string congSuat { get; set; }

        //Phương thức nhập xuất thông tin
        public override void Nhap()
        {
            base.Nhap();
            Console.WriteLine("Nhập công suất: ");
            congSuat = Console.ReadLine();
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("Công suất: " + congSuat);
        }

    }
}
