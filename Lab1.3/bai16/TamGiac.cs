using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai16
{
    internal class TamGiac
    {
        internal Diem A { get; set; }
        internal Diem B { get; set; }
        internal Diem C { get; set; }
        public TamGiac()
        {
            A = new Diem();
            B = new Diem();
            C = new Diem();
        }
        public TamGiac(Diem a, Diem b, Diem c)
        {
            A = a;
            B = b;
            C = c;
        }
        // Phương thức nhập, xuất
        public void Nhap()
        {
            Console.WriteLine("Nhập tọa độ điểm A:");
            A.Nhap();
            Console.WriteLine("Nhập tọa độ điểm B:");
            B.Nhap();
            Console.WriteLine("Nhập tọa độ điểm C:");
            C.Nhap();
        }
        public void Xuat()
        {
            Console.WriteLine("Tam giác có các đỉnh:");
            A.Xuat();
            B.Xuat();
            C.Xuat();
        }
        // Tính chu vi
        public double TinhChuVi()
        {
            return A.KhoangCach(B) + B.KhoangCach(C) + C.KhoangCach(A);
        }
        //Tính diện tích
        public double TinhDienTich()
        {
            double a = A.KhoangCach(B);
            double b = B.KhoangCach(C);
            double c = C.KhoangCach(A);
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }
}
