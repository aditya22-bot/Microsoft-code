using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
     class A
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Charater");
            char b = Convert.ToChar(Console.ReadLine());
            int a = (int)b;
            int res = 0;
            if (a > 97 && a < 122)
            {
                Console.WriteLine((char)(a - 32));

            }
            else if (a > 65 && a < 90)
            {
                Console.WriteLine((char)(a + 32));
            }
            else
            {
                Console.WriteLine("Wrong");
            }
        }
    }
    class B1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Year");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(a%4==0?"leap Year":"Not Leap Year");
        }
    }
}
