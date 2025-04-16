using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    internal class HinhTamGiac : Hinh
    {
        private double a;
        private double b;
        private double c;
        public HinhTamGiac(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public override double ChuVi()
        {
            return a + b + c;
        }
        public override double DienTich()
        {
            double p = ChuVi() / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
        public void Xuat()
        {
            Console.WriteLine("Hình tam giác có ba cạnh lần lượt là {0}, {1}, {2}", a, b, c);
            Console.WriteLine("Chu vi hình tam giác là: {0}", ChuVi());
            Console.WriteLine("Diện tích hình tam giác là: {0}", DienTich());
        }
    }
}
