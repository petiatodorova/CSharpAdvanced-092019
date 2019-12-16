﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AquariumAdventure
{
    public class Fish
    {
        public Fish(string name, string color, int fins)
        {
            Name = name;
            Color = color;
            Fins = fins;
        }

        public string Name { get; set; }
        public string Color { get; set; }
        public int Fins { get; set; }

        public override string ToString()
        {
            return $"Fish: {this.Name}{Environment.NewLine}Color: {this.Color}{Environment.NewLine}Number of fins: {this.Fins}";
        }
    }


}
