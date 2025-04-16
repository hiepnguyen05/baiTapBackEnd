
using Bai5;

class Program
{
    static void Main(string[] args)
    {
       QuanLyKhachSan quanLyKhachSan = new QuanLyKhachSan();

        while (true) 
        {
            Console.WriteLine("-------Quan ly khach san--------");
            Console.WriteLine("1. Nhap danh sach phong muon theu");
            Console.WriteLine("2. Xuat danh sach khach san");
            Console.WriteLine("3. Tim khach san theo ho ten");
            Console.WriteLine("4. Tinh tien khi tra");
            Console.WriteLine("5. Thoat");
            Console.WriteLine("--------------------------------");
            Console.Write("Chon chuc nang: ");
            int chucNang = int.Parse(Console.ReadLine());
            switch (chucNang)
            {
                case 1:
                    quanLyKhachSan.NhapDanhSach();
                    break;
                case 2:
                    quanLyKhachSan.XuatDanhSach();
                    break;
                case 3:
                    Console.Write("Nhap ho ten khach san can tim: ");
                    string hoTen = Console.ReadLine();
                    quanLyKhachSan.TimKhachSanTheoHoTen(hoTen);
                    break;
                case 4:
                    quanLyKhachSan.TinhTienKhiTra();
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