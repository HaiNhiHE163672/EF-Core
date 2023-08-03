using EFC_01_QuanLyTrungTam.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFC_01_QuanLyTrungTam.Interface
{
    interface IHocVienController 
    {
        void DanhSachHocVienTheoNgay(List<HocVien> hocViens);
        void DanhSachHocVienTheoTimKiem(List<HocVien> hocViens);
        string ThemHocVien(HocVien hocVien);
        string CapNhatHocVien(HocVien hocVien);
        string XoaHocVien(int id);
    }
}
