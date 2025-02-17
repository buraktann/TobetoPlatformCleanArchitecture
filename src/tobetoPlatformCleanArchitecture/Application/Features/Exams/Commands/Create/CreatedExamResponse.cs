using Core.Application.Responses;

namespace Application.Features.Exams.Commands.Create;

public class CreatedExamResponse : IResponse
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Priority { get; set; }
    public bool Visibility { get; set; }
    public string Description { get; set; }
    public byte NumberOfQuestions { get; set; }
    public DateTime StartingTime { get; set; }
    public DateTime EndTime { get; set; }
    public short Duration { get; set; }
}