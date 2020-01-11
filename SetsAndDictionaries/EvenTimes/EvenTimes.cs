using System;
using System.Collections.Generic;
using System.Linq;

namespace EvenTimes
{
    class EvenTimes
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<int, int> numCounts = new Dictionary<int, int>();

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (!numCounts.ContainsKey(num))
                {
                    numCounts[num] = 0;
                }
                numCounts[num]++;
            }

            int theNum = numCounts.Keys
                .FirstOrDefault(x => numCounts[x] % 2 == 0);
            Console.WriteLine(theNum);
        }
    }
}
