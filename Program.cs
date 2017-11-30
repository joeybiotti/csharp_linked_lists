using System;
using System.Collections.Generic;

namespace linked_lists
{
    class Program
    {
        static void Main()
        {
            LinkedList <string> linked = new LinkedList<string>();

            linked.AddLast("Cat");
            linked.AddLast("Dog");
            linked.AddLast("Man");
            linked.AddFirst("First");

            foreach (var item in linked)
            {
                Console.WriteLine(item);
            }
        }
    }
}
