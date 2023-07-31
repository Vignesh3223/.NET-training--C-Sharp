using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task_3107
{
    public abstract class Abstraction
    {
        public int id;
        public string name;
        public float salary;
        public float tax;
        public abstract void CalculateTax();
    }
    public class Highsalary:Abstraction
    {
        public override void CalculateTax()
        {
            tax = salary * 25 / 100;
        }
    }
    public class Midsalary : Abstraction
    {
        public override void CalculateTax()
        {
                tax = salary * 15 / 100;
        }
    }
    public class Lowsalary : Abstraction
    {
        public override void CalculateTax()
        {
                tax = salary * 5 / 100;
        }
    }

    public class Abstractionmodel
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Employee Details");
            Console.WriteLine("-----------------------");
            Console.WriteLine("Enter Employee ID : ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee Name : ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter salary : ");
            float salary = float.Parse(Console.ReadLine());
            Abstraction model;
            if (salary >= 500000)
            {
                model = new Highsalary();
            }
            else if (salary < 500000 && salary >= 300000)
            {
                model = new Midsalary();
            }
            else if (salary < 300000 && salary >= 100000)
            {
                model = new Lowsalary();
            }
            else
            {
                Console.WriteLine("You don't have any taxes");
                return;
            }
            model.id = id;
            model.name = name;
            model.salary = salary;
            model.CalculateTax();
            Console.WriteLine("\nTax Details");
            Console.WriteLine("-----------------------");
            Console.WriteLine($"Employee {name} with id {id} pays Rs.{model.tax} per year");
            Console.ReadLine();
        }
    }
}
