using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Wardrobe
{
    class Wardrobe
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, int>> colorClothCount = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {

                string[] line = Console.ReadLine()
                    .Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string color = line[0];

                if (!colorClothCount.ContainsKey(color))
                {
                    colorClothCount[color] = new Dictionary<string, int>();
                }

                string[] clothes = line[1]
                    .Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                foreach (var cloth in clothes)
                {
                    if (!colorClothCount[color].ContainsKey(cloth))
                    {
                        colorClothCount[color][cloth] = 0;
                    }
                    colorClothCount[color][cloth]++;
                }
            }

            //{ color} { clothing}


            string[] colorCloth = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            string colorFor = colorCloth[0];
            string clothing = colorCloth[1];

            foreach (var color in colorClothCount.Keys)
            {
                Console.WriteLine($"{color} clothes:");

                foreach (var dress in colorClothCount[color].Keys)
                {
                    if (color == colorFor && dress == clothing)
                    {
                        Console.WriteLine($"* {dress} - {colorClothCount[color][dress]} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {dress} - {colorClothCount[color][dress]}");
                    }
                }
            }
        }
    }
}
