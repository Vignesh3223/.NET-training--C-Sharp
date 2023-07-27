using System;

namespace Generics
{
    internal class Program1b
    {
        class GenericsSwap<T>
        {
            public void Swap(T a, T b)
            {
                Console.WriteLine("Before Swapping");
                Console.WriteLine($"Value of a:{a} and Value of b:{b}");
                Console.WriteLine("\n");
                T temp;
                temp = a;
                a = b;
                b = temp;
                Console.WriteLine("After Swapping");
                Console.WriteLine($"Value of a:{a} and Value of b:{b}");

            }
        }
        static void Main(string[] args)
        {
            GenericsSwap<int> generics = new GenericsSwap<int>();
            GenericsSwap<char> generics1 = new GenericsSwap<char>();
            Console.WriteLine("Swapping Two Integers");
            Console.WriteLine("Enter value of a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value of b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            generics.Swap(a, b);
            Console.WriteLine("\n");
            Console.WriteLine("Swapping Two Characters");
            Console.WriteLine("Enter value of a: ");
            char c = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Enter value of b: ");
            char d = Convert.ToChar(Console.ReadLine());
            generics1.Swap(c, d);
            Console.ReadLine();
        }
    }
}
