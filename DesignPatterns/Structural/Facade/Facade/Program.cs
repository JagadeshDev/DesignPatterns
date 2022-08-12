namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            var keeper = new HotelKeeper();
            var menu = keeper.GetVegMenu();
            Console.WriteLine($"Name: {menu.Name} Cost: {menu.Cost}");
            Console.ReadLine();
        }
    }
}
