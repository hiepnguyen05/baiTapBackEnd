using bai15;
Console.OutputEncoding = System.Text.Encoding.UTF8;

while (true)
{
    Console.WriteLine("Nhập cạnh của đa giác:");
    DaGiac daGiac = new DaGiac();
    daGiac.Nhap();
    Console.Write("Nhập lựa chọn của bạn:\n" +
        "1: Tính chu vi.\n" +
        "2: In ra giá trị các cạnh của đa giác.\n" +
        "3: Thoát\n" +
        "Bạn lựa chọn: ");
    int luaChon = int.Parse(Console.ReadLine());
    switch (luaChon)
    {
        case 1:
            Console.WriteLine($"Chu vi của đa giác là: {daGiac.TinhChuVi()}");
            break;
        case 2:
            daGiac.Xuat();
            break;
        default:
            Console.WriteLine("Lựa chọn không hợp lệ.");
            break;
    }
}