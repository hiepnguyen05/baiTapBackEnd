using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai12
{
    internal class MaTran
    {
        private int dong { get; set; }
        private int cot { get; set; }

        private int[,] a { get; set; }

        //Hàm tạo không tham số
        public MaTran()
        {
            dong = 0;
            cot = 0;
            a = new int[1, 1];
        }
        //Hàm tạo có tham số
        public MaTran(int n, int m)
        {
            dong = n;
            cot = m;
            a = new int[n, m];
        }

        //Phương thức nhập ma trận
        public void Nhap()
        {
            Console.WriteLine("Nhập số dòng của ma trận: ");
            dong = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập số cột của ma trận: ");
            cot = int.Parse(Console.ReadLine());
            a = new int[dong, cot];
            for (int i = 0; i < dong; i++)
            {
                for (int j = 0; j < cot; j++)
                {
                    Console.Write($"Nhập phần tử a[{i},{j}]: ");
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }
        //Phương thức xuất ma trận
        public void Xuat()
        {
            Console.WriteLine("Ma trận vừa nhập là: ");
            for (int i = 0; i < dong; i++)
            {
                for (int j = 0; j < cot; j++)
                {
                    Console.Write(a[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        //Phương thức cộng 2 ma trận
        public MaTran Tong(MaTran b)
        {
            if (dong != b.dong || cot != b.cot)
            {
                Console.WriteLine("Hai ma trận không cùng kích thước, không thể cộng!");
                return null;
            }
            MaTran c = new MaTran(dong, cot);
            for (int i = 0; i < dong; i++)
            {
                for (int j = 0; j < cot; j++)
                {
                    c.a[i, j] = a[i, j] + b.a[i, j];
                }
            }
            return c;
        }
        //Phương thức nhân 2 ma trận
        public MaTran Tich(MaTran b)
        {
            if (cot != b.dong)
            {
                Console.WriteLine("Hai ma trận không thể nhân với nhau!");
                return null;
            }
            MaTran c = new MaTran(dong, b.cot);
            for (int i = 0; i < dong; i++)
            {
                for (int j = 0; j < b.cot; j++)
                {
                    c.a[i, j] = 0;
                    for (int k = 0; k < cot; k++)
                    {
                        c.a[i, j] += a[i, k] * b.a[k, j];
                    }
                }
            }
            return c;
        }
        //Phương thức hiệu 2 ma trân
        public MaTran Hieu(MaTran b)
        {
            if (dong != b.dong || cot != b.cot)
            {
                Console.WriteLine("Hai ma trận không cùng kích thước, không thể trừ!");
                return null;
            }
            MaTran c = new MaTran(dong, cot);
            for (int i = 0; i < dong; i++)
            {
                for (int j = 0; j < cot; j++)
                {
                    c.a[i, j] = a[i, j] - b.a[i, j];
                }
            }
            return c;
        }
        //Phương thức tính thương của hai ma trận
        public MaTran Thuong(MaTran b)
        {
            if (dong != b.dong || cot != b.cot)
            {
                Console.WriteLine("Hai ma trận không cùng kích thước, không thể chia!");
                return null;
            }
            MaTran c = new MaTran(dong, cot);
            for (int i = 0; i < dong; i++)
            {
                for (int j = 0; j < cot; j++)
                {
                    c.a[i, j] = a[i, j] / b.a[i, j];
                }
            }
            return c;
        }
    }
}
