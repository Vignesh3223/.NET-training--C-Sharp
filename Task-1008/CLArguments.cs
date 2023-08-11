using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1008
{
    internal class CLArguments
    {
        static void Main(string[] args)
        {
            int arg1 = Convert.ToInt32(args[0]);
            Console.WriteLine("Argument in Integer Form(ID): " + arg1);
            string arg2 = (args[1]);
            Console.WriteLine("Argument in String Form(Name): " + arg2);
            double arg3 = Convert.ToDouble(args[2]);
            Console.WriteLine("Argument in Double Form(Salary): " + arg3);
            Console.ReadLine();
        }
    }
}
