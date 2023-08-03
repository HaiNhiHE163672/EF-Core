using EF_05_MonAn.Interface;
using EF_05_MonAn.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_05_MonAn.Controllers
{
    class CongthucController : ICongThucController
    {
        protected AppDbContext dbContext { get; }
        public CongthucController()
        {
            dbContext = new AppDbContext();
        }
        public string ThemCongThuc(CongThuc ct, int MonAnId)
        {
                if(dbContext.NguyenLieu.Any(x => x.NguyenlieuID == ct.NguyenlieuID))
                {
                    if(dbContext.MonAn.Any(x => x.MonanID == ct.MonanID))
                    {
                        ct.MonanID = MonAnId;
                        dbContext.Add(ct);
                        dbContext.SaveChanges();
                        var mon = dbContext.MonAn.Find(ct.MonanID);
                        var ngl = dbContext.NguyenLieu.Find(ct.NguyenlieuID);
                        mon.MonanID = ct.MonanID;
                        mon.Cachlam += " " +  ngl.Tennguyenlieu + ": " + ct.Soluong + " " + ct.Donvitinh + " ";
                        dbContext.Update(mon);
                        dbContext.SaveChanges();

                    }
                    else
                    {
                        return "Mon An Khong ton tai";
                    }
                }
                else
                {
                    return "Nguyen lieu khong ton tai";
                }
            
            return "Them cong thuc thanh cong";
        }

        public string ThemDanhSachCongThuc(List<CongThuc> list)
        {
            throw new NotImplementedException();
        }
    }
}
