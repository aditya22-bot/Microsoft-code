using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class.Deligates1
{
    class Class1
    {
        public int Square(int n)
        {
            return n * n;
        }
        public delegate int mydeligate(int k);
        static void Main(string[] args)
        {
            Class1 c = new Class1();
            mydeligate f = c.Square;
            int pro = f(10);
            Console.WriteLine(pro);
        }
    }
    class A
    {
        public static void Factrorial(int n)
        {
            int fact = 1;
            for(int i=1;i<=n;i++)
            {
                fact = fact * i;
            }
            Console.WriteLine(fact);
        }
        public delegate void mydel(int p);
        static void Main(string[] args)
        {
            mydel d = Factrorial;
            d.Invoke(5);
        }
    }
    public delegate void del(int k, int p);
    class AA
    {
        public static void Add(int a,int b)
        {
            Console.WriteLine("sum "+a+b);
        }
        public static void Sub(int a,int b)
        {
            Console.WriteLine("Subtraction "+(a-b));
        }
        public static void Mul(int a,int b)
        {
            Console.WriteLine("Multiplication"+a*b);
        }
        static void Main(string[] args)
        {
            del d = Add;
            d += Sub;
            d += Mul;
            d -= Add;

            d.Invoke(4, 5);

        }
        
    }
}
