using EF_05_MonAn.Controllers;
using EF_05_MonAn.View;

namespace EF_05_MonAn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MonAnView monAn = new MonAnView();
            monAn.ThucThi();
        }
    }
}