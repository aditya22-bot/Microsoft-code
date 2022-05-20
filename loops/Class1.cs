using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class.loops
{
     class Class1
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

        }
    }
    class Loop
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 6; i++)
            { 
                for(int j=6;j>=i;j--)
                {
                    Console.Write(" ");

                }
                for(int k=i;k<=6;k++)
                {
                    Console.Write(k);

                }
                Console.WriteLine();
            
            }
        }
    
    }
    /*
*
***
*****
*******
*********
     */
    class L
    {
        static void Main(string[] args)
        {
            for (int i = 1; i<=10; i+=2)
            { 
                if(i%2!=0)
                {
                    for(int j=1;j<=i;j++)
                    {
                        Console.Write("*");
                    }
                }
                Console.WriteLine("");
            }
        }
    }
    class M
    {
        static void Main(string[] args)
        {
            Console.WriteLine("No of Rows");
            int a = Convert.ToInt32(Console.ReadLine());
            for(int i=1;i<=a;i++)
            {
                for(int j=1;j<=a-i;j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }
                for (int s = 1; s <= i; s++)
                {
                    Console.Write("*"  );
                }
                Console.WriteLine("");

            }
        }

    }
    class G
    {
        static void Main(string[] args)
        {
            
        }
    }
}
