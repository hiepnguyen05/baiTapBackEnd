using System;

namespace Bai19
{
    public class HoTen
    {
        public string Ho { get; set; }
        public string TenDem { get; set; }
        public string Ten { get; set; }
    }

    public class QueQuan
    {
        public string Xa { get; set; }
        public string Huyen { get; set; }
        public string Tinh { get; set; }
    }

    public class DiemThi
    {
        public float Toan { get; set; }
        public float Ly { get; set; }
        public float Hoa { get; set; }
    }

    public class ThiSinh
    {
        public HoTen Ten { get; set; }
        public QueQuan Que { get; set; }
        public string Truong { get; set; }
        public int Tuoi { get; set; }
        public string SoBaoDanh { get; set; }
        public DiemThi Diem { get; set; }

        public float TongDiem()
        {
            return Diem.Toan + Diem.Ly + Diem.Hoa;
        }

        public void In()
        {
            Console.WriteLine($"Họ tên: {Ten.Ho} {Ten.TenDem} {Ten.Ten}");
            Console.WriteLine($"Quê quán: {Que.Xa}, {Que.Huyen}, {Que.Tinh}");
            Console.WriteLine($"Trường: {Truong}, Tuổi: {Tuoi}, Số báo danh: {SoBaoDanh}");
            Console.WriteLine($"Điểm thi: Toán: {Diem.Toan}, Lý: {Diem.Ly}, Hóa: {Diem.Hoa}");
            Console.WriteLine($"Tổng điểm: {TongDiem()}\n");
        }
    }
}