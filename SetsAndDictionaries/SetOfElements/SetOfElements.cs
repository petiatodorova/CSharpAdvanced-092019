using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace SetOfElements
{
    class SetOfElements
    {
        static void Main(string[] args)
        {

            int[] numbers = Console.ReadLine()
             .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
             .Select(int.Parse)
             .ToArray();

            int n = numbers[0];
            int m = numbers[1];

            HashSet<int> nNumbers = new HashSet<int>();
            HashSet<int> mNumbers = new HashSet<int>();
            for (int i = 0; i < n; i++)
            {
                nNumbers.Add(int.Parse(Console.ReadLine()));
            }
            for (int i = 0; i < m; i++)
            {
               mNumbers.Add(int.Parse(Console.ReadLine()));
            }

            HashSet<int> intersected = nNumbers.Intersect(mNumbers).ToHashSet();


            Console.WriteLine($"{string.Join(" ", intersected)}");
        }
    }
}
