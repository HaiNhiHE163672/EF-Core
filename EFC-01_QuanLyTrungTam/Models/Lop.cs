using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFC_01_QuanLyTrungTam.Models
{
    class Lop
    {
        public int LopID { get; set; }
        public string TenLop { get; set; }
        public List<HocVien> HocVien { get; set; }
    }
}
