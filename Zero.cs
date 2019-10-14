using System;

namespace customColorsSound
{
    public class Zero : Vehicle
    {  // Electric motorcycle

        public double BatteryKWh { get; set; }

        public void ChargeBattery()
        {

        }
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Zero goes Vrooooomy!");
        }
        public override void Turn(string direction)
        {
            Console.WriteLine($"The {MainColor} Zero turns to the {direction}");
        }
        public override void Stop()
        {
            Console.WriteLine($"Then the {MainColor} Zero stops because there is an Andy on the road.");
        }
    }
}
