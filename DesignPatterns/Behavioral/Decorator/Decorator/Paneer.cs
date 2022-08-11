namespace Decorator
{
    class Paneer : Toppings
    {
        Pizza pizza;
        public Paneer(Pizza pizza) { this.pizza = pizza; }
        public override string GetDescription() { return pizza.GetDescription() + ", Paneer "; }
        public override int GetCost() { return 70 + pizza.GetCost(); }
    }
}
