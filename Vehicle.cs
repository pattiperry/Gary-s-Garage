using System;


//this is a parent class created
//it's referenced inside of the child classes
public class Vehicle
{

    //these were all common properties of the other classes
    public string MainColor { get; set; }
    public string MaximumOccupancy { get; set; }

    //make sure this method says "virtual" so a child class can override it
    public virtual void Drive()
    {
        Console.WriteLine("Vrooom!");
    }

    public virtual void Turn()
    {
        Console.WriteLine("Turn Left Now.");
    }

    public virtual void Stop()
    {
        Console.WriteLine("Stop at the end of the road.");
    }
}