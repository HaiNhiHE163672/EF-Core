using EF_05_MonAn.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_05_MonAn.Models
{
    class CongThuc
    {
        public int CongthucID { get; set; }
        public int NguyenlieuID { get; set; }
        public int MonanID { get; set; }
        public int Soluong { get; set; }
        public string Donvitinh { get; set; }
        public NguyenLieu NguyenLieu { get; set; }
        public MonAn MonAn { get; set; }
        public void Nhap()
        {
            InputHelper h = new InputHelper();

            NguyenlieuID = h.So("nguyen lieu ID"); 
            Soluong = h.So("So luong");
            Donvitinh = h.Ten("don vi tinh", 10);
        }
    }
}
