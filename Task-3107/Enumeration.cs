using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Task_3107.Enumeration;

namespace Task_3107
{
    internal class Enumeration
    {
        public enum Shapes
        {
            circle, rectangle, square
        }
        //passing enum as parameter
        public void CalculateArea(int a, int b, Shapes shapes)
        {
            double area;
            if (shapes==Shapes.circle)
            {
                area = 3.14 * a * a;
                Console.WriteLine("Area of Circle : " + area);
            }
            else if (shapes == Shapes.rectangle)
            {
                area = a * b;
                Console.WriteLine("Area of Rectangle : " + area);
            }
            else if (shapes == Shapes.square)
            {
                area = a * a;
                Console.WriteLine("Area of Square : " + area);
            }
        }
        //Iteration
        public void Iterate(int num1,int num2)
        {
            Console.WriteLine("\n Area of Shapes");
            Console.WriteLine("---------------------------");
            foreach (Enum shape in Enum.GetValues(typeof(Shapes)))
            {
                if (shape.ToString() == "circle")
                {
                    Console.WriteLine("Area of circle:" + 3.14 * num1 * num1);
                    Console.WriteLine("---------------------------");
                }
                else if (shape.ToString() == "rectangle")
                {
                    Console.WriteLine("Area of rectangle:" + num1 * num2);
                    Console.WriteLine("---------------------------");
                }
                else if (shape.ToString() == "square")
                {
                    Console.WriteLine("Area of square:" + num1 * num1);
                }
            }
        }
            static void Main(string[] args)
        {
            Enumeration enumeration = new Enumeration();
            Console.WriteLine("Enter the Choice \n1.circle \n2.rectangle \n3.square");
            int ch = int.Parse(Console.ReadLine());

            switch (ch)
            {
                case 1:
                    Console.Write("Enter the radius : ");
                    int radius = int.Parse(Console.ReadLine());
                    enumeration.CalculateArea(radius, 0, Shapes.circle);
                    break;
                case 2:
                    Console.Write("Enter the length : ");
                    int length = int.Parse(Console.ReadLine());
                    Console.Write("Enter the breadth : ");
                    int breadth = int.Parse(Console.ReadLine());
                    enumeration.CalculateArea(length, breadth, Shapes.rectangle);
                    break;
                case 3:
                    Console.Write("Enter the side : ");
                    int side = int.Parse(Console.ReadLine());
                    enumeration.CalculateArea(side, 0, Shapes.square);
                    break;
                default:
                    Console.WriteLine("Invalid shape");
                    break;
            }

            //enumeration.Iterate(5, 8);
            Console.ReadLine();
        }
    }
}
