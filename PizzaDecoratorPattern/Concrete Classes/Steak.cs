using PizzaDecoratorPattern.Abstract_Classes;

namespace PizzaDecoratorPattern.Concrete_Classes
{
    public class Steak : ToppingsDecorator
    {
        private readonly Pizza pizza;

        public Steak(Pizza pizza)
        {
            this.pizza = pizza;
        }

        public override double cost()
        {
            return pizza.cost() + 3.99;
        }

        public override string display()
        {
            return $"{pizza.display()}, Steak";
        }
    }
}
