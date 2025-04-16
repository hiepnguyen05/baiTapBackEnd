using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai21
{
    public class HocSinh
    {
        public string HoTen { get; set; }
        public string GioiTinh { get; set; }
        public float DiemToan { get; set; }
        public float DiemLy { get; set; }
        public float DiemHoa { get; set; }
        public float DiemKiThuat { get; set; } 
        public float DiemNuCong { get; set; } 

        public float TongDiem()
        {
            return DiemToan + DiemLy + DiemHoa + (GioiTinh == "Nam" ? DiemKiThuat : DiemNuCong);
        }

        public void In()
        {
            Console.WriteLine($"Họ tên: {HoTen}, Giới tính: {GioiTinh}, Tổng điểm: {TongDiem()}");
        }
    }
}
