using bai14;
Console.OutputEncoding = System.Text.Encoding.UTF8;

while (true)
{
    Console.WriteLine("Nhập phân số ban đầu: ");
    PhanSo ps1 = new PhanSo();
    ps1.Nhap();
    Console.WriteLine("Nhập lưa chọn của bạn:\n1: Hiện thị phân số\n2: Rút gọn phân số" +
        "\n3: Cộng hai phân số\n4: Trừ hai phân số\n5: Chia hai phân số\n6: Thoát");
    int luaChon = int.Parse(Console.ReadLine());
    switch(luaChon)
    {
        case 1:
            ps1.Xuat();
            break;
        case 2:
            PhanSo psRutGon = ps1.RutGon();
            Console.WriteLine("Phân số sau khi rút gọn là: {0}/{1}", psRutGon.tuSo, psRutGon.mauSo);
            break;
        case 3:
            Console.WriteLine("Nhập phân số thứ hai: ");
            PhanSo ps2 = new PhanSo();
            ps2.Nhap();
            PhanSo kqCong = ps1.Cong(ps2);
            Console.WriteLine("Kết quả cộng hai phân số là: {0}/{1}", kqCong.tuSo, kqCong.mauSo);
            break;
        case 4:
            Console.WriteLine("Nhập phân số thứ hai: ");
            PhanSo ps3 = new PhanSo();
            ps3.Nhap();
            PhanSo kqTru = ps1.Tru(ps3);
            Console.WriteLine("Kết quả trừ hai phân số là: {0}/{1}", kqTru.tuSo, kqTru.mauSo);
            break;
        case 5:
            Console.WriteLine("Nhập phân số thứ hai: ");
            PhanSo ps4 = new PhanSo();
            ps4.Nhap();
            PhanSo kqChia = ps1.Chia(ps4);
            Console.WriteLine("Kết quả chia hai phân số là: {0}/{1}", kqChia.tuSo, kqChia.mauSo);
            break;
        default:
            Console.WriteLine("Lựa chọn không hợp lệ.");
            break;
    }
}