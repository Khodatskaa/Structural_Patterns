using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural_Patterns
{
    public class CarFacade
    {
        private Engine engine;
        private AirConditioning airConditioning;
        private GPS gps;

        public CarFacade()
        {
            engine = new Engine();
            airConditioning = new AirConditioning();
            gps = new GPS();
        }

        public void StartCar()
        {
            engine.Start();
            Console.WriteLine("Car is ready to go");
        }

        public void StopCar()
        {
            engine.Stop();
            gps.StopNavigation();
            Console.WriteLine("Car stopped");
        }

        public void NavigateTo(string destination)
        {
            StartCar();
            gps.Navigate();
            Console.WriteLine("Navigating to " + destination);
            StopCar();
        }
    }
}
