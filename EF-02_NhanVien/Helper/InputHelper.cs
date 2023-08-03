using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_02_NhanVien.Helper
{
     class InputHelper
    {
        public int ID(string a)
        {
            int num;
            while (true)
            {
                Console.Write($"{a}: ");
                if(int.TryParse(Console.ReadLine(), out num) )
                {
                    if(num > 0)
                    {
                        return num;
                    }
                    else
                    {
                        Console.WriteLine($"{a} phai lon lon hon 0");
                    }
                }
                else
                {
                    Console.WriteLine($"{a} phai la so");
                }
            }
        }
        public string name(string a)
        {
            while (true)
            {
                Console.Write($"{a}: ");
                string b = Console.ReadLine();
                if(b.Trim().Length > 0 )
                {
                    return b;
                }
                else
                {
                    Console.WriteLine($"{a} khong duoc trong va khong duoc null");
                }
            }
            
        }
        public string HoTen()
        {
            while (true)
            {
                Console.Write("Nhap Ho Ten: ");
                string b = Console.ReadLine();
                if (b.Length <= 20 && b.Length >= 2)
                {
                    return b;
                }
                else
                {
                    Console.WriteLine("Ho ten khong duoc qua 20 ky tu, co it nhat 2 tu");
                }
            }
        }
        public string TenDuAn()
        {
            while (true)
            {
                Console.Write("Nhap Ten Du An: ");
                string b = Console.ReadLine();
                if (b.Length <= 10 && b.Length >= 1)
                {
                    return b;
                }
                else
                {
                    Console.WriteLine("Ten du an khong duoc qua 10 ky tu");
                }
            }
        }
    }
}
