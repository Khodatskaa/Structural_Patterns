namespace Structural_Patterns
{
    internal class Program
    {
        static void Main()
        {
            IPizza plainPizza = new Pizza();
            Console.WriteLine("Plain Pizza:");
            Console.WriteLine("Description: " + plainPizza.GetDescription());
            Console.WriteLine("Cost: $" + plainPizza.GetCost());

            IPizza cheesePizza = new CheeseDecorator(plainPizza);
            Console.WriteLine("\nCheese Pizza:");
            Console.WriteLine("Description: " + cheesePizza.GetDescription());
            Console.WriteLine("Cost: $" + cheesePizza.GetCost());

            IPizza pepperoniCheesePizza = new PepperoniDecorator(cheesePizza);
            Console.WriteLine("\nPepperoni Cheese Pizza:");
            Console.WriteLine("Description: " + pepperoniCheesePizza.GetDescription());
            Console.WriteLine("Cost: $" + pepperoniCheesePizza.GetCost());

            Console.ReadLine();
        }
    }
}
