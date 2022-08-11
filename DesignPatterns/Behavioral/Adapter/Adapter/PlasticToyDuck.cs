namespace Adapter
{
    public class PlasticToyDuck : IToyDuck
    {
        public void Squeak()
        {
            Console.WriteLine("Quack Quack");
        }
    }
}
