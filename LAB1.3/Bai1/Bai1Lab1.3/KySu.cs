using Bai1Lab1._3;

internal class KySu : CanBo
{
    private string? nganhDaoTao;

    public KySu() : base() { }

    public KySu(string hoTen, int namSinh, string gioiTinh, string diaChi, string nganhDaoTao)
        : base(hoTen, namSinh, gioiTinh, diaChi)
    {
        this.nganhDaoTao = nganhDaoTao;
    }

    public override void Nhap()
    {
        base.Nhap();
        Console.Write("Nhập ngành đào tạo: ");
        nganhDaoTao = Console.ReadLine();
    }

    public override void Xuat()
    {
        base.Xuat();
        Console.WriteLine($"Ngành đào tạo: {nganhDaoTao}");
    }
}
