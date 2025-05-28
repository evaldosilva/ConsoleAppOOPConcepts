namespace ConsoleAppOOPConcepts.Polymorphism;

internal class Vehicle
{
    public int Speed { get; set; }
    public virtual int SpeedIncrement => 10;
    public string Description { get { return "Vehicle"; } }

    public virtual void Accelerate()
    {
        Speed += SpeedIncrement;
        Console.WriteLine($"Acelerating.... the speed now is {Speed}");
    }

    public virtual void Describe() => Console.WriteLine($"I am a {Description}");
}