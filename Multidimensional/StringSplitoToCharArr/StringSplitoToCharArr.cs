using System;
using System.Collections.Generic;
using System.Linq;

namespace Test1
{
    class StringSplitoToCharArr
    {
        static void Main(string[] args)
        {
            int size = 3;
            char[,] test = new char[size, size];

            for (int row = 0; row < size; row++)
            {
                List<string> testStr = Console.ReadLine()
                    .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries).ToList();

                for (int col = 0; col < size; col++)
                {
                    test[row, col] = testStr[col][0];
                }
            }
        }
    }
}
