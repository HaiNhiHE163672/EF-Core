
using EF_04_PhieuThu.Controller;
using EF_04_PhieuThu.Models;
using EF_04_PhieuThu.View;

namespace EF_04_PhieuThu
{
    class Program
    {
        static void Main(string[] args)
        {
            //    PhieuThuController pt = new PhieuThuController();
            //var phieuthu = new PhieuThu()
            //{
            //    Ngaylap = DateTime.Now,
            //    Nhanvienlap = "Nhan Vien 3",
            //    Ghichu = "Day du",
            //    Thanhtien = 0,
            //    ChiTietPhieuThu = new List<ChiTietPhieuThu>()
            //        {
            //            new ChiTietPhieuThu(){NguyenlieuID = 1, SoLuongBan = 2},
            //            new ChiTietPhieuThu(){NguyenlieuID = 3, SoLuongBan = 5},
            //        }

            //};
            //var res = pt.ThemPhieuThu(phieuthu);
            //Console.WriteLine(res);
            PhieuThuView phieu = new PhieuThuView();
            phieu.ThucThi();

        }
    }
}