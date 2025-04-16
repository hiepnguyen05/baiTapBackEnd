using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace bai18
{

    internal class CoQuan : Nguoi
    {
        internal string donViCongTac { get; set; }

        internal double heSoLuong { get; set; }

        // Contructor có tham số
        public CoQuan(string ht, int t, bool gt, string dvct, double hsl) : base(ht, t, gt)
        {
            this.donViCongTac = dvct;
            this.heSoLuong = hsl;

        }


        // Ghi đè phương thức in
        public override void In()
        {
            base.In();
            Console.WriteLine($"Đơn vị công tác: {donViCongTac}, Hệ số lương: {heSoLuong}");
        }

        // Tính lương
        public double TinhLuong()
        {
            const double luongCoBan = 1050000; // Lương cơ bản
            return heSoLuong * luongCoBan;
        }

    }
}
