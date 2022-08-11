namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Sparrow sparrow = new();
            PlasticToyDuck plasticToyDuck = new();
            IToyDuck toyDuck =new BirdAdapter(sparrow);
            Console.WriteLine("Sparrow...");
            sparrow.Fly();
            sparrow.MakeSound();

            Console.WriteLine("ToyDuck...");
            plasticToyDuck.Squeak();

            // toy duck behaving like a bird 
            Console.WriteLine("BirdAdapter...");
            toyDuck.Squeak();
            Console.ReadLine();
        }
    }
}
