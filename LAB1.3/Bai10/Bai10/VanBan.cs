using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai10
{
    internal class VanBan
    {
        private string xauKiTu;
        public string XauKiTu
        {
            get { return xauKiTu; }
            set { xauKiTu = value; }
        }
        public VanBan() { }
        public VanBan(string xauKiTu)
        {
            this.xauKiTu = xauKiTu;
        }
        public void Nhap()
        {
            Console.WriteLine("Nhap xau ki tu: ");
            xauKiTu = Console.ReadLine();
        }
        public void Xuat()
        {
            Console.WriteLine("Xau ki tu: " + xauKiTu);
        }
    }
}
