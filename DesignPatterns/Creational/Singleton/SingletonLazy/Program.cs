namespace Creational.Singleton.SingletonLazy
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Parallel.Invoke(
                () => Method1(),
                () => Method2());
            Console.ReadKey();
        }

        private static void Method2()
        {
            var instance = Singleton.GetInstance;
            instance.WriteMessage("I am main2");
        }

        private static void Method1()
        {
            var instance = Singleton.GetInstance;
            instance.WriteMessage("I am main1");
        }
    }
}
