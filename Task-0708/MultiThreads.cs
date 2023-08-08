using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task_0708
{
    internal class MultiThreads
    {
        public void MultiThreading()
        {
            Console.WriteLine("Main Thread Started");
            Thread t1 = new Thread(Method1)
            {
                Name = "Thread_A"
            };
            Thread t2 = new Thread(Method2)
            {
                Name = "Thread_B"
            };
            Thread t3 = new Thread(Method3)
            {
                Name = "Thread_C"
            };
            t1.Priority = ThreadPriority.Normal;
            t2.Priority = ThreadPriority.Highest;
            t3.Priority = ThreadPriority.Lowest;
            t1.Start();
            t2.Start(); 
            t3.Start();
            Console.WriteLine("Main Thread Ended");
            Console.Read();
        }
        static void Method1()
        {
            Console.ForegroundColor= ConsoleColor.Yellow;
            Console.BackgroundColor= ConsoleColor.Red;
            for(int i=0; i<5; i++) 
            {
                Console.WriteLine("This is Method 1 using "+ Thread.CurrentThread.Name);
            }
        }
        static void Method2()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Blue;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("This is Method 2 using " + Thread.CurrentThread.Name);
                if (i == 2)
                {
                    Console.WriteLine("Method2 Stopped");
                    Thread.Sleep(1000);
                }
            }

        }
        static void Method3()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.BackgroundColor = ConsoleColor.Magenta;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("This is Method 3 using " + Thread.CurrentThread.Name);
                if (i == 4)
                {
                    Console.WriteLine("Method3 Stopped");
                    Thread.Sleep(2000);
                }
            }
        }
        static void Main(string[] args)
        {
            MultiThreads m1 = new MultiThreads();
            m1.MultiThreading();
            Console.ReadLine();
        }
    }
}
