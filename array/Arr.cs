using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class.array
{
    class Sort
    {
        static void Main(string[] args)
        {
            int[] a = { 5, 2, 3, 7, 9, 6, 5, 4 };
            Array.Sort(a);
            
            for(int i=0;i<a.Length;i++ )
            {
                Console.WriteLine(a[i]); 
            }
        }
    }
    class arr
    {
        static void Main(string[] args)
        {
            int[,] a = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 } };
            for(int i=0;i<a.GetLength(0);i++)
            {
                for(int j=0;j<a.GetLength(1);j++)
                {
                    Console.Write(a[i,j]);
                }
                Console.WriteLine();
            }
        }
    }
    class arr_max
    {
        static void Main(string[] args)
        {
            int[,] a = { { 1, 2, 3, 4 }, { 50, 6, 7, 8 } };
            int max =a[0,0];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if(max<a[i,j])
                    {
                        max = a[i, j];
                    }
                    Console.Write(a[i,j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine(max);

        }
    }
    class Arr_Max_Row
    {

        static void Main(string[] args)
        {
            int[,] a = { { 4, 11, 3, 4 }, { 50, 6, 60, 8 } };
            
            
            //1,2,3,4=>4
            //50,6,7,8=>50
            //========
           // 50 6 7 8

            for(int i=0;i<a.GetLength(0);i++)
            {
                int row_max = a[0, 0];
                
                int k = 0;
                int b = 0;
                int column_max = a[i, 0];
                for (int j=0;j<a.GetLength(1);j++)
                {
                    

                    if (row_max < a[i, j])
                    {
                        row_max = a[i, j];

                    }
                    


                }
                Console.WriteLine($"Row {i} Max "+row_max);

            }




        }
    }
    //2.	WAP to create a array of 10 elements and swap first two elements with last two elements.
    class Swap
    {
        static void Main(string[] args)
        {
            int[] a = { 5, 11, 22, 5, 66, 77, 88, 66, 44, 12, 6 };
            int[] k = new int[a.Length];
            int len = a.Length;
            k[0] = a[len - 1];
            k[1] = a[len - 2];
            k[k.Length - 1] = a[0];
            k[k.Length - 2] = a[1];
            
            for(int i=2;i<a.Length-2;i++)
            {
                k[i] = a[i];
            }
            for(int j=0;j<a.Length;j++)
            {
                Console.Write(k[j]+"\t");

            }

        }

    }
//    4.	How to rearrange array in alternating positive and negative number[2]
//Input: {1, 2, 3, -4, -1, 4}
//Output: { -4, 1, -1, 2, 3, 4}

    class Arrange
    {

        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, -4, -1, 4 };
            int[] b = new int[a.Length];
            int count = 0;
            for(int i=0;i<a.Length;i++)
            {
                if(a[i]<0)
                {
                    b[count] = a[i];
                    count++;

                }
                
                    
                
            }
            for(int j=0;j<b.Length;j++)
            {
                Console.WriteLine(b[j]);
            }

        }
    }
    class Diagonal
    {
        static void Main(string[] args)
        {
            int[,] a111 = { { 4, 11, 3},
                            { 50, 6, 60 } };
            
                           
            for(int i=0;i<a111.GetLength(0);i++)
            {
                for(int j=0;j<a111.GetLength(1);j++)
                {
                    int k = a111.GetLength(0);
                    if(i==k)
                    {
                        Console.WriteLine(a111[i,j]);
                        k--;

                    }

                }
            }
        }
    }
    class JaggedArray
    {
        static void Main(string[] args)
        {
            int[][] a = new int[3][];
            a[0] = new int[5];
            a[1] = new int[2];
            a[2] = new int[3];

            for (int i = 0;i<a.GetLength(0);i++)
            {
                Console.WriteLine($"Enter {a[i].Length} element in row {i}");
                for(int j=0;j<a[i].Length;j++)
                {
                    a[i][j] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }
        
        
    }
    class Shift
    {
        static void Main(string[] args)
        {
            int[] a = new int[5];
            a[0] = 10;
            a[1] = 30;
            a[2] = 40;

            Console.WriteLine(" Position To Add");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Value");
            int v = Convert.ToInt32(Console.ReadLine());
            for(int i=a.Length-1;i>n;i--)
            {
                a[i] = a[i - 1];
            }
            a[n] = v;
            for(int i=0;i<a.Length;i++)
            {
                Console.WriteLine(a[i]);
            }

        }

    }
    class practice
    {
        public static Boolean isPresent(int []a,int n)
        {
            bool isa= false;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == n)
                {
                    isa=true;
                }
                else
                {
                    isa=false;
                }
            }
            return isa;
            
        }
        
        static void Main(string[] args)
        {
            int [] a = { 7, 8, 6, 5, 2 };
            Console.WriteLine("Enter Number To Cheak");
            int find = int.Parse(Console.ReadLine());
            bool b = isPresent(a, find);
            if(b==true)
            {
                Console.WriteLine("Present");
            }
            else
            {
                Console.WriteLine("Not Present");
            }
        }
    }
    class q
    {
        static void Main(string[] args)
        {
            int[] a = { 7, 8, 4, 5, 6, 2, 1, 8, 9, 3, 5, 4 };
            for(int i=0;i<a.Length;i++)
            {
                int count = 1;
                bool isvisited = false;
                for(int k=i-1;k>=0;k--)
                {
                    if(a[i]==a[k])
                    {
                        isvisited = true;
                        break;
                    }
                }
                if(isvisited==false)
                {
                    for(int j=i+1;j<a.Length;j++)
                    {
                        if(a[i]==a[j])
                        {
                            count++;
                        }
                    }
                }
                if(count==1)
                {
                    Console.WriteLine($"Unique Element{a[i]}");
                }
            }
        }
    }
    class Bubble
    {
        static void Main(string[] args)
        {
        int[] a = { 8, 5, 6, 23, 45, 98, 45 };

            foreach (int x in a)
            {
                Console.Write(x+" ");
            }
            for(int i=0;i<a.Length;i++)
            {
                for(int j=i+1;j<a.Length;j++)
                {
                    if(a[i]>a[j])
                    {
                        int temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }
            Console.WriteLine("//////////////");
            foreach(int x in a)
            {
                Console.Write(x+" ");
            }
        }

    }
    class qq
    {
        static void Main(string[] args)
        {
            int[] a = { 5, 2, 3,6, 7, 9, 6, 5, 4 };
            for(int i=0;i<a.Length;i++)
            {
                int count = 0;
                for(int j=0;j<a.Length;j++)
                {
                    if(a[i]==a[j] && j>i && i!=j)
                    {
                        count++;
                    }
                }
                if(count>0)
                {
                    Console.WriteLine(a[i]);
                }
            }
        }
    }
    class Aaa
    {
        static void Main(string[] args)
        {

        }
    }
}
