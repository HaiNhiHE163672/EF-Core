using EF_05_MonAn.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_05_MonAn.Models
{
    class MonAn
    {
        public int MonanID { get; set; }
        public int LoaimonanID { get; set; }
        public string Tenmon { get; set; }
        public int Giaban { get; set; }
        public string Gioithieu { get; set; }
        public string Cachlam { get; set; }
        public List<CongThuc> CongThuc { get; set; }
        public LoaiMonAn LoaiMonAn { get; set; }
        public void Nhap()
        {
            InputHelper h = new InputHelper();
            LoaimonanID = h.So("Loai mon an ID");
            Tenmon = h.Ten("Ten mon", 20);
            Giaban = h.So("Gia ban");
            Gioithieu = h.Ten("Gioi thieu", 1000);
            Cachlam = h.Ten("Cach lam", 1000);
        }
        public void NhapCongThuc()
        {
            InputHelper h = new InputHelper();
            MonanID = h.So("Mon an ID");
            Cachlam = "";
            Console.Write("Nhap so cong thuc can them: ");
            int n = int.Parse(Console.ReadLine());
            CongThuc = new List<CongThuc>(n);
            for (int i = 0; i < n; i++)
            {
                CongThuc.Add(new CongThuc() { NguyenlieuID = h.So("nguyen lieu ID"), Soluong = h.So("So luong"), Donvitinh = h.Ten("don vi tinh", 10) });
            }
        }
        public void InThongTin()
        {
            Console.WriteLine($"Mon an ID {MonanID} co ten {Tenmon} ban gia {Giaban} co cach lam {Cachlam}");
        }
    }
}
