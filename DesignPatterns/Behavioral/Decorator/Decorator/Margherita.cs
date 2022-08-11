namespace Decorator
{
    public class Margherita : Pizza
    {
        public override int GetCost() { return 150; }
        public override string GetDescription() { return "Margherita"; }
    }
}
