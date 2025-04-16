using Bai17;
Console.OutputEncoding = System.Text.Encoding.UTF8;
List<HinhTron> danhSachHinhTron = new List<HinhTron>();
Console.Write("Nhập số lượng hình tròn: ");
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    Console.WriteLine($"Hình tròn thứ {i + 1}:");
    Console.Write("Nhập tọa độ tâm (x, y): ");
    int x = int.Parse(Console.ReadLine());
    int y = int.Parse(Console.ReadLine());
    Console.Write("Nhập bán kính: ");
    float banKinh = float.Parse(Console.ReadLine());

    Diem tam = new Diem(x, y);
    HinhTron hinhTron = new HinhTron(tam, banKinh);
    danhSachHinhTron.Add(hinhTron);
}

// Hiển thị thông tin hình tròn
foreach (var hinhTron in danhSachHinhTron)
{
    hinhTron.In();
}

// Tìm hình tròn giao với nhiều hình tròn khác nhất
HinhTron hinhTronGiaoNhieuNhat = TimHinhTronGiaoNhieuNhat(danhSachHinhTron);
if (hinhTronGiaoNhieuNhat != null)
{
    Console.WriteLine("Hình tròn giao với nhiều hình tròn khác nhất:");
    hinhTronGiaoNhieuNhat.In();
}

        static HinhTron TimHinhTronGiaoNhieuNhat(List<HinhTron> danhSach)
{
    int maxGiao = 0;
    HinhTron hinhTronGiaoNhieuNhat = null;

    for (int i = 0; i < danhSach.Count; i++)
    {
        int soGiao = 0;

        for (int j = 0; j < danhSach.Count; j++)
        {
            if (i != j && KiemTraGiao(danhSach[i], danhSach[j]))
            {
                soGiao++;
            }
        }

        if (soGiao > maxGiao)
        {
            maxGiao = soGiao;
            hinhTronGiaoNhieuNhat = danhSach[i];
        }
    }

    return hinhTronGiaoNhieuNhat;
}

static bool KiemTraGiao(HinhTron h1, HinhTron h2)
{
    double khoangCach = h1.Tam.KhoangCach(h2.Tam);
    return khoangCach < (h1.BanKinh + h2.BanKinh);
}