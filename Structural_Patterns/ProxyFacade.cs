using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural_Patterns
{
    public class ProxyFacade : IFacade
    {
        private Facade facade;

        public ProxyFacade()
        {
            facade = new Facade();
        }

        public void Operation()
        {
            Console.WriteLine("ProxyFacade: Checking access before handling request.");
            facade.Operation();
        }
    }
}
