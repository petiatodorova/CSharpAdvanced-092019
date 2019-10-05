using System;
using System.Collections.Generic;
using System.Linq;

namespace FashionBoutique
{
    public class FashionBoutique
    {
        public static void Main()
        {
            int[] clothes = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

            Stack<int> dresses = new Stack<int>(clothes);

            int capacity = int.Parse(Console.ReadLine());
            if (!dresses.Any())
            {
                Console.WriteLine(0);
                return;
            }

            int countRacks = 1;
            int currSum = capacity;

            while (dresses.Any())
            {
                currSum -= dresses.Peek();
                if (currSum >= 0)
                {
                    dresses.Pop();
                }
                else
                {
                    countRacks++;
                    currSum = capacity;
                }

            }

            Console.WriteLine(countRacks);
        }
    }
}
