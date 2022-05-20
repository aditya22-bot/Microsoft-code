using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class.opps
{
    class Emplyee

    {
        float Emplyee_Salary;
        string Emplyee_Name;
        int Emplyee_id;
        int In_Hand_salary;
        //hra 10% salary

        //pf 5% salary

        Emplyee()
        {
            Emplyee_Salary = 50000f;
            Emplyee_Name = "Aditya";
            Emplyee_id = 1;
            float k = 0.1f;
            Console.WriteLine("Hra" + Emplyee_Salary * k);
            float g = 0.05f;
            Console.WriteLine("Pf " + Emplyee_Salary * 0.05);
            float k1 = k + g;
            float In_Hand_salary = Emplyee_Salary * k1;
            Console.WriteLine(k1);


            Console.WriteLine("In Hand Salary" + In_Hand_salary);
        }
        Emplyee(int a, string b, int c)
        {
            Emplyee_id = a;
            Emplyee_Name = "Nkhade";
            Emplyee_Salary = 45666;

        }

        static void Main(string[] args)
        {
            Emplyee c = new Emplyee();//default call
            Emplyee c1 = new Emplyee(10, "Nikhade", 2);//Para Call
        }
    }
    class Cheak11
    {

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int c = 1;
            //1 3 7 15
            //1 3 
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(c);
                int k=c++;
                c += k;
                
            }
        }

    }
    class Abc
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inside Main Block");
            int n = Convert.ToInt32(Console.ReadLine());
            bool k = true;
            for(int i=2;i<=n;i++)
            {
                for(int j=2;j<=n; j++)
                {
                    if(i!=j && i%j==0)
                    {
                        k = false;
                        break;
                    }

                }
                if(k)
                {
                    Console.WriteLine(i);
                }
                k = true;
            }

        }


    }
}
