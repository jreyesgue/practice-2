using Practice2.Utils;

namespace Practice2.School
{
    public class ClassroomMenu
    {
        public Classroom Classroom { get; init; }

        public ClassroomMenu()
        {
            Classroom = new Classroom();
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
                        CreateStudent();
                        break;
                    case 2:
                        DeleteStudent();
                        break;
                    case 3:
                        Console.WriteLine();
                        Classroom.DisplayStudents();
                        break;
                    case 4:
                        Console.WriteLine("\nReturning to main menu...\n");
                        finish = true;
                        break;
                    default:
                        Console.WriteLine("\nInvalid option. Try Again.");
                        break;
                }
            } while (!finish);
        }

        private void CreateStudent()
        {
            Console.Write("\nEnter the student name: ");
            string studentName = Console.ReadLine() ?? string.Empty;
            Console.Write("Enter the student roll number: ");
            int studentId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the student marks separated by commas (9,7,10): ");
            string studentMarks = Console.ReadLine() ?? string.Empty;

            var student = new Student(studentName, studentId);
            student.CalculateGrade(Converter.StringToIntArray(studentMarks));

            Classroom.AddStudent(student);
        }

        private void DeleteStudent()
        {
            Console.Write("\nEnter the student roll number: ");
            int deleteStudentId = Convert.ToInt32(Console.ReadLine());

            Classroom.RemoveStudent(deleteStudentId);
        }

        private static void DisplayMenu()
        {
            Console.WriteLine("\n--- Classroom Menu ---\n");
            Console.WriteLine("1. Add student.");
            Console.WriteLine("2. Remove student.");
            Console.WriteLine("3. Display students.");
            Console.WriteLine("4. Exit.");
        }

    }
}
