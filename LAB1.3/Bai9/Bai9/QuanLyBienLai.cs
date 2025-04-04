using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai9
{
    internal class QuanLyBienLai
    {
       List<BienLai> dsBienLai = new List<BienLai>();
        public void Nhap()
        {
            Console.Write("Nhap so luong bien lai: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                BienLai bl = new BienLai();
                bl.Nhap();
                dsBienLai.Add(bl);
            }
        }

        public void TinhTienDien()
        {
            Console.WriteLine("Nhap ma cong to dien muon tinh: ");
            string maCongTo = Console.ReadLine();

            foreach (var bl in dsBienLai)
            {
                if (bl.ThongTin.MaCongToDien == maCongTo)
                {
                    if (bl.SoDienMoi - bl.SoDienCu < 50)
                    {
                        bl.SoTienPhaiTra = (bl.SoDienMoi - bl.SoDienCu) * 1250;
                        Console.WriteLine("So tien phai tra: " + bl.SoTienPhaiTra);
                    }
                    else if (bl.SoDienMoi - bl.SoDienCu >= 50 && bl.SoDienMoi - bl.SoDienCu < 100)
                    {
                        bl.SoTienPhaiTra = (bl.SoDienMoi - bl.SoDienCu) * 1500;
                        Console.WriteLine("So tien phai tra: " + bl.SoTienPhaiTra);
                    }
                    else if (bl.SoDienMoi - bl.SoDienCu >= 100)
                    {
                        bl.SoTienPhaiTra = (bl.SoDienMoi - bl.SoDienCu) * 2000;
                        Console.WriteLine("So tien phai tra: " + bl.SoTienPhaiTra);
                    }
                    else
                    {
                        Console.WriteLine("So dien moi phai lon hon so dien cu");
                    }
                }
                else
                {
                    Console.WriteLine("Khong tim thay ma cong to dien");


                }
            }
        }
        public void Xuat()
        {
            foreach (var bl in dsBienLai)
            {
                bl.Xuat();
            }
        }


    }
}
