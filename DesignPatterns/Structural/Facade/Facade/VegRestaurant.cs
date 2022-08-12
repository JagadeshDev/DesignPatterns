namespace Facade
{
    public class VegRestaurant : IHotel
    {
        public IMenu GetMenus()
        {
            return new VegMenu();
        }
    }
}
