using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class.opps
{
    class Movie
    {
        String male_Actor, Female_Actor, Director,Producer,Movie_name;
        float rating;
        
        public void Set_male_Actor(String a)
        {
            male_Actor = a;
        }
        public String Get_male_Actor()
        {
            return male_Actor;
        }
        public void Set_female_Actor(String b)
        {
            Female_Actor = b;
            
        }
        public String Get_female_Actor()
        {
            return male_Actor;
        }
        public void Set_Director_Name(String c)
        {
            Director = c;
        }
        public String Get_Director_Actor()
        {
            return male_Actor;
        }
        public void Set_Producer_Name(String e)
        {
            Movie_name = e;
        }
        public String Get_Producer_Actor()
        {
            return male_Actor;
        }
        public void Set_Movie_Name(String f)
        {
            Movie_name = f;

        }
        public String Get_Movie_Name()
        {
            return male_Actor;
        }
        public void Set_rating(float g)
        {
            rating = g;

        }
        public String Get_rating()
        {
            return male_Actor;
        }
        static void Main(string[] args)
        {
            Movie m = new Movie();
            while(true)
            {
                Console.WriteLine("Enter Actor Name");
                m.Set_male_Actor(Console.ReadLine());
                Console.WriteLine("Enter Female Actor");
                m.Set_female_Actor(Console.ReadLine());
                Console.WriteLine("Enter Director Name");
                m.Set_Director_Name(Console.ReadLine());
                Console.WriteLine("Enter Producer Name");
                m.Set_Producer_Name(Console.ReadLine());
                Console.WriteLine("Enter Movie Name");
               
                //m.Set_Movie_Name(float.Parse(Console.ReadLine()));
                Console.WriteLine("Enter ratinr");
                m.Set_rating(Convert.ToInt32(Console.ReadLine()));
                Console.WriteLine(m.Get_male_Actor);
                Console.WriteLine(m.Get_female_Actor);
                Console.WriteLine(m.Get_Director_Actor);
                Console.WriteLine(m.Get_Producer_Actor);
                Console.WriteLine(m.Get_Movie_Name);
                Console.WriteLine(m.Get_rating);


            }

        }
    }
    class Aditya
    {
        public static int Intance1;
        public static float instance2;
        public int instance3;
        public float instance4;

        public static void instance_fuctioin1()
        {
           Intance1 = 78;

            
            Console.WriteLine("Instance1");
            
            
            
        }
        public static void instance_fuctioin2()
        {
            instance2 = 8.4f;
            Console.WriteLine("Instance2");

        }
        public  void instance_fuctioin3()
        {
            instance3 = 99;
            Console.WriteLine("Instance3");

        }
        public  void instance_fuctioin4()
        {
            instance4 = 7.6f;
            Console.WriteLine("Instance4");

        }
        static void Main(string[] args)
        {
            Console.WriteLine(  Aditya.Intance1);
            Console.WriteLine(Aditya.instance2);
            Aditya.instance_fuctioin1();
            Aditya.instance_fuctioin2();
            Aditya s = new Aditya();
            Console.WriteLine(   s.instance3 = 100);
            Console.WriteLine( s.instance4 = 7.7f);
            s.instance_fuctioin3();
            s.instance_fuctioin4();

        }
    }
}
