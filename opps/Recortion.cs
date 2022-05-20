using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class.opps
{
    class Recortion
    {
        public static void m1(int n,int k)
        {
            int e = 1;
            e = e + 2;

            Console.WriteLine(k);
            if(n>0)
            {

                m1(n - 1, k + 2);
                
            }
        }
        public static void m2()
        {

            Console.WriteLine(  "Odd Number");
            m1(5,1);
        }
        static void Main(string[] args)
        {
            Recortion.m2();
        }
    }
    class Number
    {
        public static void k(int n)
        {
            if(n>0)
            {
                Console.WriteLine(n);

                k(n - 1);
            }

        }
        public static void k1(int s)
        {
            Console.WriteLine("Number Range from 5 To 1");
            k(s);
        }
        static void Main(string[] args)
        {
            Number.k1(5);
        }

    }
    class Factorial
    {
        public static int fact(int c)
        {
            if(c==1)
            {
                return 1;
            }
            else
            {
                int ans = fact(c - 1);
                return c * ans;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Factorial.fact(5));
        }

    }
}
