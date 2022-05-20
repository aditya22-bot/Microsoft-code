using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class.Exception
{
    class Class1
    {
        static string s="ai";
        static void Main(string[] args)
        {
            
            try
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine("Division="+a/b);
                Console.WriteLine("Try ends");
                Console.WriteLine(s[2]);
            }
            catch (System.Exception e)
            {
                Console.WriteLine("error");
            }


        }
    }
    class InvalidMobileException:System.Exception
    {
       public InvalidMobileException(string s) : base(s)
        {

        }
    }
    class Mobile
    {
      public  static void mob(int num)
        {
          
            try
            {
                if(num<10)
                {
                    throw new InvalidMobileException("INvalid Mobile Number");

                }
            }
            catch(InvalidMobileException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        static void Main(string[] args)
        {
            int[] a = new int[10];
            int count = 1;
            for(int i=0;i<a.Length;i++)
            {
                Console.WriteLine("Enter Mobile Number");
                a[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("You Want to add(yes/no)");
                string c = Console.ReadLine().ToLower();
                if(c=="yes")
                {
                    count++;
                    continue;
                    
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(count);
            mob(count);
        }
    }
    class A
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Mobile Number");
            string s = Console.ReadLine();
            char []a=s.ToCharArray();
            Console.WriteLine(a.Length);
           // Mobile m = new Mobile();
            Mobile.mob(a.Length);

        }
    }
    //WAP to use catch / handle NullReferenceRange exception. 
    //WAP to catch multiple exceptions. i.IndexOutOfRangeException and DivideByZeroException
    //WAP to show use of multiple catch block with universal Exception handler.
    //WAP to create user defined Exception  and raise and catch the exception.


    class Excep
    {
        static string s="A";
       
        
       

        static void Main(string[] args)
        {
            int[] a = { 4, 2, 3 };
            try
            {
                Console.WriteLine(s.ToLower());
                
                try 
                {
                    Console.WriteLine(a[0]);
                }
                catch (IndexOutOfRangeException e)
                {
                    Console.WriteLine(e.Message);
                }
                try
                {
                    throw new UserDefineException("Denger Erroe");
                }
                catch(UserDefineException e)
                {
                    Console.WriteLine(e.Message);
                }
            } 
            catch(NullReferenceException e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
    }
    class UserDefineException:System.Exception
    {
        public UserDefineException(string s):base(s)
        {

        }
    }
}
