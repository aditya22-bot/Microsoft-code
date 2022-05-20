using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class.opps
{
    interface IAnimal

    {
        void animalsound();

    }
    interface Baby
    {
        public void animalsound();
    }
    class kindar
    {
        public void animalsound()
        {
            Console.WriteLine("This is class call");
        }
    }
    class Pig:kindar, IAnimal,Baby
    {
        public void animalsound()
        {
            Console.WriteLine("Pig Class");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Pig mypig = new Pig();
            //IAnimal i = new IAnimal();
            mypig.animalsound();

        }
    }




























}
