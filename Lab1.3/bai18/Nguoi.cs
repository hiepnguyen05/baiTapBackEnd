using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai18
{
    internal class Nguoi
    {
        internal string HoTen { get; set; }
        internal int Tuoi { get; set; }
        internal bool gioiTinh { get; set; }

        //Contructor có tham số, không tham số
        public Nguoi()
        {
            HoTen = "";
            Tuoi = 0;
            gioiTinh = false;
        }
        public Nguoi(string ht, int t, bool gt)
        {
            this.HoTen = ht;
            this.Tuoi = t;
            this.gioiTinh = gt;
        }
        public virtual void  In()
        {
            Console.WriteLine($"Họ tên: {HoTen}");
            Console.WriteLine($"Tuổi: {Tuoi}");
            Console.WriteLine($"Giới tính: {gioiTinh}");
        }
    }
}
