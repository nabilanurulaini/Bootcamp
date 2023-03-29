using System;
namespace Day8_4;
class Program{
    static void Main(string[] args){
        Console.WriteLine("Input a planet name: ");
        string input = Console.ReadLine();
        string PlanetName = input.ToLower();
        switch(PlanetName){
            case "mercury":
                Console.WriteLine("Mercury radius is: "+(int)PlanetRadius.Mercury);
                break;
            case "venus":
                Console.WriteLine("Venus radius is: "+(int)PlanetRadius.Venus);
                break;
            case "earth":
                Console.WriteLine("Earth radius is: "+(int)PlanetRadius.Earth);
                break;
            case "mars":
                Console.WriteLine("Mars radius is: "+(int)PlanetRadius.Mars);
                break;
            case "jupiter":
                Console.WriteLine("Jupiter radius is: "+(int)PlanetRadius.Jupiter);
                break;
            case "saturn":
                Console.WriteLine("Saturn radius is: "+(int)PlanetRadius.Saturn);
                break;
            case "uranus":
                Console.WriteLine("Uranus radius is: "+(int)PlanetRadius.Uranus);
                break;
            case "neptune":
                Console.WriteLine("Neptune radius is: "+(int)PlanetRadius.Neptune);
                break;
            case "pluto":
                Console.WriteLine("Pluto radius is: "+(int)PlanetRadius.Pluto);
                break;
            default:
                Console.WriteLine("Invalid input");
                break;
        }

        // foreach(PlanetRadius planet in Enum.GetValues(typeof(PlanetRadius))){
        //     Console.WriteLine(planet);
        // }
       
        
    }
}

enum PlanetRadius
{
    Mercury = 2439,
    Venus = 6052,
    Earth = 6371,
    Mars = 3389,
    Jupiter = 69911,
    Saturn = 58232,
    Uranus = 25362,
    Neptune = 24622,
    Pluto = 1188
    
}