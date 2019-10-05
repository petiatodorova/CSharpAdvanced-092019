using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace SongsQueue
{
    public class SongsQueue
    {
        public static void Main()
        {
            string[] input = Console.ReadLine()
            .Split(", ", StringSplitOptions.RemoveEmptyEntries)
            .ToArray();
            Queue<string> songs = new Queue<string>(input);

            while (true)
            {
                if (!songs.Any())
                {
                    Console.WriteLine($"No more songs!");
                    return;
                }

                string[] currLine = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

                switch (currLine[0])
                {
                    case "Play":
                        songs.Dequeue();
                        break;


                    case "Add":
                        StringBuilder temp = new StringBuilder();

                        for (int i = 1; i < currLine.Length; i++)
                        {
                            temp.Append($"{currLine[i]} ");
                        }

                        string song = temp.ToString().Trim();

                        if (!songs.Contains(song))
                        {
                            songs.Enqueue(song);
                        }
                        else
                        {
                            Console.WriteLine($"{song} is already contained!");
                        }

                        break;


                    case "Show":

                        Console.WriteLine($"{string.Join(", ", songs)}");
                        break;
                }
            }
        }
    }
}
