using DecoratorPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    //Concrete Decorator
    public class BaconDecorator : PizzaDecorator
    {
        public BaconDecorator(IPizzaInterface pizza) : base(pizza)
        {
        }

        public override string GetTypePizza()
        {
            var pizza = base.GetTypePizza();
            pizza += "\r\n com bacon extra";
            return pizza;
        }
    }
}
