using EF_04_PhieuThu.Interface;
using EF_04_PhieuThu.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_04_PhieuThu.Controller
{
    class PhieuThuController : IPhieuThuController
    {
        public AppDbContext DbContext { get; }
        public PhieuThuController()
        {
            DbContext = new AppDbContext();
        }
        public string ThemPhieuThu(PhieuThu pt)
        {
            var DsChiTiet = pt.ChiTietPhieuThu.ToList();
            pt.ChiTietPhieuThu.Clear();
            DbContext.Add(pt);
            DbContext.SaveChanges();
            foreach(var ct in DsChiTiet)
            {
                if(DbContext.NguyenLieu.Any(x => x.NguyenlieuID == ct.NguyenlieuID))
                {
                    ct.PhieuthuID = pt.PhieuthuID;
                    DbContext.Add(ct);
                    DbContext.SaveChanges();
                    var nl = DbContext.NguyenLieu.Find(ct.NguyenlieuID);
                    nl.Soluongkho = nl.Soluongkho - ct.SoLuongBan;
                    DbContext.Update(nl);
                    DbContext.SaveChanges();

                    pt.Thanhtien += nl.Giaban * ct.SoLuongBan;
                    DbContext.Update(pt);
                    DbContext.SaveChanges();
                   
                }
                else
                {
                    return "Them chi tiet thu that bai";
                }
            }
            return "Them chi tiet Thanh Cong";
        }

        public string XoaPhieuThu(int id)
        {
            if(DbContext.PhieuThu.Any(x => x.PhieuthuID == id))
            {
                
                var pt = DbContext.PhieuThu.Find(id);
                DbContext.PhieuThu.Remove(pt);
                DbContext.SaveChanges();

                List<ChiTietPhieuThu> chiTiets = DbContext.ChiTietPhieuThu.Where(x => x.PhieuthuID == id).ToList();
                DbContext.ChiTietPhieuThu.RemoveRange(chiTiets);
                DbContext.SaveChanges();
                return "Xoa mot phieu thu thanh cong";
            }
            else
            {
                return "Phieu thu khong ton tai";
            }
        }

        public void DSPhieuThu(List<PhieuThu> list)
        {
            list = DbContext.PhieuThu.Include(x => x.ChiTietPhieuThu).ThenInclude(x => x.NguyenLieu).OrderBy(x => x.Ngaylap).ToList();
            foreach(var ph in list)
            {
                Console.WriteLine();
                ph.InThongTin();
                Console.WriteLine("Danh sach nguyen lieu trong phieu la: ");
                foreach(var ct in ph.ChiTietPhieuThu.ToList())
                {
                    ct.NguyenLieu.InThongTin();
                }
            }
        }
    }
}
