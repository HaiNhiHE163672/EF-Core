using EFC_01_QuanLyTrungTam.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFC_01_QuanLyTrungTam.Models
{
    class HocVien
    {
        public int HocVienID { get; set; }
        public int LopID { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public string Email { get; set; }
        public string SDT { get; set; }
        public string TrinhDo { get; set; }
        public DateTime NgayDangKy { get; set; }
        public Lop Lop { get; set; }
        public void Nhap()
        {
            InputHelper h = new InputHelper();
            Console.Write("Nhap Lop ID: ");
            LopID = int.Parse(Console.ReadLine());
            HoTen = h.Name("Ho Ten", 6, 50);
            NgaySinh = h.Ngay("Ngay Sinh");
            GioiTinh = h.Name("Gioi Tinh",1,10);
            Email = h.Name("Email", 10, 100);
            SDT = h.Name("SDT", 10, 15);
            TrinhDo = h.Name("Trinh Do", 1, 100);
            NgayDangKy = h.Ngay("Ngay Dang Ky");
        }
        public void InThongTin1()
        {
            Console.WriteLine($"Hoc Vien co ID: {HocVienID}, ho ten la {HoTen} hoc lop {LopID} dang ky ngay {NgayDangKy.ToShortDateString()}");
        }
        public void InThongTin2()
        {
            Console.WriteLine($"Hoc Vien co ID {HocVienID}, ho ten la {HoTen} sinh ngay {NgaySinh.ToShortDateString()}");
        }
    }
}
