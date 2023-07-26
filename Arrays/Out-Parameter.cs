using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Out_Parameter
    {
        public static void AddBonus(out int id,out string name,out float salary, out double bonuspercent)
        {
                Console.WriteLine("Enter Employee ID : ");
                id = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Name : ");
                name = Console.ReadLine();
                Console.WriteLine("Enter Salary : ");
                salary = float.Parse(Console.ReadLine());
                Console.WriteLine("Enter Bonus Percentage : ");
                bonuspercent = Convert.ToDouble(Console.ReadLine());
        }
        static void Main(string[] args)
        {
            int id;
            string name;
            float salary;
            double bonuspercent, bonus;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Employee " + (i + 1) + " details: \n");
                AddBonus(out id, out name, out salary, out bonuspercent);
                bonus = (salary / 100) * bonuspercent;
                Console.WriteLine("Employee ID : " + id);
                Console.WriteLine("Employee Name : " + name);
                Console.WriteLine("Employee Salary : " + salary);
                Console.WriteLine("Bonus Percentage : " + bonuspercent);
                Console.WriteLine("Bonus Amount : " + bonus);
                Console.ReadLine();
            }
        }
    }
}
