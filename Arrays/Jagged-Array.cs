using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Jagged_Array
    {
        public void JaggedArray()
        {
            int[][,] array = new int[3][,]
            {
                new int[ , ] { { 1, 2, 3 }, { 2, 3, 4 } },
                new int[ , ] { { 1, 2 }, { 2, 3 }, { 3, 4 } },
                new int[ , ] { { 4, 5, 6, 7 }, { 5, 6, 7, 8 }, { 6, 7, 8, 9 } },
            };
            Console.WriteLine("Jagged Array");
            for(int i=0;i<array.Length;i++)
            {
                Console.Write("\n");
            for(int j = 0; j < array[i].GetLength(0); j++)
            {
               for(int k = 0; k < array[i].GetLength(1); k++)
                    {
                        Console.Write(array[i][j,k] + "");
                        Console.Write("\t");
                    }
                    Console.Write("\n");
            }
            } 
        }
        static void Main(string[] args)
        {
            Jagged_Array jarray = new Jagged_Array();
            jarray.JaggedArray();
            Console.ReadLine();
        }
    }
}
