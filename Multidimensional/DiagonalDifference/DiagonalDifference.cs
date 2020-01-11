using System;
using System.Linq;
using System.Collections.Generic;

namespace DiagonalDifference
{
    class DiagonalDifference
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[,] matrix = new int[size, size];

            for (int row = 0; row < size; row++)
            {
                int[] line = Console.ReadLine()
                    .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = line[col];
                }
            }

            int sumFirstDiag = 0;
            int sumSecondDiag = 0;

            for (int row = 0; row < size; row++)
            {
                sumFirstDiag += matrix[row, row];
                sumSecondDiag += matrix[row, size - row - 1];
            }

            Console.WriteLine($"{Math.Abs(sumFirstDiag - sumSecondDiag)}");
        }
    }
}
