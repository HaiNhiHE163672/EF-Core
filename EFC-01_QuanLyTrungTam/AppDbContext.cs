using EFC_01_QuanLyTrungTam.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFC_01_QuanLyTrungTam
{
    class AppDbContext : DbContext
    {
        public DbSet<HocVien> HocVien { get; set; }
        public DbSet<Lop> Lop { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connect = "Server =DESKTOP-GM3477H;uid=nhinth;pwd=123456789; Database = QuanLyTrungTamIelts; TrustServerCertificate=True;";
            optionsBuilder.UseSqlServer(connect);
        }
    }
}
