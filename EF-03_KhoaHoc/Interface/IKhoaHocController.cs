using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EF_03_KhoaHoc.Interface
{
     interface IKhoaHocController
    {
        string XoaKhoaHoc(int id);
        void DoanhThu();

    }
}
