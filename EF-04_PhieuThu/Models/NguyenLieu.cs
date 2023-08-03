using EF_04_PhieuThu.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_04_PhieuThu.Models
{
    class NguyenLieu
    {
        public int NguyenlieuID { get; set; }
        public int LoainguyenlieuID { get; set; }
        public string Tennguyenlieu { get; set; }
        public int Giaban { get; set; }
        public string Donvitinh { get; set; }
        public int Soluongkho { get; set; }
        public LoaiNguyenLieu LoaiNguyenLieu { get; set; }
        public List<ChiTietPhieuThu> ChiTietPhieuThu { get; set; }
        public void Nhap()
        {
            InputHelper h = new InputHelper();
            LoainguyenlieuID = h.ID("Nhap loai nguyen lieu ID");
            Tennguyenlieu = h.TenLoai("Nhap ten nguyen lieu");
            Giaban = h.ID("Nhap gia ban");
            Donvitinh = h.Donvitinh();
            Soluongkho = h.ID("Nhap so luong kho");
        }
        public void InThongTin()
        {
             Console.WriteLine($"Nguyen lieu co ID: {NguyenlieuID}, gia ban la {Giaban} va so luong kho: {Soluongkho}");
        }
    }
}
