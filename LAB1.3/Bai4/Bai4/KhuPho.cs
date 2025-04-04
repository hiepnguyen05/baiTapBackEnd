using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    internal class KhuPho
    {
        private int soThanhVien;
        private string soNha;
        private Nguoi thongTinCaNhan;

        List<Nguoi> listNguoi = new List<Nguoi>();

        public KhuPho()
        {
        }
        public KhuPho(int soThanhVien, string soNha)
        {
            this.soThanhVien = soThanhVien;
            this.soNha = soNha;
            //this.thongTinCaNhan = thongTinCaNhan;
        }

        public int SoThanhVien { get => soThanhVien; set => soThanhVien = value; }
        public string SoNha { get => soNha; set => soNha = value; }

        public void Nhap()
        {
            Console.WriteLine("Nhap so thanh vien: ");
            soThanhVien = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so nha: ");
            soNha = Console.ReadLine();
            Console.WriteLine("Nhap thong tin cua cac thanh vien: ");
            for (int i = 0; i < soThanhVien; i++)
            {
                Console.WriteLine($"Nhap thong tin nguoi thu {i+1}");
                Nguoi nguoi = new Nguoi();
                nguoi.Nhap();
                listNguoi.Add(nguoi);
                Console.WriteLine("--------Them thanh cong------");
            }
        }

        public void XuatThongHoDan()
        {
            Console.WriteLine("----------Thong tin ho dan----------");
            Console.WriteLine("So nha: " + soNha);
            Console.WriteLine("So thanh vien: " + soThanhVien);
            foreach (var nguoi in listNguoi)
            {
                nguoi.Xuat();
            }
            Console.WriteLine("------------------------------------");
        }

    }
}
