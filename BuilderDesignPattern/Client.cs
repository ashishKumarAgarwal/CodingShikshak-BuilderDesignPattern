using BuilderDesignPattern.Builders;
using BuilderDesignPattern.Director;
using System;

namespace BuilderDesignPattern
{
    internal class Client
    {
        private static void Main(string[] args)
        {
            PizzaDirector pizzaFactory = new PizzaDirector();
            var selectedPizza = pizzaFactory.Build(new MargaritaBuilder());

            if (selectedPizza != null)
            {
                Console.WriteLine($" You have selected {selectedPizza.Name} pizza");

                if (!string.IsNullOrEmpty(selectedPizza.Description))
                {
                    Console.WriteLine($"\n Description: { selectedPizza.Description}");
                }
                if (selectedPizza.Price > 0)
                {
                    Console.WriteLine($"\n Price : {selectedPizza.Price} ");
                }
                if (selectedPizza.Toppings != null)
                {
                    Console.WriteLine($"\n Toppings: {string.Join(',', selectedPizza.Toppings)}");
                }
            }
        }
    }
}