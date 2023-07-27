using System;

namespace Generics
{
    internal class ObjasPara
    {
        public string name { get; set; }
        public int age { get; set; }
        public double mobileno { get; set; }
        public string address { get; set; }

        public void Display(ObjasPara obj)
        {
            obj.name = name;
            obj.age = age;
            obj.mobileno = mobileno;
            obj.address = address;
            Console.WriteLine($" Trainee {name} is {age} years old , he lives in {address} and his mobile number is {mobileno}");
        }

        static void Main(string[] args)
        {
            ObjasPara pass = new ObjasPara();
            Console.WriteLine("Enter Number of Trainees : ");
            int count = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Enter Name: ");
                pass.name = Console.ReadLine();
                Console.WriteLine("Enter Age: ");
                pass.age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Mobile Number: ");
                pass.mobileno = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter Address: ");
                pass.address = Console.ReadLine();
                pass.Display(pass);
            }
            Console.ReadLine();
        }
    }
}
