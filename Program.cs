using HB.MarsRover.Enums;
using HB.MarsRover.Models;
using System;

namespace HB.MarsRover
{
    internal class Program
    {
        static void Main(string[] args)
        {  
             
            Rover rover = new Rover(new Area(5, 5), new Location(1, 2), CordinatesEnum.NORT);
            if (rover.RunLetter("LMLMLMLMMMM"))
                Console.WriteLine(rover.WriteCurrentLocation());
            else
            {
                Console.WriteLine("Rover can't do this command."); 
                rover.LandRoverFirstLocation(1, 2, CordinatesEnum.NORT);
                Console.WriteLine(rover.WriteCurrentLocation());
            }


            rover.LandRoverFirstLocation(3, 3, CordinatesEnum.EAST);
            if (rover.RunLetter("MMRMMRMRRM")) 
                Console.WriteLine(rover.WriteCurrentLocation()); 
            else
            {
                Console.WriteLine("Rover can't do this command.");
                rover.LandRoverFirstLocation(3, 3, CordinatesEnum.EAST);
                Console.WriteLine(rover.WriteCurrentLocation());
            }
            Console.Read();
        }
    }
}
