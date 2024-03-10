namespace Structural_Patterns
{
    internal class Program
    {
        static void Main()
        {
            IFacade proxyFacade = new ProxyFacade();
            proxyFacade.Operation();

            Console.ReadLine();
        }
    }
}
