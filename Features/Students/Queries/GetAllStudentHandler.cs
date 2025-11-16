using MediatR;
using StudentManagement.Data;
using StudentManagement.Models;
using StudentManagement.Features.Students.Queries;

namespace StudentManagement.Features.Students.Handlers
{
    public class GetAllStudentsHandler : IRequestHandler<GetAllStudentsQuery, List<StudentDto>>
    {
        private readonly StudentStore _store;

        public GetAllStudentsHandler(StudentStore store)
        {
            _store = store;
        }

        public Task<List<StudentDto>> Handle(GetAllStudentsQuery request, CancellationToken cancellationToken)
        {
            var dtos = _store.Students.Select(s => new StudentDto
            {
                Id = s.Id,
                Name = s.Name,
                Age = s.Age,
                Course = s.Course
            }).ToList();

            return Task.FromResult(dtos);
        }
    }
}