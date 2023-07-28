using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public partial class Partial
    {
        private int id;
        private string name;
        public Partial()
        {
            id = 101;
            name = "Ajay";
        }
        partial void Display();
        class Partialmain
        {
            static void Main(string[] args)
            {
                Partial partialcall = new Partial();
                partialcall.Display();
                Console.ReadLine();
            }
        }
    }
}
