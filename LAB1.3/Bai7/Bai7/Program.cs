using Bai7;

class Program
{
    static void Main(string[] args)
    {
        QuanLyCanBo quanLyCanBo = new QuanLyCanBo();
        while (true)
        {
            Console.WriteLine("---------------Quan ly luon can bo--------------");
            Console.WriteLine("1. Nhap danh sach can bo");
            Console.WriteLine("2. Tim kiem can bo theo que quan");
            Console.WriteLine("3. Danh sach can bo co luong thuc lanh tren 5 trieu");
            Console.WriteLine("4. Xuat danh sach can bo");
            Console.WriteLine("5. Thoat");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Nhap lua chon: ");
            int choice = int.Parse(Console.ReadLine());
            switch(choice)
            {
                case 1:
                    quanLyCanBo.NhapDanhSach();
                    break;
                case 2:
                    quanLyCanBo.TimKiemCanBo();
                    break;
                case 3:
                    quanLyCanBo.CanBoCoLuongTren1Jack();
                    break;
                case 4:
                    quanLyCanBo.XuatDanhSach();
                    break;
                case 5:
                    Console.WriteLine("Thoat chuong trinh");
                    return;
                default:
                    Console.WriteLine("Lua chon khong hop le. Vui long chon lai.");
                    break;
            }
        }
    }
}