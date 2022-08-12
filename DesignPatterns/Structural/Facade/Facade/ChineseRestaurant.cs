namespace Facade
{
    public class ChineseRestaurant : IHotel
    {
        public IMenu GetMenus()
        {
            return new ChineseMenu();
        }
    }
}
