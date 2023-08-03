using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_03_KhoaHoc.Helper
{
     class InputHelper
    {
        public int Id(string a)
        {
            int num;
            while(true)
            {
                Console.Write($"{a} : ");
                if(int.TryParse(Console.ReadLine(), out num) )
                {
                    if(num > 0)
                    {
                        return num;
                    }
                    else
                    {
                        Console.WriteLine("ID khong dung vui long nhap so lon hon 0");
                    }
                }
                else
                {
                    Console.WriteLine("Nhap vao phai la so");
                }
            }
        }
        public string Name(string a)
        {
            while(true)
            {
                Console.Write($"{a} : ");
                string name = Console.ReadLine();
                if (name.Trim().Length > 0)
                {
                    return name;
                }
                else
                {
                    Console.WriteLine("Nhap vao khong duoc de trong");
                }
            }
        }
        public string HoTen()
        {
            while (true)
            {
                Console.Write("Nhap Ho Ten Hoc Vien: ");
                string hoTen = Console.ReadLine();
                if(hoTen.Length >= 2 && hoTen.Length <= 20)
                {
                    return hoTen;
                }
                else
                {
                    Console.WriteLine("Ho Ten khong duoc qua 20 ky tu, co it nhat 2 tu");
                }
            }
        }
        public string TenKhoaHoc()
        {
            while (true)
            {
                Console.Write("Nhap Ho Ten Khoa Hoc: ");
                string ten = Console.ReadLine();
                if (ten.Length <= 10)
                {
                    return ten;
                }
                else
                {
                    Console.WriteLine("Ten Khoa Hoc khong duoc qua 10 ky tu");
                }
            }
        }
        public DateTime NgaySinh()
        {
            DateTime date;
            while (true)
            {
                Console.Write("Nhap Ngay Sinh: ");
                if(DateTime.TryParse(Console.ReadLine(), out date))
                {
                    if(date < DateTime.Now)
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
        public DateTime Ngay(string a)
        {
            DateTime date;
            while (true)
            {
                Console.Write($"{a}: ");
                if (DateTime.TryParse(Console.ReadLine(), out date))
                {
                    return date;
                }
                else
                {
                    Console.WriteLine($"{a} khong hop le");
                }
            }
        }
        public int HocPhi()
        {
            int hp;
            while (true)
            {
                Console.Write("Nhap Hoc Phi: ");
                if(int.TryParse(Console.ReadLine(), out hp))
                {
                    if(hp > 0 && hp < 10000000)
                    {
                        return hp;
                    }
                    else
                    {
                        Console.WriteLine("Hoc Phi phai lon hon 0 va be hon 10 trieu");
                    }
                }
                else
                {
                    Console.WriteLine("Hoc phi phai la so");
                }
            }
        }
    }
}
