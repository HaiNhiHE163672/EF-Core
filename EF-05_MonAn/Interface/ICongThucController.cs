using EF_05_MonAn.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_05_MonAn.Interface
{
    interface ICongThucController
    {
        string ThemCongThuc(CongThuc congThuc, int MonAnId);
        string ThemDanhSachCongThuc(List<CongThuc> list);
    }
}
