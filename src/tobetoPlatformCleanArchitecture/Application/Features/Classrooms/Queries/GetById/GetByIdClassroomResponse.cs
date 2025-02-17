using Core.Application.Responses;

namespace Application.Features.Classrooms.Queries.GetById;

public class GetByIdClassroomResponse : IResponse
{
    public int Id { get; set; }
    public string Name { get; set; }
    public byte MaximumCapacity { get; set; }
}