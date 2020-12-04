using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SolarSystem
{
    class Program
    {
        public class Item
        {
            string name;
            int mass;

            public Item(string _name, int _mass)
            {
                name = _name;
                mass = _mass;
                Console.WriteLine($"Item {name} create");
            }

            public string Name { get { return name; } }
            public int Mass { get { return mass; } }
        }
        static void Main(string[] args)
        {
            SolarSystem();
        }

        public static void SolarSystem()
        {
            string filePath = @"C:\Users\opilane\samples";
            string fileName = @"planet.txt";

            List<Item> pLaNeT = new List<Item>();

            List<string> linesFromFile = File.ReadAllLines(Path.Combine(filePath, fileName)).ToList();

            foreach (string line in linesFromFile)
            {
                string[] tempArray = line.Split(new char[] { '$' }, StringSplitOptions.RemoveEmptyEntries);
                Item newItem = new Item(tempArray[0], Int32.Parse(tempArray[1]));
                pLaNeT.Add(newItem);

            }

            Console.WriteLine("your planets :");
            int total = 0;
            foreach (Item item in pLaNeT)
            {
                Console.WriteLine($"Item: {item.Name}; mass: {item.Mass}");
                total += item.Mass;
            }
            Console.WriteLine($"Your planets total mass is : {total} ");
        }
    }
}
