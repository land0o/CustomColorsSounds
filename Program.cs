using System;

namespace customColorsSound
{
    class Program
    {
        static void Main(string[] args)
        {
            // fxs is the model
            Zero fxs = new Zero();
            fxs.MainColor = "Gold";

            // models is the model
            Tesla modelS = new Tesla();
            modelS.MainColor = "Orange";


            // mx410 is the model
            Cessna mx410 = new Cessna();
            mx410.MainColor = "Blue";

            fxs.Drive();
            fxs.Turn("North");
            fxs.Stop();
            mx410.Drive();
            mx410.Turn("East");
            mx410.Stop();
            modelS.Drive();
            modelS.Turn("West");
            modelS.Stop();
        }
    }
}
