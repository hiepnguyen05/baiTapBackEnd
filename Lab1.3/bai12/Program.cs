using bai12;
Console.OutputEncoding = System.Text.Encoding.UTF8;

//Ma trận 1\
Console.WriteLine("Nhập ma trận 1: ");
MaTran mt1 = new MaTran();
mt1.Nhap();
mt1.Xuat();
//Ma trận 2
Console.WriteLine("Nhập ma trận 2: ");
MaTran mt2 = new MaTran();
mt2.Nhap();
mt2.Xuat();

Console.WriteLine("Nhập lựa phép tính (1:Tổng, 2:Tích, 3:Hiệu, 4:Thương) ");
int luachon = int.Parse(Console.ReadLine());

switch (luachon)
{
    case 1:
        {
            MaTran mt = new MaTran();
            mt = mt1.Tong(mt2);
            Console.WriteLine("Tổng của 2 ma trận là: ");
            mt.Xuat();
            break;
        }    
    case 2:
        {
            MaTran mt = new MaTran();
            mt = mt1.Tich(mt2);
            Console.WriteLine("Tích của 2 ma trận là: ");
            mt.Xuat();
            break;
        }    
    case 3:
        {
            MaTran mt = new MaTran();
            mt = mt1.Hieu(mt2);
            Console.WriteLine("Hiệu của 2 ma trận là: ");
            mt.Xuat();
            break;
        }   
    case 4:
        {
            MaTran mt = new MaTran();
            mt = mt1.Thuong(mt2);
            Console.WriteLine("Hiệu của 2 ma trận là: ");
            mt.Xuat();
            break;
        }
    default:
        {
            Console.WriteLine("Lựa chọn không hợp lệ");
            break;
        }
}
