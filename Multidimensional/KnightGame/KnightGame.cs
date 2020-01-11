using System;
using System.ComponentModel.DataAnnotations;

namespace KnightGame
{
    class KnightGame
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            char[,] chess = new char[size, size];

            for (int row = 0; row < size; row++)
            {
                char[] line = Console.ReadLine().ToCharArray();
                for (int col = 0; col < size; col++)
                {
                    chess[row,col] = line[col];
                }
            }

            int count = 0;
            

            while (true)
            {
                int maxCycleAttacking = 0;
                int rowMaxAttacker = 0;
                int colMaxAttacker = 0;

                for (int row = 0; row < size; row++)
                {
                    for (int col = 0; col < size; col++)
                    {
                        int maxCurAttacking = 0;

                        if (chess[row, col] == 'K')
                        {
                            maxCurAttacking += CheckAttack(chess, row - 1, col - 2);
                            maxCurAttacking += CheckAttack(chess, row - 2, col - 1);
                            maxCurAttacking += CheckAttack(chess, row - 2, col + 1);
                            maxCurAttacking += CheckAttack(chess, row - 1, col + 2);
                            maxCurAttacking += CheckAttack(chess, row + 1, col + 2);
                            maxCurAttacking += CheckAttack(chess, row + 2, col + 1);
                            maxCurAttacking += CheckAttack(chess, row + 2, col - 1);
                            maxCurAttacking += CheckAttack(chess, row + 1, col - 2);
                        }

                        if (maxCurAttacking > maxCycleAttacking)
                        {
                            maxCycleAttacking = maxCurAttacking;
                            rowMaxAttacker = row;
                            colMaxAttacker = col;
                        }
                    }
                }

                if (maxCycleAttacking == 0)
                {
                    break;
                }
                else
                {
                    chess[rowMaxAttacker, colMaxAttacker] = '0';
                    count++;
                }

            }
            Console.WriteLine(count);
        }

        private static int CheckAttack(char[,] chess, int currRow, int curCol)
        {
            if ((currRow >= 0) && (curCol >= 0) &&
                (currRow < chess.GetLength(0)) && (curCol < chess.GetLength(1)) &&
                chess[currRow, curCol] == 'K')
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
