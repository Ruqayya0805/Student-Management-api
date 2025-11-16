using StudentManagement.Data;
using StudentManagement.Models;

namespace StudentManagement.Repositories
{
    public class InMemoryStudentRepository : IStudentRepository
    {
        private readonly StudentStore _store;

        public InMemoryStudentRepository(StudentStore store)
        {
            _store = store;
        }

        public Task<List<Student>> GetAllAsync()
        {
            return Task.FromResult(_store.Students.ToList());
        }

        public Task<Student?> GetByIdAsync(Guid id)
        {
            var student = _store.Students.FirstOrDefault(s => s.Id == id);
            return Task.FromResult(student);
        }

        public Task<Student> AddAsync(Student student)
        {
            _store.Students.Add(student);
            return Task.FromResult(student);
        }

        public Task<Student?> UpdateAsync(Student student)
        {
            var existing = _store.Students.FirstOrDefault(s => s.Id == student.Id);
            if (existing == null)
                return Task.FromResult<Student?>(null);

            existing.Name = student.Name;
            existing.Age = student.Age;
            existing.Course = student.Course;

            return Task.FromResult<Student?>(existing);
        }

        public Task<bool> DeleteAsync(Guid id)
        {
            var student = _store.Students.FirstOrDefault(s => s.Id == id);
            if (student == null)
                return Task.FromResult(false);

            _store.Students.Remove(student);
            return Task.FromResult(true);
        }
    }
}