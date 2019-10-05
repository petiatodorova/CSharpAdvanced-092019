using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace TextEditor
{
    public class TextEditor
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<char> allText = new List<char>();
            Stack<string> stackVariations = new Stack<string>();

            for (int i = 0; i < n; i++)
            {
                string[] line = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

                string command = line[0];

                if (command == "1")
                {
                    char[] someString = line[1].ToCharArray();
                    allText.AddRange(someString);
                    string currTextVersion = $"{string.Join("", allText)}";
                    stackVariations.Push(currTextVersion);
                }
                else if (command == "2")
                {
                    int count = int.Parse(line[1]);

                    if (count <= allText.Count)
                    {
                        allText.RemoveRange(allText.Count - count, count);
                        string currTextVersion = $"{string.Join("", allText)}";
                        stackVariations.Push(currTextVersion);
                    }
                }
                else if (command == "3")
                {
                    int index = int.Parse(line[1]);
                    if (index >= 1 && index <= allText.Count)
                    {
                        Console.WriteLine(allText[index - 1]);
                    }
                }
                else if (command == "4")
                {
                    if (stackVariations.Any())
                    {
                        stackVariations.Pop();
                    }
                    allText.Clear();
                    if (stackVariations.Any())
                    {
                        allText.AddRange(stackVariations.Peek().ToCharArray());
                    }
                }
            }
        }
    }
}

