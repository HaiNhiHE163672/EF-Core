using EF_03_KhoaHoc.Interface;
using EF_03_KhoaHoc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_03_KhoaHoc.Controller
{
    class NgayHocController : INgayHocController
    {
        protected AppDbContext dbContext { get; }
        public NgayHocController()
        {
            dbContext = new AppDbContext();
        }
        public string ThemNgayHoc(NgayHoc nh)
        {
            dbContext.Add(nh);
            dbContext.SaveChanges();
            return "Them mot ngay hoc thanh cong";
            
        }
    }
}
