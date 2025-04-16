using bai11;

Console.OutputEncoding = System.Text.Encoding.UTF8;

SoPhuc sp1 = new SoPhuc();
SoPhuc sp2 = new SoPhuc();
sp1.Nhap();
sp2.Nhap();

Console.WriteLine("Nhập lựa phép tính (1:Tổng, 2:Tích, 3:Hiệu, 4:Thương)");
int luaChon = int.Parse(Console.ReadLine());

switch (luaChon)
{
    case 1:
        SoPhuc tong = sp1.Cong(sp2);
        Console.WriteLine("Tổng hai số phức là: ");
        tong.Xuat();
        break;
    case 2:
        SoPhuc hieu = sp1.Hieu(sp2);
        Console.WriteLine("Hiệu hai số phức là: ");
        hieu.Xuat();
        break;
    case 3:
        SoPhuc tich = sp1.Nhan(sp2);
        Console.WriteLine("Tích hai số phức là: ");
        tich.Xuat();
        break;
    case 4:
        SoPhuc thuong = sp1.Chia(sp2);
        Console.WriteLine("Thương hai số phức là: ");
        thuong.Xuat();
        break;
    default:
        Console.WriteLine("Lựa chọn không hợp lệ.");
        break;
}