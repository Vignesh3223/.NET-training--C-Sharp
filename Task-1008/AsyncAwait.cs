using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1008
{
    internal class AsyncAwait
    {
        public static async Task<int> SumofNumbers()
        {
            int n,sum =0;
            Console.WriteLine("Enter the number to sum: ");
            n = Convert.ToInt32(Console.ReadLine());
            for(int i =0; i <= n; i++) 
            {
                sum += i;
            }
            await Task.Delay(2000);
            return sum;
        }
        public static async Task<int> ProductofNumbers()
        {
            int m, product=1;
            Console.WriteLine("Enter the number to multiply: ");
            m = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= m; i++)
            {
                product *= i;
            }
            await Task.Delay(500);
            return product;
        }
        public static async Task Main()
        {
            Console.WriteLine("Enter the Values");
            Console.WriteLine("---------------");
            Task<int> res = SumofNumbers();
            Task<int> res1 = ProductofNumbers();
            var val = await res;
            var val1 = await res1;
            Console.WriteLine("\nResult");
            Console.WriteLine("---------------");
            Console.WriteLine("\nSum of n numbers: " + val);
            Console.WriteLine("\nProduct of n numbers: " + val1);
            Console.WriteLine("\n*******************");
            Console.ReadLine();
        }
    }
}
