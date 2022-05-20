using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class.opps
{
    class constructor
    {
        int empid;
        String name;
        public constructor()
        {
            empid = 10;
            name = "Aditya";
            Console.WriteLine("Defeult contrictor");

        }
        public constructor(int id,String name )
        {
            empid = id;
            this.name = name;
            Console.WriteLine("Paramatric Constructor");
        }
        static void Main(string[] args)
        {
            constructor con = new constructor();
            Console.WriteLine(con.name+" "+con.empid);
            constructor conn = new constructor(101, "Nikhade");
            Console.WriteLine(conn.empid+" "+conn.name);
        }

    }
    class Country
    {
        string country_name;
        string capital;
        int no_of_States,no_of_Language;
        public string Country_name
        {
            get
            {
                return country_name;
            }
            set
            {
                country_name = value;
            }

        }
        public string Capital
        {

            get 
            {
                return capital; 
            }
            set { capital = value; }
        }
        public int No_of_States
        {
            get { return no_of_States; }
            set { no_of_States = value; }
        }
        public int No_of_Language
        {
            get { return no_of_Language; }
            set { no_of_Language = value; }
        }
        static void Main(string[] args)
        {
            Country co = new Country();
            co.no_of_Language = 30;
            co.no_of_States = 32;
            co.capital = "Delhi";
            co.country_name = "India";
            Console.WriteLine();



        }

    }

}
