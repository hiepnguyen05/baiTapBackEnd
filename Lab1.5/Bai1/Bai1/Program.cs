// dung thu vien collections;
using System;
using System.Collections.Generic;
using System.Linq;
using Bai1;


List<PhanSo> dsPhanSo = new List<PhanSo>();
Console.WriteLine("Nhap so luong phan so: ");
int n = int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    Console.WriteLine($"Nhap phan so thu {i + 1}: ");
    Console.Write("Tu so: ");
    int tu = int.Parse(Console.ReadLine());
    Console.Write("Mau so: ");
    int mau = int.Parse(Console.ReadLine());
    PhanSo ps = new PhanSo(tu, mau);
    dsPhanSo.Add(ps);
}
Console.WriteLine("Danh sach phan so: ");
foreach (PhanSo ps in dsPhanSo)
{
    ps.Xuat();
}
Console.WriteLine("Tong cac phan so: ");
double tong = 0;
foreach (PhanSo ps in dsPhanSo)
{
    tong += ps.TinhTong();
}
Console.WriteLine(tong);

