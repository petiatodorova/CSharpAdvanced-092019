using System;
using System.Collections.Generic;
using System.Linq;

namespace TwoByTwoSquares
{
    class TwoByTwoSquares
    {
        static void Main(string[] args)
        {
            int[] line = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            if (line.Length <= 1)
            {
                Console.WriteLine(0);
                return;
            }
            int rows = line[0];
            int cols = line[1];

            if (rows < 2 || cols < 2)
            {
                Console.WriteLine(0);
                return;
            }

            int sumEqualQuadrats = 0;

            char[,] matrix = new char[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                char[] curRow = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse)
                    .ToArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = curRow[col];
                }
            }

            for (int row = 0; row < rows - 1; row++)
            {
                for (int col = 0; col < cols - 1; col++)
                {
                    if (
                        matrix[row, col].Equals(matrix[row + 1, col]) &&
                        matrix[row, col + 1].Equals(matrix[row + 1, col + 1]) &&
                        matrix[row, col].Equals(matrix[row, col + 1])
                        )
                    {
                        sumEqualQuadrats ++;
                    }
                }
            }

            Console.WriteLine($"{sumEqualQuadrats}");
        }
    }
}
