using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace BalancedParentheses
{
    public class BalancedParentheses
    {
        static void Main()
        {
            char[] input = Console.ReadLine().ToArray();
            Stack<char> leftParentheses = new Stack<char>(input);
            bool balanced = true;

            for (int i = 0; i < input.Length; i++)
            {
                char symbol = input[i];

                if (symbol.Equals('(') || symbol.Equals('[') || symbol.Equals('{'))
                {
                    leftParentheses.Push(symbol);
                }
                else
                {
                    if (leftParentheses.Any())
                    {
                        if (
                            (symbol.Equals('}') && !(leftParentheses.Pop().Equals('{'))) ||
                            (symbol.Equals(')') && !(leftParentheses.Pop().Equals('('))) ||
                            (symbol.Equals(']') && !(leftParentheses.Pop().Equals('[')))
                            )
                        {
                            balanced = false;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }
            if (balanced)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
