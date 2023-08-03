using EF_04_PhieuThu.Controller;
using EF_04_PhieuThu.Helper;
using EF_04_PhieuThu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_04_PhieuThu.View
{
    class PhieuThuView
    {
        public void menu()
        {
            Console.WriteLine("======================================");
            Console.WriteLine("1. Them mot nguyen lieu");
            Console.WriteLine("2. Them mot danh sach chi tiet");
            Console.WriteLine("3. Them mot phieu thu");
            Console.WriteLine("4. Xoa mot phieu thu");
            Console.WriteLine("5. Lay thong tin cac phieu thu theo thoi gian.");
        }
        public void ThucThi()
        {
            
            while(true)
            {
                NguyenLieuController nl = new NguyenLieuController();
                PhieuThuController ph = new PhieuThuController();
                ChiTietPhieuThuController ct = new ChiTietPhieuThuController();
                InputHelper h = new InputHelper();
                List<PhieuThu> phs = new List<PhieuThu>();
                menu();
                Console.Write("Nhap lua chon: ");
                switch (int.Parse(Console.ReadLine()))
                {
                    case 0:
                        return;
                    case 1:
                        NguyenLieu nguyenLieu = new NguyenLieu();
                        nguyenLieu.Nhap();
                        Console.WriteLine(nl.ThemNguyenLieu(nguyenLieu));
                        break;
                    case 2:
                        ChiTietPhieuThu chiTietPhieu = new ChiTietPhieuThu();
                        chiTietPhieu.Nhap();
                        Console.WriteLine(ct.ThemChiTietPhieuThu(chiTietPhieu));
                        break;
                    case 3:
                        PhieuThu phieuThu = new PhieuThu();
                        phieuThu.Nhap();
                        Console.WriteLine(ph.ThemPhieuThu(phieuThu));
                        break;
                    case 4:
                        int id = h.ID("Nhap Phieu Thu ID can xoa");
                        Console.WriteLine(ph.XoaPhieuThu(id));
                        break;
                    case 5:
                        ph.DSPhieuThu(phs);
                        break;
                    default:
                        Console.WriteLine("Vui long nhap 1-5 va 0 de thoat khoi chuong trinh!");
                        break;
                }

            }
        }
    }
}
