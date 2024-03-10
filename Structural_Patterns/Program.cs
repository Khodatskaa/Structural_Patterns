namespace Structural_Patterns
{
    internal class Program
    {
        static void Main()
        {
            IComponent component = new ConcreteComponent();

            IComponent decoratedComponent = new ProxyDecorator(new ConcreteDecoratorA(new ConcreteDecoratorB(component)));

            decoratedComponent.Operation();

            Console.ReadLine();
        }
    }
}
