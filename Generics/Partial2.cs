using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Generics
{
    public partial class Partial
    {
        partial void Display()
        {
            Console.WriteLine($"{name}'s employee id is {id}");
        }
    }
}