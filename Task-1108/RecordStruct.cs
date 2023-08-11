using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Runtime.CompilerServices
{
    internal static class IsExternalInit { } 
    public record struct Employee
    {
        public int ID { get; init; }
        public string Name { get; init; }
        public string Designation { get; init; }
        public double Salary;
        public double Bonus;
        public static void Display(Employee employee)
        {
            Console.WriteLine("\nEmployee Details");
            Console.WriteLine("------------");
            Console.WriteLine($"Employee ID: {employee.ID}");
            Console.WriteLine($"Employee Name: {employee.Name}");
            Console.WriteLine($"Designation: {employee.Designation}");
            Console.WriteLine($"Salary: {employee.Salary}");

            if (employee.Salary > 50000)
            {
                employee.Bonus = (employee.Salary * 20) / 100;
                employee.Salary += employee.Bonus;
            }
            else if (employee.Salary < 50000 && employee.Salary >= 25000)
            {
                employee.Bonus = (employee.Salary * 15) / 100;
                employee.Salary += employee.Bonus;
            }
            else
            {
                employee.Bonus = (employee.Salary * 10) / 100;
                employee.Salary += employee.Bonus;
            }

            var emp1 = employee with { Bonus = employee.Bonus , Salary = employee.Salary};
            Console.WriteLine("\nEmployee Details afetr Bonus Calculation");
            Console.WriteLine("------------");
            Console.WriteLine($"Employee ID: {emp1.ID}");
            Console.WriteLine($"Employee Name: {emp1.Name}");
            Console.WriteLine($"Designation: {emp1.Designation}");
            Console.WriteLine($"Bonus: {emp1.Bonus}");
            Console.WriteLine($"Total Salary (with Bonus): {emp1.Salary}");
        }
    }
   
internal class RecordStruct
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of Employees");
            int eno = int.Parse(Console.ReadLine());
            for (int i = 0; i < eno; i++)
            {
                Console.WriteLine("Enter Emplot");
                Console.WriteLine("Enter Employee ID");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Employee Name");
                string name = Console.ReadLine();
                Console.WriteLine("Enter Designation");
                string des = Console.ReadLine();
                Console.WriteLine("Enter Salary");
                double sal = Convert.ToDouble(Console.ReadLine());
                var empRec = new Employee
                {
                    ID = id,
                    Salary = sal,
                    Name = name,
                    Designation = des,
                };
                Employee.Display(empRec);
                Console.WriteLine("\n****************");
            }      
            Console.ReadLine();
        }
    }
}
