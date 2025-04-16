using Bai10;

class Program
{
    static void Main(string[] args)
    {
        XuLyXauKiTu xuly = new XuLyXauKiTu();
        while (true)
        {
            Console.WriteLine("1. Nhap xau ki tu");
            Console.WriteLine("2. Dem so ky tu 'h'");
            Console.WriteLine("3. Dem so tu");
            Console.WriteLine("4. Chuan hoa xau ky tu");
            Console.WriteLine("5. Xuat danh sach xau ki tu");
            Console.WriteLine("6. Thoat");
            Console.Write("Chon chuc nang: ");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    xuly.Nhap();
                    break;
                case 2:
                    xuly.DemSoKyTu_H_();
                    break;
                case 3:
                    xuly.DemTu();
                    break;
                case 5:
                    xuly.Xuat();
                    break;

                case 4:
                    xuly.ChuanHoaXau();
                    Console.WriteLine("Da chuan hoa xau ki tu!");
                    break;
                case 6:
                    return;
                default:
                    Console.WriteLine("Chuc nang khong hop le!");
                    break;
            }

        }
    }
}