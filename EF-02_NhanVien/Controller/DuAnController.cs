using EF_02_NhanVien.IController;
using EF_02_NhanVien.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_02_NhanVien.Controller
{
    class DuAnController : IDuAnController
    {
        protected AppDbContext dbContext { get; }
        public DuAnController()
        {
            dbContext = new AppDbContext();
        }
        public string SuaThongTinDuAn(DuAn da)
        {
            if(dbContext.DuAn.Any(x => x.DuanID == da.DuanID))
            {
                dbContext.Update(da);
                dbContext.SaveChanges();
                return "Sua thong tin du an thanh cong";
            }
            else
            {
                return "Sua thong tin du an that bai";
            }
        }
    }
}
