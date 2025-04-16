using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai16
{
    internal class Diem
    {
        internal int hoanhDo { get; set; }
        internal int tungDo { get; set; }
        // Hàm tạo không tham số và có tham số
        public Diem()
        {
            hoanhDo = 0;
            tungDo = 0;
        }
        public Diem(int x, int y)
        {
            hoanhDo = x;
            tungDo = y;
        }
        // Phương thức nhập, xuất
        public void Nhap()
        {
            Console.Write("Nhập hoành độ: ");
            hoanhDo = int.Parse(Console.ReadLine());
            Console.Write("Nhập tung độ: ");
            tungDo = int.Parse(Console.ReadLine());
        }
        public void Xuat()
        {
            Console.WriteLine($"Điểm có tọa độ ({hoanhDo}, {tungDo})");
        }
        //Toán tử tạo lập

        // Tính khoảng cách giữa 2 điểm
        public double KhoangCach(Diem d)
        {
            return Math.Sqrt(Math.Pow(hoanhDo - d.hoanhDo, 2) + Math.Pow(tungDo - d.tungDo, 2));
        }
    }
}
