using System;
using System.Collections.Generic;
using System.Text;
using BuilderDesignPattern.Builders;
using BuilderDesignPattern.Product;

namespace BuilderDesignPattern.Director
{
    class PizzaFactory
    {
        public Pizza Build(IPizzaBuilder builder)
        {
          builder.SetName();
          builder.SetDescription();
          builder.SetPrice();
          builder.SetToppings();
          return builder.GetPizza();

        }

    }

  
}
