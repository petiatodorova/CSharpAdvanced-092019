using System;
using System.Linq;
using System.Collections.Generic;

namespace FastFood
{
    public class FastFood
    {
        public static void Main(string[] args)
        {
            int remainingFood = int.Parse(Console.ReadLine());

            int[] myOrders = Console.ReadLine()
                 .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToArray();
            Queue<int> theOrders = new Queue<int>();


            foreach (var item in myOrders)
            {
                theOrders.Enqueue(item);
            }

            Console.WriteLine(theOrders.Max());

            while (theOrders.Any())
            {
                int curOrder = theOrders.Peek();
                if (curOrder > remainingFood)
                {
                    Console.WriteLine($"Orders left: {string.Join(" ", theOrders)}");
                    break;
                }
                else
                {
                    remainingFood -= curOrder;
                    theOrders.Dequeue();
                    if (!theOrders.Any())
                    {
                        Console.WriteLine("Orders complete");
                    }
                }
            }
        }
    }
}