namespace Practice2.Vehicles
{
    public class Motorcycle : Vehicle
    {
        public int EngineDisplacement { get; set; }
        public string HandlebarType { get; set; }
        public bool HasSidecar { get; set; }

        public Motorcycle(string make, string model, int year, int engineDisplacement, string handlebarType, bool hasSidecar)
            : base(make, model, year)
        {
            EngineDisplacement = engineDisplacement;
            HandlebarType = handlebarType;
            HasSidecar = hasSidecar;
        }

        public override void DisplayDetails()
        {
            Console.WriteLine($"--- Motorcycle ---");
            Console.WriteLine($"Make: {Make}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Year: {Year}");
            Console.WriteLine($"Engine Displacement: {EngineDisplacement} cc");
            Console.WriteLine($"Handlebar Type: {HandlebarType}");
            Console.WriteLine($"Sidecar: {HasSidecar}");
        }

        public override void StartEngine()
        {
            Console.WriteLine($"Started {Make} {Model} Motorcycle engine...");
        }
    }
}
