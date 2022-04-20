using DecoratorPattern.Interface;
using System;

namespace DecoratorPattern
{
    public class Pizza : IPizzaInterface
    {
        public string GetTypePizza()
        {
            var pizza = "Está é uma pizza normal";
            return pizza;
        }
    }
}
