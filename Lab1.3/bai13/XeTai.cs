using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai13
{
    internal class XeTai : PhuongTien
    {
        protected string trongTai {get; set; }

        //Phương thức nhập xuất thông tin
        public override void Nhap()
        {
            base.Nhap();
            Console.WriteLine("Nhập trọng tải: ");
            trongTai = Console.ReadLine();
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("Trọng tải: " + trongTai);
        }
    }
}
