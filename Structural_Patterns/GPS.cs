using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural_Patterns
{
    public class GPS
    {
        public void Navigate()
        {
            Console.WriteLine("GPS navigating");
        }

        public void StopNavigation()
        {
            Console.WriteLine("GPS stopped navigating");
        }
    }
}
