namespace Facade
{
    public class HotelKeeper
    {
        public VegMenu GetVegMenu()
        {
            var menu = new VegRestaurant();
            return (VegMenu)menu.GetMenus();
        }
        public NonVegMenu GetNonVegMenu()
        {
            var menu = new VegRestaurant();
            return (NonVegMenu)menu.GetMenus();
        }
        public ChineseMenu GetChineseMenu()
        {
            var menu = new VegRestaurant();
            return (ChineseMenu)menu.GetMenus();
        }
    }
}
