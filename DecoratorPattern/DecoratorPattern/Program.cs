using DecoratorPattern.Interface;
using System;

namespace DecoratorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IPizzaInterface pizza = new Pizza();
            IPizzaInterface queijo = new CheeseDecorator(pizza);
            IPizzaInterface bacon = new BaconDecorator(queijo);
            IPizzaInterface cebola = new OnionDecorator(bacon);

            Console.WriteLine(cebola.GetTypePizza());
            Console.WriteLine();
        }
    }
}
