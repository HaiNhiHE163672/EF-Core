using EF_04_PhieuThu.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_04_PhieuThu
{
    class AppDbContext : DbContext
    {
        public DbSet<LoaiNguyenLieu> LoaiNguyenLieu { get; set; }
        public DbSet<NguyenLieu> NguyenLieu { get; set; }
        public DbSet<ChiTietPhieuThu> ChiTietPhieuThu { get; set; }
        public DbSet<PhieuThu> PhieuThu { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connect = "Server =DESKTOP-GM3477H;uid=nhinth;pwd=123456789; Database = QuanLyPhieuThu; TrustServerCertificate=True;";
            optionsBuilder.UseSqlServer(connect);
        }
    }
}
