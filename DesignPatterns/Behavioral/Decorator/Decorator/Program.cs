namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Pizza pizza1 = new FarmHouse();
            Console.WriteLine($"{pizza1.GetDescription()} Cost: {pizza1.GetCost()}");

            Pizza pizza2 = new PeppyPaneer();
            pizza2 = new FreshTomato(pizza2);
            pizza2 = new Barbeque(pizza2);
            pizza2 = new ThinBase(pizza2);
            Console.WriteLine($"{pizza2.GetDescription()} Cost: {pizza2.GetCost()}");

            Console.ReadLine();
        }
    }
}
