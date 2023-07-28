using System;

namespace Generics
{
    internal class Program1a
    {
        class GenericsSort1<T>
        {
            public void Sort(T[] input)
            {
                Array.Sort(input);
                Array.Reverse(input);
                foreach (var a in input)
                {
                    Console.WriteLine(a);
                }
            }
        }
        static void Main(string[] args)
        {
            GenericsSort1<int> genericsSort = new GenericsSort1<int>();
            GenericsSort1<char> genericsSort1 = new GenericsSort1<char>();
            Console.WriteLine("Enter the size of the array of integers: ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] intArray = new int[size];
            Console.WriteLine("Enter the integer array elements: ");
            for (int i = 0; i < size; i++)
            {

                intArray[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Sorted integer array in reverse order:");
            genericsSort.Sort(intArray);

            Console.WriteLine("\nEnter the size of the array of characters: ");
            size = Convert.ToInt32(Console.ReadLine());
            char[] charArray = new char[size];
            Console.WriteLine("Enter the character array elements: ");
            for (int i = 0; i < size; i++)
            {

                charArray[i] = Convert.ToChar(Console.ReadLine());
            }
            Console.WriteLine("Sorted character array in reverse order:");
            genericsSort1.Sort(charArray);
            Console.ReadLine();
        }
    }
}
