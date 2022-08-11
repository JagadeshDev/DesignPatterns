namespace Adapter
{
    public class Sparrow : IBird
    {
        public void Fly()
        {
            Console.WriteLine("Flying");
        }

        public void MakeSound()
        {
            Console.WriteLine("Chirp Chirp");
        }
    }
}
