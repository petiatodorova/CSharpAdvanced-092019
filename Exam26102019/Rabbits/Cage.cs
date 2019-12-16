using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Rabbits
{
    public class Cage
    {
        private List<Rabbit> data;

        public Cage(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            this.data = new List<Rabbit>();
            
        }
        public string Name { get; set; }
        public int Capacity { get; set; }

        public void Add(Rabbit rabbit)
        {
            if (this.data.Count < this.Capacity)
            {
                this.data.Add(rabbit);
            }
        }

        public bool RemoveRabbit(string name)
        {
            foreach (var rabbit in this.data)
            {
                if (rabbit.Name == name)
                {
                    return true;
                }
            }

            return false;
        }

        //Method RemoveSpecies(string species) - removes all rabbits by given species
        public void RemoveSpecies(string species)
        {
            this.data.RemoveAll(x => x.Species == species);
        }

        //Method SellRabbit(string name) - sell(set its Available property to false without removing it 
        //from the collection) the first rabbit with the given name, also return the rabbit
        public Rabbit SellRabbit(string name)
        {
            var rabbitToSell = this.data.FirstOrDefault(x => x.Name == name);
            rabbitToSell.Available = false;
            return rabbitToSell;
        }


        //Method SellRabbitsBySpecies(string species) - sells(set their Available property to false 
        //without removing them from the collection) and returns all rabbits from that species as an array
        public Rabbit[] SellRabbitsBySpecies(string species)
        {
            List<Rabbit> selledRabbits = new List<Rabbit>();

            foreach (var rabbit in this.data)
            {
                if (rabbit.Species == species)
                {
                    rabbit.Available = false;
                    selledRabbits.Add(rabbit);
                }
            }

            return selledRabbits.ToArray();
        }


        //Getter Count - returns the number of rabbits
        public int Count => this.data.Count;


        //Report() - returns a string in the following format, including only not sold rabbits:
        //"Rabbits available at {cageName}:
        //{Rabbit1}
        //{Rabbit2}
        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Rabbits available at {this.Name}:");
            foreach (var rabbitNotSold in this.data)
            {
                if (rabbitNotSold.Available)
                {
                    sb.AppendLine(rabbitNotSold.ToString());
                }
            }

            return sb.ToString().TrimEnd();
        }
    }
}
