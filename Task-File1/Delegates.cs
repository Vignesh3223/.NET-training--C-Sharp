using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_File1
{
        public delegate bool CouponCode(Purchase pur);
        public class Purchase
        {
            public string name { get; set; }
            public double purchaseamt { get; set; }
            public string couponcode { get; set; }
            public double discount;
            public double totalamt;


            public static void CheckCouponCode(List<Purchase> purchaseList, CouponCode isValid)
            {
                Console.WriteLine("\nPurchase Details");
                Console.WriteLine("*******************");
                foreach (Purchase pur in purchaseList)
                {
                    if (isValid(pur) && pur.purchaseamt >= 2000)
                    {
                        Console.WriteLine(pur.couponcode + " is a Valid Code");
                        pur.discount = (pur.purchaseamt * 10) / 100;
                        pur.totalamt = pur.purchaseamt - pur.discount;

                    }
                    else if (isValid(pur) && pur.purchaseamt < 2000)
                    {
                        Console.WriteLine(pur.purchaseamt + " is below the Limit");
                        pur.totalamt = pur.purchaseamt;
                    }
                    else
                    {
                        Console.WriteLine(pur.couponcode + " is a Invalid Code");
                        pur.discount = 0;
                        pur.totalamt = pur.purchaseamt;

                    }
                    Console.WriteLine($"Customer Name: {pur.name}");
                    Console.WriteLine($"Discount Amount: {pur.discount}");
                    Console.WriteLine($"Total Amount: {pur.totalamt}");
                    Console.WriteLine("\n");
                }
            }
            public static bool CorrectCoupon(Purchase pur)
            {
                if (pur.couponcode == "CH234SD7")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            public static void CouponCodeCheck()
            {
                List<Purchase> purch = new List<Purchase>();
                Console.WriteLine("*******************");
                Console.WriteLine("Enter Customer Name: ");
                string n = Console.ReadLine();
                Console.WriteLine("Enter Purchase Amount: ");
                double puramt = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter Coupon Code: ");
                string coucode = Console.ReadLine();
                purch.Add(new Purchase() { name = n, couponcode = coucode, purchaseamt = puramt });
                CouponCode code = new CouponCode(CorrectCoupon);
                Purchase.CheckCouponCode(purch, code);
            }
            static void Main(string[] args)
            {
                Console.WriteLine("Enter number of Customers");
                int cust = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Purchase Details Of the Customers");
                for (int i = 0; i < cust; i++)
                {
                    CouponCodeCheck();
                }

                Funcdelegate func = new Funcdelegate();
                func.Multiply();
                Console.WriteLine("\n*******************");

                Actiondelegate action = new Actiondelegate();
                action.PrintToDoList();
                Console.ReadLine();
            }
        }
        class Funcdelegate
        {
            static int MulTable(int x, int y)
            {
                return x * y;
            }
            public void Multiply()
            {
                int result = 0;
                Console.Write("Enter the number (Table to be calculated) : ");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("-------------");
                Func<int, int, int> multi = MulTable;
                for (int y = 1; y <= 10; y++)
                {
                    result = multi(x, y);
                    Console.WriteLine($"{x} x {y} = {result}");
                }
            }
        }

        class Actiondelegate
        {
            static void AddToDoList(string w)
            {
                Console.WriteLine(w);
            }
            static void DeleteToDoList(string w)
            {
                Console.WriteLine(w);
            }
            public void PrintToDoList()
            {
                Console.WriteLine("\nToDo List");
                Console.WriteLine("-------------");
                Action<string> todo = AddToDoList;
                todo("Assign Task");
                todo("Inspect Code");
                todo("Check Task Status");
                todo("Evaluate Task");
                Console.WriteLine("\nCompleted List");
                Console.WriteLine("-------------");
                Action<string> todo1 = DeleteToDoList;
                todo1("Inspect Code");
            }
        }
}
