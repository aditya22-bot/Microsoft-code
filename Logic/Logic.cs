
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class.Logic
{
    class Logic
    {

        static void Main(string[] args)

        {
            int max = Convert.ToInt32(Console.ReadLine());
            int min = max / 2;

            Console.WriteLine(min);

            for (int i = 1; i <= max; i++)
            {
                for (int j = 1; j <= max; j++)

                {
                    if (j == 1 || j == min || i == max)
                    {
                        Console.Write("*");
                    }
                    else
                    {

                        Console.Write(" ");
                    }


                }
                Console.WriteLine();
            }
        }
    }
    class K
    {
        static void Main(string[] args)
        {
            int max = Convert.ToInt32(Console.ReadLine());
            int min = max / 2;

            Console.WriteLine(min);

            for (int i = 1; i <= max; i++)
            {
                for (int j = 1; j <= max; j++)

                {
                    if (j==1||(j==max-i))
                    {
                        Console.Write("*");
                    }
                    else
                    {

                        Console.Write(" ");
                    }


                }
                Console.WriteLine();
            }
        }
    }
    class Star
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 7; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine(" ");
            }
        }
        
    }
    class Star1
    {
        static void Main(string[] args)
        {
            for (int i = 7; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine(" ");
            }
        }

    }
    class Star2
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 7; i++)
            {
                for (int j = 1; j <=i; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine(" ");
            }
        }

    }
    class Star3
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <=7; i++)
            {
                for (int j = i; j <=7; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine(" ");
            }
        }

    }
    class Star4
    {
 /*
 5
45
345
2345
12345
 */
        static void Main(string[] args)
        {
            for (int i = 5; i >=1 ; i--)
            {
                for (int j = i; j <= 5; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine(" ");
            }
        }

    }
    class F
    {       
        static void Main(string[] args)
        {
                for (int i = 5; i >= 1; i--)
                {
                    for (int j = 5; j >= i; j--)
                    {
                        Console.Write(j);
                    }
                    Console.WriteLine(" ");
                }
        }

    }
    class E
    {
        static void Main(string[] args)
        {
            for(int i=1;i<=10;i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (j % 2 ==1 && i%2!=0)
                    {
                        Console.Write(j);
                        
                    }
                }
                Console.WriteLine("");

            }
        }
    }
    class G
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Enter Input");
            int max = Convert.ToInt32(Console.ReadLine());
            int min = max / 2;
            for(int i=1;i<=max;i++)
            {
                for (int j = 1; j <= max; j++)
                {
                    if (j==min )
                    {
                        Console.Write(" *");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                    
                
                }
                Console.WriteLine("");

            }
        }
    }
    

}

