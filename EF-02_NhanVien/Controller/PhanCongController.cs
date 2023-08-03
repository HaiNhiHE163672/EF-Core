using EF_02_NhanVien.IController;
using EF_02_NhanVien.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_02_NhanVien.Controller
{
    class PhanCongController : IPhanCongController
    {
        protected AppDbContext dbContext { get; }
        public PhanCongController()
        {
            dbContext = new AppDbContext();
        }
        public string PhanCongNhanVien(PhanCong pc)
        {
            NhanVien nv = new NhanVien();
            DuAn da = new DuAn();
            if(dbContext.NhanVien.Any(x => x.NhanvienID == pc.NhanvienID) && dbContext.DuAn.Any(x => x.DuanID == pc.DuanID))
            {
                dbContext.PhanCong.Add(pc);
                dbContext.SaveChanges();
                return "Them Nhan Vien vao Du An thanh cong";
            }
            else
            {
                return "Them Nhan Vien vao Du An that bai";
            }
            
        }
    }
}
