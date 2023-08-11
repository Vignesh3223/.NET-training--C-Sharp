using System;
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
        static void Main(string[] args)
        {
            Console.WriteLine("enter number of trainees");
            int count = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nEnter The details of CG-VAK Trainees\n");
            for (int i = 1; i <= count; i++)
            {
                Console.WriteLine($"Enter Trainee-{i} details");
                Console.WriteLine("-------------");
                Console.WriteLine("Enter Trainee Id: ");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Trainee Name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Enter Trainee City: ");
                string city = Console.ReadLine();
                var emp = (id, name, city);
                Console.WriteLine("-------------");
                Console.WriteLine($"Trainee-{i} Details");
                Console.WriteLine($"\nTrainee {emp.name} with id {emp.id} lives in {emp.city}");
                Console.WriteLine("\n********************\n");
            }
            Console.ReadLine();
        }
        
    }
}
