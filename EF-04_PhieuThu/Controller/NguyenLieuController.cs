using EF_04_PhieuThu.Interface;
using EF_04_PhieuThu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_04_PhieuThu.Controller
{
    class NguyenLieuController : INguyenlieuController
    {
        public AppDbContext DbContext { get; }
        public NguyenLieuController()
        {
            DbContext = new AppDbContext();
        }
        public string ThemNguyenLieu(NguyenLieu nl)
        {
            DbContext.NguyenLieu.Add(nl);
            DbContext.SaveChanges();
            return "Them nguyen lieu thanh cong";
        }
    }
}
