using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesion6.Helper
{
     class InputHelper
    {
        public string Hoten()
        {
            while (true)
            {
                Console.WriteLine("Nhap Ho Ten: ");
                string name = Console.ReadLine();
                if(name.Length >= 2 && name.Length <= 20)
                {
                    return name;
                }
                else
                {
                    Console.WriteLine("Hoten khong duoc qua 20 ky tu, co it nhat 2 tu!");
                }
            }
        }
        public DateTime Ngaysinh()
        {
            DateTime dob;
            while (true)
            {
                Console.WriteLine("Nhap Ngay Sinh: ");
                if(DateTime.TryParse(Console.ReadLine(), out dob))
                {
                    if(dob.Year >= 2001 && dob.Year <= 2013)
                    {
                        return dob;
                    }
                    else
                    {
                        Console.WriteLine("Ngay Sinh phai la cua hoc sinh tu nam 2001-2013");
                    }
                }
                else
                {
                    Console.WriteLine("Dinh dang phai la thoi gian");
                }
            }
        }
        public string Quequan()
        {
            while (true)
            {
                Console.WriteLine("Nhap Que Quan: ");
                string name = Console.ReadLine();
                if (name.Trim().Length > 0)
                {
                    return name;
                }
                else
                {
                    Console.WriteLine("Que quan phai co chua it  nhat ten 1 thanh pho");
                }
            }
        }
        public string TenLop()
        {
            while (true)
            {
                Console.WriteLine("Nhap ten lop: ");
                string name = Console.ReadLine();
                if(name.Length <= 10)
                {
                    return name;
                }
                else
                {
                    Console.WriteLine("Ten lop khong duoc qua 10 ky tu");
                }
            }
        }
        public int SiSo()
        {
            int s;
            while(true)
            {
                Console.WriteLine("Nhap Si So: ");
                if(int.TryParse(Console.ReadLine(), out s))
                {
                    if (s <= 20)
                    {
                        return s;
                    }
                    else
                    {
                        Console.WriteLine("Moi lop co si so ti da la 20 hoc sinh");
                    }
                }
                else
                {
                    Console.WriteLine("Dinh dang phai la so nguyen duong");
                }
            }
        }

    }
}
