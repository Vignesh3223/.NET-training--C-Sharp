using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilder_AccessSpecifiers
{
    internal class Program1
    {
         static string[] _trainees = new string[]
        {
            "Arun Joseph",
            "Hemanth",
            "Haritha",
            "Siva Bharat",
            "Srikanth",
            "Vignesh",
            "Yamini Priya"
        };

        public static void Display(StringBuilder dnt)
        {
            foreach(string trainee in _trainees)
            {
                dnt.AppendLine(trainee);
            }
            Console.WriteLine(dnt.ToString());
            Console.ReadLine();
        }
        static void Main(string[]args)
        {
            StringBuilder dnt = new StringBuilder("The DotNET trainees :").AppendLine();
            Display(dnt);
        }
    }
}
