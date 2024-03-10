namespace Structural_Patterns
{
    internal class Program
    {
        static void Main()
        {
            CarFacade carFacade = new CarFacade();

            Console.WriteLine("**** Starting the car ****");
            carFacade.StartCar();
            Console.WriteLine("\n**** Stopping the car ****");
            carFacade.StopCar();

            Console.WriteLine("\n**** Navigating to a destination ****");
            carFacade.NavigateTo("Office");

            Console.ReadLine();
        }
    }
}
