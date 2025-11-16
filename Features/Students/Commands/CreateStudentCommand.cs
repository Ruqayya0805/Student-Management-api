using MediatR;
using StudentManagement.Models;

namespace StudentManagement.Features.Students.Commands
{
    public class CreateStudentCommand : IRequest<StudentDto>
    {
        public string Name { get; set; } = string.Empty;
        public int Age { get; set; }
        public string Course { get; set; } = string.Empty;
    }
}