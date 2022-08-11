namespace Decorator
{
    class FreshTomato : Toppings
    {
        Pizza pizza;

        public FreshTomato(Pizza pizza) { this.pizza = pizza; }

        public override string GetDescription() { return pizza.GetDescription() + ", Fresh Tomato "; }

        public override int GetCost() { return 40 + pizza.GetCost(); }
    }
}
