namespace ConsoleAppOOPConcepts.Inheritance;

internal class Electronic
{
    private string _description;

    public Electronic(string description)
    {
        _description = description;
    }

    static Electronic()
    {
        Console.WriteLine("Electronic starting !!!");
    }

    ~Electronic()
    {
        Console.WriteLine($"Electronic stopping {_description}... (Probably I will never be called...)");
    }

    public void TurnOn() => Console.WriteLine($"Power On the {_description}.");
    public void TurnOff()  => Console.WriteLine($"Power Off the {_description}.");
    public void Describe() => Console.WriteLine($"I am a {_description}.");
}