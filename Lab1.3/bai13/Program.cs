using bai13;
Console.OutputEncoding = System.Text.Encoding.UTF8;

while (true)
{
    Console.WriteLine("Nhập lưa chọn của bạn (1: Đăng kí phương tiện, 2:Tìm kiếm phương tiện, 3:Thoát.)");
    int luaChon = int.Parse(Console.ReadLine());
    QLPT qlpt = new QLPT();
    switch (luaChon)
    {
        case 1:
            qlpt.DangKiPhuongTien();
            break;
        case 2:
            qlpt.TimKiemPhuongTien();
            break;
        case 3:
            Console.WriteLine("Thoát chương trình.");
            return;
        default:
            Console.WriteLine("Lựa chọn không hợp lệ.");
            break;
    }
}
