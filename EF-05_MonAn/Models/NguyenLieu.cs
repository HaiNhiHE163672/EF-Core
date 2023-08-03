using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_05_MonAn.Models
{
    class NguyenLieu
    {
        public int NguyenlieuID { get; set; }
        public string Tennguyenlieu { get; set; }
        public string Ghichu { get; set; }
        public List<CongThuc> CongThuc { get; set; }
    }
}
