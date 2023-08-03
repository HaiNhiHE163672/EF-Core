using Lesion6.Models;
using Lesion6.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesion6.View
{
     class HocSinhView
    {
        public void menu()
        {
            Console.WriteLine("1. Them mot hoc sinh vao lop");
            Console.WriteLine("2. Sua thong tin cua mot hoc sinh");
            Console.WriteLine("3. Xoa mot hoc sinh");
            Console.WriteLine("4. Chuyen lop cho hoc sinh sang lop moi");
            Console.WriteLine("5. Thoat chuong trinh");
        }
        public void ThucThi()
        {
            HocSinhService hss = new HocSinhService();
            while (true)
            {
                menu();
                Console.WriteLine("Nhap 1 lua chon: ");
                switch (int.Parse(Console.ReadLine())){
                    case 1:
                        HocSinh hs = new HocSinh();
                        hs.Nhap();
                        Console.WriteLine(hss.ThemHocSinh(hs));
                        break;
                    case 2:                      
                        hs = new HocSinh();
                        Console.WriteLine("Nhap Hoc Sinh ID can sua: ");
                        hs.HocSinhId = int.Parse(Console.ReadLine());
                        hs.Nhap();
                        Console.WriteLine(hss.SuaThongTin(hs));
                        break;
                    case 3:
                        Console.WriteLine("Nhap ID can xoa: ");
                        int id = int.Parse(Console.ReadLine());
                        Console.WriteLine(hss.XoaHocSinh(id));
                        break;
                    case 4:
                        Console.WriteLine("Nhap Hoc Sinh ID can chuyen: ");
                        id = int.Parse(Console.ReadLine());
                        Console.WriteLine("Nhap lop muon chuyen: ");
                        int LopId = int.Parse(Console.ReadLine());
                        Console.WriteLine(hss.ChuyenLop(id, LopId));
                        break;
                    case 5:
                        return;
                    default:
                        Console.WriteLine("Vui long nhap lua chon 1-5!");
                        break;
                }
            }
        }
    }
}
