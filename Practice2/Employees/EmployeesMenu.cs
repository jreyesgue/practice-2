using Practice2.Utils;

namespace Practice2.Employees
{
    public class EmployeesMenu
    {
        private readonly EmployeeManager _employeeManager;

        public EmployeesMenu()
        {
            _employeeManager = new EmployeeManager();
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
                        CreateManager();
                        break;
                    case 2:
                        CreateDeveloper();
                        break;
                    case 3:
                        DeleteEmployee();
                        break;
                    case 4:
                        Console.WriteLine();
                        _employeeManager.MakeAllEmployeesWork();
                        break;
                    case 5:
                        Console.WriteLine();
                        _employeeManager.SendAllEmployeesOnBreak();
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

        private void CreateManager()
        {
            int managerId = ConsoleReader.GetIntParam("\nEnter the manager ID: ");
            string managerName = ConsoleReader.GetStringParam("Enter the manager name: ");
            double managerSalary = ConsoleReader.GetDoubleParam("Enter the manager salary: ");
            string managerDepartment = ConsoleReader.GetStringParam("Enter the department: ");
            int managerTeamSize = ConsoleReader.GetIntParam("Enter the team size: ");
            double managerBudget = ConsoleReader.GetDoubleParam("Enter the budget: ");

            _employeeManager.AddEmployee(new Manager(managerId, managerName,
                managerSalary, managerDepartment, managerTeamSize, managerBudget));
        }

        private void CreateDeveloper()
        {
            int devId = ConsoleReader.GetIntParam("\nEnter the developer ID: ");
            string devName = ConsoleReader.GetStringParam("Enter the developer name: ");
            double devSalary = ConsoleReader.GetDoubleParam("Enter the developer salary: ");
            string devSpecialization = ConsoleReader.GetStringParam("Enter the specialization: ");
            string devProject = ConsoleReader.GetStringParam("Enter the project name: ");

            _employeeManager.AddEmployee(new Developer(devId, devName, devSalary,
                devSpecialization, devProject));
        }

        private void DeleteEmployee()
        {
            int employeeId = ConsoleReader.GetIntParam("\nEnter the employee ID: ");

            _employeeManager.RemoveEmployee(employeeId);
        }

        private static void DisplayMenu()
        {
            Console.WriteLine("\n--- Employees Menu ---\n");
            Console.WriteLine("1. Add manager.");
            Console.WriteLine("2. Add developer.");
            Console.WriteLine("3. Remove employee.");
            Console.WriteLine("4. Make employees work.");
            Console.WriteLine("5. Send employees on break.");
            Console.WriteLine("6. Exit.");
        }
    }
}
