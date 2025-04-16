using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai8
{
    internal class TheMuon
    {
        private int soMuon;
        private DateOnly  ngayMuon;
        private DateOnly hanTra;
        private string soHieuSach;
        private SinhVien thongTin;


        public TheMuon() { }
        public TheMuon(int soMuon, DateOnly ngayMuon, DateOnly hanTra, string soHieuSach, SinhVien thongTin)
        {
            this.soMuon = soMuon;
            this.ngayMuon = ngayMuon;
            this.hanTra = hanTra;
            this.soHieuSach = soHieuSach;
            this.thongTin = thongTin;
        }
        public int SoMuon
        {
            get { return soMuon; }
            set { soMuon = value; }
        }
        public DateOnly NgayMuon
        {
            get { return ngayMuon; }
            set { ngayMuon = value; }
        }
        public DateOnly HanTra
        {
            get { return hanTra; }
            set { hanTra = value; }
        }

        public string SoHieuSach
        {
            get { return soHieuSach; }
            set { soHieuSach = value; }
        }
        public SinhVien ThongTin
        {
            get { return thongTin; }
            set { thongTin = value; }
        }
        public void Nhap()
        {
            try
            {
                Console.Write("Nhap so muon: ");
                soMuon = int.Parse(Console.ReadLine());
                Console.Write("Nhap ngay muon (yyyy-mm-dd): ");
                ngayMuon = DateOnly.Parse(Console.ReadLine());
                Console.Write("Nhap han tra (yyyy-mm-dd): ");
                hanTra = DateOnly.Parse(Console.ReadLine());
                Console.Write("Nhap so hieu sach: ");
                soHieuSach = Console.ReadLine();
                thongTin = new SinhVien();
                thongTin.Nhap();
            }
            catch (FormatException)
            {
                Console.WriteLine("Nhap sai dinh dang, vui long nhap lai!");
                Nhap();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Loi: {ex.Message}");
            }
        }
        public void Xuat()
        {
            Console.WriteLine("----------Thong tin the muon-----------");
            Console.WriteLine($"So muon: {soMuon}");
            Console.WriteLine($"Ngay muon: {ngayMuon}");
            Console.WriteLine($"Han tra: {hanTra}");
            Console.WriteLine($"So hieu sach: {soHieuSach}");
            Console.WriteLine("Thong tin sinh vien:");
            thongTin.Xuat();
            Console.WriteLine("---------------------------------------");
        }


    }
}
