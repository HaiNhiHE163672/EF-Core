using Lesion6.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesion6.Models
{
     class Lop
    {
        public int LopId { get; set; }
        public string Tenlop { get; set; }
        public int Siso { get; set; }
        public void Nhap()
        {
            InputHelper h = new InputHelper();
            Tenlop = h.TenLop();
            Siso = h.SiSo();
        }
        public Lop() { }
        public List<HocSinh> HocSinhs { get; set; }
    }
}
