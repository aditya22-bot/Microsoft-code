using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class.opps
{
    class Book
    {
        
       public String Author,Book_Name;
       public int Year_Of_Publish,Price;

        static void Main(string[] args)
        {
            Book s = new Book();
            s.Author = "Aditya";
            s.Book_Name = "Xyz";
            s.Year_Of_Publish = 2014;
            s.Price = 780;
            Console.WriteLine(s.Author);
            Console.WriteLine(s.Book_Name);
            Console.WriteLine(s.Year_Of_Publish);
            Console.WriteLine(s.Price);    

        }
    }
    class Book1
    {
        static void Main(string[] args)
        {
            Book s1 = new Book();
            Console.WriteLine( "Enter Author Name" );
            s1.Author = Console.ReadLine();
            Console.WriteLine("Enter Book Name");
            s1.Book_Name = Console.ReadLine();
            Console.WriteLine("Enter Year Of Publish");
            s1.Year_Of_Publish = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Price Of book");
            s1.Price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(s1.Author);
            Console.WriteLine(s1.Book_Name);
            Console.WriteLine(s1.Year_Of_Publish);
            Console.WriteLine(s1.Price);

        }
    
    }
    class Book2

    {
        public int Sum(int a, int b)
        {
            //Console.WriteLine("My Name Is Aditya Nikhade");
            return a + b;

        }
        static void Main(string[] args)
        {
            Book2 a = new Book2();
            int sum = a.Sum(10, 30);
            Console.WriteLine("Sum of Two Number Is" + sum);

        }
    }


        class Calculator
        {
            public int Sum(int a, int b)
            {
                return a + b;
            }
            public float Simpleintrast(int p, float r, int t)
            {
                return p * r * t;
            }
            public bool Is_leap_Year(int a)
            {
                if (a % 4 == 0)
                {
                    return true;

                }
                else
                {
                    return false;
                
                }
            }

            static void Main(string[] args)
            {
                Calculator cal = new Calculator();
                Console.WriteLine("Enter Two Number For Addition");
                int a = Convert.ToInt32(Console.ReadLine());
                int b = Convert.ToInt32(Console.ReadLine());

                int sum=cal.Sum(a, b);
                Console.WriteLine(  $" Sum OF Number IS => {sum}");
                Console.WriteLine("Calculate Simple Intrest");
                Console.WriteLine("1 Principal");
                int p = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("2 Annual Interst rate");
                float r = Convert.ToInt32(Console.ReadLine()); 
                Console.WriteLine("3 Term Of loan in Year");
                int t = Convert.ToInt32(Console.ReadLine());
                float s = cal.Simpleintrast(p, r, t);
                Console.WriteLine("Simple Interst "+s);
                Console.WriteLine("Enter Year To calCulate Is Leap Year Or Not");
                int y = Convert.ToInt32(Console.ReadLine());
                bool yy = cal.Is_leap_Year(y);
                Console.WriteLine(yy);


            }


        }
    }
