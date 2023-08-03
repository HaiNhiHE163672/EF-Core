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
    class HocVienController : IHocVienController
    {
        protected AppDbContext dbContext { get; }
        public HocVienController()
        {
            dbContext = new AppDbContext();
        }
        public string SuaThongTin(HocVien hv)
        {
            if(dbContext.HocVien.Any(x => x.HocVienID == hv.HocVienID))
            {
                dbContext.Update(hv);
                dbContext.SaveChanges();
                return "Sua thong tin cua mot hoc vien thanh cong";
            }
            else
            {
                return "Hoc vien khong ton tai";
            }
        }

        public void TimKiem(string search)
        {
            List<HocVien> hvs = dbContext.HocVien.Where(x => x.HoTen.Contains(search) || x.KhoaHoc.TenKhoaHoc.Contains(search)).Include(x => x.KhoaHoc).ToList();
            foreach(var hv in hvs)
            {
                hv.InThongTin();
            }

        }
           
    }
}
