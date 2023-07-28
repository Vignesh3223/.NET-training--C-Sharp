using System;
using System.Collections;

namespace Generics
{
    internal class Collections
    {
        public static void ArrayList()
        {
            ArrayList array = new ArrayList();
            array.Add(null);
            array.Add(20);
            array.Add(null);
            array.Add("DOTNET");
            Console.WriteLine("Printing ArrayList \n");
            foreach (var a in array)
            {
                var c = a ?? "I have a value";
                    Console.WriteLine(c);
            }
        }
        static void Main(string[] args)
        {
            ArrayList();
            Console.ReadLine();
        }
    }
}
