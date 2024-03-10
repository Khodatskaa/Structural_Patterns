using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural_Patterns
{
    public class ProxyDecorator : Decorator
    {
        public ProxyDecorator(IComponent component) : base(component)
        {
        }

        public override void Operation()
        {
            Console.WriteLine("ProxyDecorator: Checking access before handling request.");
            base.Operation();
        }
    }
}
