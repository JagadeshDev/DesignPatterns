namespace Decorator
{
    public class FarmHouse : Pizza
    {
        public override int GetCost() { return 200; }
        public override string GetDescription() { return "Farm House"; }
    }
}
