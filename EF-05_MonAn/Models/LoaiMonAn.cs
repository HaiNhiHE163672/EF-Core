using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_05_MonAn.Models
{
    class LoaiMonAn
    {
        public int LoaimonanID { get; set; }
        public string Tenloai { get; set; }
        public string Mota { get; set; }
        public List<MonAn> MonAn { get; set; }
    }
}
