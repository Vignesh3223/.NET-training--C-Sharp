using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Arrays
{
    internal class Params
    {
        public string name,addr;
        public int age;
        public double mob;

        public void Display(params object[] trainees)
        {
            for (int i = 0; i < trainees.Length; i++)
            {
                Console.WriteLine(trainees[i]);
            }
        }
        static void Main(string[] args)
        {
            Params paramArray = new Params();

            object[] trainee = new object[4];
            Console.WriteLine("Enter Number of Trainees : ");
            int count = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Enter Name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Enter Age: ");
                int age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Mobile Number: ");
                double mob = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter Address: ");
                string addr = Console.ReadLine();
                paramArray.Display(name, age, mob, addr);
            }
            Console.ReadLine();
        }
    }
}
