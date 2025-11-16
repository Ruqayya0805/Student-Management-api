using MediatR;
using StudentManagement.Data;
using StudentManagement.Models;
using StudentManagement.Features.Students.Commands;

namespace StudentManagement.Features.Students.Handlers
{
    public class CreateStudentHandler : IRequestHandler<CreateStudentCommand, StudentDto>
    {
        private readonly StudentStore _store;

        public CreateStudentHandler(StudentStore store)
        {
            _store = store;
        }

        public Task<StudentDto> Handle(CreateStudentCommand request, CancellationToken cancellationToken)
        {
            var student = new Student
            {
                Id = Guid.NewGuid(),
                Name = request.Name,
                Age = request.Age,
                Course = request.Course
            };

            _store.Students.Add(student);

            var dto = new StudentDto
            {
                Id = student.Id,
                Name = student.Name,
                Age = student.Age,
                Course = student.Course
            };

            return Task.FromResult(dto);
        }
    }
}