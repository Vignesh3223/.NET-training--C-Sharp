using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1008
{
    class Variables
    {
        public readonly int a = 10; public readonly int b;
        public const int c = 27;
        public static int d;
        public int e;

        public Variables(int i)
        {
            a = i;
            b = i;
            d = i;    
            e = i;
        }
        public void ChangeValue(int val1)
        {
            d = val1;
            e = val1;
        }
        public void Display()
        {
            Console.WriteLine($"Value of First readonly variable: {a}");
            Console.WriteLine($"Value of Second readonly variable value of b: {b}");
            Console.WriteLine($"Value of constant variable: {c}");
            Console.WriteLine($"Value of static variable: {d}");
            Console.WriteLine($"Value of instance variable: {e}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Variables v = new Variables(104);
            Variables v1 = new Variables(39);
            //v1.ChangeValue(97);
            Console.WriteLine("Displaying Values\n");
            v.Display();
            Console.WriteLine("\n****************\n");
            Console.WriteLine("Displaying Values after changes\n");
            Console.WriteLine($"Variables.static value: {Variables.d}");
            Console.WriteLine($"Variables.instance value: {v.e}");
            Console.WriteLine($"Variables.constant value: {Variables.c}");
            Console.ReadLine();
        }
    }
}
