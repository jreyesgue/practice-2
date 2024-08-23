namespace Practice2.Employees
{
    public abstract class Employee
    {
        public int EmployeeID { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        protected Employee(int employeeID, string name, double salary)
        {
            EmployeeID = employeeID;
            Name = name;
            Salary = salary;
        }
    }
}
