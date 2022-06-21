namespace PizzaDecoratorPattern.Abstract_Classes
{
    public abstract class Pizza
    {
        protected string description = "";

        public virtual string display()
        {
            return description;
        }

        public abstract double cost();
    }
}
