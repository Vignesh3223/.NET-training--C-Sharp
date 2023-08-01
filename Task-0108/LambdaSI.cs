using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_0108
{
    public class LambdaSI
    {
        public double amount;
        public int years;
        public double rate;
        public void GetValues()
        {
            Console.WriteLine("Simple Interest Calculation");
            Console.WriteLine("-----------------------");
            Console.WriteLine("Enter the Loan Amount : ");
            amount = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Number of Years : ");
            years = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Rate of Interest : ");
            rate = Convert.ToDouble(Console.ReadLine());
        }
        public void CalculateSI()
        {
            var Interest = (double amount, int years, double rate) =>
            {
                double SI;
                SI = (amount * rate * years) / 100;
                return SI;
            };
            Console.WriteLine("-----------------------");
            Console.WriteLine("Simple Interest : " + Interest(amount,years,rate));
        }
        static void Main(string[] args)
        {
            LambdaSI lambda = new LambdaSI();
            lambda.GetValues();
            lambda.CalculateSI();
            Console.ReadLine();
        }
    }
}
