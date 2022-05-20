using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class.String11
{
    class Class1
    {
        static void Main(string[] args)
        {
            //string? s = Console.ReadLine();
            //string k = Console.ReadLine();
            string s = "AdityaA";
            string k = "Adi";
            int count = 0;
            s=s.ToLower();
            k = k.ToLower();

            for(int i=0;i<k.Length;i++)
            {
                Console.WriteLine(k[i]);
                for(int j=0;j<s.Length;j++)
                {
                    if(k[i]==s[j])
                    {
                        count++;
                    }
                }
            }
            if(count==k.Length)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("No");
            }


        }
    }
    class A
    {
        static public int freq(string s, char ch)
        {
            int c = 0;
            for(int i=0;i<s.Length;i++)
            {
                if(s[i]==ch)
                {
                    c++;
                }
            }
            return c;
        }
        static void Main(string[] args)
        {
            string s = "Aditya".ToLower();
            string f = "Adi".ToLower();
            bool isfound = true;
            foreach(char c in f)
            {
                int ori = freq(s, c);
                int sea = freq(f, c);
                if(ori<sea)
                {
                    isfound = false;
                }
            }

        }
    }
    interface Cheak
    {
        public void m1();
    }
    interface Che
    {
        public void m1();
        public void m2();
        public void m3()
        {
            Console.WriteLine("Interface 2 M3 Invoked");
        }
    }
    class K : Cheak, Che
    {
        public void m1()
        {
            throw new NotImplementedException();
        }

        public void m2()
        {
            throw new NotImplementedException();
        }
    }
    class Find
    {
        static void Main(string[] args)
        {
            int[] a = { 1,2, 3, 4, 5, 7, 8, 9 };
            
            int first = a[0];
            int c = 0;
            for(int i=0;i<a.Length;i++)
            {
                if(first==a[i])
                {
                    c++;
                    //Console.WriteLine("In IF"+c);
                    first++;
                }
                else
                {
                    
                    c++;
                    //Console.WriteLine("In Else"+c);

                    first++;
                    break;

                }
                
            }
            Console.WriteLine("Array Missing Number"+  c);
        }
    }
}
