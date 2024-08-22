namespace Practice2.School
{
    public class Student
    {
        public string Name { get; set; }
        public int RollNumber { get; set; }
        public double Grade { get; private set; }

        public Student(string name, int rollNumber)
        {
            Name = name;
            RollNumber = rollNumber;
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"--- Student {RollNumber} ---");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Grade: {Grade}");
        }

        public void CalculateGrade(params int[] marks)
        {
            Grade = marks.Average();
        }
    }
}
