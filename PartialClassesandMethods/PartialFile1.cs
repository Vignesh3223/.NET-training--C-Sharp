using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClassesandMethods
{
    public partial class PartialFile1
    {
        partial void hashtable();
        partial void queue();
        partial void hashset();
        partial void linkedList();


    class PartialMain
        {
            static void Main(string[] args)
            {
                PartialFile1 partialmethod = new PartialFile1();
                partialmethod.hashtable();
                partialmethod.queue();
                partialmethod.hashset();
                partialmethod.linkedList();
                Console.ReadLine();
            }
        }
    }
}
