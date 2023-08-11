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
                Console.WriteLine($"Trainee {tr.Item2} with id {tr.Item1} is {tr.Item3} years old");
            }
            else if (tr.Item4 == "G2")
            {
                Console.WriteLine($"Trainee {tr.Item2} with id {tr.Item1} is {tr.Item3} years old");
            }
            else
            {
                Console.WriteLine("\nWrong data");
            }
        }
    static void Main(string[] args)
        {
            int tid, tage;
            string tname, tcompany;
            List<Trainee> CGTrainees = new List<Trainee>();
            List<Trainee> G2Trainees = new List<Trainee>();
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
                if (tcompany == "CGVAK")
                {
                    CGTrainees.Add(new Trainee(tid, tname, tage, tcompany));
                }
                else if (tcompany == "G2")
                {
                    G2Trainees.Add(new Trainee(tid, tname, tage, tcompany));
                }     
            }
            Console.WriteLine("Trainee Details");
            Console.WriteLine("-------------");
            Console.WriteLine("\nTrainees of CG-VAK");
            Console.WriteLine("-------------");
            foreach (var value in CGTrainees)
            {
                var tr = new Tuple<int, string, int, string>(value.tid, value.tname, value.tage, value.tcompany);
                CompanyCheck(tr);
            }
            Console.WriteLine();
            Console.WriteLine("\nTrainees of G2");
            Console.WriteLine("-------------");
            foreach (var value1 in G2Trainees)
            {
                var tr = new Tuple<int, string, int, string>(value1.tid, value1.tname, value1.tage, value1.tcompany);
                CompanyCheck(tr);
            }
            Console.WriteLine("\n****************\n");
            Console.ReadLine();
        }
    }
}
