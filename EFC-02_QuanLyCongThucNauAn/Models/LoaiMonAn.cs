using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFC_02_QuanLyCongThucNauAn.Models
{
    class LoaiMonAn
    {
        public int LoaimonanID { get; set; }
        public string Tenloai { get; set; }
        public List<MonAn> MonAn { get; set; }
    }
}
