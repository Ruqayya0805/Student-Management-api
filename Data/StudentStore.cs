namespace StudentManagement.Data
{
    using StudentManagement.Models;

    public class StudentStore
    {
        public List<Student> Students { get; } = new List<Student>();

        public StudentStore()
        {
            Students.Add(new Student
            {
                Id = Guid.NewGuid(),
                Name = "Alice",
                Age = 20,
                Course = "Computer Science"
            });
            Students.Add(new Student
            {
                Id = Guid.NewGuid(),
                Name = "Bob",
                Age = 22,
                Course = "Mathematics"
            });
        }
    }
}