using EF_03_KhoaHoc.Interface;
using EF_03_KhoaHoc.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_03_KhoaHoc.Controller
{
    class KhoaHocController : IKhoaHocController
    {
        protected AppDbContext dbContext { get; }
        public KhoaHocController()
        {
            dbContext = new AppDbContext();
        }
        public double DoanhThuMotKhoa(int id)
        {
            var kh = dbContext.KhoaHoc.SingleOrDefault(x => x.KhoaHocID == id);
            return dbContext.HocVien.Where(x => x.KhoaHocID == id).Count() * kh.HocPhi;
        }
        public double DoanhThuMotThang(int thang)
        {

            double ds = 0;
            dbContext.KhoaHoc.Where(x => x.NgayBatDau.Month == thang).ToList().ForEach(y =>
            {
                ds += DoanhThuMotKhoa(y.KhoaHocID);
            });
            return ds;
            //dbContext.KhoaHoc.Where(x => x.NgayBatDau.Month == thang).ToList().ForEach(y =>
            //{
            //    Console.WriteLine(y.HocPhi);
            //});
            //return 0;
        }
        
        public void DoanhThu()
        {
            List<int> thangs = dbContext.KhoaHoc.Select(x => x.NgayBatDau.Month).Distinct().ToList();
            foreach (int t in thangs)
            {
                Console.WriteLine($"Thang {t} co doanh thu : {DoanhThuMotThang(t)}");
            }

        }
        public string XoaKhoaHoc(int id)
        {
            if(dbContext.KhoaHoc.Any(x => x.KhoaHocID == id))
            {
                KhoaHoc kh = dbContext.KhoaHoc.Find(id);
                dbContext.Remove(kh);
                dbContext.SaveChanges();
                return "Xoa mot khoa hoc thanh cong";
            }
            else
            {
                return "Khong co khoa hoc do ton tai";
            }
        }
    }
}
