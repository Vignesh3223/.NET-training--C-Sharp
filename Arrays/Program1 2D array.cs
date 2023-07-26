using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {

        public void twoDimArray()
        {
            Console.WriteLine("Enter the number of rows : ");
            int Rows = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number of columns : ");
            int Columns = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter elements of Array : ");
            int[,] arr = new int[Rows, Columns];
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("\n Printing the 2D array elements");
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    Console.Write(arr[i, j]);
                    Console.Write("\t");
                }
                Console.Write("\n");
            }
            //printing array in Column wise
            int index = 0;
            int RowCount = arr.GetLength(0);
            int ColumnCount = arr.GetLength(1);
            int[] oneDimColumnArray = new int[RowCount * ColumnCount]; 
            for (int y = 0; y < ColumnCount; y++)
            {
                for (int x = 0; x < RowCount; x++)
                {
                    oneDimColumnArray[index] = arr[x, y];
                    index++;
                }
            }
            Console.WriteLine("\n 1D array of 2D array in Column wise");
            foreach (int col in oneDimColumnArray)
            {
                Console.Write(col + " ");
            }
            Console.ReadLine();

            //printing array in Row wise
            int index1 = 0;
            int noOfRows = arr.GetLength(0);
            int noOfColumns = arr.GetLength(1);
            int[] oneDimRowArray = new int[RowCount * ColumnCount];
            for (int y = 0; y < noOfRows; y++)
            {
                for (int x = 0; x < noOfColumns; x++)
                {
                    oneDimRowArray[index1] = arr[y,x];
                    index1++;
                }
            }
            Console.WriteLine("\n 1D array of 2D array in Row wise");
            foreach (int row in oneDimRowArray)
            {
                Console.Write(row + " ");
                Console.Write("\n");
            }
            Console.ReadLine();
        }
        
        static void Main(string[] args)
        {
            Program array = new Program();
            array.twoDimArray();
            Console.ReadLine();
        }
    }
}
