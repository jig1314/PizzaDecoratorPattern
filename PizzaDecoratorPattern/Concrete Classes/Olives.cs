﻿using PizzaDecoratorPattern.Abstract_Classes;

namespace PizzaDecoratorPattern.Concrete_Classes
{
    public class Olives : ToppingsDecorator
    {
        private readonly Pizza pizza;

        public Olives(Pizza pizza)
        {
            this.pizza = pizza;
        }

        public override double cost()
        {
            return pizza.cost() + 2.99;
        }

        public override string display()
        {
            return $"{pizza.display()}, Olives";
        }
    }
}
