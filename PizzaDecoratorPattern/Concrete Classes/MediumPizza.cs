using PizzaDecoratorPattern.Abstract_Classes;

namespace PizzaDecoratorPattern.Concrete_Classes
{
    public class MediumPizza : Pizza
    {
        public MediumPizza()
        {
            description = "Medium Pizza";
        }

        public override double cost()
        {
            return 10.99;
        }
    }
}
