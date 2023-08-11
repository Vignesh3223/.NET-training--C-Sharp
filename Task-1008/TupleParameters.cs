using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Task_1008
{
    internal class TupleParameters
    {
        static void Main(string[] args)
        {
            int tid, tage;
            string tname, tcompany;
            Console.WriteLine("Enter number of trainees from both Organisations");
            int trainee = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < trainee; i++)
            {
                Console.WriteLine($"Enter Trainee details");
                Console.WriteLine("-------------");
                Console.WriteLine("Enter Trainee Id: ");
                tid = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Trainee Name: ");
                tname = Console.ReadLine();
                Console.WriteLine("Enter Trainee Age: ");
                tage = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Trainee Company: ");
                tcompany = Console.ReadLine();
                if (tcompany == "CGVAK")
                {
                    Console.WriteLine("\nTrainee of CG-VAK");
                    Display((tid, tname, tage, tcompany));
                }
                else if (tcompany == "G2")
                {
                    Console.WriteLine("\nTrainee of G2");
                    Display((tid, tname, tage, tcompany));
                }
                else
                {
                    Console.WriteLine("\nWrong data");
                }
                Console.WriteLine("-------------");
            }
            void Display((int tid, string tname, int tage, string tcompany) tr1)
            {
              Console.WriteLine($"{tr1.tname} with id {tr1.tid} is {tr1.tage} years old is working in {tr1.tcompany}");
            }
            Console.ReadLine();
        }
    }
}
