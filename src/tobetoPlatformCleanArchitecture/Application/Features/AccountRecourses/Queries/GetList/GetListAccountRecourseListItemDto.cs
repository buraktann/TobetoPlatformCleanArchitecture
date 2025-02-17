using Core.Application.Dtos;

namespace Application.Features.AccountRecourses.Queries.GetList;

public class GetListAccountRecourseListItemDto : IDto
{
    public int Id { get; set; }
    public int AccountId { get; set; }
    public int ApplicationId { get; set; }
    public int ApplicationStepId { get; set; }
}