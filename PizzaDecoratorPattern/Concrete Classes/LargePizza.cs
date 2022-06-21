using PizzaDecoratorPattern.Abstract_Classes;

namespace PizzaDecoratorPattern.Concrete_Classes
{
    public class LargePizza : Pizza
    {
        public LargePizza()
        {
            description = "Large Pizza";
        }

        public override double cost()
        {
            return 12.99;
        }
    }
}
