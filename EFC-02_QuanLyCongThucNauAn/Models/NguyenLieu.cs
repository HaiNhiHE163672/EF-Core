using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFC_02_QuanLyCongThucNauAn.Models
{
    class NguyenLieu
    {
        public int NguyenlieuID { get; set; }
        public string Tennguyenlieu { get; set; }
        public List<CongThuc> CongThuc { get; set; }
        
    }
}
