using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural_Patterns
{
    public class Pizza : IPizza
    {
        public string GetDescription()
        {
            return "Pizza";
        }

        public double GetCost()
        {
            return 5.00;
        }
    }
}
