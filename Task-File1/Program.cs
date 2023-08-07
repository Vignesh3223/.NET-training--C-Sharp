using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using CsvHelper;
using CsvHelper.Configuration;
using System.Dynamic;

namespace Task_File1
{ 
        public class Employee
        {
            public int EmpID { get; set; }
            public string EmpName { get; set; }
            public string Designation { get; set; }
            public double Salary { get; set; }
            public double bonus { get; set; }
            public static void WriteDetails(List<Employee> employee)
            {
                string file = @"E:\Naveen\Task-Files\EmpReport.csv";
                string Seperator = ",";
                StringBuilder output = new StringBuilder();
                string[] heading = new string[] { "Employee ID", "Employee Name", "Designation", "Salary", "Bonus" };
                output.AppendLine(string.Join(Seperator, heading));
                foreach (Employee emp in employee)
                {
                    if (emp.Salary >= 50000)
                    {
                        emp.bonus = (emp.Salary * 20) / 100;
                    }
                    else if (emp.Salary >= 25000 && emp.Salary < 50000)
                    {
                        emp.bonus = (emp.Salary * 15) / 100;
                    }
                    else
                    {
                        emp.bonus = (emp.Salary * 10) / 100;
                    }

                    string newline = string.Format("{0}, {1}, {2}, {3}, {4}", emp.EmpID.ToString(), emp.EmpName, emp.Designation, emp.Salary.ToString(), emp.bonus.ToString());
                    output.AppendLine(string.Join(Seperator, newline));
                }
                try
                {
                    File.WriteAllText(file, output.ToString());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                Console.WriteLine("Data Written Successfully");
            }
            public static void Main(string[] args)
            {
                List<Employee> employee = new List<Employee>();
                Console.WriteLine("Enter number of Employees: ");
                int count = int.Parse(Console.ReadLine());
                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine("Enter Employee ID: ");
                    int empID = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Employee Name: ");
                    string empName = Console.ReadLine();
                    Console.WriteLine("Enter Employee Designation: ");
                    string designation = Console.ReadLine();
                    Console.WriteLine("Enter Employee Salary: ");
                    double salary = Convert.ToDouble(Console.ReadLine());
                    employee.Add(new Employee() { EmpID = empID, EmpName = empName, Designation = designation, Salary = salary });
                }
                WriteDetails(employee);
                string readfile = File.ReadAllText(@"E:\Naveen\Task-Files\EmpReport.csv");
                Console.WriteLine(readfile);
                var reader = new StringReader(readfile);
                var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
                var records = csv.GetRecords<dynamic>();
                foreach (var rec in records)
                {
                    Console.WriteLine($"{rec.EmpID,-5}{rec.EmpName,-10}{rec.Designation,-10}{rec.Salary,-5}{rec.bonus,-5}");
                }
                Console.ReadLine();
            }
        }
}
