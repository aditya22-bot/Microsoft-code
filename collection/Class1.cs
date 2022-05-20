using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace Class.collection
{
    class Class1
    {
        //collection hierarche growable in nature
        //hetrogenous non generic
        static void Main(string[] args)
        {
            ArrayList a = new ArrayList();
            a.Add("Aditya");
            a.Add(90);
            a.Add("Aditya");
            a.Add(true);
            a.Add("Aditya");
            a.Add(4.56);
            a.Remove("Aditya");
            a.RemoveAt(3);
            a.Reverse();
            for(int i=0;i<a.Count;i++)
            {
                Console.WriteLine( a[i]);
            }

        }
        
    }
    class has
    {

        string name;

        public has(string name)
        {
            this.name = name;
        }

        public override string ToString()
        {
            return name ;
        }
        static void Main(string[] args)
        {
            ArrayList a = new ArrayList()
            {
                "Patik","jayesh","sanket"
            };
            
            ArrayList a1 = new ArrayList()
            {
                "om","paske"
            };
            
            Hashtable h = new Hashtable();
            h.Add("A", 10);
            h.Add("b", 20);
            h.Add('c', a);
            h.Add('d', a1);

            //Console.WriteLine(h.Keys);
            //Console.WriteLine(h.Values);
            foreach (var q in h.Values)
            {
                Console.WriteLine(q);
            }

        }
    }
    class A
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee() { EmpId = 100, EmpName = "Aditya" };
            Console.WriteLine(emp);
        }
    }
    class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        //public override string ToString()
        //{
          //  return this.EmpId + " " + this.EmpName;
        //}
    }
    class Home
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            al.Add(10);
            al.Add(20);
            al.Add(30);
            al.Add(40);
            al.Add(40);
            al.Add(30);
            al.Add(20);
            al.Add(10);
            al.Add(60);
            al.Add(100);
            al.Add(20);
            al.Add(50);
            
            
            for(int i=0;i<al.Count;i++)
            {
                int count = 1;
                bool isvisited = false;
                for (int j=i-1;j>=0;j--)
                {
                    if(al[i]==al[j])
                    {
                        isvisited = true;
                        break;
                    }
                }
                if (isvisited == false)
                {
                    for (int j = i + 1; j < al.Count; j++)
                    {
                        if (al[i] == al[j])
                        {
                            count++;
                        }
                    }
                }
                Console.WriteLine(al[i]+" "+count);
            }
            

        }
    }
    class pot
    {
        string name;
        int number;
       static public void Poten(string s,int count)
        {
            int max = count;
            if(count<max)
            {
                Console.Write(s+ " ");
            }
            else
            {
                Console.Write(s+" ");
            }
        }
        static void Main(string[] args)
        {
            Hashtable h = new Hashtable();

            string s = "THE SKY IS PIPE LIMIT";
            string[] k = s.Split(" ");
            int index = 0;
            int count=0;
            for (int j=0;j<k.Length;j++)
            {
                
                char[] c = k[j].ToArray();
                count=0;

                for (char i = 'A'; i <= 'Z'; i++)
                {
                    
                    count++;
                    
                    for (int a = 0; a < c.Length; a++)
                    {
                        if (i == c[a])
                        {
                            index += count;
                            
                        }
                      
                    }
            
                }
                pot.Poten(k[j], index);
                Console.WriteLine(k[j]+" "+index);
               //h.Add(k[j], index);
                index = 0;


                //Console.WriteLine(k[j]+" "+count-index);
            }
          


        }
    }
    class Player
    {
        int playerid;
        string name;
        string country;
        string team;
        static int count = 0;
        public override string ToString()
        {
            return "id: " + playerid + " Name: " + name + " country: " + country + " team:" + team;
        }
        public int Playerid { get => playerid; set => playerid = value; }
        public string Name { get => name; set => name = value; }
        public string Country { get => country; set => country = value; }
        public string Team { get => team; set => team = value; }
        
        Player(int playerid,string name,string country,string team)
        {
            this.playerid = playerid;
            this.name = name;
            this.country = country;
            this.team = team;
            if(country=="Australia" && team=="RCB")
            {
                count++;
            }
        }
        static void Main(string[] args)
        {
            Player p = new Player(1, "Ms Dhoni", "India", "Channai");
            Player p1 = new Player(2, "curry", "Australia", "RCB");
            Player p2= new Player(1, "Santnor", "India", "Channai");
            Player p3= new Player(1, "Ab Devilers", "Australia", "RCB");

            Console.WriteLine(p);
            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine(p3);
            Console.WriteLine("Australian Player Count "+Player.count);

        }
    }
    //5.	Write a program to get the value of a specified key in a HashTable
    // and also update the value for given key.

    class Q
    {
        static void Main(string[] args)
        {
            Hashtable s = new Hashtable();
            //it does not maintain a insertion order
            s.Add("key1",1);
            s.Add("key2", 2);
            s.Add("key3", 3);
            s.Add(2, 4);
            s.Add("key5", 5);
            //updating
            s["key5"] = 8;
            s["key3"] = 30;
            s[2] = 0;

            foreach(var i in s.Keys)
            {
                Console.WriteLine("key: "+i+" value "+s[i]);
            }


        }
    }
    	//Write a program to get a set of keys contained in HashTable and
        //print whole HashTable using for each loop.
    class U
    {
        int keys;
        string value1;

        public int Keys
        {
            set { keys = value; }
            get { return keys; }
        }
        public string Value
        {
            set { value1 = value; }
            get{ return value1; }
        }
    }
    class H
    {
        static void Main(string[] args)
        {
            U u = new U();
            Hashtable h = new Hashtable();
            h.Add(u.Keys = 1, u.Value = "Aditya");
            h.Add(u.Keys = 2, u.Value = "Tejal");
            h.Add(u.Keys = 3, u.Value = "More");
            h.Add(u.Keys = 4, u.Value = "Nikhade");
            foreach(var i in h.Keys)
            {
                Console.WriteLine("keys "+i+" value "+h[i]);
            }
        }
    }
  //  7.	Create a HashTable where key is integers 1 to 10 and string is number in Words.Remove entry for which number is divisible by 3.
  class Aa
    {
        static void Main(string[] args)
        {
            Hashtable h = new Hashtable();
            h.Add(1, "one");
            h.Add(2, "Two");
            h.Add(3, "three");
            h.Add(4, "four");
            h.Add(5, "Five");
            h.Add(6, "six");
            h.Add(7, "seven");
            h.Add(8, "eight");
            h.Add(9, "Nine");
            h.Add(10, "ten");


            ArrayList al = new ArrayList();
            foreach (int x in h.Keys)
            {
                if(x%3==0)
                {
                    al.Add(x);
                }
                

            }
            for(int i=0;i<al.Count;i++)
            {

                h.Remove(al[i]);
                //Console.WriteLine(al[i]);
            }
            foreach(dynamic c in h.Keys)
            {
                Console.WriteLine(c+" "+h[c]);
            }
            
            
            
            
            
           // h.Remove(count);
            //Console.WriteLine("count_out" + count);


           // foreach (dynamic j in h.Keys)
            //{
              //  Console.WriteLine("keys "+j+" value "+h[j]);
            //}
        }
    }
    class hast
    {
        static void Main(string[] args)
        {

            char[] a = { 'a', 'b', 'c', 'd', 'e', 'b', 'a' };
            Hashtable h = new Hashtable();

            for(int i=0;i<a.Length;i++)
            {
                if(h.ContainsKey(a[i]))
                {
                    char k = a[i];
                    int val=(int)h[k];
                    h[k] = val + 1;
                }
                else
                {
                    h.Add(a[i], 1);
                }
            }
            foreach(dynamic k in h.Keys)
            {
                Console.WriteLine(k+" "+h[k]);
            }
            
        }
    }
    class Pra
    {
        static void to_string(dynamic [] k)
        {

        }
        static void Main(string[] args)
        {
            Hashtable h = new Hashtable();
            ArrayList al = new ArrayList()
            {
                "Aditya",40,40.5,true
            };
            ArrayList al2 = new ArrayList()
            {
                "Aditya",40,40.5,true
            };
            to_string(al);
            
        }
        public override string ToString()
        {
            return base.ToString();
        }
        private static void to_string(ArrayList al)
        {
            
            
            for(int i=0;i<al.Count;i++)
            {
                Console.WriteLine(al[i]);
            }
        }
    }
    class AA
    {
        static void Main(string[] args)
        {

        }
    }

}
