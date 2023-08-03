using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFC_02_QuanLyCongThucNauAn.Helper
{
    class InputHelper
    {
        public int So(string a)
        {
            int num;
            while (true)
            {
                Console.Write($"Nhap {a}: ");
                if (int.TryParse(Console.ReadLine(), out num))
                {
                    if (num > 0)
                    {
                        return num;
                    }
                    else
                    {
                        Console.WriteLine($"{a} phai lon hon 0");
                    }
                }
                else
                {
                    Console.WriteLine($"{a} phai la so");
                }
            }
        }
        public string Ten(string a, int gh)
        {
            while (true)
            {
                Console.Write($"Nhap {a}: ");
                string b = Console.ReadLine();
                if (b.Trim().Length > 0 && b.Length <= gh)
                {
                    return b;
                }
                else
                {
                    Console.WriteLine($"{a} khong duoc qua {gh} ky tu");
                }
            }
        }
    }
}
