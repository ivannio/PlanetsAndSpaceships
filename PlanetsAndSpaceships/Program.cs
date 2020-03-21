using System;
using System.Collections.Generic;

namespace PlanetsAndSpaceships
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string>() { "Mercury", "Mars" };

            planetList.Add("Jupiter");
            planetList.Add("Saturn");

            var lastPlanets = new List<string>() { "Uranus", "Neptune" };

            planetList.AddRange(lastPlanets);

            planetList.Insert(1, "Earth");
            planetList.Insert(1, "Venus");
            planetList.Add("Pluto");

            var rockyPlanets = planetList.GetRange(0, 4);

            planetList.Remove("Pluto");

            var spaceCrafts = new Dictionary<string, List<string>>();

            spaceCrafts.Add("Voyager 1", new List<string> { "Jupiter", "Saturn", "Earth" });
            spaceCrafts.Add("Voyager 2", new List<string> { "Jupiter", "Saturn", "Earth", "Uranus", "Neptune" });
            spaceCrafts.Add("New Horizons", new List<string> { "Jupiter", "Pluto" });
            spaceCrafts.Add("Mariner 10", new List<string> { "Venus", "Mercury" });
            spaceCrafts.Add("Mars Observer", new List<string> { "Mars" });
            
            var spacecraftsVisitedPlanet = new List<string>();

            foreach (var planet in planetList)
            {
                foreach (var spaceCraft in spaceCrafts)
                {
                    if (spaceCraft.Value.Contains(planet))
                    {
                        spacecraftsVisitedPlanet.Add(spaceCraft.Key);
                    }
                }
                Console.WriteLine($"{planet}: {string.Join(", ", spacecraftsVisitedPlanet)}");
                spacecraftsVisitedPlanet.Clear();
            }
            Console.ReadLine();
        }
    }
}
