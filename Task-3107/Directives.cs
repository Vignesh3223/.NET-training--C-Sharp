#define BubbleSort
#undef QuickSort
#define MergeSort
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3107
{
    internal class Directives
    {
#if (BubbleSort)
        #region
        public void BubbleSort(int[]arr)
        {
            int n = arr.Length;
            for (int j=0; j<=n-2; j++)
            {
                for(int i=0;i<=n-2;i++) 
                {
                    if (arr[i] > arr[i+1])
                    {
                        int temp = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = temp;
                    }
                }  
            }
        }
        #endregion
#endif
#if (QuickSort)
        #region
        public void QuickSort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int pivotIndex = Partition(arr, left, right);
                QuickSort(arr, left, pivotIndex - 1);
                QuickSort(arr, pivotIndex + 1, right);
            }
        }
        private static int Partition(int[] arr, int left, int right)
        {
            int pivot = arr[right];
            int i = left - 1;

            for (int j = left; j < right; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
            int temp2 = arr[i + 1];
            arr[i + 1] = arr[right];
            arr[right] = temp2;

            return i + 1;
        }
        #endregion
#endif

#pragma warning disable
#warning MergeSort is undefined
#pragma warning restore
#warning MergeSort is undefined at Directives.cs
//#error MergeSort is undefined
        static void Main(string[] args)
        {
//#line 35 "Directives.cs"
 //        string a = 50;
            #region
            Console.WriteLine("Enter The Size of array : ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];
            Console.WriteLine("Enter the array elements : ");
            for(int i=0;i<arr.Length;i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Directives directives = new Directives();
#if (BubbleSort)
            {
             Console.WriteLine("Bubble Sort");
                directives.BubbleSort(arr);
            }
#elif(QuickSort)
            {
                Console.WriteLine("Quick Sort");
                directives.QuickSort(arr, 0, arr.Length - 1);
            }
#else
        Console.WriteLine("No Sorting");
        return;
#endif
            {
                Console.WriteLine("After Sorting Array :");
                foreach (int item in arr)
                {
                    Console.Write(item + " ");
                }
                Console.ReadLine(); 
            }
            #endregion
        }
    }
}
