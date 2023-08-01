using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_0108
{
    interface IInterface1
    {
        void Area();
    }
    interface IInterface2
    {
        void Area();
    }
    public class Derived : IInterface1, IInterface2 
    {
        public int radius;
        public int length;
        public int width;
        void IInterface1.Area()
        {
            Console.WriteLine("Enter the Radius: ");
            radius=Convert.ToInt32(Console.ReadLine());
            double area;
            area = 3.14 * radius * radius;
            Console.WriteLine($"Area of Circle is {area}");

        }
        void IInterface2.Area()
        {
            Console.WriteLine("Enter the Length: ");
            length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Width: ");
            width = Convert.ToInt32(Console.ReadLine());
            double area;
            area = length * width;
            Console.WriteLine($"Area of Rectangle is {area}");
        }
    }
    internal class Interfaces
    {
        static void Main(string[] args)
        {
            IInterface1 i1;
            Console.WriteLine("Circle Area Calculation");
            Console.WriteLine("--------------");
            i1 = new Derived();
            i1.Area();
            IInterface2 i2;
            Console.WriteLine("\nRectangle Area Calculation");
            Console.WriteLine("--------------");
            i2 =new Derived();
            i2.Area();
            Console.ReadLine();
        }
    }
}
