using EFC_02_QuanLyCongThucNauAn.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFC_02_QuanLyCongThucNauAn.Models
{
    class MonAn
    {
        public int MonanID { get; set; }
        public int LoaimonanID { get; set; }
        public string Tenmon { get; set; }
        public string GhiChu { get; set; }
        public List<CongThuc> CongThuc { get; set; }
        public LoaiMonAn LoaiMonAn { get; set; }
        public void Nhap()
        {
            InputHelper h = new InputHelper();
            LoaimonanID = h.So("Loai mon an ID");
            Tenmon = h.Ten("ten mon", 100);
            GhiChu = h.Ten("ghi chu", 1000);
            Console.Write("Nhap so luong cong thuc can them: ");
            int n = int.Parse(Console.ReadLine());
            CongThuc = new List<CongThuc>(n);
            for(int i = 0; i < n; i++)
            {
                CongThuc.Add(new CongThuc()
                {
                    NguyenlieuID = h.So("nguyen lieu ID"),
                    Soluong = h.So("so luong"),
                    Donvitinh = h.Ten("don vi tinh", 10)
                }) ;
            }
        }
        public void InThongTin()
        {
            Console.WriteLine($"Mon an co ID = {MonanID} co ten la {Tenmon}");
        }
    }
}
