using System;
using Bai3;

public class Program
{
    public static void Main(string[] args)
    {
        TuyenSinh tuyenSinh = new TuyenSinh();
        while (true)
        {
            Console.WriteLine("---------Quan ly thi sinh---------");
            Console.WriteLine("1. Nhap thong tin thi sinh");
            Console.WriteLine("2. Hien thi thong tin trung tuyen");
            Console.WriteLine("3. Tim thi sinh theo so bao danh");
            Console.WriteLine("4. Thoat");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Nhap lua chon: ");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    tuyenSinh.Nhap();
                    break;
                case 3:
                    tuyenSinh.TimKiem();
                    break;
                case 2:
                    tuyenSinh.ThiSinhTrungTuyen();
                    break;
                case 4:
                    return;
                default:
                    break;
            }
        }
    }
}
