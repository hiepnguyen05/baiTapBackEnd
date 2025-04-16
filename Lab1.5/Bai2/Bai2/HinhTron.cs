using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    internal class HinhTron :   Hinh
    {
        private double r;
        public HinhTron(double r)
        {
            this.r = r;
        }

        public override double ChuVi()
        {
            return 2 * Math.PI * r;
        }
        public override double DienTich()
        {
            return Math.PI * r * r;
        }
        public void Xuat()
        {
            Console.WriteLine("Hình tròn có bán kính {0}", r);
            Console.WriteLine("Chu vi hình tròn là: {0}", ChuVi());
            Console.WriteLine("Diện tích hình tròn là: {0}", DienTich());
        }
    }
}
