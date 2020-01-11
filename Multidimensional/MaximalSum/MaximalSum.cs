using System;
using System.Collections.Generic;
using System.Linq;

namespace MaximalSum
{
    class MaximalSum
    {
        static void Main(string[] args)
        {
            int[] line = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rows = line[0];
            int cols = line[1];

            if (rows < 3 || cols < 3)
            {
                return;
            }

            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                int[] curLine = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = curLine[col];
                }
            }

            int maxSum = int.MinValue;
            int rowMaxSum = 0;
            int colMaxSum = 0;

            for (int row = 0; row < rows - 2; row++)
            {
                for (int col = 0; col < cols - 2; col++)
                {
                    int sum = 0;
                    for (int i = row; i <= row + 2; i++)
                    {
                        for (int j = col; j <= col + 2; j++)
                        {
                            sum += matrix[i, j];
                        }

                    }
                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        rowMaxSum = row;
                        colMaxSum = col;
                    }
                }
            }

            Console.WriteLine($"Sum = {maxSum}");

            for (int row = rowMaxSum; row <= rowMaxSum + 2; row++)
            {
                for (int col = colMaxSum; col <= colMaxSum + 2; col++)
                {
                    Console.Write($"{matrix[row, col]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
