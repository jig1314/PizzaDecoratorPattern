using PizzaDecoratorPattern.Abstract_Classes;

namespace PizzaDecoratorPattern.Concrete_Classes
{
    public class Anchovies : ToppingsDecorator
    {
        private readonly Pizza pizza;

        public Anchovies(Pizza pizza)
        {
            this.pizza = pizza;
        }

        public override double cost()
        {
            return pizza.cost() + 3.99;
        }

        public override string display()
        {
            return $"{pizza.display()}, Anchovies";
        }
    }
}
