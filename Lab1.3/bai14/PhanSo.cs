using System;

namespace bai14
{
    internal class PhanSo
    {
        internal int tuSo;
        internal int mauSo;

        // Hàm tạo không tham số và có tham số
        public PhanSo()
        {
            tuSo = 0;
            mauSo = 1; // Đặt mẫu số mặc định là 1 để tránh chia cho 0
        }

        public PhanSo(int tu, int mau)
        {
            if (mau == 0) throw new ArgumentException("Mẫu số không thể là 0.");
            tuSo = tu;
            mauSo = mau;
        }

        // Phương thức nhập, xuất
        public void Nhap()
        {
            Console.Write("Nhập tử số: ");
            tuSo = int.Parse(Console.ReadLine());
            Console.Write("Nhập mẫu số: ");
            mauSo = int.Parse(Console.ReadLine());
            if (mauSo == 0) throw new ArgumentException("Mẫu số không thể là 0.");
        }

        public void Xuat()
        {
            Console.WriteLine("Phân số là: {0}/{1}", tuSo, mauSo);
        }

        // Rút gọn phân số
        private int UCLN(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return Math.Abs(a);
        }

        public PhanSo RutGon()
        {
            int ucln = UCLN(tuSo, mauSo);
            return new PhanSo(tuSo / ucln, mauSo / ucln);
        }

        // Cộng 2 phân số
        public PhanSo Cong(PhanSo ps)
        {
            PhanSo kq = new PhanSo();
            kq.tuSo = this.tuSo * ps.mauSo + ps.tuSo * this.mauSo; // Sửa thành cộng
            kq.mauSo = this.mauSo * ps.mauSo;
            return kq.RutGon(); // Rút gọn trước khi trả về
        }

        // Trừ 2 phân số
        public PhanSo Tru(PhanSo ps)
        {
            PhanSo kq = new PhanSo();
            if (this.mauSo == ps.mauSo)
            {
                kq.tuSo = this.tuSo - ps.tuSo;
                kq.mauSo = this.mauSo;
            }
            else
            {
                kq.tuSo = this.tuSo * ps.mauSo - ps.tuSo * this.mauSo;
                kq.mauSo = this.mauSo * ps.mauSo;
            }
            return kq.RutGon(); // Rút gọn trước khi trả về
        }

        // Chia hai phân số
        public PhanSo Chia(PhanSo ps)
        {
            if (ps.tuSo == 0) throw new DivideByZeroException("Không thể chia cho phân số có tử số bằng 0.");
            PhanSo kq = new PhanSo();
            kq.tuSo = this.tuSo * ps.mauSo;
            kq.mauSo = this.mauSo * ps.tuSo;
            return kq.RutGon(); // Rút gọn trước khi trả về
        }
    }
}