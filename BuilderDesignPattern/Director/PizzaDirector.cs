using BuilderDesignPattern.Builders;
using BuilderDesignPattern.Product;

namespace BuilderDesignPattern.Director
{
    internal class PizzaDirector
    {
        public Pizza Build(IPizzaBuilder builder)
        {
            builder.SetName()
                   .SetDescription()
                  .SetPrice()
                  .SetToppings();
            return builder.GetPizza();
        }
    }
}