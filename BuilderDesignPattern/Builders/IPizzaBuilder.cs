using BuilderDesignPattern.Product;

namespace BuilderDesignPattern.Builders
{
    public interface IPizzaBuilder
    {
        void SetName();

        void SetPrice();

        void SetDescription();

        void SetToppings();

        Pizza GetPizza();
    }
}