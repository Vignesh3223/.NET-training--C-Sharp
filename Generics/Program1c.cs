using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Program1c
    {
        class GenericCombinations<T1, T2, T3>
        {
            T1 valA;
            T2 valB;
            T3 valC;
            public GenericCombinations(T1 valA, T2 valB, T3 valC)
            {
                this.valA = valA;
                this.valB = valB;
                this.valC = valC;
                Console.WriteLine($"Value of A is {valA} and it is of {typeof(T1)} data type");
                Console.WriteLine($"Value of B is {valB} and it is of {typeof(T2)} data type");
                Console.WriteLine($"Value of C is {valC} and it is of {typeof(T3)} data type");
            }
        }
            static void Main(string[] args)
            {
            GenericCombinations<int, string, char> generic3 = new GenericCombinations<int, string, char>(50, "C#", 'A');
            Console.ReadLine();
            }
        }
    }
