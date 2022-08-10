namespace Creational.Singleton.SingletonLazy
{
    public sealed class Singleton
    {
        private readonly int _count = 0;
        private Singleton()
        {
            _count++;
            Console.WriteLine($"Instance count {_count}");
        }
        //private static Singleton? instance = new();
        private static readonly Lazy<Singleton>? instance = new(()=>new Singleton());

        public static Singleton GetInstance
        {
            get
            {
                return instance.Value;
            }
        }

        public void WriteMessage(string message)
        {
            Console.WriteLine($"Your message {message}");
        }
    }
}
