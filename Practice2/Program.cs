﻿using Practice2.Employees;
using Practice2.LibrarySystem;
using Practice2.Players;
using Practice2.School;
using Practice2.Utils;
using Practice2.Vehicles;

namespace Practice2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool finish = false;

            do
            {
                DisplayMenu();

                switch (ConsoleReader.GetOption())
                {
                    case 1:
                        var classroom = new ClassroomMenu();
                        classroom.StartMenu();
                        break;
                    case 2:
                        var library = new LibraryMenu();
                        library.StartMenu();
                        break;
                    case 3:
                        var vehicleManager = new VehicleMenu();
                        vehicleManager.StartMenu();
                        break;
                    case 4:
                        var playerManager = new PlayersMenu();
                        playerManager.StartMenu();
                        break;
                    case 5:
                        var employeeManager = new EmployeesMenu();
                        employeeManager.StartMenu();
                        break;
                    case 6:
                        finish = true;
                        Console.WriteLine("\nGoodbye :)");
                        break;
                    default:
                        Console.WriteLine("\nInvalid option. Try Again.\n");
                        break;
                }

            } while (!finish);
        }

        private static void DisplayMenu()
        {
            Console.WriteLine("----- Menu -----\n");
            Console.WriteLine("1. Classroom.");
            Console.WriteLine("2. Library.");
            Console.WriteLine("3. Vehicles.");
            Console.WriteLine("4. Players.");
            Console.WriteLine("5. Employees.");
            Console.WriteLine("6. Exit.");
        }
    }
}
