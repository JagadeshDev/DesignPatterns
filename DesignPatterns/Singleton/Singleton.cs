namespace Singleton
{
    public sealed class Singleton
    {
        private readonly int _count = 0;
        private Singleton()
        {
            _count++;
            Console.WriteLine($"Instance count {_count}");
        }
        private static Singleton? instance = null;
        private static readonly object instanceLock = new();

        public static Singleton GetInstance
        {
            get
            {
                if (instance == null)
                {
                    lock (instanceLock)
                    {
                        if (instance == null)
                            instance = new Singleton();
                    }
                }
                return instance;
            }
        }

        public void WriteMessage(string message)
        {
            Console.WriteLine($"Your message {message}");
        }
    }
}
