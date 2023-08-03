using EF_04_PhieuThu.Interface;
using EF_04_PhieuThu.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EF_04_PhieuThu.Controller
{
    class ChiTietPhieuThuController : IChitietphieuthuController
    {
        public AppDbContext DbContext { get;}
        public ChiTietPhieuThuController()
        {
            DbContext = new AppDbContext();
        }
        public string ThemChiTietPhieuThu(ChiTietPhieuThu ct)
        {
            if(DbContext.PhieuThu.Any(x => x.PhieuthuID == ct.PhieuthuID))
            {
                if (DbContext.NguyenLieu.Any(x => x.NguyenlieuID == ct.NguyenlieuID))
                {
                    DbContext.Add(ct);
                    DbContext.SaveChanges();
                    return "Them chi tiet thanh cong";
                }
                else{
                    return "Nguyen Lieu khong ton tai";
                }
                
            }
            else
            {
                return "Phieu thu khong ton tai";
            }
        }
    }
}
