// See https://aka.ms/new-console-template for more information
using PizzaDecoratorPattern.Abstract_Classes;
using PizzaDecoratorPattern.Concrete_Classes;

Pizza smallPizza = new SmallPizza();
Console.WriteLine($"{smallPizza.display()}: {smallPizza.cost().ToString("C")}");

Pizza mediumPizza = new MediumPizza();
mediumPizza = new Anchovies(mediumPizza);
mediumPizza = new Olives(mediumPizza);
Console.WriteLine($"{mediumPizza.display()}: {mediumPizza.cost().ToString("C")}");


Pizza largePizza = new LargePizza();
largePizza = new Steak(largePizza);
largePizza = new Spinach(largePizza);
largePizza = new Mushrooms(largePizza);
Console.WriteLine($"{largePizza.display()}: {largePizza.cost().ToString("C")}");