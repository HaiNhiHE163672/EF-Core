using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFC_01_QuanLyTrungTam.Helper
{
    class InputHelper
    {
        public string Name(string a, int min, int max)
        {
            while(true)
            {
                Console.Write($"Nhap {a}: ");
                string b = Console.ReadLine();
                if(b.Length >= min && b.Length <= max)
                {
                    return b;
                }
                else
                {
                    Console.WriteLine($"{a}: bắt buộc, từ {min}-{max} kí tự");
                }
            }
        }
        public DateTime Ngay(string a)
        {
            DateTime date;
            while(true)
            {
                Console.Write($"Nhap {a}: ");
                if(DateTime.TryParse(Console.ReadLine(), out date))
                {
                    if(date <= DateTime.Now)
                    {
                        return date;
                    }
                    else
                    {
                        Console.WriteLine($"{a} phai nho hon hoac bang ngay hien tai");
                    }
                }
                else
                {
                    Console.WriteLine($"Nhap {a} khong dung dinh dang");
                }
            }
        }
        
    }
}
