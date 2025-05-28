namespace ConsoleAppOOPConcepts.Polymorphism;

internal class Bicycle : Vehicle
{
    public override int SpeedIncrement => 1;
    public new string Description { get { return "Bicycle"; } }
    public override void Describe() => Console.WriteLine($"I am a the new description, a {Description}");
}