using EF_02_NhanVien.Controller;
using EF_02_NhanVien.Helper;
using EF_02_NhanVien.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_02_NhanVien.View
{
    class NhanVienView
    {
        public void menu()
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("1. Them mot nhan vien");
            Console.WriteLine("2. Sua thong tin mot du an da ton tai");
            Console.WriteLine("3. Xoa mot nhan vien");
            Console.WriteLine("4. Luong cac nhan vien");
            Console.WriteLine("5. Thoat");
        }
        public void ThucThi()
        {
            
            while (true)
            {
                InputHelper h = new InputHelper();
                PhanCongController pc = new PhanCongController();
                NhanVienController nv = new NhanVienController();
                DuAnController da = new DuAnController();
                menu();
                Console.Write("Nhap vao 1 lua chon: ");
                switch (int.Parse(Console.ReadLine()))
                {
                    case 1:
                        PhanCong p = new PhanCong();
                        p.Nhap();
                        pc.PhanCongNhanVien(p);
                        break;
                    case 2:
                        DuAn d = new DuAn();
                        d.DuanID = h.ID("Nhap ID Du An can sua: ");
                        d.Nhap();
                        da.SuaThongTinDuAn(d);
                        break;
                    case 3:

                        int id = h.ID("Nhap ID Nhan Vien can xoa:");
                        Console.WriteLine(nv.XoaNhanVien(id));
                        break;
                    case 4:
                        nv.TinhLuong();
                        break;
                    case 5:
                        return;
                    default:
                        Console.WriteLine("Nhap lua chon trong khoang 1-5");
                        break;
                }
            }
           
        }
    }
}
