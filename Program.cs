using System;
namespace ConsoleApp1
{
    class App
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Area And Perimeter of a square is");
            Console.WriteLine("Enter a Side of square");

            int side = Convert.ToInt32(Console.ReadLine());
            int area = side * side;
            int perimeter = 4 * side;
            Console.WriteLine("Perimeter of square is " + perimeter);
            Console.WriteLine("Area of square is " + area);



        }

    }
    class B
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter NUmber of subjects You have");

            int sub = Convert.ToInt32(Console.ReadLine());
            int marks = 0;

            for (int i = 1; i <= sub; i++)
            {
                Console.WriteLine("Enter Subjects Marks");
                int marks1 = Convert.ToInt32(Console.ReadLine());
                marks += marks1;
            }
            Console.WriteLine("Average of subjects is " + marks / sub);
        }
    }
    class C
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Number");
            int number = Convert.ToInt32(Console.ReadLine());
            string c = number.ToString();
            int len = c.Length;
            int sum = 0;
            for (int i = 1; i <= len; i++)
            {
                int digit = number % 10;
                sum += digit;
                number = number / 10;
            }
            Console.WriteLine("Digit Sum " + sum);

        }
    }
    class D
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter seeling price");
            int val = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter how much descount(%) You want to give");
            int val1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Discounted Price is " + (val - val1));



        }
    }
    class j
    {

    }    
}