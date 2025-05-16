using MediatR;

namespace Application.Categories.Commands.CreateCategoryCommand;

public record CreateCategoryCommand(string Name) : IRequest<Guid>;