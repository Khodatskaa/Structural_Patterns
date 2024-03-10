using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural_Patterns
{
    public class CheeseDecorator : PizzaDecorator
    {
        public CheeseDecorator(IPizza pizza) : base(pizza)
        {
        }

        public override string GetDescription()
        {
            return _pizza.GetDescription() + ", Cheese";
        }

        public override double GetCost()
        {
            return _pizza.GetCost() + 1.25;
        }
    }
}
