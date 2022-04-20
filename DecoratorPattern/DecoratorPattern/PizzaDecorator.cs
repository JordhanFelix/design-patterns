using DecoratorPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    //Base decorator
    public class PizzaDecorator : IPizzaInterface
    {
        private readonly IPizzaInterface _pizzaInterface;

        public PizzaDecorator(IPizzaInterface pizza)
        {
            _pizzaInterface = pizza;
        }
        public virtual string GetTypePizza()
        {
            var pizza = _pizzaInterface.GetTypePizza();
            return pizza;
        }

    }
}
