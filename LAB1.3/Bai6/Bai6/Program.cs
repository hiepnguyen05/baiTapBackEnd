using Bai6;

class Program
{
    static void Main(string[] args)
    {
        QuanLyHoSo ql = new QuanLyHoSo();

        while (true)
        {
            Console.WriteLine("----------------Quan ly ho so ----------------");
            Console.WriteLine("1. Nhap danh sach ho so");
            Console.WriteLine("2. Xuat danh sach hoc sinh nu sinh nam 1985");
            Console.WriteLine("3. Tim kiem theo que quan");
            Console.WriteLine("4. Thoat");
            Console.WriteLine("----------------------------------------------");
            Console.Write("Chon chuc nang: ");
            int chucNang = int.Parse(Console.ReadLine());
            switch (chucNang)
            {
                case 1:
                    ql.NhapDanhSach();
                    break;
                case 2:
                    ql.XuatDanhSachHocSinhNuSinhNam1985();
                    break;
                case 3:
                    Console.Write("Nhap que quan: ");
                    string queQuan = Console.ReadLine();
                    ql.TimKiemTheoQueQuan(queQuan);
                    break;
                case 4:
                    return;
                default:
                    Console.WriteLine("Chuc nang khong hop le!");
                    break;
            }
        }
    }
}
