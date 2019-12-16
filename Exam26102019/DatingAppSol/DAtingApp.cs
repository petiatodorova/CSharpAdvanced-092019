using System;
using System.Collections.Generic;
using System.Linq;

namespace DatingAppSol
{
    public class DAtingApp
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine()
            .Split()
            .Select(sbyte.Parse);

            var males = new Stack<sbyte>(line);

            line = Console.ReadLine()
            .Split()
            .Select(sbyte.Parse);

            var females = new Queue<sbyte>(line);
            sbyte matchesCount = 0;

            while (females.Any() && males.Any())
            {
                if (females.Peek() <= 0)
                {
                    females.Dequeue();
                    //If someone’s value is equal to or below 0, you should remove him/ her 
                    //from the records before trying to match him/ her with anybody.
                    continue;

                }
                else if (males.Peek() <= 0)
                {
                    males.Pop();
                    continue;
                }
                else if (females.Peek() % 25 == 0)
                {
                    females.Dequeue();
                    if (females.Count > 0)
                    {
                        females.Dequeue();
                    }
                    continue;

                    //Special case - if someone’s value divisible by 25 without remainder, 
                    //you should remove him / her and the next person of the same gender. 
                }
                else if (males.Peek() % 25 == 0)
                {
                    males.Pop();
                    if (males.Count > 0)
                    {
                        males.Pop();
                    }
                    continue;
                }

                if (females.Peek() == males.Peek())
                {
                    //If their values are equal, you have to match them and remove both of them. 
                    matchesCount++;
                    females.Dequeue();
                    males.Pop();
                    continue;
                }
                else
                {
                    //Otherwise you should remove only the female and decrease the value of the male by 2.
                    females.Dequeue();
                    if (males.Count > 0)
                    {
                        males.Push((sbyte)(males.Pop() - 2));
                    }
                }
            }

            Console.WriteLine($"Matches: {matchesCount}");

            //On the second line -prsbyte all males left:
            //oIf there are no males: "Males left: none"
            //oIf there are males: "Males left: {male1}, {male2}, {male3}, (…)"

            if (males.Count == 0)
            {
                Console.WriteLine("Males left: none");
            }
            else
            {
                Console.WriteLine($"Males left: {string.Join(", ", males)}");
            }

            //On the third line -prsbyte all females left:
            //oIf there are no females: "Females left: none"
            //oIf there are females: "Females left: {female1}, {female2}, {female3}, (…)"

            if (females.Count == 0)
            {
                Console.WriteLine("Females left: none");
            }
            else
            {
                Console.WriteLine($"Females left: {string.Join(", ", females)}");
            }
        }
    }
}
