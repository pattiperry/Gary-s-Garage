using System;

namespace GarysGarage
{
    public class Zero   : Vehicle// Electric motorcycle
    {
        public double BatteryKWh { get; set; }
        
        public void ChargeBattery()
        {
            // method definition omitted
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Zero zips by you. Yeeeeeooowwwwww!");
        }

        public override void Turn()
        {
            Console.WriteLine("This vehicle carefully turns right.");
        }

        public override void Stop()
        {
            Console.WriteLine("This vehicle gently rolls to a stop.");
        }
    }
}
