using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class APP
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 2 Number");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("a="+a+"b"+b);
            Console.WriteLine("a={0}b={1}",a,b);

            Console.WriteLine($"a{a}b{b}");
        }

    }
    class Divion
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter  Number");
            int num = Convert.ToInt32(Console.ReadLine());
            
            if (num %7==0 || num%10==7)
                    Console.WriteLine("Buzz Number");
            else
                    Console.WriteLine("Not Buzz Number");

        }
    }
}