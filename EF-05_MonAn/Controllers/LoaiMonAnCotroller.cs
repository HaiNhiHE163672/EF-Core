using EF_05_MonAn.Interface;
using EF_05_MonAn.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_05_MonAn.Controllers
{
    class LoaiMonAnCotroller : ILoaiMonAnController
    {
        protected AppDbContext dbContext { get; }
        public LoaiMonAnCotroller()
        {
            dbContext = new AppDbContext();
        }
        public void XoaCongThuc(int id)
        {
            List<CongThuc> congThucs = dbContext.CongThuc.Where(x => x.MonanID == id).ToList();
            dbContext.CongThuc.AddRange(congThucs);
            dbContext.SaveChanges();
        }
        public void XoaMonAn(int id)
        {
            List<MonAn> monAns = dbContext.MonAn.Where(x => x.MonanID == id).ToList();
            dbContext.MonAn.AddRange(monAns);
            dbContext.SaveChanges();
        }
        public void XoaMonAnTheoLoaiMonAn(int loaimonid)
        {
            dbContext.MonAn.Where(x => x.LoaimonanID == loaimonid).ToList().ForEach(y =>
            {
                XoaCongThuc(y.MonanID);
                XoaMonAn(y.MonanID);
            });
        }
        public string XoaLoaiMonAn(int id)
        {
            if(dbContext.LoaiMonAn.Any(x => x.LoaimonanID == id))
            {
                var loai = dbContext.LoaiMonAn.Find(id);
                dbContext.Remove(loai);
                dbContext.SaveChanges();
                XoaMonAnTheoLoaiMonAn(id);
                return "Xoa loai mon an thanh cong";
            }
            else
            {
                return "Xoa loai mon an that bai";
            }
        }
    }
}
