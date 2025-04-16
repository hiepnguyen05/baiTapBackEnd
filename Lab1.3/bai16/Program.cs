using bai16;
Console.OutputEncoding = System.Text.Encoding.UTF8;

List<TamGiac> danhSachTamGiac = new List<TamGiac>();

Console.Write("Nhập số lượng tam giác: ");
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    Console.WriteLine($"Tam giác thứ {i + 1}:");
    Console.Write("Nhập tọa độ ba điểm (x1, y1, x2, y2, x3, y3): ");
    int x1 = int.Parse(Console.ReadLine());
    int y1 = int.Parse(Console.ReadLine());
    int x2 = int.Parse(Console.ReadLine());
    int y2 = int.Parse(Console.ReadLine());
    int x3 = int.Parse(Console.ReadLine());
    int y3 = int.Parse(Console.ReadLine());

    Diem d1 = new Diem(x1, y1);
    Diem d2 = new Diem(x2, y2);
    Diem d3 = new Diem(x3, y3);
    TamGiac tamGiac = new TamGiac(d1, d2, d3);
    danhSachTamGiac.Add(tamGiac);
}

double tongChuVi = 0;
double tongDienTich = 0;

foreach (var tamGiac in danhSachTamGiac)
{
    tongChuVi += tamGiac.TinhChuVi();
    tongDienTich += tamGiac.TinhDienTich();
}

Console.WriteLine($"Tổng chu vi: {tongChuVi}");
Console.WriteLine($"Tổng diện tích: {tongDienTich}");