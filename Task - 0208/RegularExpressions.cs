using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task___0208
{
    internal class RegularExpressions
    {
        public void Matches()
        {
            Console.WriteLine("Password Pattern");
            Console.WriteLine("---------------");
            var Password = new List<string> { "Asde4!rds","sd43@"};
            Password.ForEach(x => Console.WriteLine(Regex.IsMatch(x, "^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[!@#$%^&*?]).{8,}$") + " --> " + x));
          
            Console.WriteLine("\nMobile Number Pattern");
            Console.WriteLine("---------------");
            var Mobile = new List<string>{"6345571847","900341297"};
            Mobile.ForEach(x => Console.WriteLine(Regex.IsMatch(x,@"(^[1-8]{10}$)")+ " --> " + x));

            Console.WriteLine("\nTelephone Number Pattern");
            Console.WriteLine("---------------");
            var Tele = new List<string> {"123-2343-679","1223-678-092"};
            Tele.ForEach(x => Console.WriteLine(Regex.IsMatch(x, @"\(?\d{3}\)?[-\.]? *\d{4}[-\.]? *[-\.]?\d{3}") + " --> " + x));
    
        }
        static void Main(string[] args)
        {
            RegularExpressions regex = new RegularExpressions();
            regex.Matches();
            Console.ReadLine();
        }
    }
}
