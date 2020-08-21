using BuilderDesignPattern.Product;

namespace BuilderDesignPattern.Builders
{
    public interface IPizzaBuilder
    {
        IPizzaBuilder SetName();

        IPizzaBuilder SetPrice();

        IPizzaBuilder SetDescription();

        IPizzaBuilder SetToppings();

        Pizza GetPizza();
    }
}