namespace Structural_Patterns
{
    internal class Program
    {
        static void Main()
        {
            FlyweightFactory flyweightFactory = new FlyweightFactory();

            IFlyweight flyweight1 = flyweightFactory.GetFlyweight("A");
            IFlyweight flyweight2 = flyweightFactory.GetFlyweight("B");
            IFlyweight flyweight3 = flyweightFactory.GetFlyweight("A");

            Client client = new Client();
            client.AddFlyweight(flyweight1);
            client.AddFlyweight(flyweight2);
            client.AddFlyweight(flyweight3);

            client.Execute();

            Console.ReadLine();
        }
    }
}
