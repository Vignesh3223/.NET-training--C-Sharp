using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Task_1008
{
    public class Trainee
    {
        public int tid { get; set; }
        public string tname { get; set; }
        public int tage { get; set; }
        public string tcompany { get; set; }

        public Trainee(int tid, string tname, int tage, string tcompany) { 
            this.tid = tid;
            this.tname = tname; 
            this.tage = tage;
            this.tcompany = tcompany;
        }
    }
    internal class TupleParameters
    {
        public static void CompanyCheck(Tuple<int,string,int,string> tr)
        {
            if (tr.Item4 == "CGVAK")
            {
                Console.WriteLine("\nTrainee of CG-VAK");
            }
            else if (tr.Item4 == "G2")
            {
                Console.WriteLine("\nTrainee of G2");
            }
            else
            {
                Console.WriteLine("\nWrong data");
            }

            Console.WriteLine($"\nTrainee {tr.Item1} with id {tr.Item2} is {tr.Item3} years old");
        }
    static void Main(string[] args)
        {
            int tid, tage;
            string tname, tcompany;
            List<Trainee> Trainees = new List<Trainee>();
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
                Console.WriteLine("-------------");
                Trainees.Add(new Trainee ( tid, tname, tage, tcompany ));
            }
            Console.WriteLine("Trainee Details");
            Console.WriteLine("-------------");
            foreach (var value in Trainees)
            {
                var tr = new Tuple<int, string, int, string>(value.tid, value.tname, value.tage, value.tcompany);
                CompanyCheck(tr);
            }
            Console.WriteLine("****************");
            Console.ReadLine();
        }
    }
}
