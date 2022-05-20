using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class.opps
{
    class Student
    {
        string Collage_name;
        int Number_of_Student;
        string deparment;
        public Student()
        {
            Collage_name = "D y";


        }
      
    


    }
    class Flat
    {
        int flatno;
        string buildingname;
        Owner name = new Owner();
        public int Flatno
        {
            get { return flatno; }
            set { flatno = value; }

        }
        public string Buildingname
        {
            get { return buildingname; }
            set { buildingname = value; }

        }
        public Owner Name
        {

            set { name = value; }
            get { return name; }
        }
        public Flat()
        {
            flatno = 74;
            buildingname = "Park";
            name.Age = 40;
            name.Gendar = "Female";
            name.Owner_name = "Sakshi";
        }
        public Flat(int a,string b,int c,string d,string e)
        {
            flatno = a;
            buildingname = b;
            name.Age = c;
            name.Gendar = d; 
            name.Owner_name = e;

        }

    }
    class Owner
    {
        string owner_name;
        int age;
        string gendar;
        public string Owner_name
        {
            get { return owner_name; }
            set { owner_name = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public string Gendar
        {
            get { return gendar; }
            set { gendar = value; }

        }


    }
    class test
    {
        static void Main(string[] args)
        {
            Flat k = new Flat();
            Flat k1 = new Flat(45,"K wing",45,"Nish","Female");
            //k.Buildingname = "K Wing";
            //k.Flatno = 45;
            //k.Name.Age = 40;
            //k.Name.Owner_name = "Aditya";
            //k.Name.Gendar = "Male";
            Console.WriteLine("Default Constructor");
            Console.WriteLine($"{k.Buildingname} \n{k.Flatno}\n{k.Name.Age }\n{k.Name.Owner_name}\n{k.Name.Gendar}");
            Console.WriteLine("Paramatric Constructor");
            Console.WriteLine($"{k1.Buildingname} \n{k1.Flatno}\n{k1.Name.Age }\n{k1.Name.Owner_name}\n{k1.Name.Gendar}");

        }
    }

    
}
