using EF_02_NhanVien.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_02_NhanVien.Models
{
     class DuAn
    {
       public int DuanID { get; set; }
       public string Tenduan { get; set; }
       public string Mota { get; set; }
       public string Ghichu { get; set; }
       public List<PhanCong> phanCongs { get; set; }
        public void Nhap()
        {
            InputHelper h = new InputHelper();
            Tenduan = h.TenDuAn();
            Mota = h.name("Nhap Mo Ta");
            Ghichu = h.name("Nhap Ghi Chu");
        }
    }
}
