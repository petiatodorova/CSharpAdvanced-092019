using System;
using System.Collections.Generic;
using System.Linq;

namespace Play
{
    public class PlayAround
    {
        public static void Main(string[] args)
        {
            byte n = byte.Parse(Console.ReadLine());
            Stack<byte> myStack = new Stack<byte>();

            for (byte i = 0; i < n; i++)
            {
                byte[] query = Console.ReadLine()
                 .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                 .Select(byte.Parse)
                 .ToArray();

                byte first = query[0];

                switch (first)
                {
                    case 1:
                        myStack.Push(query[1]);
                        break;
                    case 2:
                        if (myStack.Any())
                        {
                            myStack.Pop();
                        }
                        break;
                    case 3:
                        if (myStack.Any())
                        {
                            Console.WriteLine($"{myStack.Max()}");
                        }
                        break;
                    case 4:
                        if (myStack.Any())
                        {
                            Console.WriteLine($"{myStack.Min()}");
                        }
                        break;
                }

            }

            Console.WriteLine($"{string.Join(", ", myStack)}");
        }
    }
}
