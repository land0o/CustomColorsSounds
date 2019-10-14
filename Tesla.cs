using System;

namespace customColorsSound
{
    public class Tesla : Vehicle
    {
        public double BatteryKWh { get; set; }

        public void ChargeBattery()
        {

        }
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Tesla goes put put put!");
        }
        public override void Turn(string direction)
        {
            Console.WriteLine($"The {MainColor} Tesla turns to the {direction}");
        }
        public override void Stop()
        {
            Console.WriteLine($"Then the {MainColor} Tesla stops because there is a lake where the road used to be.");
        }
    }
}