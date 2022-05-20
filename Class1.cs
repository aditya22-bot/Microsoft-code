using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class.opps
{
    class Class1
    {
        static void Main(string[] args)
        {
            //1.Write a C# program to check whether a year is leap year or not 
            Console.WriteLine("Enter Year");
            int val1 = Convert.ToInt32(Console.ReadLine());

            if ((val1 % 4 == 0) && (val1 % 100 != 0))
            {
                Console.WriteLine("Leap Year"+val1);
            }
            else if((val1%400==0) && (val1 %100==0))
            {
                Console.WriteLine("Leap Year "+val1);

            }
            else
            {
                Console.WriteLine("Not a Leap Year "+val1);
            }


        }
    }
    //Write a C# program to check whether a number is divisible by 5 and 11 or not 
    class cheak
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Number");
            int num = Convert.ToInt32(Console.ReadLine());
            if ((num % 5 == 0) && (num % 11 == 0))
            {
                Console.WriteLine("Number is divisible by 5 And 11");
            }
            else
            {

                Console.WriteLine("Not Number is divisible by 5 And 11 ");
            }


        }
    }
    //Write a C# program to find maximum between three numbers 
    class max
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Three Number");
            int num = Convert.ToInt32(Console.ReadLine());
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            if ((num>num1) &&(num>num2))
            {
                Console.WriteLine("Max Number "+num);

            }
           else if ((num1 > num2) && (num1 > num))
            {
                Console.WriteLine("Max Number " + num1);

            }
           else if ((num2 > num1) && (num2 > num))
            {
                Console.WriteLine("Max Number " + num2);

            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }

    }
    //Write a C# program to input any alphabet and check whether it is vowel or consonant 
    class vowel
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter alphabet to cheak wheter is vowel or consonant");
            char obj = Convert.ToChar(Console.ReadLine());
            if (obj == 'a' || obj == 'e' || obj == 'i' || obj == 'o' || obj == 'u')
            {
                Console.WriteLine(" alphabet Vowel ");


            }
            else
            {
                Console.WriteLine("Consonant");

            }
        }
    }
        //Write a C# program to create Simple Calculator 
    class add
    {
            static void Main(string[] args)
            {
                Console.WriteLine("Enter your Two Number");
                int obj = Convert.ToInt32(Console.ReadLine());
                int obj1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Your Choice 1:Add 2:Sub 3 mul 4:div");
                int ch = Convert.ToInt32(Console.ReadLine());
                if (ch == 1)
                {
                    Console.WriteLine("Addition"+(obj+obj1));
                }
                else if (ch == 2)
                {
                    Console.WriteLine("Subtraction" + (obj - obj1));
                }
                else if (ch == 3)
                {
                    Console.WriteLine("Multiplication" + (obj * obj1));
                }
                if (ch == 4)
                {
                    Console.WriteLine("Divison" + (obj / obj1));
                }




            }


    }
    //Write a C# program to check whether a number is negative, positive or 
    class number
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Number to cheak whether is postive negative or zero");
            int obj = Convert.ToInt32(Console.ReadLine());
            if ((obj > 0) )
            {
                Console.WriteLine("Number is Positive Number");


            }
            else if ((obj < 0) )
            {
                Console.WriteLine("Negative Number");
            }
            else if( obj==0)
            {
                Console.WriteLine("Zero Number");
            }
        }
    }
    //Write a C# program to input any character and check whether it is alphabet, digit or special character 
    class digit
    {


    }
    //Write a C# program to check whether a number is even or odd  
    class even
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Number To cheak Where is even or odd");
            int digit = Convert.ToInt32(Console.ReadLine());
            if (digit %2==0)
            {
                Console.WriteLine("Even Number");

            }
            else
            {
                Console.WriteLine("Odd Number");

            }
        }
    }
    //WAP a program to check whether entered number is 3 digit or not .If it is a 3 digit no. then do sum of 1st and 3rd digit and print sum
    class number1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Number");
            int digit11 = Convert.ToInt32(Console.ReadLine());
            string c = Convert.ToString(digit11);
            int num = Convert.ToInt32(c.Length);

            if (num == 3)
            {
             //123
                int first11 = digit11 / 10;
                
                int last11 = first11 % 10;
                Console.WriteLine(last11);
                //Console.WriteLine("Sum OF FIrst And last DIgit Number is " + (first11+last11));

            }
            else
            {
                Console.WriteLine("Length is less then 3");
            }



        }
    }
    //Write a C# program to enter number between 1to 5 and print it in word
    class C1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number In a Range of (1-5)");
            String ch1 = Console.ReadLine();
            if (ch1 == "1")
            {
                Console.WriteLine("One");

            }
            else if (ch1 == "2")
            {
                Console.WriteLine("Two");

            }
            else if (ch1 == "3")
            {
                Console.WriteLine("Three");
            }
            else if (ch1 == "4")
            {
                Console.WriteLine("Four");

            }
            else if (ch1 == "5")
            {
                Console.WriteLine("Five");
            
            }
            else
            {

                Console.WriteLine("Invalid Number");

            }
        }
    }
    // For any integer input not between 1 to 7 it should display "error, day does not exist"
    class A1
    {
        static void Main(string[] args)
        {
            Console.WriteLine(  "Enter Number");
            int ch = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < ch; i++)
            {
                if (ch< 7)
                {
                    Console.WriteLine("Error");
                    break;
                }
                else
                {
                    Console.WriteLine("Valid");
                    break;

                }
            }
        }

    }
     //A bank intends to design a program to display the denomination of an input amount.The available denomination with the bank are of rupees 2000, 500, 200, 100, 50, 20, 10 and 1.
    class D11
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Amount");
            int ch = Convert.ToInt32(Console.ReadLine());
            int ch1 = ch / 2000;
            int ch11 = ch % 2000;
            int ch2 = ch11 / 500;
            int ch22 = ch11 % 500;
            int ch3 = ch22 / 200;
            int ch33 = ch22 % 200;
            int ch4 = ch33 / 100;
            int ch44 = ch33 % 100;
            int ch5 = ch44 / 50;
            int ch55 = ch44 % 50;
            int ch6 = ch55 / 20;
            int ch66 = ch55 % 20;
            int ch7 = ch66 / 10;
            int ch77 = ch66 % 10;
            Console.WriteLine("2000 Notes "+ch1);
            Console.WriteLine("500 Notes " + ch2);
            Console.WriteLine("200 Notes " + ch3);
            Console.WriteLine("100 Notes " + ch4);
            Console.WriteLine("50 Notes " + ch5);
            Console.WriteLine("20 Notes " + ch6);
            Console.WriteLine("10 Notes " + ch7);
        }
    }
    //Write a C# program to create Simple Calculator using switch case Menu Driven 
    class E
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Press Two Number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("press 1.ADDITION 2.SUBTRACTION 3.MULTIPLICATION 4.DIVISION");
            int ch = Convert.ToInt32(Console.ReadLine());
            switch (ch)
            {

                case 1:
                    Console.WriteLine("Addition Of Number is "+(num1+num2));
                        
                    break;
                case 2:
                    Console.WriteLine("Subtraction Of Number is " + (num1 - num2));

                    break;
                case 3:
                    Console.WriteLine("Multiplication Of Number is " + (num1 * num2));

                    break;
                case 4:
                    if (num2!=0)
                    {
                        Console.WriteLine("Divison Of Number is " + (num1 / num2));

                    }
                    else
                        Console.WriteLine(  "Num2 Not be Zero");

                    break;
            }



        }
    }
    //Write a program that displays the day of the week corresponding to the number entered-   1 - "Monday", 2- "Tuesday" and so on.

    class F
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Presss 1-7 To Know week Day comes in Perticular Number");
            int ch = Convert.ToInt32(Console.ReadLine());
            switch(ch)
            {
                case 1:
                    Console.WriteLine("Sunday");
                    break;

                case 2:
                    Console.WriteLine("Monday");
                    break;
                case 3:
                    Console.WriteLine("Tusday");
                    break;
                case 4:
                    Console.WriteLine("wenasday");
                    break;
                case 5:
                    Console.WriteLine("Thousday");
                    break;
                case 6:
                    Console.WriteLine("Friday");
                    break;
                case 7:
                    Console.WriteLine("Saterday");
                    break;
            }
        }
    }
    // in C# using switch case for following: Area of a circle Area of a square Area of a right angled triangle Area of a rectangle Circumference of a circle Perimeter of a square Accept inputs like radius,side,etc through keyboard. //Menu driven program using switch case:
    class G
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Radius");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Side");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("1.Area of circle\n2.Area Of square\n3.Area of righ angle triangle\n4.Area of rectangle \n5.Circumference of a circle\n6.Perimeter of a Square");
            int ch = Convert.ToInt32(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    Console.WriteLine("Area of Circle "+(3.14f*num*num));
                    break;
                case 2:
                    Console.WriteLine("Length ");

                    int a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Height " );

                    int b = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Area of Right Angle Triangle "+(a*b)/2);
                    break;
                case 3:
                    Console.WriteLine("Length ");

                    int a1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Width ");

                    int b1 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Area of rectangle " + (a1*b1));
                    break;
                case 4:
                    Console.WriteLine("Circumfarance of a circle "+(2*3.14f*num));
                    break;
                case 5:
                    Console.WriteLine("Perimeter of a square "+(4*num1));
                    break;
                case 6:
                    Console.WriteLine("Area of Square "+num1*num1);
                    break;
                default:
                    Console.WriteLine("Default");
                    break;
            }
        }
    }
    // Write a C# program to input basic salary of an employee and calculate its 
    //Gross salary according to following:
    //Basic Salary <= 10000 : HRA = 20%, DA = 80% 
    //Basic Salary <= 20000 : HRA = 25%, DA = 90% 
    //Basic Salary >20000 : HRA = 30%, DA = 95% 
    class Sal
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Salary");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num <= 10000)
            {
                int BasicSal = Convert.ToInt32(num + (num * 0.2));
                int sal = Convert.ToInt32(BasicSal + (BasicSal * 0.8));
                Console.WriteLine("Basic Salary " + sal);


            }
            else if (num <= 20000)
            {
                int BasicSal = Convert.ToInt32(num + (num * 0.25));
                int sal = Convert.ToInt32(BasicSal + (BasicSal * 0.9));
                Console.WriteLine("Basic Salary " + sal);
            }
            else if(num>20000)
            {
                int BasicSal = Convert.ToInt32(num + (num * 0.3));
                int sal = Convert.ToInt32(BasicSal + (BasicSal * 0.95));
                Console.WriteLine("Basic Salary " + sal);

            }
            else
            {

                Console.WriteLine("Invalid Input");
            }
        }


    }
    class X
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Number");
            int n = Convert.ToInt32(Console.ReadLine());
            int c = 1;

            int j = 1;
            int sum = 0;
            int k = 0;
            for (int i = 1; i <= n; i++)
            {
                sum = sum + j * c;
                Console.WriteLine(sum);
                k += sum;
                c *= 10;
               
            }
            Console.WriteLine(k);
        }


    }
}



