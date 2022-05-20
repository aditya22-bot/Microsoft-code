using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Home.opps;
namespace Class.opps
{
    class Papa
    {
        public void age()
        {
            Console.WriteLine("Age is 50");

        }
    }
    class Child:Papa
    {

        public void Age()
        {

            Console.WriteLine("Age is 25");
        }


    }
    class Call
    {
        static void Main(string[] args)
        {
            Child c = new Child();
            c.Age();
            c.age();

        }

    }
}
