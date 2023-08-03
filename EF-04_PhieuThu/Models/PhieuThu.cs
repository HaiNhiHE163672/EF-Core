using EF_04_PhieuThu.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_04_PhieuThu.Models
{
    class PhieuThu
    {
        public int PhieuthuID { get; set; }
        public DateTime Ngaylap { get; set; }
        public string Nhanvienlap { get; set; }
        public string Ghichu { get; set; }
        public int Thanhtien { get; set; }
        public List<ChiTietPhieuThu> ChiTietPhieuThu { get; set; }
        public void Nhap()
        {
            InputHelper h = new InputHelper();
            Ngaylap = h.Ngay();
            Nhanvienlap = h.Name("Nhap Nhan Vien");
            Ghichu = h.Name("Nhap Ghi Chu");
            Thanhtien = 0;
            Console.Write("Nhap so luong phieu thu chi tiet: ");
            int n = int.Parse(Console.ReadLine());
            ChiTietPhieuThu = new List<ChiTietPhieuThu>(n);

            for (int i = 0; i < n; i++)
            {
                ChiTietPhieuThu.Add(new ChiTietPhieuThu() { NguyenlieuID = h.ID("Nhap nguyen lieu ID"), SoLuongBan = h.ID("Nhap so luong ban") });
            }
            
        }
        public void InThongTin()
        {
            Console.WriteLine($"Phieu thu co ID: {PhieuthuID} , Ngay lap: {Ngaylap.ToShortDateString()}, nhan vien lap: {Nhanvienlap} , thanh tien : {Thanhtien} ");
        }
    }
}
