using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai10
{
    internal class XuLyXauKiTu
    {
        List<VanBan> list = new List<VanBan>();
        public void Nhap()
        {
            Console.WriteLine("Nhap so luong xau ki tu: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                VanBan vb = new VanBan();
                vb.Nhap();
                list.Add(vb);
            }
        }
      
        public void DemSoKyTu_H_()
        {
            int count = 0;
            Console.Write("So ky tu 'h' trong xau ki tu: ");
            foreach (var vb in list)
            {
                count = vb.XauKiTu.Count(c => c == 'h');
                Console.WriteLine(count);
            }

        }
        public void DemTu()
        {
            Console.WriteLine("So tu trong xau ki tu: ");
            foreach (var vb in list)
            {
                int count = vb.XauKiTu.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length;
                Console.WriteLine(count);
            }
        }
        public void Xuat()
        {
            Console.WriteLine("Danh sach xau ki tu: ");
            foreach (var vb in list)
            {
                vb.Xuat();
            }
        }

        public void ChuanHoaXau()
        {
            foreach (var vb in list)
            {
                vb.XauKiTu = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(vb.XauKiTu.ToLower());
            }
        }

    }
}
