using EF_05_MonAn.Interface;
using EF_05_MonAn.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_05_MonAn.Controllers
{
    class MonAnController : IMonAnController
    {
        protected AppDbContext dbContext { get; }
        public MonAnController()
        {
            dbContext= new AppDbContext();
        }
        public string ThemMonAn(MonAn mon)
        {
            dbContext.MonAn.Add(mon);
            dbContext.SaveChanges();
            return "Them mon an thanh cong";
        }

        public void TimKiemMonAn(string search)
        {
            List<MonAn> mon = dbContext.MonAn.Include(x => x.CongThuc).ThenInclude(x => x.NguyenLieu).Where(x => x.Tenmon.Contains(search) || x.CongThuc.Any(y => y.NguyenLieu.Tennguyenlieu.Contains(search))).ToList();
            foreach(var m in mon)
            {
                m.InThongTin();
            }
        }
    }
}
