namespace Decorator
{
    public class ThinBase : Base
    {
        Pizza pizza;

        public ThinBase(Pizza pizza) { this.pizza = pizza; }
        public override int GetCost() { return pizza.GetCost() + 100; }

        public override string GetDescription() { return pizza.GetDescription() + ", Thin Base "; }
    }
}
