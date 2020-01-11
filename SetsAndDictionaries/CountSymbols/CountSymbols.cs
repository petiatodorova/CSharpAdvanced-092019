using System;
using System.Collections.Generic;
using System.Linq;

namespace CountSymbols
{
    class CountSymbols
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<char, int> symbolsCount = new Dictionary<char, int>();

            for (int i = 0; i < input.Length; i++)
            {
                char symbol = input[i];

                if (!symbolsCount.ContainsKey(symbol))
                {
                    symbolsCount[symbol] = 0;
                }
                symbolsCount[symbol]++;
            }

            foreach (var item in symbolsCount.Keys.OrderBy(x => x))
            {
                Console.WriteLine($"{item}: {symbolsCount[item]} time/s");
            }
        }
    }
}
