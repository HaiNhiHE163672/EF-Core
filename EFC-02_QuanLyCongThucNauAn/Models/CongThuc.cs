using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFC_02_QuanLyCongThucNauAn.Models
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
        public void InThongTin()
        {
            Console.WriteLine($"[{NguyenLieu.Tennguyenlieu}] - [{Soluong}] - [{Donvitinh}]");
        }
    }
}
