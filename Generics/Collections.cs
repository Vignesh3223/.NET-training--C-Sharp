using System;
using System.Collections;

namespace Generics
{
    internal class Collections
    {
        public static void ArrayList()
        {
            ArrayList array = new ArrayList();
            array.Add("Vignesh");
            array.Add(null);
            array.Add(20);
            array.Add(null);
            Console.WriteLine("Printing ArrayList \n");
            foreach (var a in array)
            {
                if (a == null)
                {
                    Console.WriteLine("I have a value");
                }
                else
                {
                    Console.WriteLine(a);
                }
            }
        }
        static void Main(string[] args)
        {
            ArrayList();
            Console.ReadLine();
        }
    }
}
