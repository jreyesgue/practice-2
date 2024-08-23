namespace Practice2.Vehicles
{
    public class Car : Vehicle
    {
        public int NumberOfDoors { get; set; }
        public double TrunkCapacity { get; set; }
        public bool HasSunroof { get; set; }

        public Car(string make, string model, int year, int numberOfDoors, double trunkCapacity, bool hasSunroof)
            : base(make, model, year)
        {
            NumberOfDoors = numberOfDoors;
            TrunkCapacity = trunkCapacity;
            HasSunroof = hasSunroof;
        }

        public override void DisplayDetails()
        {
            Console.WriteLine($"--- Car ---");
            Console.WriteLine($"Make: {Make}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Year: {Year}");
            Console.WriteLine($"Number of Doors: {NumberOfDoors}");
            Console.WriteLine($"Trunk Capacity: {TrunkCapacity} liters");
            Console.WriteLine($"Sunroof: {HasSunroof}");
        }

        public override void StartEngine()
        {
            Console.WriteLine($"Started {Make} {Model} Car engine...");
        }
    }
}
