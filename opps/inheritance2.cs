using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class.opps
{
    class Parant
    {
        public virtual void study()
        {
            Console.WriteLine("In parant class");
        }
    }
    class Child1 : Parant
    {
        public override void study()
        {
            Console.WriteLine("In child Class");
        }

    }
    class Child2 : Child1
    {
        public override void study()
        {
            Console.WriteLine("In Child 2");
        }
    }
    class Test
    {
        static void Main(string[] args)
        {
            Child1 c1 = new Child1();
            Parant p = new Parant();
            Parant p1 = new Child1();
            p1 = new Child2();
            p1.study();
            p1.study();
            p.study();
            c1.study();
        }


    }
    class Test1
    {
        static void Main(string[] args)
        {
            int add = 54;
            int a = add / 100;
            Console.WriteLine(a);
            int b = add / 10;

            int e = b % 10;
            Console.WriteLine(e);
            int f = add / 1;

            int g = f % 10;
            Console.WriteLine(g);
            if (a < e && e < g && a < g)
            {
                Console.WriteLine("Inceasing");
            }
            else if (a > e && a > g && e > g)
            {
                Console.WriteLine(" Deceasing");
            }
            else if (a < e && a > g)
            {
                Console.WriteLine("Bouncy");
            }

        }
    }
    class A
    {
        protected int a=20;
        private int  a2=10;
        internal string b="Aditya";
        private protected int  c=30;
        protected internal int d = 40;
        public static void Ground()
        {
            Console.WriteLine("INside Static Parant Method");
        }
        public  virtual void Study1()
        {
            Console.WriteLine("INside Parant class");
        }
        public void Play()//method hiding
        {
            Console.WriteLine("Inside Parant Play");
        }

    }
    //sealed=stop a sub class 
    class B : A
    {
        //sealed =cant call next sub class becaused of sealed of method
        public override void Study1()
        {
            Console.WriteLine("Inside Child Class"+a);
        }
        
        public  new void Play()
        {
            Console.WriteLine("Inside Play Child1",d);
        }
        //public static virtual Game()
        //{

        //}
        //sealed static method error comes can not sealed becaused is not override
        public static void Ground()
        {
            Console.WriteLine("Static Method Inside Child");
        }

    }
    
    class C : B
    {
        public override void Study1()
        {
            Console.WriteLine("Inside Child @2");
            
        }
        public new void Play()
        {
            Console.WriteLine("INside Play Child @2");
        }
    }
    class Test2
    {
        static void Main(string[] args)
        {
            //B b = new B();
            //b.Study1();//method Hiding
            A a = new C();
            //a.Study1();
            a.Play();
            //a.Study1();
            //A a1 = new B();
            //a1.Study1();
            //B a = new C();

            //a.Play();
            //B.Ground();
            
            
           // a.Study1();



        }
    }

}
