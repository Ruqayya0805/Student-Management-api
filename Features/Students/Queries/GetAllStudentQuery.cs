using MediatR;
using StudentManagement.Models;

namespace StudentManagement.Features.Students.Queries
{
    public class GetAllStudentsQuery : IRequest<List<StudentDto>>
    {
        internal Guid Id;
    }
}