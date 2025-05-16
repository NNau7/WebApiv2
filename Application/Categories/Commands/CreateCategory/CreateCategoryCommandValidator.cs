using FluentValidation;

namespace Application.Categories.Commands.CreateCategoryCommand;

public class CreateCategoryCommandValidator : AbstractValidator<CreateCategoryCommand>
{
    public CreateCategoryCommandValidator()
    {
        RuleFor(x => x.Name).NotEmpty().WithMessage("El nombre es requerido");
    }
}