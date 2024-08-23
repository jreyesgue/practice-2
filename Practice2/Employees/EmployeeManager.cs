namespace Practice2.Employees
{
    public class EmployeeManager
    {
        private readonly List<IWorkable> _employees;

        public EmployeeManager()
        {
            _employees = new List<IWorkable>();
        }

        public void AddEmployee(IWorkable employee)
        {
            _employees.Add(employee);
        }

        public void RemoveEmployee(IWorkable employee)
        {
            _employees.Remove(employee);
        }

        public void MakeAllEmployeesWork()
        {
            _employees.ForEach(employee => employee.Work());
        }

        public void SendAllEmployeesOnBreak()
        {
            _employees.ForEach(employee => employee.TakeBreak());
        }
    }
}
