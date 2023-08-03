using EFC_02_QuanLyCongThucNauAn.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFC_02_QuanLyCongThucNauAn.Interface
{
    interface IMonAnController
    {
        void DSCongthuc();
        void TimKiemDanhSachTheoNguyenLieuHanhToi(string search);
        string ThemMonMoi(MonAn monAn);
    }
}
