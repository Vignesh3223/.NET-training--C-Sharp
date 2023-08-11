using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1108
{
    public record Movies
    {
        public void Display()
        {
            Console.WriteLine("Movies.......");
        }
    }
    public record ActionMovies : Movies
    {
        public void Display1()
        {
            Console.WriteLine("Action Movies....");
        }
    }
    public record ComedyMovies : Movies
    {
        public void Display2()
        {
            Console.WriteLine("Comedy Movies....");
        }
    }
    public record ThrillerMovies : Movies
    {
        public void Display3()
        {
            Console.WriteLine("Thriller Movies....");
        }
    }
    internal class RecordInheritance
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Base Record");
            Console.WriteLine("-------------");
            Movies m = new Movies();
            m.Display();
            Console.WriteLine("\n");
            Console.WriteLine("Child-1 Record");
            Console.WriteLine("-------------");
            ActionMovies a = new ActionMovies();
            a.Display();
            a.Display1();
            Console.WriteLine("\n");
            Console.WriteLine("Child-2 Record");
            Console.WriteLine("-------------");
            ComedyMovies c = new ComedyMovies();
            c.Display2();
            Console.WriteLine("\n");
            Console.WriteLine("Child-3 Record");
            Console.WriteLine("-------------");
            ThrillerMovies t = new ThrillerMovies();
            t.Display();
            t.Display3();
            Console.WriteLine("\n");
            Console.WriteLine("***************");
            Console.ReadLine();
        }
    }
}
