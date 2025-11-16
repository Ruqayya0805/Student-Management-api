using MediatR;
using StudentManagement.Data;
using StudentManagement.Models;
using StudentManagement.Features.Students.Commands;

namespace StudentManagement.Features.Students.Handlers
{
    public class UpdateStudentHandler : IRequestHandler<UpdateStudentCommand, StudentDto?>
    {
        private readonly StudentStore _store;

        public UpdateStudentHandler(StudentStore store)
        {
            _store = store;
        }

        public Task<StudentDto?> Handle(UpdateStudentCommand request, CancellationToken cancellationToken)
        {
            var student = _store.Students.FirstOrDefault(s => s.Id == request.Id);

            if (student == null)
                return Task.FromResult<StudentDto?>(null);

            student.Name = request.Name;
            student.Age = request.Age;
            student.Course = request.Course;

            var dto = new StudentDto
            {
                Id = student.Id,
                Name = student.Name,
                Age = student.Age,
                Course = student.Course
            };

            return Task.FromResult<StudentDto?>(dto);
        }
    }
}