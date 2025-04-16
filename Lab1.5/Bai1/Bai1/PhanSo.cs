using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    internal class PhanSo
    {
        private int tuSo;
        private int mauSo;
        public PhanSo(int tu, int mau)
        {
            this.tuSo = tu;
            this.mauSo = mau;
        }
        public void Xuat()
        {
            Console.WriteLine($"{tuSo}/{mauSo}");
        }
       public double TinhTong()
        {
            double kq = (double)tuSo / mauSo;
            return kq;
        }
        
    }
}
