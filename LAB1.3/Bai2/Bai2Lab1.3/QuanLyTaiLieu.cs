using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2Lab1._3
{
    internal class QuanLyTaiLieu
    {
        private List<Taileu> listTL = new List<Taileu>();
        public void Nhap()
        {
            Console.WriteLine("Nhap so tai lieu muon nhap: ");
            int n = int.Parse(Console.ReadLine() ?? "0");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("1. Sach");
                Console.WriteLine("2. Tap chi");
                Console.WriteLine("3. Bao");
                Console.WriteLine("Chon loai tai lieu: ");
                int chon = int.Parse(Console.ReadLine() ?? "0");
                Taileu tl;
                switch (chon)
                {
                    case 1:
                        tl = new Sach();
                        break;
                    case 2:
                        tl = new TapChi();
                        break;
                    case 3:
                        tl = new Bao();
                        break;
                    default:
                        tl = new Sach();
                        break;
                }
                tl.Nhap();
                listTL.Add(tl);
            }
        }
        public void Xuat()
        {
            foreach (var item in listTL)
            {
                item.Xuat();
            }
        }
        public void TimKiem(string maTL)
        {
            foreach (var item in listTL)
            {
                if (item.MaTL == maTL)
                {
                    item.Xuat();
                }
            }
        }
    }
}
