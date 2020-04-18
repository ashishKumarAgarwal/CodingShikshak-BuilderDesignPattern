using System;
using System.Collections.Generic;
using System.Text;
using BuilderDesignPattern.Product;

namespace BuilderDesignPattern.Builders
{
    class MargaritaBuilder : IPizzaBuilder
    {
        private readonly Pizza _pizza=new Pizza();
        public void SetName()
        {
            _pizza.Name = "Margarita";
        }

        public void SetPrice()
        {
            _pizza.Price = 400;
        }

        public void SetDescription()
        {
            _pizza.Description = "Margarita medium size pizza";
        }

        public void SetToppings()
        {
            _pizza.Toppings = new[] { "Tomato","Cheese"};
        }

        public Pizza GetPizza()
        {
            return _pizza;
        }
    }
}
