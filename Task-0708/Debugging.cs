using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_0708
{
        //program-4
        class DivNumbers
    {
        int result = 0;
        public DivNumbers() { }

        public void division(int num1, int num2)
        {
            try
            {
                result = num1 / num2;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Exception caught: "+ e.Message);
            }
            finally
            {
                Console.WriteLine("Result: {0}", result);
            }
        }
    }
        internal class Debugging
    {
        static void Main(string[] args)
        {
            //program-1
            int i, j;
                int[,] arr1 = new int[3, 3];

                Console.Write("\n\nRead a 2D array of size 3x3 and print the matrix :\n");
                Console.Write("-----------------------------------------\n");


                /* Stored values into the array*/
                Console.Write("Input elements in the matrix :\n");
                for (i = 0; i <= 2; i++)
                {
                    for (j = 0; j <= 2; j++)
                    {
                        Console.Write("element - [{0}] : " , i,j);
                        arr1[i,j] = Convert.ToInt32(Console.ReadLine());
                    }
                }

                Console.Write("\nThe matrix is : \n");
                for (i = 0; i < 3; i++)
                {
                    Console.Write("\n");
                    for (j = 0; j < 3; j++)
                        Console.Write("{0}\t", arr1[i, j]);
                }
                Console.Write("\n\n");

            //program-2
            int a, b;
            a = 10; b = 20;
            Console.WriteLine("Before swap a= " + a + " b= " + b);
             a = a * b;
             b = a / b;
             a = a / b;
            Console.Write("After swap a =  "+a +"b = "+b);

            //program-3
            string username, password;
            int ctr = 0;
            Console.Write("\n\nCheck username and password :\n");

            Console.Write("N.B. : Default username and password is :abcd and 1234\n");
            Console.Write("---------------------------------------\n");

            do
            {
                Console.Write("Input a username: ");
                username = Console.ReadLine();

                Console.Write("Input a password: ");
                password = Console.ReadLine();

                if (username != "abcd" || password != "1234")
                    ctr++;
                else
                    ctr = 1;
            }
            while ((username != "abcd" || password != "1234") && (ctr != 3));

            if (ctr == 3)
                Console.Write("\nLogin attempt three or more times. Try later!\n\n");
            else
                Console.Write("\nThe password entered successfully!\n\n");

            //program-4
            DivNumbers d = new DivNumbers();
            Console.WriteLine("Enter value of a : ");
            int a1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter value of b : ");
            int a2 = int.Parse(Console.ReadLine());
            d.division(a1, a2);

            //program-6
            IDictionary<int, string> numberNames = new Dictionary<int, string>();
            numberNames.Add(1, "One"); //adding key/value using the Add() method
            numberNames.Add(3, "Three");
            numberNames.Add(2, "Two");

            foreach (var kvp in numberNames)
            {
                Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
            }

            //creating a dictionary using collection-initializer syntax
            var cities = new Dictionary<int, string>()
            {
            { 1, "London, Manchester, Birmingham" },
            { 2, "Chicago, New York, Washington" },
            { 3, "Mumbai, New Delhi, Pune" },
            };
            foreach (var kvp in cities)
            {
                Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
            }
            Console.ReadLine();
            }
        }
    }
