using System.Collections;

namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            int numberOfTires;
            bool userInput = false;
            do
            {
                Console.WriteLine("How many tires does your vehicle have?");
                userInput = int.TryParse(Console.ReadLine(), out numberOfTires);
            } while (userInput == false);
            

            IVehicle vehicle = VehicleFactory.GetVehicle(numberOfTires);
            vehicle.Drive();
            

        }
    }
}
