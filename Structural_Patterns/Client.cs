using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural_Patterns
{
    public class Client
    {
        private List<IFlyweight> flyweights = new List<IFlyweight>();

        public void AddFlyweight(IFlyweight flyweight)
        {
            flyweights.Add(flyweight);
        }

        public void Execute()
        {
            foreach (var flyweight in flyweights)
            {
                flyweight.Operation();
            }
        }
    }
}
