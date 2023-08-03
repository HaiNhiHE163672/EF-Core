using EFC_02_QuanLyCongThucNauAn.Controller;
using EFC_02_QuanLyCongThucNauAn.Helper;
using EFC_02_QuanLyCongThucNauAn.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFC_02_QuanLyCongThucNauAn.View
{
    class CongThucView
    {
        public void menu()
        {
            Console.WriteLine("================================================");
            Console.WriteLine("1. Hiển thị danh sách công thức nấu ăn");
            Console.WriteLine("2. Tìm kiếm những món ăn theo tên nguyên liệu \"Hành hoặc Tỏi\"");
            Console.WriteLine("3. Thêm mới món ăn kèm công thức nấu ăn");
            Console.WriteLine("0. Thoat chuong trinh");
        }
        public void ThucThi()
        {
            while (true)
            {
                MonAnController monAn = new MonAnController();
                InputHelper h = new InputHelper();
                menu();
                Console.Write("Nhap lua chon: ");
                switch(int.Parse(Console.ReadLine()))
                {
                    case 0:
                        return;
                    case 1:
                        monAn.DSCongthuc();
                        break;
                    case 2:
                        Console.Write("Nhap ten nguyen lieu co trong mon an: ");
                        string search = Console.ReadLine();
                        monAn.TimKiemDanhSachTheoNguyenLieuHanhToi(search);
                        break;
                    case 3:
                        MonAn mon = new MonAn();
                        mon.Nhap();
                        Console.WriteLine(monAn.ThemMonMoi(mon));
                        break;
                    default:
                        Console.WriteLine("Nhap tu 1-3 va 0 de thoat chuong trinh");
                        break;
                }
            }
        }
    }
}
