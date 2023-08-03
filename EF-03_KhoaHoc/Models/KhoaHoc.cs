using EF_03_KhoaHoc.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_03_KhoaHoc.Models
{
     class KhoaHoc
    {
        public int KhoaHocID { get; set; }
        public string TenKhoaHoc { get; set; }
        public string MoTa { get; set; }
        public int HocPhi { get; set; }
        public DateTime NgayBatDau { get; set; }
        public DateTime NgayKetThuc { get; set; }
        public List<NgayHoc> NgayHocs { get; set; }
        public List<HocVien> HocViens { get; set; }
        public void Nhap()
        {
            InputHelper h = new InputHelper();
            TenKhoaHoc = h.TenKhoaHoc();
            MoTa = h.Name("Nhap Mo Ta");
            HocPhi = h.HocPhi();
            NgayBatDau = h.Ngay("Nhap ngay bat dau");
            NgayKetThuc = h.Ngay("Nhap ngay ket thuc");
        }

    }
}
