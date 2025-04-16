using Bai9;

class Program
{
    static void Main(string[] args)
    {
        QuanLyBienLai ql = new QuanLyBienLai();
        while (true) 
        {
            Console.WriteLine("-------------Menu-------------");
            Console.WriteLine("1. Nhap thong tin khach hang");
            Console.WriteLine("2. Tinh tien dien");
            Console.WriteLine("3. Xuat thong tin khach hang");
            Console.WriteLine("4. Thoat");
            Console.WriteLine("------------------------------");
            Console.Write("Chon chuc nang: ");
            int chucNang = int.Parse(Console.ReadLine());
            switch (chucNang)
            {
                case 1:
                    ql.Nhap();
                    break;
                case 2:
                    ql.TinhTienDien();
                    break;
                case 3:
                    ql.Xuat();
                    break;
                case 4:
                    return;
                default:
                    Console.WriteLine("Chuc nang khong hop le");
                    break;
            }
        }
    }
}
