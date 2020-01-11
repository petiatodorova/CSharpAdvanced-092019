using System;
using System.Collections.Generic;
using System.Linq;

namespace Test
{
    class Test
    {
        static void Main(string[] args)
        {
            HashSet<int> test = new HashSet<int>();
            test.Add(3);
            if (test.Contains(3))
            {
                Console.WriteLine("yes");
            }
            
        }
    }
}
