using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai13
{
    internal class PhuongTien
    {
        public string hangSanXuat { get; set; }
        public string namSanXuat { get; set; }
        public string giaBan { get; set; }
        public string mauXe { get; set; }

        //phương thức nhập và xuất thông tin
        public virtual void Nhap()
        {
            Console.WriteLine("Nhập hãng sản xuất: ");
            hangSanXuat = Console.ReadLine();
            Console.WriteLine("Nhập năm sản xuất: ");
            namSanXuat = Console.ReadLine();
            Console.WriteLine("Nhập giá bán: ");
            giaBan = Console.ReadLine();
            Console.WriteLine("Nhập màu xe: ");
            mauXe = Console.ReadLine();
        }

        public virtual void Xuat()
        {
            Console.WriteLine("Hãng sản xuất: " + hangSanXuat);
            Console.WriteLine("Năm sản xuất: " + namSanXuat);
            Console.WriteLine("Giá bán: " + giaBan);
            Console.WriteLine("Màu xe: " + mauXe);
        }


    }
}
