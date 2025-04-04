using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai9
{
    internal class KhachHang
    {
        private string hoTen;
        private string soNha;
        private string maCongToDien;

        public KhachHang() { }
        public KhachHang(string hoTen, string soNha, string maCongToDien)
        {
            this.hoTen = hoTen;
            this.soNha = soNha;
            this.maCongToDien = maCongToDien;
        }
        public string HoTen
        {
            get { return hoTen; }
            set { hoTen = value; }
        }
        public string SoNha
        {
            get { return soNha; }
            set { soNha = value; }
        }
        public string MaCongToDien
        {
            get { return maCongToDien; }
            set { maCongToDien = value; }
        }
        public void Nhap()
        {
            Console.Write("Nhap ho ten: ");
            hoTen = Console.ReadLine();
            Console.Write("Nhap so nha: ");
            soNha = Console.ReadLine();
            Console.Write("Nhap ma cong to dien: ");
            maCongToDien = Console.ReadLine();
        }
        public void Xuat()
        {
            Console.WriteLine("Ho ten: " + hoTen);
            Console.WriteLine("So nha: " + soNha);
            Console.WriteLine("Ma cong to dien: " + maCongToDien);
        }
    }
}
