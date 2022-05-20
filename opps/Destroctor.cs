using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class.opps
{
    class Constroctor
    {
        public Constroctor()
        {
            Console.WriteLine("Inside Constroctor");
        }
        ~ Constroctor()
        {
            Console.WriteLine("Inside Desctorctor");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Inside main");
            Constroctor c = new Constroctor();

        }
    }
}
