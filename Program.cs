// Practice Lists in C#
using System;
using System.Collections.Generic;

namespace lists
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            List<string> planetList = new List<string>()
            {
                "Mercury", "Mars"
            };

            //Add to a list
            planetList.Add("Jupiter");
            planetList.Add("Saturn");

            //Iterate through a list in C#
            foreach(string planet in planetList){
                Console.WriteLine(planet);
            };
            Console.WriteLine("");

            //Create new list to hold last 2 planets
            List <string> lastPlanetList = new List<string>()
            {
                "Uranus", "Neptune"
            };

            //Concatenate both lists
            planetList.AddRange(lastPlanetList);

            //Insert Earth and Venus
            planetList.Insert(1, "Venus");
            planetList.Insert(2, "Earth");

            //Iterate through a list in C#
            foreach(string planet in planetList){
                Console.WriteLine(planet);
            };
            Console.WriteLine("");

            //Add Pluto to list
            planetList.Add("Pluto");

            //Iterate through a list in C#
            foreach(string planet in planetList){
                Console.WriteLine(planet);
            };

            Console.WriteLine("");

            //Create an empty new list called rockyPlanets
            List <string> rockyPlanets = new List <string>(){

            };

            //Get rocky planets Mercury, Venus, Earth, Mars and add to new rockyPlanets list
            rockyPlanets = planetList.GetRange(0,4);

            foreach(string planet in rockyPlanets){
                Console.WriteLine(planet);
            }
            Console.WriteLine("");

            //Remove Pluto from the planetList list
            planetList.Remove("Pluto");

            foreach(string planet in planetList){
                Console.WriteLine(planet);
            };
            Console.WriteLine("");

            //Create a list of dictionaries...?

            //Create a dictionary holding the name of spacecraft launched and 1 planet it has visited.
            Dictionary<string, string> spaceCraft = new Dictionary <string, string>();
            spaceCraft.Add("Messenger", "Mercury");
            spaceCraft.Add("Mariner 10", "Mercury");
            spaceCraft.Add("BepiColombo", "Mercury");
            spaceCraft.Add("Sputnik 19", "Venus");
            spaceCraft.Add("Zond 1", "Venus");
            spaceCraft.Add("Cosmos 96", "Venus");
            spaceCraft.Add("Zond 2", "Mars");
            spaceCraft.Add("Mariner 3", "Mars");
            spaceCraft.Add("Mariner 6", "Mars");

            foreach(KeyValuePair<string, string> craft in spaceCraft){
                //Sample:  trying different methods to see what works...I'm sooo close....
                if (craft.Value == "Mercury"){
                    Console.WriteLine(craft.Value + " " + craft.Key);
                }
            }
            Console.WriteLine("");

        }

    }
}
