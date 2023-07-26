
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilder_AccessSpecifiers
{
    internal class Program2
    {
       static void Main(string[] args)
        {
            Console.WriteLine("Enter a string : ");
            string str = Console.ReadLine();
            StringBuilder sb = new StringBuilder(str);
            sb.AppendLine(" Trainee");
            sb.AppendLine("Welcome to .NET, ");
            sb.Insert(35, "C#");
            sb.Remove(9, 8);
            sb.Replace("!!!", "???");
            Console.WriteLine(sb.ToString());
            Console.ReadLine();
        }
    }
}
