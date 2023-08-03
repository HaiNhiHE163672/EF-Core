using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_04_PhieuThu.Models
{
    class LoaiNguyenLieu
    {
        public int LoainguyenlieuID { get; set; }
        public string Tenloai { get; set; }
        public string Mota { get; set; }
        public List<NguyenLieu> NguyenLieu { get; set;}
    }
}
