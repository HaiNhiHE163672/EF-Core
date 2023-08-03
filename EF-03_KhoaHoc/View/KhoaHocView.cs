using EF_03_KhoaHoc.Controller;
using EF_03_KhoaHoc.Helper;
using EF_03_KhoaHoc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_03_KhoaHoc.View
{
     class KhoaHocView
    {
        public void menu()
        {
            Console.WriteLine("====================================");
            Console.WriteLine("1. Them mot ngay hoc vao khoa hoc");
            Console.WriteLine("2. Sua thong tin cua mot hoc vien");
            Console.WriteLine("3. Xoa mot khoa hoc");
            Console.WriteLine("4. Tim kiem cac hoc vien the ten va khoa hoc");
            Console.WriteLine("5. Tinh doanh thu trong cac thang");
            Console.WriteLine("0. Thoat chuong trinh");
        }
        public void ThucThi()
        {
            
            while(true)
            {
                NgayHocController nh = new NgayHocController();
                KhoaHocController kh = new KhoaHocController();
                HocVienController hv = new HocVienController();
                menu();
                Console.Write("Nhap Lua chon: ");
                switch (int.Parse(Console.ReadLine()))
                {
                    case 1:
                        NgayHoc ngay = new NgayHoc();
                        ngay.Nhap();
                        Console.WriteLine(nh.ThemNgayHoc(ngay));
                        break;
                    case 2:
                        HocVien h = new HocVien();
                        Console.Write("Nhap ID hoc vien can sua: ");
                        h.HocVienID = int.Parse(Console.ReadLine());
                        h.Nhap();
                        Console.WriteLine(hv.SuaThongTin(h));
                        break;
                    case 3:
                        InputHelper ip = new InputHelper();
                        int id = ip.Id("Nhap ID can xoa");
                        Console.WriteLine(kh.XoaKhoaHoc(id));
                        break;
                    case 4:
                        Console.Write("Nhap Ho Ten Hoc Vien Hoac Ten Khoa Hoc ma Hoc Vien theo hoc: ");
                        string search = Console.ReadLine();
                        hv.TimKiem(search);
                        break;
                    case 5:
                        kh.DoanhThu();
                        break;
                    case 0:
                        return;
                    default:
                        Console.WriteLine("Vui long nhap tu 1-6 de thuc hien chuong trinh va 0 de thoat");
                        break;
                }
            }
            
        }
    }
}
