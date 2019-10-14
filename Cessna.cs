using System;

namespace customColorsSound
{
    public class Cessna : Vehicle
    {
        public double FuelCapacity { get; set; }

        public void RefuelTank()
        {

        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Cessna goes Zoooooom!");
        }
        public override void Turn(string direction)
        {
            Console.WriteLine($"The {MainColor} Cessna turns to the {direction}");
        }
        public override void Stop()
        {
            Console.WriteLine($"Then the {MainColor} Cessna stops because there is a Goose on the loose inside the plane.");
        }
    }
}