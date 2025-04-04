using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    internal class QuanLyHoDan
    {
        List<KhuPho> listKhuPho = new List<KhuPho>();
        public void SoHoDan()
        {
            Console.WriteLine("Nhap so ho dan: ");
            int soHoDan = int.Parse(Console.ReadLine());
            for (int i = 0; i < soHoDan; i++)
            {
                KhuPho khuPho = new KhuPho();
                Console.WriteLine($"Nhap thanh vien ho thu {i+1} ");
                khuPho.Nhap();
                listKhuPho.Add(khuPho);
                Console.WriteLine("--------Them thanh cong--------- ");
            }
        }

        public void TimKiem()
        {
            Console.WriteLine("Nhap so nha can tim: ");
            string soNha = Console.ReadLine();
            foreach (KhuPho khuPho in listKhuPho)
            {
                if (khuPho.SoNha == soNha)
                {
                    khuPho.XuatThongHoDan();
                }
            }
        }


        public void Xuat()
        {
            foreach (KhuPho khuPho in listKhuPho)
            {
                khuPho.XuatThongHoDan();
            }
        }


    }
}
