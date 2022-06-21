using PizzaDecoratorPattern.Abstract_Classes;

namespace PizzaDecoratorPattern.Concrete_Classes
{
    public class SmallPizza : Pizza
    {
        public SmallPizza()
        {
            description = "Small Pizza";
        }

        public override double cost()
        {
            return 8.99;
        }
    }
}
