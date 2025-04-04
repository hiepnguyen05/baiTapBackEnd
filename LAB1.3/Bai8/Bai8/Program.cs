using Bai8;

class Program
{
    static void Main(string[] args)
    {
        QuanLyThuVien quanLyThuVien = new QuanLyThuVien();

        while (true) 
        {
            Console.WriteLine("----------Quan ly muon tra sach-----------");
            Console.WriteLine("1. Nhap danh sach the muon");
            Console.WriteLine("2. Xuat danh sach the muon");
            Console.WriteLine("3. Danh sach sinh vien den han tra sach");
            Console.WriteLine("4. Tim kiem sinh vien theo ma");
            Console.WriteLine("5. Thoat");
            Console.WriteLine("------------------------------------------");
            Console.Write("Chon chuc nang: ");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    quanLyThuVien.Nhap();
                    break;
                case 2:
                    quanLyThuVien.Xuat();
                    break;
                case 3:
                    quanLyThuVien.SinhVienDenHan();
                    break;
                case 4:
                    quanLyThuVien.TimKiem();
                    break;
                case 5:
                    return;
                default:
                    Console.WriteLine("Chuc nang khong hop le!");
                    break;
            }
        }

    }
}