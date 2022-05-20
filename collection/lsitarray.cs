using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace Class.collection
{
    class Cheak<T>
    {
        T a;
        public void ADD(T b)
        {
            a = b;
        }
        public T get()
        {
            return a;
        }
    }
    class BB
    {
        static void Main(string[] args)
        {
            Cheak<string> a = new Cheak<string>();
            //a.ADD(30);
            a.ADD("Ad");
            ArrayList al = new ArrayList();
            al.Add("Aditya");
            //Allow Different type of data is allowing hetrogenus
            al.Add("Nikhade");
            al.Add("pip");
            //al.Add("Zinger");
            string[] k = { "om", "kajal", "Tejal" };
            Stack<string> a11 = new Stack<string>();
            a11.Push("samadhan");
            a11.Push("Anjali");
            Console.WriteLine(a11.Append("kaljal"));
            List<string> s = new List<string>()
            {
                "Aditya","Nikhade","Pratik","Raju","Kismat"
            };
            s.AddRange(a11);
            IEnumerable<string> e=s.Append("More");
            
            
           al.CopyTo(k);

            foreach(var i in e)
            {
                Console.WriteLine(i);
            }
            Dictionary<string, int> dd = new Dictionary<string, int>();
            dd.Add("A", 900);
            dd.Add("B", 45);
            foreach(KeyValuePair<string,int> h in dd)
            {
                Console.WriteLine(h.Key+" "+h.Value);
            }


          
        }
    }
    class I
    {
        static void Main(string[] args)
        {
            SortedList<student, int> g = new SortedList<student, int>();
            g.Add(new student("Aditya", 56, "java"), 96);
            g.Add(new student("Pratik", 55, "python"), 96);
            g.Add(new student("Sahil", 66, "c sharp"), 96);
            g.Add(new student("Lokesh", 11, "c"), 96);
            g.Add(new student("Rahul", 22, "c++"), 96);
            foreach(dynamic c in g)
            {
                Console.WriteLine(c);
            }
        }

    }
}
