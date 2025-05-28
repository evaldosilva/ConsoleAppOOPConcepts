namespace ConsoleAppOOPConcepts.Polymorphism;

internal class Polymorphism
{
    public void Action()
    {
        Vehicle vehicle = new();
        vehicle.Describe();
        vehicle.Accelerate();
        vehicle.Accelerate();

        Bicycle bicycle = new();
        bicycle.Describe();
        bicycle.Accelerate();
        bicycle.Accelerate();
    }
}