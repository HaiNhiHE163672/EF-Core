using EFC_01_QuanLyTrungTam.Controller;
using EFC_01_QuanLyTrungTam.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFC_01_QuanLyTrungTam.View
{
    class HocVienView
    {
        public void menu()
        {
            Console.WriteLine("======================================================");
            Console.WriteLine("1. Hiển thị danh sách học viên theo thứ tự ngày đăng ký mới nhất từ trên xuống dưới");
            Console.WriteLine("2. Hiển thị danh sách những học viên sinh năm 2002 và có tên chứa \"An\"");
            Console.WriteLine("3. Thêm mới 1 học viên");
            Console.WriteLine("4. Cập nhật thông tin học viên");
            Console.WriteLine("5. Xóa học viên");
        }
        public void ThucThi()
        {
            
            while (true)
            {
                HocVienController hv = new HocVienController();
                HocVien hocVien = new HocVien();
                List<HocVien> hocViens = new List<HocVien>();
                menu();
                Console.Write("Nhap lua chon: ");
                switch(int.Parse(Console.ReadLine()))
                {
                    case 0:
                        return;
                    case 1:
                        hv.DanhSachHocVienTheoNgay(hocViens);
                        break;
                    case 2:
                        hv.DanhSachHocVienTheoTimKiem(hocViens);
                        break;
                    case 3:
                        hocVien.Nhap();
                        Console.WriteLine(hv.ThemHocVien(hocVien));
                        break;
                    case 4:
                        Console.Write("Nhap ID hoc vien can cap nhat: ");
                        hocVien.HocVienID = int.Parse(Console.ReadLine());
                        hocVien.Nhap();
                        Console.WriteLine(hv.CapNhatHocVien(hocVien));
                        break;
                    case 5:
                        Console.Write("Nhap ID hoc vien can xoa: ");
                        int id = int.Parse(Console.ReadLine());
                        Console.WriteLine(hv.XoaHocVien(id));
                        break;
                    default:
                        Console.WriteLine("Nhap lua chon tu 1-5 va 0 de thoat chuong trinh");
                        break;
                }

            }
        }
    }
}
