using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilder_AccessSpecifiers
{
    internal class Program4
    {
        public static void decimalSum()
        {
            decimal de1 = 123.455M;
            decimal de2 = 789.123M;
            decimal desum = de1 + de2;
            Console.WriteLine("Sum of decimal values : " + desum);
          Console.ReadLine();
        }

        public static void doubleSum()
        {
            double do1 = 673.456556784235658;
            double do2 = 924.123785445987421;
            double dosum = do1 + do2;
            Console.WriteLine("Sum of Double values : " + dosum);
           Console.ReadLine();
        }

        public static void floatSum()
        {
            float f1 = 354.456F;
            float f2 = 552.123F;
            float fsum = f1 + f2;
            Console.WriteLine("Sum of float values : " + fsum);
           Console.ReadLine();
        }
        static void Main(string[] args)
        {
            decimalSum();
            floatSum(); 
            doubleSum();    
        }
    }
}
