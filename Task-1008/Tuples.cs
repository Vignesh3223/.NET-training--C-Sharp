using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Xml.Linq;

namespace Task_1008
{
    internal class Tuples
    {
        static Hashtable trainee = new Hashtable();
        public static void Display(Tuple<int, string, string>emp)
        {
            trainee.Add(emp.Item2, emp.Item3);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of trainees");
            int count = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nEnter The details of CG-VAK Trainees\n");
            Console.WriteLine($"Enter Trainee details");
            Console.WriteLine("-------------");
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("\nEnter Trainee Id: ");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Trainee Name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Enter Trainee City: ");
                string city = Console.ReadLine();
                var emp =new Tuple<int,string,string> (id, name, city);
                Display(emp);                
            }
            Console.WriteLine("\nTrainee Details");
            foreach (DictionaryEntry val1 in trainee)
            {
                Console.WriteLine($"\nEmployee {val1.Key} lives in {val1.Value}");
            }
            Console.WriteLine("\n----------------");
            Console.ReadLine();
        }
    }
}
