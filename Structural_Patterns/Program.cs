namespace Structural_Patterns
{
    internal class Program
    {
        static void Main()
        {
            IRealSubject proxy = new Proxy();
            proxy.Request();

            Console.ReadLine();
        }
    }
}
