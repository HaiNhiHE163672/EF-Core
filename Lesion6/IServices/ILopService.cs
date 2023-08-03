using Lesion6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesion6.IServices
{
     interface ILopService
    {
        List<Lop> GetLops();
        Lop GetLop(int LopId);
    }
}
