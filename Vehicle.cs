using System;

namespace customColorsSound
{
    public class Vehicle
    {
        public string MainColor { get; set; }
        public int MaximumOccupancy { get; set; }
        // public string Make { get; set; }


        // public Vehicle(string name, string color, int occupants)
        // {
        //     Make = name;
        //     MainColor = color;
        //     MaximumOccupancy = occupants;
        // }
        public virtual void Drive()
        {
            Console.WriteLine("Vrooom!");
        }
        public virtual void Turn(string direction)
        {
            Console.WriteLine("Turn Right!");
        }
        public virtual void Stop()
        {
            Console.WriteLine("Then the car stopped.");
        }

    }
}