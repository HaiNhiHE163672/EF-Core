using EFC_02_QuanLyCongThucNauAn.Interface;
using EFC_02_QuanLyCongThucNauAn.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFC_02_QuanLyCongThucNauAn.Controller
{
    class MonAnController : IMonAnController
    {
        protected AppDbContext dbContext { get; }
        public MonAnController()
        {
            dbContext = new AppDbContext();
        }
        public void DSCongthuc()
        {
            List<MonAn> monAns = dbContext.MonAn.Include(x => x.CongThuc).ThenInclude(x => x.NguyenLieu).ToList();
            foreach(var monAn in monAns)
            {
                Console.WriteLine();
                Console.WriteLine($"Mon an {monAn.Tenmon}");
                foreach(var nl in monAn.CongThuc.ToList())
                {
                    nl.InThongTin();
                }
            }
        }

        public string ThemMonMoi(MonAn monAn)
        {
            var DsCongThuc = monAn.CongThuc.ToList();
            monAn.CongThuc.Clear();
            dbContext.Add(monAn);
            dbContext.SaveChanges();
            foreach(var ct in DsCongThuc)
            {
                if(dbContext.NguyenLieu.Any(x => x.NguyenlieuID == ct.NguyenlieuID))
                {
                    ct.MonanID = monAn.MonanID;
                    dbContext.Add(ct);
                    dbContext.SaveChanges();
                }
                else
                {
                    return "Them cong thuc that bai";
                }
            }
            return "Them mon moi kem cong thuc nau an thanh cong";
        }

        public void TimKiemDanhSachTheoNguyenLieuHanhToi(string search)
        {
            var mons = dbContext.MonAn.Include(x => x.CongThuc).ThenInclude(x => x.NguyenLieu).Where(x => x.CongThuc.Any(x => x.NguyenLieu.Tennguyenlieu.ToLower().Contains(search))).ToList();
            mons.ForEach(x => x.InThongTin());
        }
    }
}
