using System;
using System.Collections.Generic;
using System.Text;
using BuilderDesignPattern.Product;

namespace BuilderDesignPattern.Builders
{
    class FarmHouseBuilder : IPizzaBuilder
    {
        private readonly Pizza _pizza=new Pizza();
        public void SetName()
        {
            _pizza.Name = "Farm House";
        }

        public void SetPrice()
        {
            _pizza.Price = 500;
        }

        public void SetDescription()
        {
            _pizza.Description = "Farm House medium size pizza";
        }

        public void SetToppings()
        {
            _pizza.Toppings = new[] { "Tomato","Capsicum","Mushroom","Cheese"};
        }

        public Pizza GetPizza()
        {
            return _pizza;
        }
    }
}
