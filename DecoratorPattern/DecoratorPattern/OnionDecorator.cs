using DecoratorPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    //concrete decorator
    public class OnionDecorator : PizzaDecorator
    {
        public OnionDecorator(IPizzaInterface pizza) : base(pizza)
        {
        }

        public override string GetTypePizza()
        {
            var pizza = base.GetTypePizza();
            pizza += "\r\n com cebola extra";
            return pizza;
        }
    }
}
