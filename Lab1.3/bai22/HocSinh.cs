using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai22
{
    public class HocSinh
    {
        public string HoTen { get; set; }
        public int NamSinh { get; set; }
        public float TongDiem { get; set; }

        public void In()
        {
            Console.WriteLine($"Họ tên: {HoTen.ToUpper()}, Năm sinh: {NamSinh}, Tổng điểm: {TongDiem}");
        }
    }
}
