using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace JaggedArrayManipulator
{
    class JaggedArrayManipulator
    {
        static void Main(string[] args)
        {

            int rows = int.Parse(Console.ReadLine());
            double[][] jaggedMatrix = new double[rows][];

            for (int i = 0; i < rows; i++)
            {
                double[] currRow = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(double.Parse)
                    .ToArray();
                jaggedMatrix[i] = currRow;
            }

            // equal lengths or no
            for (int row = 0; row < rows - 1; row++)
            {
                int lengthCurrent = jaggedMatrix[row].Length;
                int lengthNext = jaggedMatrix[row + 1].Length;
                if (lengthCurrent == lengthNext)
                {
                    for (int col = 0; col < lengthCurrent; col++)
                    {
                        jaggedMatrix[row][col] *= 2;
                        jaggedMatrix[row + 1][col] *= 2;
                    }
                }
                else
                {
                    for (int col = 0; col < lengthCurrent; col++)
                    {
                        jaggedMatrix[row][col] /= 2;
                    }
                    for (int col = 0; col < lengthNext; col++)
                    {
                        jaggedMatrix[row + 1][col] /= 2;
                    }
                }
            }

            while (true)
            {
                string[] line = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                if (line[0] == "End")
                {
                    break;
                }

                string command = line[0];
                int row = int.Parse(line[1]);
                int column = int.Parse(line[2]);
                double value = double.Parse(line[3]);

                if (command == "Add" &&
                    row >= 0 && row < jaggedMatrix.Length &&
                    column >= 0 && column < jaggedMatrix[row].Length)
                {
                    jaggedMatrix[row][column] += value;
                }
                else if (command == "Subtract" &&
                    row >= 0 && row < jaggedMatrix.Length &&
                    column >= 0 && column < jaggedMatrix[row].Length)
                {
                    jaggedMatrix[row][column] -= value;
                }
            }

            foreach (var curRow in jaggedMatrix)
            {
                Console.WriteLine($"{string.Join(' ', curRow)}");
            }
        }
    }
}
