using EF_03_KhoaHoc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_03_KhoaHoc.Interface
{
     interface IHocVienController
    {
        string SuaThongTin(HocVien hv);
        void TimKiem(string search);
    }
}
