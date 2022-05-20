using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class.String11
{
    class Str
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a String");
            string ch = Console.ReadLine();

            for(int i=0;i<ch.Length;i++)
            {
                Console.WriteLine(ch[i]);
            }
            Console.WriteLine();
        }


    }
    class Res
    {
        static void Main(string[] args)
        {
            string s = "maddam";
            int len = s.Length;
            int count = 0;
            int cal = 1;
            for(int i=s.Length-1;i>0;i--)
            {
                if(s[i]==s[count])
                {
                    count++;
                    cal++;
                }
                else
                {
                    count++;
                }
               
            }
            if(len==cal)
            {
                Console.WriteLine("Palindrome");
            }
            else
            {
                Console.WriteLine("Not Palindrome");
            }

        }
    }
}
