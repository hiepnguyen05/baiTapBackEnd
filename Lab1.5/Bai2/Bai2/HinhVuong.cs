using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    internal class HinhVuong : Hinh
    {
        private double a;
        public HinhVuong(double a)
        {
            this.a = a;
        }

        public override double ChuVi()
        {
            return 4 * a;
        }
        public override double DienTich()
        {
            return a * a;
        }
        public void Xuat()
        {
            Console.WriteLine("Hình vuông có cạnh {0}", a);
            Console.WriteLine("Chu vi hình vuông là: {0}", ChuVi());
            Console.WriteLine("Diện tích hình vuông là: {0}", DienTich());
        }
    }
}
