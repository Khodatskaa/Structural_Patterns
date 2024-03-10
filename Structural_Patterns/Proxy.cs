using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural_Patterns
{
    public class Proxy : IRealSubject
    {
        private RealSubject? realSubject;

        public void Request()
        {
            if (realSubject == null)
            {
                Console.WriteLine("Proxy: Creating an instance of RealSubject.");
                realSubject = new RealSubject();
            }

            Console.WriteLine("Proxy: Checking access before handling request.");

            realSubject.Request();
        }
    }
}
