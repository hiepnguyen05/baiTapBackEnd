using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    internal class HinhChuNhat : Hinh
    {
        private double a;
        private double b;
        public HinhChuNhat(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public override double ChuVi()
        {
            return 2 * (a + b);
        }
        public override double DienTich()
        {
            return a * b;
        }
        public void Xuat()
        {
            Console.WriteLine("Hình chữ nhật có chiều dài {0} và chiều rộng {1}", a, b);
            Console.WriteLine("Chu vi hình chữ nhật là: {0}", ChuVi());
            Console.WriteLine("Diện tích hình chữ nhật là: {0}", DienTich());
        }
    }
}
