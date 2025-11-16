using MediatR;

namespace StudentManagement.Features.Students.Commands
{
    public class DeleteStudentCommand : IRequest<bool>
    {
        public Guid Id { get; init; }
    }
}