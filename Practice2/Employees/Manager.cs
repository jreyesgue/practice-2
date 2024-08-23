namespace Practice2.Employees
{
    public class Manager : Employee, IWorkable
    {
        public string Department { get; set; }
        public int TeamSize { get; set; }
        public double TeamBudget { get; set; }

        public Manager(int employeeID, string name, double salary, string department, int teamSize, double teamBudget)
            : base(employeeID, name, salary)
        {
            Department = department;
            TeamSize = teamSize;
            TeamBudget = teamBudget;
        }

        public void TakeBreak()
        {
            Console.WriteLine($"The Manager {Name} is taking a break...");
        }

        public void Work()
        {
            Console.WriteLine($"The Manager {Name} is working...");
        }
    }
}
