using EF_02_NhanVien.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_02_NhanVien.IController
{
    interface IPhanCongController
    {
        string PhanCongNhanVien(PhanCong pc);
    }
}
