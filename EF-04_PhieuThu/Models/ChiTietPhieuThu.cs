using EF_04_PhieuThu.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_04_PhieuThu.Models
{
    class ChiTietPhieuThu
    {
        public int ChitietphieuthuID { get; set; }
        public int NguyenlieuID { get; set; }
        public int PhieuthuID { get; set; }
        public int SoLuongBan { get; set; }
        public NguyenLieu NguyenLieu { get; set; }
        public PhieuThu PhieuThu { get; set; }
        public void Nhap()
        {
            InputHelper h = new InputHelper();
            NguyenlieuID = h.ID("Nhap nguyen lieu ID");
            PhieuthuID = h.ID("Nhap phieu thu ID");
            SoLuongBan = h.ID("Nhap So Luong Ban");

        }
    }
}
