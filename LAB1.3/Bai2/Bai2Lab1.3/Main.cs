using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2Lab1._3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("------Quan ly tai lieu------");
            //Console.WriteLine("1. Nhap thong tin tai lieu");
            //Console.WriteLine("2. Hien thi thong tin tai lieu");
            //Console.WriteLine("3. Tim kiem tai lieu");
            //Console.WriteLine("4. Thoat");
            QuanLyTaiLieu qltl = new QuanLyTaiLieu();
            while (true)
            {
                Console.WriteLine("------Quan ly tai lieu------");
                Console.WriteLine("1. Nhap thong tin tai lieu");
                Console.WriteLine("2. Hien thi thong tin tai lieu");
                Console.WriteLine("3. Tim kiem tai lieu");
                Console.WriteLine("4. Thoat");
                Console.WriteLine("Chon chuc nang: ");

                int chon = int.Parse(Console.ReadLine() ?? "0");
                switch (chon)
                {
                    case 1:
                        qltl.Nhap();
                        break;
                    case 2:
                        Console.WriteLine("------Thong tin tai lieu------");
                        qltl.Xuat();
                        Console.WriteLine("------------------------------");
                        break;
                    case 3:
                        Console.WriteLine("Nhap ma tai lieu can tim: ");
                        string maTL = Console.ReadLine();
                        Console.WriteLine("------Thong tin tai lieu------");
                        qltl.TimKiem(maTL);
                        Console.WriteLine("------------------------------");
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Chon chuc nang khong hop le");
                        break;
                }
            }
        }
    }
}
