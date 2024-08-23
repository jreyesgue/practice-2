namespace Practice2.Vehicles
{
    public class VehicleManager
    {
        private readonly List<Vehicle> _vehicles;

        public VehicleManager()
        {
            _vehicles = new List<Vehicle>();
        }

        public void AddVehicle(Vehicle vehicle)
        {
            _vehicles.Add(vehicle);
        }

        public void RemoveVehicle(Vehicle vehicle)
        {
            _vehicles.Remove(vehicle);
        }

        public void RemoveVehicle(string vehicleModel, int vehicleYear)
        {
            _vehicles.RemoveAll(vehicle => vehicle.Model == vehicleModel && vehicle.Year == vehicleYear);
        }

        public void DisplayVehicles()
        {
            _vehicles.ForEach(vehicle => vehicle.DisplayDetails());
        }

        public void StartAllEngines()
        {
            _vehicles.ForEach(vehicle => vehicle.StartEngine());
        }
    }
}
