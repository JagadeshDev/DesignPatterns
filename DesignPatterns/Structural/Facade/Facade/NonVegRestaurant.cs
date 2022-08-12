namespace Facade
{
    public class NonVegRestaurant : IHotel
    {
        public IMenu GetMenus()
        {
            return new NonVegMenu();
        }
    }
}
