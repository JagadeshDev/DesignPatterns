namespace Decorator
{
    class Barbeque : Toppings
    {
        Pizza pizza;
        public Barbeque(Pizza pizza) { this.pizza = pizza; }
        public override string GetDescription() { return pizza.GetDescription() + ", Barbeque "; }
        public override int GetCost() { return 90 + pizza.GetCost(); }
    }
}
