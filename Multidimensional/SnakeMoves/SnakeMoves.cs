using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace SnakeMoves
{
    class SnakeMoves
    {
        static void Main(string[] args)
        {
            int[] line = Console.ReadLine()
              .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
              .Select(int.Parse)
              .ToArray();

            string snake = Console.ReadLine();

            int rows = line[0];
            int cols = line[1];

            char[,] matrix = new char[rows, cols];

            string repeatedSnake = "";
            int timesRepeated = 0;
            if ((rows * cols) % snake.Length != 0)
            {
                timesRepeated = (rows * cols) / snake.Length + 1;
            }
            else
            {
                timesRepeated = (rows * cols) / snake.Length;
            }

            for (int i = 0; i < timesRepeated; i++)
            {
                repeatedSnake += snake;
            }

            int index = 0;

            for (int row = 0; row < rows; row++)
            {
                if (row % 2 == 0)
                {
                    for (int col = 0; col < cols; col++)
                    {
                        matrix[row, col] = repeatedSnake[index];
                        index++;
                    }
                }
                else
                {
                    for (int col = cols - 1; col >= 0; col--)
                    {
                        matrix[row, col] = repeatedSnake[index];
                        index++;
                    }
                }
            }

            // print final
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write($"{matrix[row, col]}");
                }

                Console.WriteLine();
            }
        }
    }
}
