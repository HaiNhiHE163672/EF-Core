using EF_03_KhoaHoc.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_03_KhoaHoc.Models
{
     class HocVien
    {
        public int HocVienID { get; set; }
        public int KhoaHocID { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public string QueQuan { get; set; }
        public string DiaChi { get; set; }
        public string SoDienThoai { get; set; }
        public KhoaHoc KhoaHoc { get; set; }
        public void Nhap()
        {
            InputHelper h = new InputHelper();
            KhoaHocID = h.Id("Nhap Khoa Hoc ID");
            HoTen = h.HoTen();
            NgaySinh = h.NgaySinh();
            QueQuan = h.Name("Nhap Que Quan");
            DiaChi = h.Name("Nhap Dia Chi");
            SoDienThoai = h.Name("Nhap So Dien Thoai");
        }
        public void InThongTin()
        {
            Console.WriteLine($"Hoc Vien ID: {HocVienID} tham gia khoa hoc co so ID {KhoaHocID} co ho ten la {HoTen}, sinh ngay {NgaySinh.ToShortDateString()}, Dia chi o {DiaChi}");
        }
    }
}
