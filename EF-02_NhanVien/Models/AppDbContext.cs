using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_02_NhanVien.Models
{
     class AppDbContext : DbContext
    {
        public DbSet<NhanVien> NhanVien { get; set; }
        public DbSet<PhanCong> PhanCong { get; set; }
        public DbSet<DuAn> DuAn { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connect = "Server =DESKTOP-GM3477H;uid=nhinth;pwd=123456789; Database = QuanLyNhanVien; TrustServerCertificate=True;";
            optionsBuilder.UseSqlServer(connect);
        }

    }
}
