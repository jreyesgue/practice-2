namespace Practice2.Employees
{
    public class Developer : Employee, IWorkable
    {
        public string Specialization { get; set; }
        public string ProjectName { get; set; }

        public Developer(int employeeID, string name, double salary, string specialization, string projectName)
            : base(employeeID, name, salary)
        {
            Specialization = specialization;
            ProjectName = projectName;
        }

        public void TakeBreak()
        {
            Console.WriteLine($"The Developer {Name} is taking a break...");
        }

        public void Work()
        {
            Console.WriteLine($"The Developer {Name} is working...");
        }
    }
}
