using Bai1Lab1._3;

internal class NhanVien : CanBo
{
    private string? congViec;

    public NhanVien() : base() { }

    public NhanVien(string hoTen, int namSinh, string gioiTinh, string diaChi, string congViec)
        : base(hoTen, namSinh, gioiTinh, diaChi)
    {
        this.congViec = congViec;
    }

    public override void Nhap()
    {
        base.Nhap();
        Console.Write("Nhập công việc: ");
        congViec = Console.ReadLine();
    }

    public override void Xuat()
    {
        base.Xuat();
        Console.WriteLine($"Công việc: {congViec}");
    }
}
