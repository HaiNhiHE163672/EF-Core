using Lesion6.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesion6.Models
{
     class HocSinh
    {
        public int HocSinhId { get; set; }
        public string Hoten { get; set; }
        public DateTime Ngaysinh { get; set; }
        public string Quequan { get; set; }
        public int LopId { get; set; }
        public Lop Lop { get; set; }
        public HocSinh(string hoten, DateTime ngaysinh, string quequan, int lopId)
        {
            Hoten = hoten;
            Ngaysinh = ngaysinh;
            Quequan = quequan;
            LopId = lopId;
        }
        public HocSinh() { }
        public void Nhap()
        {
            InputHelper h = new InputHelper();
            Hoten = h.Hoten();
            Ngaysinh = h.Ngaysinh();
            Quequan = h.Quequan();
            Console.WriteLine("Nhap lop ID: ");
            LopId = int.Parse(Console.ReadLine());
        }
        public void InThongTin()
        {
            Console.WriteLine($"Hoc Sinh co ID la {HocSinhId}, ho ten la {Hoten}, Ngay Sinh: {Ngaysinh.ToShortDateString()}, Que Quan: {Quequan}, hoc lop {LopId}");
        }
    }
}
