namespace Decorator
{
    public class PeppyPaneer : Pizza
    {
        public override int GetCost() { return 100; }

        public override string GetDescription() { return "Peppy Paneer"; }
    }
}
