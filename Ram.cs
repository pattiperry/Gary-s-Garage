using System;

public class Ram  : Vehicle// Gas powered truck
{
    public double FuelCapacity { get; set; }
    
    public void RefuelTank()
    {
        // method definition omitted
    }

    public override void Drive()
    {
        Console.WriteLine($"The {MainColor} Ram growls by you. Rummmmmbbbllleee!");
    }

    public override void Turn()
    {
        Console.WriteLine("The vehicle carefully turns right.");
    }

    public override void Stop()
    {
        Console.WriteLine("The vehicle gently rolls to a stop.");
    }
}