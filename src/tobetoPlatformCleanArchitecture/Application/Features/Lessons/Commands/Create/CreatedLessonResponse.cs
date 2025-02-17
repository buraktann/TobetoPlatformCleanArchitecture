using Core.Application.Responses;

namespace Application.Features.Lessons.Commands.Create;

public class CreatedLessonResponse : IResponse
{
    public int Id { get; set; }
    public int CourseId { get; set; }
    public string Name { get; set; }
    public bool Visibility { get; set; }
    public string Language { get; set; }
    public string Content { get; set; }
    public int Duration { get; set; }
}