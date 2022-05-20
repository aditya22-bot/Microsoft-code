using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class.opps
{
    class Bank

    {
        public void Name1 ()
        {
            Console.WriteLine("Bank");
        }
        public void m1()
        {
            Console.WriteLine( "M1 Function");

        }
    }
    class HDFC:Bank
    {

        public void Name2()
        {
            Console.WriteLine("HDFC Bank");
        }
    }
    class ICIC:HDFC
    {
        public void Name3()
        {

            Console.WriteLine("ICIC Bank");
        }

    }
    class Inharitance
    {
        static void Main(string[] args)
        {
            ICIC c = new ICIC();
            c.Name1();

            
        }   


    }
}
