using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClassesandMethods
{
    public partial class PartialFile1
    {
        //Hashtable
        partial void hashtable()
        {
            Hashtable ht = new Hashtable();
            ht.Add(1, "DOTNET");
            ht.Add(2, "C#");
            ht.Add(3, 100);
            ht.Add(4, 12.5);
            Console.WriteLine("\n Hashtable Keys");
            foreach (var a in ht.Keys)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine("\n Hashtable Values");
            foreach (var b in ht.Values)
            {
                Console.WriteLine(b);
            }
            Console.WriteLine("\n Hashtable Key-Value Pairs");
            foreach (DictionaryEntry dt in ht)
            {
                Console.WriteLine("Key :{0} and Value : {1}", dt.Key, dt.Value);
            }
        }

        //Queue
        partial void queue()
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(10);
            queue.Enqueue(33);
            queue.Enqueue(45);
            Console.WriteLine("\n Items in Queue");
            foreach(var a in queue)
            {
                Console.WriteLine(a);
            }
            queue.Dequeue();
            queue.Enqueue(63);
            Console.WriteLine("\n Items in Queue after Deletion and Insertion");
            foreach (var a in queue)
            {
                Console.WriteLine(a);
            }
        }

        //hashset
        partial void hashset()
        {
            HashSet<string> hs = new HashSet<string>();
            hs.Add("Lists");
            hs.Add("Queue");
            hs.Add("Stack");
            Console.WriteLine("\n Items in HashSet");
            foreach (var d in hs)
            {
                Console.WriteLine(d);
            }
            Console.WriteLine("\n Items in HashSet after Deletion and Insertion");
            hs.Remove("Stack");
            hs.Add("Hashtable");
            hs.Add("Queue");
            foreach (var d in hs)
            {
                Console.WriteLine(d);
            }
        }

        //LinkedList
        partial void linkedList()
        {
            LinkedList<string> list = new LinkedList<string>();
            list.AddLast("Hemanth");
            list.AddLast("Sharon");
            Console.WriteLine("\n Names in LinkedList");
            foreach (var c1 in list)
            {
                Console.WriteLine(c1);
            }
            list.AddFirst("Arun Joseph");
            var node = list.AddLast("Vignesh");
            list.AddBefore(node, "Srikanth");
            list.AddAfter(node, "Yamini");
            Console.WriteLine("\n Names in LinkedList after Insertion");
            foreach (var c1 in list)
            {
                Console.WriteLine(c1);
            }
            list.RemoveFirst();
            list.RemoveLast();
            Console.WriteLine("\n Names in LinkedList after Deletion");
            foreach (var c1 in list)
            {
                Console.WriteLine(c1);
            }
        }
    }
}
