using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai17
{
    internal class HinhTron
    {
        internal Diem Tam { get; set; }
        internal float BanKinh { get; set; }

        // Toán tử tạo lập
        public HinhTron() { }

        public HinhTron(Diem d, float bk)
        {
            Tam = d;
            BanKinh = bk;
        }

        // Tính chu vi
        public double TinhChuVi()
        {
            return 2 * Math.PI * BanKinh;
        }

        // Tính diện tích
        public double TinhDienTich()
        {
            return Math.PI * BanKinh * BanKinh;
        }

        // Phương thức in thông tin hình tròn
        public void In()
        {
            Console.WriteLine($"Hình tròn: Tâm = ({Tam.hoanhDo}, {Tam.tungDo}), Bán kính = {BanKinh}, Chu vi = {TinhChuVi()}, Diện tích = {TinhDienTich()}");
        }
    }
}
