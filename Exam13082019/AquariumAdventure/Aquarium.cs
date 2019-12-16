using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AquariumAdventure
{
    public class Aquarium
    {
        private HashSet<Fish> fishInPool;

        public Aquarium(string name, int capacity, int size)
        {
            Name = name;
            Capacity = capacity;
            Size = size;
            this.fishInPool = new HashSet<Fish>();
        }

        public string Name { get; set; }

        public int Capacity { get; set; }

        //the volume
        public int Size { get; set; }

        //Method Add(Fish fish) - adds the entity if there isn't a fish with 
        //the same name and if there is enough space for it.
        public void Add(Fish fish)
        {
            if (this.fishInPool.Count < this.Capacity)
            {
                this.fishInPool.Add(fish);
            }
        }

        //Method Remove(string name) - removes a fish from the pool with the given name, 
        //            if such exists and returns bool if the deletion is successful.

        public bool Remove(string name)
        {
            foreach (var fish in this.fishInPool)
            {
                if (fish.Name == name)
                {
                    fishInPool.Remove(fish);
                    return true;
                }
            }

            return false;
        }

        //Method FindFish(string name) - returns a fish with the given name.If it doesn't exist, return null.

        public Fish FindFish(string name)
        {
            return fishInPool.FirstOrDefault(x => x.Name == name);
        }

        //Method Report() - returns information about the aquarium and the fish inside it in the following format:
        //"Aquarium: {name} ^ Size: {size}
        //{Fish1}
        //{Fish2}

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Aquarium: {this.Name} ^ Size: {this.Size}");
            foreach (var fish in this.fishInPool)
            {
                sb.AppendLine(fish.ToString());
            }

            return sb.ToString().TrimEnd();
        }
    }
}
