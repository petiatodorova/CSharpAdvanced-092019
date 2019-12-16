using System;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BookWorm
{
    public class BookWorm
    {
        static void Main(string[] args)
        {
            //On the first line, you are given the initial string
            //On the second line, you are given the integer N - the size of the square matrix
            //The next N lines holds the values for every row
            //On each of the next lines you will get a move command

            StringBuilder sb = new StringBuilder(Console.ReadLine());
            
            int size = int.Parse(Console.ReadLine());

            char[,] matrix = new char[size, size];

            int playerX = 0;
            int playerY = 0;


            // feed the matrix
            for (int i = 0; i < size; i++)
            {
                char[] curLine = Console.ReadLine().ToCharArray();
                for (int j = 0; j < size; j++)
                {
                    matrix[i, j] = curLine[j];
                    if (matrix[i,j].Equals('P'))
                    {
                        // player's position
                        playerX = i;
                        playerY = j;
                    }
                }
            }

            //

            //If he moves to a letter, he consumes it, concatеnates it to the initial string 
            //and the letter disappears from the field. If he tries to move outside of the field, 
            //he is punished - he loses the last letter in the string, if there are any, and the player’s position is not changed.
            //When the command "end" is received, stop the program, print all letters and the field.

            string command = Console.ReadLine();

            while (command != "end")
            {
                switch (command)
                {
                    case "up":
                        if (playerX > 0)
                        {
                            matrix[playerX, playerY] = '-';
                            playerX--;
                            ConcateAndEatAndPlaceP(sb, matrix, playerX, playerY);

                        }
                        else
                        {
                            //If he tries to move outside of the field, he is punished - he loses the last letter in the string, 
                            //if there are any, and the player’s position is not changed.
                            RemoveLastChar(sb);
                        }

                        break;

                    case "down":
                        if (playerX < size - 1)
                        {
                            matrix[playerX, playerY] = '-';
                            playerX++;
                            ConcateAndEatAndPlaceP(sb, matrix, playerX, playerY);
                        }
                        else
                        {
                            //If he tries to move outside of the field, he is punished - he loses the last letter in the string, 
                            //if there are any, and the player’s position is not changed.
                            RemoveLastChar(sb);
                        }
                        break;

                    case "left":
                        if (playerY > 0)
                        {
                            matrix[playerX, playerY] = '-';
                            playerY--;
                            ConcateAndEatAndPlaceP(sb, matrix, playerX, playerY);
                        }
                        else
                        {
                            //If he tries to move outside of the field, he is punished - he loses the last letter in the string, 
                            //if there are any, and the player’s position is not changed.
                            RemoveLastChar(sb);
                        }
                        break;

                    case "right":
                        if (playerY < size - 1)
                        {
                            matrix[playerX, playerY] = '-';
                            playerY++;
                            ConcateAndEatAndPlaceP(sb, matrix, playerX, playerY);
                        }
                        else
                        {
                            //If he tries to move outside of the field, he is punished - he loses the last letter in the string, 
                            //if there are any, and the player’s position is not changed.
                            RemoveLastChar(sb);
                        }
                        break;
                }

                // end of switch

                command = Console.ReadLine();
            }
            // end while loop

            // print
            Console.WriteLine(sb.ToString());
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(matrix[i,j]);
                }
                Console.WriteLine();
            }
        }

        private static void RemoveLastChar(StringBuilder sb)
        {
            if (sb.Length > 0)
            {
                sb.Remove(sb.Length - 1, 1);
            }
        }

        private static void ConcateAndEatAndPlaceP(StringBuilder sb, char[,] matrix, int playerX, int playerY)
        {
            if (!(matrix[playerX, playerY].Equals('-') || matrix[playerX, playerY].Equals('P')))
            {
                //If he moves to a letter, he consumes it, concatеnates it to the initial 
                //string and the letter disappears from the field
                sb.Append(matrix[playerX, playerY]);
                matrix[playerX, playerY] = 'P';
            }
        }
    }
}
