using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai11
{
    internal class SoPhuc
    {
        public double thuc { get; set; }
        public double ao { get; set; }

        //hàm tạo không đối số
        public SoPhuc()
        {
            thuc = 0;
            ao = 0;
        }
        //hàm tạo có đối số
        public SoPhuc(double thuc, double ao)
        {
            this.thuc = thuc;
            this.ao = ao;
        }

        //hàm nhập số phức
        public void Nhap()
        {
            Console.Write("Nhập phần thực: ");
            thuc = double.Parse(Console.ReadLine());
            Console.Write("Nhập phần ảo: ");
            ao = double.Parse(Console.ReadLine());
        }
        //hàm xuất số phức
        public void Xuat()
        {
            if (ao >= 0)
            {
                Console.WriteLine("Số phức là: " + thuc + " + " + ao + "i");
            }
            else
            {
                Console.WriteLine("Số phức là: " + thuc + " - " + Math.Abs(ao) + "i");
            }
        }
        //hàm cộng hai số phức
        public SoPhuc Cong(SoPhuc sp)
        {
            SoPhuc kq = new SoPhuc();
            kq.thuc = this.thuc + sp.thuc;
            kq.ao = this.ao + sp.ao;
            return kq;
        }
        //Hàm hiệu hai số phức
        public SoPhuc Hieu(SoPhuc sp)
        {
            SoPhuc kq = new SoPhuc();
            kq.thuc = this.thuc - sp.thuc;
            kq.ao = this.ao - sp.ao;
            return kq;
        }
        //hàm nhân hai số phức
        public SoPhuc Nhan(SoPhuc sp)
        {
            SoPhuc kq = new SoPhuc();
            kq.thuc = this.thuc * sp.thuc - this.ao * sp.ao;
            kq.ao = this.thuc * sp.ao + this.ao * sp.thuc;
            return kq;
        }

        //hàm chia hai số phức
        public SoPhuc Chia(SoPhuc sp)
        {
            SoPhuc kq = new SoPhuc();
            double mau = sp.thuc * sp.thuc + sp.ao * sp.ao;
            kq.thuc = (this.thuc * sp.thuc + this.ao * sp.ao) / mau;
            kq.ao = (this.ao * sp.thuc - this.thuc * sp.ao) / mau;
            return kq;
        }
    }
}
