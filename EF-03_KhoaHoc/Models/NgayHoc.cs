using EF_03_KhoaHoc.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_03_KhoaHoc.Models
{
     class NgayHoc
    {
        public int NgayHocID { get; set;}
        public int KhoaHocID { get; set;}
        public string NoiDung { get; set;}
        public string GhiChu { get; set;}
        public KhoaHoc KhoaHoc { get; set;}

        public void Nhap()
        {
            InputHelper h = new InputHelper();
            KhoaHocID = h.Id("Nhap Khoa Hoc ID");
            NoiDung = h.Name("Nhap Noi Dung");
            GhiChu = h.Name("Nhap Ghi Chu");
        }

    }
}
