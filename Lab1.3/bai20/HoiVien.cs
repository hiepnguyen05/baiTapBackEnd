using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai20
{
    public class HoiVien
    {
        public string HoTen { get; set; }
        public string DiaChi { get; set; }

        public virtual void In()
        {
            Console.WriteLine($"Họ tên: {HoTen}, Địa chỉ: {DiaChi}");
        }
    }

    public class HoiVienDaKetHon : HoiVien
    {
        public string HoTenVo { get; set; }
        public DateTime NgayCuoi { get; set; }

        public override void In()
        {
            base.In();
            Console.WriteLine($"Họ tên vợ: {HoTenVo}, Ngày cưới: {NgayCuoi.ToString("dd.MM.yyyy")}");
        }
    }

    public class HoiVienCoNguoiYeu : HoiVien
    {
        public string HoTenNguoiYeu { get; set; }
        public string SoDienThoai { get; set; }

        public override void In()
        {
            base.In();
            Console.WriteLine($"Họ tên người yêu: {HoTenNguoiYeu}, Số điện thoại: {SoDienThoai}");
        }
    }
}