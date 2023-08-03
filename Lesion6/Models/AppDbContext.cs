using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesion6.Models
{
     class AppDbContext : DbContext
    {
        public DbSet<Lop> Lops { get; set; }
        public DbSet<HocSinh> HocSinhs { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connect = "Server =DESKTOP-GM3477H;uid=nhinth;pwd=123456789; Database = QuanLyHocSinh; TrustServerCertificate=True;";
            optionsBuilder.UseSqlServer(connect);
        }
        

    }
}
