using EF_02_NhanVien.Helper;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_02_NhanVien.Models
{
     class NhanVien
    {
        public int NhanvienID { get; set; }
        public string Hoten { get; set; }
        public string Sodienthoai { get; set; }
        public string Diachi { get; set; }
        public string Email { get; set; }
        public int Hesoluong { get; private set; }
        public List<PhanCong> phanCongs { get; set; }
        public void Nhap()
        {
            InputHelper h = new InputHelper();
            Hoten = h.HoTen();
            Sodienthoai = h.name("Nhap so dien thoai");
            Diachi = h.name("Nhap Dia Chi");
            Email = h.name("Nhap Email");
            Hesoluong = h.ID("Nhap He So Luong");
        }
    }
}
