using EFC_01_QuanLyTrungTam.Interface;
using EFC_01_QuanLyTrungTam.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFC_01_QuanLyTrungTam.Controller
{
    class HocVienController : IHocVienController
    {
        protected AppDbContext dbContext { get; }
        public HocVienController()
        {
            dbContext = new AppDbContext();
        }
        public string CapNhatHocVien(HocVien hocVien)
        {
            if(dbContext.HocVien.Any(x => x.HocVienID == hocVien.HocVienID))
            {
                dbContext.HocVien.Update(hocVien);
                dbContext.SaveChanges();
                return "Cap nhat thong tin hoc vien thanh cong";
            }
            else
            {
                return "Cap nhat thong tin that bai";
            }
        }

        public void DanhSachHocVienTheoNgay(List<HocVien> hocViens)
        {
            hocViens = dbContext.HocVien.OrderByDescending(x => x.NgayDangKy).ToList();
            hocViens.ForEach(x =>
            {
                x.InThongTin1();
            });
        }

        public void DanhSachHocVienTheoTimKiem(List<HocVien> hocViens)
        {
            hocViens = dbContext.HocVien.Where(x => x.NgaySinh.Year == 2002 && x.HoTen.Contains("An")).ToList();
            hocViens.ForEach(x =>
            {
                x.InThongTin2();
            });
        }

        public string ThemHocVien(HocVien hocVien)
        {
            dbContext.HocVien.Add(hocVien);
            dbContext.SaveChanges();
            return "Them Hoc Vien thanh cong";
        }

        public string XoaHocVien(int id)
        {
            if(dbContext.HocVien.Any(x => x.HocVienID == id))
            {
                var hv = dbContext.HocVien.Find(id);
                dbContext.HocVien.Remove(hv);
                dbContext.SaveChanges() ;
                return "Xoa mot Hoc Vien Thanh Cong";
            }
            else
            {
                return "Hoc Vien Khong ton tai";
            }
        }
    }
}
