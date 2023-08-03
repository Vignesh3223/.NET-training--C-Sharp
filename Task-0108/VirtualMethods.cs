using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Task_0108
{
    class Employee
    {
        public int EId { get; set; }
        public string EName { get; set; }
        public float ESalary { get; set; }

        //public string Details() => $"Employee {EName} with id {EId} earns an amount of Rs.{ESalary}";
        public virtual void Details()
        {
            Console.WriteLine($"Employee {EName} with id {EId} earns an amount of Rs.{ESalary}");
        }
    }

    class HR : Employee
    {
        public float bonus;

        public override void Details()
        {
            if (ESalary >= 50000)
            {
                bonus = (ESalary * 25) / 100;
            }
            else if (ESalary > 25000 && ESalary < 50000)
            {
                bonus = (ESalary * 15) / 100;
            }
            else
            {
                bonus = (ESalary * 10) / 100;
            }
            Console.WriteLine($"Bonus Amount : {bonus}");
        }
        //public new int Details()
        //{
        //    if (ESalary >= 50000)
        //    {
        //        bonus = (ESalary * 25) / 100;
        //    }
        //    else if (ESalary > 25000 && ESalary < 50000)
        //    {
        //        bonus = (ESalary * 15) / 100;
        //    }
        //    else
        //    {
        //        bonus = (ESalary * 10) / 100;
        //    }
        //    Console.WriteLine($"Bonus Amount : {bonus}");
        //    return 0;
        //}
    }
    internal class VirtualMethods
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**Enter Employee Details**");
            Console.WriteLine("------------------------");
            Console.WriteLine("Enter Employee ID : ");
            int Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee Name : ");
            string Name = Console.ReadLine();
            Console.WriteLine("Enter Employee Salary : ");
            float Salary = float.Parse(Console.ReadLine());
            Console.WriteLine("------------------------");
            var employee = new HR()
            {
                EId = Id,
                EName = Name,
                ESalary = Salary
            };
            Employee emp1 = employee;
            emp1.Details();
            employee.Details();
            Console.ReadLine();
        }
    }
}
