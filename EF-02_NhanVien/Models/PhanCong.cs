using EF_02_NhanVien.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_02_NhanVien.Models
{
     class PhanCong
    {
        public int PhancongID { get; set; }
        public int Sogiolam { get; set; }
        public int NhanvienID { get; set; }
        public int DuanID { get; set; }
        public NhanVien NhanVien { get; set; }
        public DuAn DuAn { get; set; }
        public void Nhap()
        {
            InputHelper h = new InputHelper();
            Sogiolam = h.ID("Nhap So Gio Lam");
            NhanvienID = h.ID("Nhap nhan vien id");
            DuanID = h.ID("Nhap du an id");
        }
    }
}
