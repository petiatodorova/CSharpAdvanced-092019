using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise2
{
    public class QueueSample
    {
        public static void Main(string[] args)
        {

            int[] nsx = Console.ReadLine()
                 .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToArray();
            int n = nsx[0];
            int s = nsx[1];
            int x = nsx[2];

            int[] numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Queue<int> myQueue = new Queue<int>();

            int length = numbers.Length;
            int endNum = 0;

            if (n <= length)
            {
                endNum = n;
            }
            else
            {
                endNum = length;
            }
            for (int i = 0; i < endNum; i++)
            {
                myQueue.Enqueue(numbers[i]);
            }

            if (s <= myQueue.Count)
            {
                endNum = s;
            }
            else
            {
                endNum = myQueue.Count;
            }

            for (int i = 0; i < endNum; i++)
            {
                myQueue.Dequeue();
            }

            if (myQueue.Count > 0)
            {
                if (myQueue.Contains(x))
                {
                    Console.WriteLine($"true");
                }
                else
                {
                    Console.WriteLine(myQueue.Min());
                }
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
