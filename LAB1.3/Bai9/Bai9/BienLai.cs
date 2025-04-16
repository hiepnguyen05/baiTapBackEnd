using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai9
{
    internal class BienLai
    {
        private double soDienCu;
        private double soDienMoi;
        private double soTienPhaiTra;
        private KhachHang thongTin;
        public BienLai() { }
        public BienLai(double soDienCu, double soDienMoi, double soTienPhaiTra, KhachHang thongTin)
        {
            this.soDienCu = soDienCu;
            this.soDienMoi = soDienMoi;
            this.soTienPhaiTra = soTienPhaiTra;
            this.thongTin = thongTin;
        }
        public double SoDienCu
        {
            get { return soDienCu; }
            set { soDienCu = value; }
        }
        public double SoDienMoi
        {
            get { return soDienMoi; }
            set { soDienMoi = value; }
        }
        public double SoTienPhaiTra
        {
            get { return soTienPhaiTra; }
            set { soTienPhaiTra = value; }
        }
        public KhachHang ThongTin
        {
            get { return thongTin; }
            set { thongTin = value; }
        }
        public void Nhap()
        {
            Console.Write("Nhap so dien cu: ");
            soDienCu = double.Parse(Console.ReadLine());
            Console.Write("Nhap so dien moi: ");
            soDienMoi = double.Parse(Console.ReadLine());
            //Console.Write("Nhap so tien phai tra: ");
            //soTienPhaiTra = double.Parse(Console.ReadLine());
            thongTin = new KhachHang();
            thongTin.Nhap();
        }
        public void Xuat()
        {
            Console.WriteLine("-------------Thong tin khach hang------------ ");
            Console.WriteLine("So dien cu: " + soDienCu);
            Console.WriteLine("So dien moi: " + soDienMoi);
            Console.WriteLine("So tien phai tra: " + soTienPhaiTra);
            thongTin.Xuat();
            Console.WriteLine("--------------------------------------------- ");
        }

    }
}
