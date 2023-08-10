using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_0908
{
    class Employee<T>
    {
        private T[] employee = new T[10];   

        public T this[int index]
        {
            get
            {
                return employee[index];
            }
            set 
            { 
                employee[index] = value; 
            }
        }
    }
    class GenericIndexer
    {
        public static void GetDetails()
        {
            Employee<int> ID = new Employee<int>();
            Console.WriteLine("Enter Employee ID : ");
            ID[0] = Convert.ToInt32(Console.ReadLine());
            Employee<string> Name = new Employee<string>();
            Console.WriteLine("Enter Employee Name : ");
            Name[0] = Console.ReadLine();
            Employee<string> Designation = new Employee<string>();
            Console.WriteLine("Enter Employee Designation : ");
            Designation[0] = Console.ReadLine();
            Console.WriteLine("-----------------");
            Console.WriteLine("Employee Details");
            Console.WriteLine("-----------------");
            Console.WriteLine("Employee ID : " + ID[0]);
            Console.WriteLine("Employee Name : " + Name[0]);
            Console.WriteLine("Employee Designation : " + Designation[0]);
            Console.WriteLine("*****************");
        }
    }
    internal class Indexer
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of Employees ");
            int count = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("*****************");
            Console.WriteLine("Enter Employee Details");
            Console.WriteLine("-----------------");
            for (int i = 0; i < count; i++)
            {
                GenericIndexer.GetDetails();
            }
            Console.ReadLine();
        }
    }
}
