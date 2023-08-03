using EF_04_PhieuThu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_04_PhieuThu.Interface
{
    interface IPhieuThuController
    {
        string ThemPhieuThu(PhieuThu pt);
        string XoaPhieuThu(int id);
        void DSPhieuThu(List<PhieuThu> list);
    }
}
