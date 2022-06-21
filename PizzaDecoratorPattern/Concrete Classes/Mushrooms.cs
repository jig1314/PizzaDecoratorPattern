using PizzaDecoratorPattern.Abstract_Classes;

namespace PizzaDecoratorPattern.Concrete_Classes
{
    public class Mushrooms : ToppingsDecorator
    {
        private readonly Pizza pizza;

        public Mushrooms(Pizza pizza)
        {
            this.pizza = pizza;
        }

        public override double cost()
        {
            return pizza.cost() + 2.99;
        }

        public override string display()
        {
            return $"{pizza.display()}, Mushrooms";
        }
    }
}
