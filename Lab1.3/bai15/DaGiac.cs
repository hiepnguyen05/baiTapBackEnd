using System;

namespace bai15
{
    internal class DaGiac
    {
        internal int soCanh;
        internal int[] doDaiCanh;

        public DaGiac()
        {
            soCanh = 3; // Đặt mặc định là tam giác
            doDaiCanh = new int[soCanh];
        }

        public DaGiac(int soCanh)
        {
            if (soCanh < 3) throw new ArgumentException("Số cạnh phải lớn hơn hoặc bằng 3.");
            this.soCanh = soCanh;
            doDaiCanh = new int[soCanh];
        }

        // Phương thức nhập, xuất
        public void Nhap()
        {
            Console.Write("Nhập số cạnh của đa giác (>= 3): ");
            soCanh = int.Parse(Console.ReadLine());
            if (soCanh < 3) throw new ArgumentException("Số cạnh phải lớn hơn hoặc bằng 3.");
            doDaiCanh = new int[soCanh];
            for (int i = 0; i < soCanh; i++)
            {
                Console.Write($"Nhập độ dài cạnh thứ {i + 1}: ");
                doDaiCanh[i] = int.Parse(Console.ReadLine());
                if (doDaiCanh[i] <= 0) throw new ArgumentException("Độ dài cạnh phải lớn hơn 0.");
                
            }
        }

        public void Xuat()
        {
            Console.WriteLine($"Đa giác có {soCanh} cạnh với độ dài các cạnh là: ");
            for (int i = 0; i < soCanh; i++)
            {
                Console.Write($"{doDaiCanh[i]} ");
            }
            Console.WriteLine();
        }

        // Tính chu vi
        public int TinhChuVi()
        {
            int chuVi = 0;
            for (int i = 0; i < soCanh; i++)
            {
                chuVi += doDaiCanh[i];
            }
            return chuVi;
        }
    }
}