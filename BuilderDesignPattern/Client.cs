using BuilderDesignPattern.Builders;
using BuilderDesignPattern.Director;
using System;

namespace BuilderDesignPattern
{
    internal class Client
    {
        private static void Main(string[] args)
        {
            PizzaFactory pizzaFactory = new PizzaFactory();
            var selectedPizza = pizzaFactory.Build(new MargaritaBuilder());
            Console.WriteLine($" You have selected {selectedPizza.Name} pizza \n Description : {selectedPizza.Description}" +
                              $"\n Price : {selectedPizza.Price} \n Toppings: {string.Join(',', selectedPizza.Toppings)}");
        }
    }
}