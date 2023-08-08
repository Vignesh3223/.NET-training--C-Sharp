using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task_0708
{
    internal class InvalidIDException : Exception
    {
        public InvalidIDException(string message) : base($"Invalid ID :{message} (ID must contain only numbers)") { }
    }
    internal class InvalidNameException : Exception
    {
        public InvalidNameException(string message) : base($"Invalid Name :{message} (Name must contain only alphabets)") { }
    }
    internal class InvalidSalaryException : Exception
    {
        public InvalidSalaryException(string message) : base($"Invalid Salary :{message} (Salary must contain only numbers)") { }
    }
    class BonusCalcEvent : EventArgs
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public double Bonus;

    }
    class Employee
    {
        public EventHandler<BonusCalcEvent> OnCreated;
        int count = 0;
        public void Create(int id, string name, double salary) 
        { 
            if(OnCreated!=null)
            {
                Console.WriteLine("Employee Account Created");
                Console.WriteLine($"Account - {++count}");
                Console.WriteLine($"Employee {name} with id {id} earns an amount of Rs.{salary}");
                OnCreated(this, new BonusCalcEvent { ID = id, Name = name, Salary = salary });
            }
        }
    }
    class Bonus
    {
        public static void Calculate(object Bonus, BonusCalcEvent e)
        {
            if (e.Salary > 40000)
            {
                e.Bonus = (e.Salary * 15) / 100;
            }
            else if (e.Salary > 20000 && e.Salary <= 40000)
            {
                e.Bonus = (e.Salary * 10) / 100;
            }
            else
            {
                e.Bonus = (e.Salary * 5) / 100;
            }
            Console.WriteLine($"{e.Name} gets a bonus of Rs.{e.Bonus}");
        }
    }
    internal class Events
    {
        static void Main(string[] args)
        {
            var Emp = new Employee();
            Emp.OnCreated += Bonus.Calculate;
            int emp, id;
            string name;
            double salary;
                Console.WriteLine("Enter number of Employees: ");
                emp = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Employee Details");
                Console.WriteLine("************");
                for (int i = 0; i < emp; i++)
                {
                Regex ValidId = new Regex(@"(^[0-9]{3}$)");
                Regex Validname = new Regex("^[A-Za-z ]+$");
                Regex ValidSalary = new Regex(@"(^[0-9]{4,}$)");
                Console.WriteLine("Enter Employee ID: ");
                id = Convert.ToInt32(Console.ReadLine());
                try
                {
                    if (!ValidId.IsMatch(Convert.ToString(id)))
                    {
                        throw new InvalidIDException(id.ToString());
                    }
                    Console.WriteLine("Enter Employee Name: ");
                    name = Console.ReadLine();
                    if (!Validname.IsMatch(name))
                    {
                        throw new InvalidNameException(name);
                    }
                    Console.WriteLine("Enter Salary: ");
                    salary = Convert.ToDouble(Console.ReadLine());
                    if (!ValidSalary.IsMatch(Convert.ToString(salary)))
                    {
                        throw new InvalidSalaryException(salary.ToString());
                    }
                    Emp.Create(id, name, salary);
                    Console.WriteLine("************");
                }
                catch (InvalidIDException e1)
                {
                    Console.WriteLine(e1.Message);
                }
                catch(InvalidNameException e2)
                {
                    Console.WriteLine(e2.Message);
                }
                catch(InvalidSalaryException e3)
                {
                    Console.WriteLine(e3.Message);
                }     
            }
            Console.ReadLine();
        }
    }
}
