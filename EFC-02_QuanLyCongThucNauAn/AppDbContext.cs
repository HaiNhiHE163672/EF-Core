using EFC_02_QuanLyCongThucNauAn.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFC_02_QuanLyCongThucNauAn
{
    class AppDbContext : DbContext
    {
        public DbSet<LoaiMonAn> LoaiMonAn { get; set; }
        public DbSet<MonAn> MonAn { get; set; }
        public DbSet<CongThuc> CongThuc { get; set; }
        public DbSet<NguyenLieu> NguyenLieu { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connect = "Server =DESKTOP-GM3477H;uid=nhinth;pwd=123456789; Database = QuanLyCongThucNauAn; TrustServerCertificate=True;";
            optionsBuilder.UseSqlServer(connect);
        }
    }
}
