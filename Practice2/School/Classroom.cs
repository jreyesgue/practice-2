namespace Practice2.School
{
    public class Classroom
    {
        private readonly List<Student> _students;

        public Classroom()
        {
            _students = new List<Student>();
        }

        public void AddStudent(Student student)
        {
            _students.Add(student);
        }

        public void RemoveStudent(Student student)
        {
            _students.Remove(student);
        }

        public void RemoveStudent(int studentRollNumber)
        {
            _students.RemoveAll(student => student.RollNumber == studentRollNumber);
        }

        public void DisplayStudents()
        {
            _students.ForEach(student => student.DisplayDetails());
        }
    }
}
