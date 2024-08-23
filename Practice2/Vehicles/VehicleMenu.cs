using Practice2.Utils;

namespace Practice2.Vehicles
{
    public class VehicleMenu
    {
        private VehicleManager _vehicleManager;

        public VehicleMenu()
        {
            _vehicleManager = new VehicleManager();
        }

        public void StartMenu()
        {
            bool finish = false;

            do
            {
                DisplayMenu();

                switch (ConsoleReader.GetOption())
                {
                    case 1:
                        CreateCar();
                        break;
                    case 2:
                        CreateMotorcycle();
                        break;
                    case 3:
                        DeleteVehicle();
                        break;
                    case 4:
                        Console.WriteLine();
                        _vehicleManager.DisplayVehicles();
                        break;
                    case 5:
                        Console.WriteLine();
                        _vehicleManager.StartAllEngines();
                        break;
                    case 6:
                        Console.WriteLine("\nReturning to main menu...\n");
                        finish = true;
                        break;
                    default:
                        Console.WriteLine("\nInvalid option. Try Again.");
                        break;
                }
            } while (!finish);
        }

        private void CreateCar()
        {
            string carMake = ConsoleReader.GetStringParam("\nEnter the car make: ");
            string carModel = ConsoleReader.GetStringParam("Enter the car model: ");
            int carYear = ConsoleReader.GetIntParam("Enter the car year: ");
            int carNumberOfDoors = ConsoleReader.GetIntParam("Enter the number of doors: ");
            double carTrunkCapacity = ConsoleReader.GetDoubleParam("Enter the trunk capacity (liters): ");
            bool carHasSunroof = ConsoleReader.GetBoolParam("Does it have a sunroof (true/false)? ");

            _vehicleManager.AddVehicle(new Car(carMake, carModel, carYear,
                carNumberOfDoors, carTrunkCapacity, carHasSunroof));
        }

        private void CreateMotorcycle()
        {
            string motorcycleMake = ConsoleReader.GetStringParam("\nEnter the motorcycle make: ");
            string motorcycleModel = ConsoleReader.GetStringParam("Enter the motorcycle model: ");
            int motorcycleYear = ConsoleReader.GetIntParam("Enter the motorcycle year: ");
            int motorcycleEngineDisplacement = ConsoleReader.GetIntParam("Enter the engine displacement (cc): ");
            string motorcycleHandlebar = ConsoleReader.GetStringParam("Enter the type of handlebar: ");
            bool motorcycleHasSidecar = ConsoleReader.GetBoolParam("Does it have a sidecar (true/false)? ");

            _vehicleManager.AddVehicle(new Motorcycle(motorcycleMake, motorcycleModel,
                motorcycleYear, motorcycleEngineDisplacement, motorcycleHandlebar,
                motorcycleHasSidecar));
        }

        private void DeleteVehicle()
        {
            string vehicleModel = ConsoleReader.GetStringParam("\nEnter the vehicle model: ");
            int vehicleYear = ConsoleReader.GetIntParam("Enter the vehicle year: ");

            _vehicleManager.RemoveVehicle(vehicleModel, vehicleYear);
        }

        private static void DisplayMenu()
        {
            Console.WriteLine("\n--- Vehicles Menu ---\n");
            Console.WriteLine("1. Add car.");
            Console.WriteLine("2. Add motorcycle.");
            Console.WriteLine("3. Remove vehicle.");
            Console.WriteLine("4. Display vehicles.");
            Console.WriteLine("5. Start vehicles.");
            Console.WriteLine("6. Exit.");
        }
    }
}
