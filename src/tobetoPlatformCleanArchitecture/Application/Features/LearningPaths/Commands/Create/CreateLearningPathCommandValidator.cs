using FluentValidation;

namespace Application.Features.LearningPaths.Commands.Create;

public class CreateLearningPathCommandValidator : AbstractValidator<CreateLearningPathCommand>
{
    public CreateLearningPathCommandValidator()
    {
        RuleFor(c => c.Name).NotEmpty();
        RuleFor(c => c.Visibility).NotEmpty();
        RuleFor(c => c.StartingTime).NotEmpty();
        RuleFor(c => c.EndTime).NotEmpty();
    }
}