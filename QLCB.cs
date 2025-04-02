using System;
using System.Collections.Generic;

namespace Bai1Lab1._3
{
    internal class QLCB
    {
        static void Main()
        {
            List<CanBo> danhSachCanBo = new List<CanBo>();

            while (true) 
            {
                Console.WriteLine("------Quan ly can bo-------");
                Console.WriteLine("1/ Nhap thong tin can bo");
                Console.WriteLine("2/ Tim kiem theo ho ten");
                Console.WriteLine("3/ Hien thi danh sach can bo");
                Console.WriteLine("4/ Thoat");
                Console.WriteLine("---------------------------");
                Console.Write("Nhap lua chon: ");

                int luaChon;
                if (!int.TryParse(Console.ReadLine(), out luaChon))
                {
                    Console.WriteLine("Vui long nhap so hop le!");
                    continue;
                }

                switch (luaChon)
                {
                    case 1:
                        while (true) 
                        {
                            Console.WriteLine("Lua chon can bo ");
                            Console.WriteLine("1. Cong nhan");
                            Console.WriteLine("2. Ky su");
                            Console.WriteLine("3. Nhan vien");
                            Console.WriteLine("0. Quay lai menu chinh");

                            int luaChonCanBo;
                            if (!int.TryParse(Console.ReadLine(), out luaChonCanBo))
                            {
                                Console.WriteLine("Vui long nhap so hop le!");
                                continue;
                            }

                            if (luaChonCanBo == 0) break; 

                            CanBo canBo = null;
                            switch (luaChonCanBo)
                            {
                                case 1:
                                    canBo = new CongNhan();
                                    break;
                                case 2:
                                    canBo = new KySu();
                                    break;
                                case 3:
                                    canBo = new NhanVien();
                                    break;
                                default:
                                    Console.WriteLine("Lua chon khong hop le. Moi ban nhap lai!");
                                    continue;
                            }

                            canBo.Nhap();
                            danhSachCanBo.Add(canBo);
                            Console.WriteLine("Da them can bo thanh cong!");
                        }
                        break;

                    case 2:

                        Console.Write("Nhap ho ten can bo can tim ");
                        string hoTenCanTim = Console.ReadLine();
                        bool timThay = false;
                        foreach (var canBo in danhSachCanBo)
                        {
                            if (canBo.HoTen.Equals(hoTenCanTim, StringComparison.OrdinalIgnoreCase))  
                            {
                                Console.WriteLine("Da tim thay can bo : ");
                                canBo.Xuat();  
                                timThay = true;
                                break;  
                            }
                        }
                        if (!timThay)
                        {
                            Console.WriteLine("Khong tim thay can bo");
                        }
                        break; 
                    case 3:
                        Console.WriteLine("Danh sach can bo:");
                        foreach (var canBo in danhSachCanBo)
                        {
                            canBo.Xuat();
                        }
                        break;

                    case 4:
                        Console.WriteLine("Thoat chuong trinh!");
                        return; 

                    default:
                        Console.WriteLine("Lua chon khong hop le. Moi nhap lai!");
                        break;
                }
            }
        }
    }
}
