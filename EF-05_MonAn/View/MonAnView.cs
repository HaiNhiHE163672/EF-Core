using EF_05_MonAn.Controllers;
using EF_05_MonAn.Helper;
using EF_05_MonAn.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_05_MonAn.View
{
    class MonAnView
    {
        public void menu()
        {
            Console.WriteLine("======================================================");
            Console.WriteLine("1. Them mot mon an");
            Console.WriteLine("2. Them cac cong thuc cho mot mon an");
            Console.WriteLine("3. Xoa mot loai mon an");
            Console.WriteLine("4. Tim Kiem mon an theo ten va nguyen lieu che bien mon");
            Console.WriteLine("0. Thoat chuong trinh");
        }
        public void ThucThi()
        {
            while (true)
            {
                MonAnController monAn = new MonAnController();
                CongthucController congthuc = new CongthucController();
                LoaiMonAnCotroller loaiMonAn = new LoaiMonAnCotroller();
                MonAn mon = new MonAn();
                
                menu();
                Console.Write("Nhap lua chon: ");
                switch(int.Parse(Console.ReadLine()))
                {
                    case 0:
                        return;
                    case 1:
                        mon.Nhap();
                        Console.WriteLine(monAn.ThemMonAn(mon));
                        break;
                    case 2:
                        Console.Write("Nhap so luong cong thuc can them: ");
                        int n = int.Parse(Console.ReadLine());
                        Console.Write("Nhap ID mon an can them cong thuc: ");
                        int id = int.Parse(Console.ReadLine());
                        List<CongThuc> congThucs = new List<CongThuc>(n);
                        for(int i = 0; i < n; i++)
                        {
                            CongThuc cong = new CongThuc();
                            cong.Nhap();
                            cong.MonanID = id;
                            Console.WriteLine(congthuc.ThemCongThuc(cong, id));
                        }
                        break;
                    case 3:
                        InputHelper h = new InputHelper();
                        id = h.So("loai mon an can xoa");
                        Console.WriteLine(loaiMonAn.XoaLoaiMonAn(id));
                        break;
                    case 4:
                        Console.WriteLine("Nhap ten hoac nguyen lieu can tim: ");
                        string s = Console.ReadLine();
                        monAn.TimKiemMonAn(s);
                        break;
                    default:
                        Console.WriteLine("Nhap lua chon tu 1-4 va 0 de thoat chuong trinh");
                        break;
                }
            }
        }
    }
}
