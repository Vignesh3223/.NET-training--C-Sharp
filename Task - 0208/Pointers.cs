using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Task___0208
{

    internal class Pointers
    {
        public unsafe static void GetDetails()
        {
            Console.WriteLine("Trainee Details");
            Console.WriteLine("************************");
            Console.WriteLine("Enter Employee ID : ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee Name : ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Employee Department : ");
            string dept = Console.ReadLine();
            int* ptr1 = &id;
            string* ptr2 = &name;
            string* ptr3 = &dept;
            Console.WriteLine("\nProperty Value");
            Console.WriteLine("--------------");
            Console.WriteLine("Value of id : {0}", id);
            Console.WriteLine("Value of name : {0}", name);
            Console.WriteLine("Value of department :{0}", dept);
            Console.WriteLine("\nProperty Address");
            Console.WriteLine("--------------");
            Console.WriteLine("Address of id: {0}", (int)ptr1);
            Console.WriteLine("Address of name: {0}", (int)ptr2);
            Console.WriteLine("Address of department:{0}", (int)ptr3);
            Console.WriteLine("\n************************\n");
        }

        public static void Swapmethod()
        {
            unsafe
            {
                Console.WriteLine("Swapping Integer Values");
                Console.WriteLine("************************");
                Console.WriteLine("Enter first value : ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter second value: ");
                int b = Convert.ToInt32(Console.ReadLine());
                int* p1 = &a;
                int* p2 = &b;
                Console.WriteLine("\nValues Before Swapping");
                Console.WriteLine("--------------");
                Console.WriteLine("Value of a : {0}", a);
                Console.WriteLine("Value of b : {0}", b);
                *p1 = *p1 + *p2;
                *p2 = *p1 - *p2;
                *p1 = *p1 - *p2;
                Console.WriteLine("\nValues After Swapping");
                Console.WriteLine("--------------");
                Console.WriteLine("Value of a : {0}", a);
                Console.WriteLine("Value of b : {0}", b);
                Console.WriteLine("\n************************\n");
                Console.WriteLine("Swapping Character Values");
                Console.WriteLine("************************");
                Console.WriteLine("enter first value : ");
                char x = Convert.ToChar(Console.ReadLine());
                Console.WriteLine("enter second value: ");
                char y = Convert.ToChar(Console.ReadLine());
                char* ptr1 = &x;
                char* ptr2 = &y;
                Console.WriteLine("\nvalues before swapping");
                Console.WriteLine("--------------");
                Console.WriteLine("value of x : {0}", x);
                Console.WriteLine("value of y : {0}", y);
                *ptr1 = Convert.ToChar(*ptr1 + *ptr2);
                *ptr2 = Convert.ToChar(*ptr1 - *ptr2);
                *ptr1 = Convert.ToChar(*ptr1 - *ptr2);
                Console.WriteLine("\nvalues after swapping");
                Console.WriteLine("--------------");
                Console.WriteLine("value of x : {0}", x);
                Console.WriteLine("value of y : {0}", y);
                Console.WriteLine("\n************************\n");
            } 
        }
        public unsafe static void MatrixAddition()
        {
            Console.WriteLine("Enter the number of rows: ");
            int Rows = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number of columns: ");
            int Columns = Convert.ToInt32(Console.ReadLine());
            int[,] matrix1 = new int[Rows, Columns];
            int[,] matrix2 = new int[Rows, Columns];
            int[,] result = new int[Rows, Columns];

            Console.WriteLine("Enter elements of First Matrix: ");
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    matrix1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Enter elements of Second Matrix: ");
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    matrix2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("\nMatrix1 elements");
            Console.WriteLine("--------------");
            fixed (int* ptr = matrix1)
            {
                for (int i = 0; i < matrix1.Length; i++)
                {
                    Console.Write($"{*(ptr + i)}\t");
                }
                Console.WriteLine("\n");
            }
            Console.WriteLine("\nMatrix2 elements");
            Console.WriteLine("--------------");
            fixed (int* ptr2 = matrix2)
            {
                for (int i = 0; i < matrix2.Length; i++)
                {
                    Console.Write($"{*(ptr2 + i)}\t");
                }
                Console.WriteLine("\n");
            }
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    result[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }
            Console.WriteLine("\nResultant Matrix:");
            Console.WriteLine("--------------");
            fixed (int* sum = result)
            {
                for (int i = 0; i < result.Length; i++)
                {
                    Console.Write($"{*(sum + i)}\t");
                }
                Console.WriteLine("\n");
            }
            Console.WriteLine("************************\n");
        }

        static void Main(string[] args)
        {
            MatrixAddition();
            GetDetails();
            Swapmethod();
            Console.ReadLine();
        }
    }
}
