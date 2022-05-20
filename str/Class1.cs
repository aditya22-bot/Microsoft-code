using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class.str
{
    class Class1
    {
        static void Main(string[] args)
        {
            string fname, lname;
            fname = "Aditya";
            lname = "Nikhade";

            char[] let = { 'A', 'D', 'E', 'I', 'T' };
            string[] str1 = { "Aditya", "Rajendra", "Nikhade" };
            string fullname = fname +" "+ lname;
            Console.WriteLine(fullname);
            string gree = new string(let);
            Console.WriteLine("greeting:{0}",gree);
            string mess = String.Join(" ", str1);
            Console.WriteLine(mess);
            Console.WriteLine("message: "+mess);
            DateTime wait = new DateTime(2012, 10, 10, 17, 58, 1);
            string chat = string.Format("");
            Console.WriteLine("================");
            string str2 = "This is test";
            string str3 = "This is test";
            if(string.Compare(str2,str3)==0)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not Equal");
            }
            
            Console.WriteLine(str2.CompareTo(str3));
        
            if(str2.Contains("test"))
            {
                Console.WriteLine("Test Is Found");
            }

            string str4 = "Last Night i dreamt of san pedro";
            Console.WriteLine(str4);
            string substr = str4.Substring(23);
            //string p = substr.Substring();
            Console.WriteLine(substr);
        }

    }
}
