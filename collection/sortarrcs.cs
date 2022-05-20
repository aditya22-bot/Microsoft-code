using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Class.collection
{
    class sortarrcs : IComparable
    {
        string sname;
        int percent;
        string city;

        public string Sname { get => sname; set => sname = value; }
        public int Percent { get => percent; set => percent = value; }
        public string City { get => city; set => city = value; }

        public sortarrcs(string sname, int percent, string city)
        {
            this.sname = sname;
            this.percent = percent;
            this.city = city;
        }
        public override string ToString()
        {
            return $"Name {sname} City {city} Percent {percent}";
        }

        public int CompareTo(object o)
        {
            sortarrcs d = (sortarrcs)o;
            return d.percent.CompareTo(this.percent);
        }

    }
    class Aaa
    {
        static void Main(string[] args)
        {
            SortedList s = new SortedList();
            s.Add(new sortarrcs("aditya", 88, "nashik"), "c#");
            s.Add(new sortarrcs("pratik", 78, "nashik"), "c#");
            s.Add(new sortarrcs("om", 68, "nashik"), "c#");
            s.Add(new sortarrcs("tushar", 58, "nashik"), "c#");

            s.Add(new sortarrcs("ganesh", 18, "nashik"), "c#");
            foreach (dynamic x in s.Keys)
            {
                Console.WriteLine(x + " " + s[x]);
            }
        }
    }
    class mysort : IComparer
    {
        public int Compare(Object o1, object o2)
        {
            StringBuilder sb1 = (StringBuilder)o1;
            StringBuilder sb2 = (StringBuilder)o2;
            return sb1.ToString().CompareTo(sb2.ToString());
        }
    }
    class B
    {
        static void Main(string[] args)
        {
            SortedList s1 = new SortedList(new mysort());
            s1.Add(new StringBuilder("Aditya"), 90);
            s1.Add(new StringBuilder("pratik"), 90);
            s1.Add(new StringBuilder("sanket"), 90);
            s1.Add(new StringBuilder("jasprit"), 90);
            s1.Add(new StringBuilder("kajal"), 90);
            s1.Add(new StringBuilder("tiya"), 90);
            s1.Add(new StringBuilder("ciya"), 90);
            s1.Add(new StringBuilder("siya"), 90);
            ArrayList al = new ArrayList();
            al.Add(new StringBuilder("aditya"));
            al.Add(new StringBuilder("pratik"));
            al.Add(new StringBuilder("kalpesh"));
            al.Add(new StringBuilder("jasmin"));
            al.Add(new StringBuilder("ruturaj"));
            al.Add(new StringBuilder("dhoni"));
            al.Sort(new mysort());


        }
    }
    class W
    {
        static void Main(string[] args)
        {
            Stack st = new Stack();
            //st.Push(10);
            //st.Push(30);
            //st.Push(800);

            int[] a = { 9, 8, 7, 4, 5, 6, 3, 2, 1 };
            for (int i = 0; i < a.Length; i++)
            {
                st.Push(a[i]);
            }
            foreach (var i in st)
            {
                Console.WriteLine(i);
            }
        }

    }
    class O
    {
        static void Main(string[] args)
        {
            string s = "Hello";
            string s1 = "Hello";
            char[] c = { 'H', 'e', 'l', 'l', 'o' };
            string str1 = new string(c);
            foreach (char x in str1)
            {
                Console.Write(x + " ");
            }
            foreach (var x in s1)
            {
                Console.Write(x);
            }
        }
    }
    class P
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            al.Add(10);
            al.Add("Kik");
            al.Insert(0, 50);
            foreach (var i in al)
            {
                Console.WriteLine(i);
            }
            Queue<string> q = new Queue<string>();
            q.Enqueue("Add");
            q.Enqueue("Price");
            //Console.WriteLine( q.Dequeue("Add"));
            Console.WriteLine("___LinkList______");
            LinkedList<int> l = new LinkedList<int>();
            l.AddLast(90);
            l.AddLast(95);
            l.AddLast(100);
            l.AddLast(110);
            l.AddFirst(80);
            l.Remove(95);
            // l.Reverse<int>();
            LinkedListNode<int> nodebefore = l.Find(80);
            l.AddBefore(nodebefore, 75);
            l.AddAfter(nodebefore, 85);
            Console.WriteLine("Count" + l.Count());
            foreach (var i in l)
            {
                Console.WriteLine(i);
            }
            HashSet<string> a = new HashSet<string>();
            a.Add("Aditya");
            a.Add("pipsy");
            a.Add("Nikhil");
            HashSet<string> a1 = new HashSet<string>();
            a1.Add("Pipsy");
            a1.Add("Pratik");
            a1.Add("Aditya");




        }
    }
    class Subset
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            al.Add("Sun");
            al.Add("Mon");
            al.Add("Sat");
            al.Add("Sun");
            al.Add("Mon");
            al.Add("Sat");
            al.Add("Sun");
            al.Add("Sat");
            al.Add("Sun");
            al.Add("Mon");
            for (int i = 0; i < al.Count; i++)
            {
                int count = 0;
                for (int j = 0; j < al.Count - 1; j++)
                {
                    if (al[i] == al[j + 1] && j > i && i != j)
                    {
                        count++;
                    }
                }
                if (count == 1)

                    Console.WriteLine(al[i] + " " + count);
            }

        }
    }
    class Already
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            al.Add("Sun");
            al.Add("Mon");
            al.Add("Sat");
            al.Add("Sun");
            al.Add("Mon");
            al.Add("Sat");
            al.Add("Sun");
            al.Add("Sat");
            al.Add("Sun");
            al.Add("Mon");


            for (int i = 0; i < al.Count; i++)
            {
                int flag = 1;
                int count = 0;
                for (int j = i-1; j >= 0; j--)
                {
                    if (al[i] == al[j])
                    {
                        flag = 0;
                        break;
                    }
                }
                if (flag == 1)
                {
                    for (int j = i+1; j < al.Count; j++)
                    {
                        if (al[i] == al[j])
                        {
                            count++;   
                        }
                    }
                }
                if(count==1)
                {
                    Console.WriteLine(al[i]);
                }
            }
        }


    }
    class AAA
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            al.Add("Sun");
            al.Add("Mon");
            al.Add("Sat");
            al.Add("Sun");
            al.Add("Mon");
            al.Add("Sat");
            al.Add("Sun");
            al.Add("Sat");
            al.Add("Sun");
            al.Add("Mon");
            Console.WriteLine("Before Sort");
            foreach(var x in al)
            {
                Console.WriteLine(x);
            }
            al.Sort();
            Console.WriteLine("After Sort");
            foreach(var i in al)
            {
                Console.WriteLine(i);
            }
        }
    }
    class Ha
    {

        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            al.Add("pune");
            al.Add("Mumbai");
            al.Add("pune");
            al.Add("Mumbai");
            al.Add("Nasik");
            al.Add("pune");
            Hashtable h = new Hashtable();
            for (int i = 0; i < al.Count; i++)
            {
                int flag = 1;
                int count = 1;
                for (int j = i - 1; j >= 0; j--)
                {
                    if (al[i] == al[j])
                    {
                        flag = 0;
                        break;
                    }
                }
                if (flag == 1)
                {
                    for (int j = i + 1; j < al.Count; j++)
                    {
                        if (al[i] == al[j])
                        {
                            count++;
                        }
                    }
                }
                if (h.ContainsKey(al[i]))
                {
                    continue;
                }
                else
                {
                    h.Add(al[i], count);
                }
            }
            Console.WriteLine("!!!!!!!!!!!");
            foreach(var i in al)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("in Hash Table");
            foreach(DictionaryEntry k in h)
            {
                Console.WriteLine(k.Key+" "+k.Value);
            }
        }
    }
}
