using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural_Patterns
{
    public abstract class PizzaDecorator : IPizza
    {
        protected IPizza _pizza;

        public PizzaDecorator(IPizza pizza)
        {
            _pizza = pizza;  
        }

        public virtual string GetDescription()
        {
            return _pizza.GetDescription();
        }

        public virtual double GetCost()
        {
            return _pizza.GetCost();
        }
    }
}
