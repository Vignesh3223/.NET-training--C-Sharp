using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Schema;

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
            double bonuspercent, bonus , total;
            Console.WriteLine("Enter Number of Employees : ");
            int empcount = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < empcount ; i++)
            {
                Console.WriteLine("Employee " + (i + 1) + " details: \n");
                AddBonus(out id, out name, out salary, out bonuspercent);
                bonus = (salary / 100) * bonuspercent;
                total = bonus + salary;
                Console.WriteLine("Employee ID : " + id);
                Console.WriteLine("Employee Name : " + name);
                Console.WriteLine("Employee Salary : " + salary);
                Console.WriteLine("Bonus Percentage : " + bonuspercent);
                Console.WriteLine("Bonus Amount : " + bonus);
                Console.WriteLine("Total Salary : " + total);
                Console.ReadLine();
            }
        }
    }
}
