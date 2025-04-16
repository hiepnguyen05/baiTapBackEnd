using bai18;
Console.OutputEncoding = System.Text.Encoding.UTF8;
List<CoQuan> danhSachCoQuan = new List<CoQuan>();
Console.Write("Nhập số lượng cá nhân: ");
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    Console.WriteLine($"Cá nhân thứ {i + 1}:");
    Console.Write("Nhập họ tên: ");
    string hoTen = Console.ReadLine();
    Console.Write("Nhập giới tính (1: Nam, 0: Nữ): ");
    bool gioiTinh = Console.ReadLine() == "1";
    Console.Write("Nhập tuổi: ");
    int tuoi = int.Parse(Console.ReadLine());
    Console.Write("Nhập đơn vị công tác: ");
    string donViCongTac = Console.ReadLine();
    Console.Write("Nhập hệ số lương: ");
    double heSoLuong = double.Parse(Console.ReadLine());

    CoQuan coQuan = new CoQuan(hoTen, tuoi, gioiTinh, donViCongTac, heSoLuong);
    danhSachCoQuan.Add(coQuan);
}

// Hiển thị thông tin cho cá nhân có đơn vị là Phòng tài chính
Console.WriteLine("\nThông tin cá nhân có đơn vị là Phòng tài chính:");
foreach (var coQuan in danhSachCoQuan)
{
    if (coQuan.donViCongTac.Equals("Phòng tài chính", StringComparison.OrdinalIgnoreCase))
    {
        coQuan.In();
    }
}

// Tìm kiếm thông tin theo họ tên
Console.Write("\nNhập họ tên để tìm kiếm: ");
string tenTimKiem = Console.ReadLine();
var ketQuaTimKiem = danhSachCoQuan.Where(c => c.HoTen.Contains(tenTimKiem, StringComparison.OrdinalIgnoreCase)).ToList();

if (ketQuaTimKiem.Count > 0)
{
    Console.WriteLine("\nKết quả tìm kiếm:");
    foreach (var coQuan in ketQuaTimKiem)
    {
        coQuan.In();
        Console.WriteLine($"Lương: {coQuan.TinhLuong()} VNĐ");
    }
}
else
{
    Console.WriteLine("Không tìm thấy cá nhân nào.");
}

Console.WriteLine("Thoát khỏi chương trình.");