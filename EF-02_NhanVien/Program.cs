using EF_02_NhanVien.Controller;
using EF_02_NhanVien.Models;
using EF_02_NhanVien.View;

namespace EF_02_NhanVien
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NhanVienView nv = new NhanVienView();
            nv.ThucThi();
        }
    }
}