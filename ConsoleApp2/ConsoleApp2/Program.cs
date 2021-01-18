using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace giaiptb1
{
    class Program
    {
        static void Main(string[] args)
        {
            float x;
            Console.WriteLine("Nhap he so a:");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap he so b:");
            float b = float.Parse(Console.ReadLine());
            if (a == 0)
            {
                if (b == 0)
                    Console.WriteLine("Phuong trinh vo so nghiem");
                else
                    Console.WriteLine("Phuong trinh vo nghiem");
            }
            else
            {
                x = -b / a;
                Console.WriteLine("Phuong trinh co nghiem = " + x);
            }
            Console.ReadKey();
        }
    }
}