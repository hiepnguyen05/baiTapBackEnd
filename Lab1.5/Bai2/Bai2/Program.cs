// import cac thu vien can thiet
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bai2;
Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.InputEncoding = System.Text.Encoding.UTF8;





List<Hinh> hinh = new List<Hinh>();
while (true)
{
    Console.WriteLine("Chọn hình để tính diện tích và chu vi:");
    Console.WriteLine("1. Hình vuông");
    Console.WriteLine("2. Hình chữ nhật");
    Console.WriteLine("3. Hình tam giác");
    Console.WriteLine("4. Hinh tron");
    Console.WriteLine("5. Thoát");
    Console.Write("Nhập lựa chọn của bạn: ");
    int choice = int.Parse(Console.ReadLine());
    if (choice == 5)
        break;
    switch (choice)
    {
        case 1:
            Console.Write("Nhập cạnh hình vuông: ");
            double a = double.Parse(Console.ReadLine());
            hinh.Add(new HinhVuong(a));
            break;
        case 2:
            Console.Write("Nhập chiều dài hình chữ nhật: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Nhập chiều rộng hình chữ nhật: ");
            double c = double.Parse(Console.ReadLine());
            hinh.Add(new HinhChuNhat(b, c));
            break;
        case 3:
            Console.Write("Nhập cạnh a: ");
            double d = double.Parse(Console.ReadLine());
            Console.Write("Nhập cạnh b: ");
            double e = double.Parse(Console.ReadLine());
            Console.Write("Nhập cạnh c: ");
            double f = double.Parse(Console.ReadLine());
            hinh.Add(new HinhTamGiac(d, e, f));
            break;
        case 4:
            Console.Write("Nhập bán kính hình tròn: ");
            double r = double.Parse(Console.ReadLine());
            hinh.Add(new HinhTron(r));
            break;
        default:
            Console.WriteLine("Lựa chọn không hợp lệ!");
            break;
    }
    Console.WriteLine("Danh sách các hình đã nhập:");
    foreach (var item in hinh)
    {
        if (item is HinhVuong)
        {
            ((HinhVuong)item).Xuat();
        }
        else if (item is HinhChuNhat)
        {
            ((HinhChuNhat)item).Xuat();
        }
        else if (item is HinhTamGiac)
        {
            ((HinhTamGiac)item).Xuat();
        }
    }
    double tongDienTich = 0;

    double tongChuVi = 0;

    foreach (var item in hinh)
    {
        tongDienTich += item.DienTich();
        tongChuVi += item.ChuVi();
    }
    Console.WriteLine("----------------------------------------------------------------");
    Console.WriteLine("Tổng diện tích các hình đã nhập là: {0}", tongDienTich);

    Console.WriteLine("Tổng chu vi các hình đã nhập là: {0}", tongChuVi);
    Console.WriteLine("----------------------------------------------------------------");
}
