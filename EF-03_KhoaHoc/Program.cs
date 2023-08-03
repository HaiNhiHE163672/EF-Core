using EF_03_KhoaHoc.Controller;
using EF_03_KhoaHoc.View;

namespace EF_03_KhoaHoc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            KhoaHocView k = new KhoaHocView();
            k.ThucThi();
        }
    }
}