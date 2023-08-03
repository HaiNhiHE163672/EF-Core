using Lesion6.IServices;
using Lesion6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesion6.Services
{
    class LopService : ILopService
    {
        protected AppDbContext dbContext { get; }
        public LopService()
        {
            dbContext = new AppDbContext();
        }

        public Lop GetLop(int id)
        {
            Lop l = dbContext.Lops.SingleOrDefault(x => x.LopId== id);
            if(l != null)
            {
                return l;
            }
            throw new Exception("Lop Khong ton tai");
        }

        public List<Lop> GetLops()
        {
            return dbContext.Lops.AsQueryable().ToList();
        }
    }
}
