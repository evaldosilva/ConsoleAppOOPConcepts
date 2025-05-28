namespace ConsoleAppOOPConcepts.Inheritance
{
    internal class Inheritance
    {
        public Inheritance()
        {
            Console.WriteLine("-= Starting Inheritance example =-");
            Console.WriteLine();
        }

        public void Action() {
            Electronic[] electronics = [new Playstation("Playstation"), new WashingMachine("WashingMachine")];

            foreach (Electronic electronic in electronics)
            {
                electronic.Describe();
                electronic.TurnOn();
                electronic.TurnOff();
                Console.WriteLine();
            }
        }
    }
}