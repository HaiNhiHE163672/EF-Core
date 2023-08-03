using EF_03_KhoaHoc.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_03_KhoaHoc
{
     class AppDbContext : DbContext
    {
        public DbSet<NgayHoc> NgayHoc { get; set; }
        public DbSet<KhoaHoc> KhoaHoc { get; set; }
        public DbSet<HocVien> HocVien { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connect = "Server =DESKTOP-GM3477H;uid=nhinth;pwd=123456789; Database = QuanLyKhoaHoc; TrustServerCertificate=True;";
            optionsBuilder.UseSqlServer(connect);
        }
    }
}
