using Lesion6.IServices;
using Lesion6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesion6.Services
{
    class HocSinhService : IHocSinhService
    {
        protected AppDbContext dbContext { get; }
        public HocSinhService()
        {
            dbContext = new AppDbContext();
        }
        public string ChuyenLop(int id, int LopId)
        {
            var hsUpdate = dbContext.HocSinhs.SingleOrDefault(x => x.HocSinhId == id);
            if (hsUpdate != null)
            {
                hsUpdate.LopId = LopId;
                dbContext.HocSinhs.Update(hsUpdate);
                dbContext.SaveChanges();
                return "Chuyen lop thanh cong";
                
            }
            else
            {
                return "Hoc Sinh ID khong ton tai";
            }
            
        }

        public HocSinh GetHocSinh(int id)
        {
            HocSinh hs = dbContext.HocSinhs.SingleOrDefault(x => x.HocSinhId == id);
            if(hs != null)
            {
                return hs;
            }
            throw new Exception("Hoc Sinh Khong Ton Tai");
        }

        public List<HocSinh> GetHocSinhs()
        {
            return dbContext.HocSinhs.AsQueryable().ToList();
        }

        public string SuaThongTin(HocSinh hs)
        {
           if(dbContext.HocSinhs.Any(x => x.HocSinhId == hs.HocSinhId))
            {
                dbContext.HocSinhs.Update(hs);
                dbContext.SaveChanges();
                return "Sua thong tin hoc sinh thanh cong";
            }
            else
            {
                return "Sua thong tin hoc sinh that bai";
            }
            
        }

        public string ThemHocSinh(HocSinh hs)
        {
           
                dbContext.HocSinhs.Add(hs);
                dbContext.SaveChanges();
                return "Them Hoc Sinh Thanh Cong";
            
        }

        public string XoaHocSinh(int id)
        {
            
            if (dbContext.HocSinhs.Any(x => x.HocSinhId == id))
            {
                var hs = dbContext.HocSinhs.Find(id);
                dbContext.HocSinhs.Remove(hs);
                dbContext.SaveChanges() ;
                return "Xoa mot hoc sinh thanh cong";
            }
            else
            {
                return "Hoc Sinh Khong Ton Tai";
            }
            
        }
    }
}
