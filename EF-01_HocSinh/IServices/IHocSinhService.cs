using Lesion6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesion6.IServices
{
     interface IHocSinhService
    {
        List<HocSinh> GetHocSinhs();
        HocSinh GetHocSinh(int id);
        string ThemHocSinh(HocSinh hs);
        string SuaThongTin(HocSinh hs);
        string XoaHocSinh(int HocSinhId);
        string ChuyenLop(int id, int LopId);
    }
}
