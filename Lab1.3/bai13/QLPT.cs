using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace bai13
{
    internal class QLPT
    {
        private List<PhuongTien> dsPhuongTien = new List<PhuongTien>();

        //Phương thức đăng kí phương tiện
        public void DangKiPhuongTien()
        {
            Console.WriteLine("Nhập loại phương tiện (1: Xe máy, 2: Ô tô, 3: Xe tải): ");
            int loaiPT = int.Parse(Console.ReadLine());
            PhuongTien pt = null;
            switch (loaiPT)
            {
                case 1:
                    pt = new XeMay();
                    break;
                case 2:
                    pt = new Oto();
                    break;
                case 3:
                    pt = new XeTai();
                    break;
                default:
                    Console.WriteLine("Loại phương tiện không hợp lệ.");
                    return;
            }
            pt.Nhap();
            dsPhuongTien.Add(pt);
        }

        //Tìm kiếm phương tiện theo màu hoặc năm sản xuất
        public void TimKiemPhuongTien()
        {
            Console.WriteLine("Nhập màu xe hoặc năm sản xuất để tìm kiếm: ");
            string tuKhoa = Console.ReadLine();
            var ketQua = dsPhuongTien.Where(pt => pt.mauXe.Contains(tuKhoa) || pt.namSanXuat.Contains(tuKhoa)).ToList();
            if (ketQua.Count > 0)
            {
                Console.WriteLine("Kết quả tìm kiếm:");
                foreach (var pt in ketQua)
                {
                    pt.Xuat();
                }
            }
            else
            {
                Console.WriteLine("Không tìm thấy phương tiện nào.");
            }
        }

    }
}
