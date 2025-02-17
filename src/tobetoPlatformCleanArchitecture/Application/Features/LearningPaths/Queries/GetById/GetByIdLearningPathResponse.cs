using Core.Application.Responses;

namespace Application.Features.LearningPaths.Queries.GetById;

public class GetByIdLearningPathResponse : IResponse
{
    public int Id { get; set; }
    public string Name { get; set; }
    public bool Visibility { get; set; }
    public DateTime StartingTime { get; set; }
    public DateTime EndTime { get; set; }
}