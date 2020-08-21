using BuilderDesignPattern.Product;

namespace BuilderDesignPattern.Builders
{
    internal class FarmHouseBuilder : IPizzaBuilder
    {
        private readonly Pizza _pizza = new Pizza();

        public IPizzaBuilder SetName()
        {
            _pizza.Name = "Farm House";
            return this;
        }

        public IPizzaBuilder SetPrice()
        {
            _pizza.Price = 500;
            return this;
        }

        public IPizzaBuilder SetDescription()
        {
            _pizza.Description = "Farm House medium size pizza";
            return this;
        }

        public IPizzaBuilder SetToppings()
        {
            _pizza.Toppings = new[] { "Tomato", "Capsicum", "Mushroom", "Cheese" };
            return this;
        }

        public Pizza GetPizza()
        {
            return _pizza;
        }
    }
}