using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    internal class TuyenSinh
    {
        List<ThiSinh> listThiSinh = new List<ThiSinh>();
        public void Nhap()
        {
            Console.WriteLine("Nhap so thi sinh: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap loai thi sinh: ");
                Console.WriteLine("1. Khoi A");
                Console.WriteLine("2. Khoi B");
                Console.WriteLine("3. Khoi C");
                int choice = int.Parse(Console.ReadLine());
                ThiSinh ts = null;
                switch (choice)
                {
                    case 1:
                        ts = new KhoiA();
                        break;
                    case 2:
                        ts = new KhoiB();
                        break;
                    case 3:
                        ts = new KhoiC();
                        break;
                    default:
                        break;
                }
                ts.Nhap();
                listThiSinh.Add(ts);
            }
        }
        public void ThiSinhTrungTuyen()
        {
            foreach (var ts in listThiSinh)
            {
                if (ts is KhoiA)
                {
                    KhoiA khoiA = ts as KhoiA;
                    if (khoiA.Toan + khoiA.Ly + khoiA.Hoa > 15)
                    {
                        khoiA.Xuat();
                    }
                    else
                    {
                        Console.WriteLine("Khong co thi sinh khoi A nao trung tuyen");
                    }
                }
                else if (ts is KhoiB)
                {
                    KhoiB khoiB = ts as KhoiB;
                    if (khoiB.Toan + khoiB.Sinh + khoiB.Hoa > 16)
                    {
                        khoiB.Xuat();
                    }
                    else
                    {
                        Console.WriteLine("Khong co thi sinh khoi B nao trung tuyen");
                    }
                }
                else if (ts is KhoiC)
                {
                    KhoiC khoiC = ts as KhoiC;
                    if (khoiC.Van + khoiC.Su + khoiC.Dia > 13.5)
                    {
                        khoiC.Xuat();
                    }
                    else
                    {
                        Console.WriteLine("Khong co thi sinh khoi C nao trung tuyen");
                    }
                }
            }
        }


        public void TimKiem()
        {
            Console.WriteLine("Nhap so bao danh can tim: ");
            int soBaoDanh = int.Parse(Console.ReadLine());
            foreach (var ts in listThiSinh)
            {
                if (ts.SoBaoDanh == soBaoDanh)
                {
                    ts.Xuat();
                }
            }
        }
    }
}
