using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_04_PhieuThu.Helper
{
    class InputHelper
    {
        public int ID(string input)
        {
            int num;
            while (true)
            {
                Console.Write($"{input}: ");
                if(int.TryParse(Console.ReadLine(), out num) )
                {
                    if(num > 0)
                    {
                        return num;
                    }
                    else
                    {
                        Console.WriteLine($"{input} phai lon hon 0");
                    }
                }
                else
                {
                    Console.WriteLine($"{input} phai la so");
                }
            }
        }
        public string Name(string input)
        {
            string a;
            while(true)
            {
                Console.Write($"{input}: ");
                a = Console.ReadLine();
                if(a.Trim().Length > 0 )
                {
                    return a;
                }
                else{
                    Console.WriteLine($"{input} khong duoc de trong va rong");
                }
            }
        }
        public string TenLoai(string input)
        {
            string a;
            while (true)
            {
                Console.Write($"{input}: ");
                a = Console.ReadLine();
                if (a.Trim().Length > 0 && a.Length <= 20)
                {
                    return a;
                }
                else
                {
                    Console.WriteLine($"{input} khong duoc rong hoac qua 20 ky tu");
                }
            }
        }
        public string Donvitinh()
        {
            string a;
            while (true)
            {
                Console.Write("Nhap Don Vi Tinh: ");
                a = Console.ReadLine();
                if (a.Trim().Length > 0 && a.Length <= 10)
                {
                    return a;
                }
                else
                {
                    Console.WriteLine($"Don vi tinh khong duoc rong hoac qua 10 ky tu");
                }
            }
        }
        public DateTime Ngay()
        {
            DateTime date;
            while (true)
            {
                Console.Write("Nhap Ngay Lap: ");
                if (DateTime.TryParse(Console.ReadLine(), out date))
                {
                    if (date <= DateTime.Now)
                    {
                        return date;
                    }
                    else
                    {
                        Console.WriteLine("Ngay sinh khong hop le");
                    }
                }
                else
                {
                    Console.WriteLine("Ngay sinh khong hop le");
                }
            }
        }

    }
}
