using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class.opps
{
    class Array
    {
        static void Main(string[] args)
        {
            int[] a = new int[5];
            int even = 0;
            int odd = 0;
            for(int i=0;i<a.Length;i++)
            {
                Console.WriteLine($"Position {i} Add");
                a[i] = Convert.ToInt32(Console.ReadLine());

            }
            for(int j=0;j<a.Length;j++)
            {
                if (a[j]%2==0)
                {
                    even++;
                }
                else
                {
                    odd++;
                }
            }
            Console.WriteLine($"Even Number Count {even} And Odd {odd}");
        }
    }
    class Merge
    {



        static void Main(string[] args)
        {
            int[] a = { 1, 22, 44, 55, 66 ,100};
            int[] b = { 44, 556, 77, 88, 5 };
            int[] c = new int[a.Length + b.Length];
            

            for(int i=0;i<a.Length;i++)
            {
                c[i] = a[i];
            }
            int k1 = a.Length;
            

            for(int k=0;k<b.Length;k++)
            {
                c[k1] = b[k];
                k1++;

            }
            for(int j=0;j<c.Length;j++)
            {
                Console.WriteLine(c[j]);
            }
            
        }
    }
    class Reverse
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 22, 44, 55, 66 };
            int[] b = { 44, 556, 77, 88, 5 };
            int[] c = new int[a.Length + b.Length];

            int d = 0;
            for(int i=a.Length-1;i>=0;i--)
            {
                c[d] = a[i];
                d++;
            }
            int g = a.Length;
            for(int j=0;j<b.Length;j++)
            {
                c[g] = c[j];
                g++;
            }
            for(int i=0;i<c.Length;i++)
            {
                Console.WriteLine(c[i]);
            }


        }
    }
    class Alternate
    {

        static void Main(string[] args)
        {
            int[] a = { 1, 22, 44, 55, 66 };
            int[] b = { 44, 556, 77, 88, 5 };
            int[] c = new int[a.Length + b.Length];

            int g = 0;
            int k = 1;
            for(int i=0;i<a.Length;i++)
            {
                c[g] = a[i];
                c[k] = b[i];
                g = g + 2;
                k = k + 2;

            }
            for(int k1=0;k1<c.Length;k1++)
            {
                Console.WriteLine(c[k1]);
            }
        }
    }
    class Miss
    {

        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 5 ,6,7,8,9};
            int[] b = { 1, 2, 3, 4, 5 };
            

            if(a.Length>b.Length)
            {
                int[] c = new int[a.Length ];
                for(int i=0;i<a.Length;i++)
                {
                    for(int j=0;j<b.Length;j++)
                    {
                        c[i] = a[i] + b[j];

                    }

                }
                for(int i=0;i<c.Length;i++)
                {
                    Console.WriteLine(c[i]);
                }
            }


        }
    }
    class K
    {

        static void Main(string[] args)
        {
            int[] a = { 1, 22, 44, 55, 66, 100 };
            int[] b = { 44, 556, 77, 88, 5 ,60};
            int[] c = new int[a.Length + b.Length];
            for(int i=0;i<c.Length;i++)
            {
                if(i%2==0 && i==0)
                {
                    c[i] = a[i];
                }
                else
                {
                    c[i] = b[i];
                }
            }

        }

    }
}
