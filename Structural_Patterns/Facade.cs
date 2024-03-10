using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural_Patterns
{
    public class Facade : IFacade
    {
        private Subsystem1 subsystem1;
        private Subsystem2 subsystem2;

        public Facade()
        {
            subsystem1 = new Subsystem1();
            subsystem2 = new Subsystem2();
        }

        public void Operation()
        {
            subsystem1.Operation1();
            subsystem1.Operation2();
            subsystem2.Operation1();
            subsystem2.Operation2();
        }
    }
}
