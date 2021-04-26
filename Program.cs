using System;

namespace GarysGarage
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero MidnightBlue = new Zero()
            {
                BatteryKWh = 15.5,
                MainColor = "MidnightBlue",
                MaximumOccupancy = "2 people"

            };
            MidnightBlue.Drive();
            MidnightBlue.Turn();
            MidnightBlue.Stop();
            Console.WriteLine();

            Tesla Burgandy = new Tesla()
            {
                BatteryKWh = 24.5,
                MainColor = "Burgandy",
                MaximumOccupancy = "5 people"
            };
            Burgandy.Drive();
            Burgandy.Turn();
            Burgandy.Stop();
            Console.WriteLine();

            Ram Silver = new Ram()
            {
                FuelCapacity = 32.5,
                MainColor = "Silver",
                MaximumOccupancy = "5 people"
            };
            Silver.Drive();
            Silver.Turn();
            Silver.Stop();
            Console.WriteLine();

            Cessna White = new Cessna()
            {
                FuelCapacity = 123.2,
                MainColor = "White",
                MaximumOccupancy = "32 people"
            };
            White.Drive();
            White.Turn();
            White.Stop();
            Console.WriteLine();

        }
    }
}
