using EF_02_NhanVien.IController;
using EF_02_NhanVien.Models;
using Microsoft.EntityFrameworkCore.Query.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_02_NhanVien.Controller
{
    class NhanVienController : INhanVienController
    {
        protected AppDbContext dbContext { get; }
        public NhanVienController()
        {
            dbContext= new AppDbContext();
        }
        public string ThemNhanVien(NhanVien nv)
        {
            dbContext.NhanVien.Add(nv);
            dbContext.SaveChanges();
            return "Them Nhan Vien Thanh Cong";
        }
        public int TongGioLam(int id)
        {
            NhanVien nv = dbContext.NhanVien.SingleOrDefault(x => x.NhanvienID == id);
            int sum = dbContext.PhanCong.Where(x => x.NhanvienID == id).Sum(pc => pc.Sogiolam) * 15 * nv.Hesoluong;
                
            return sum;
        }
        public void TinhLuong()
        {
            List<NhanVien> nhanViens = dbContext.NhanVien.ToList();
            foreach(var nv in nhanViens)
            {
                Console.WriteLine($"{nv.NhanvienID} ten {nv.Hoten} co luong {TongGioLam(nv.NhanvienID)}");
            }
        }
        public string XoaNhanVien(int id)
        {
            if (dbContext.NhanVien.Any(x => x.NhanvienID == id))
            {
                var nv = dbContext.NhanVien.Find(id);
                dbContext.NhanVien.Remove(nv);
                dbContext.SaveChanges();
                return "Xoa mot Nhan Vien Thanh Cong";
            }
            else
            {
                return "Nhan Vien Khong to tai";
            }
        }
    }
}
