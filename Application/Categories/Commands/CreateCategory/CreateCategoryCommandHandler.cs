using Domain.Entities;
using Domain.Interfaces;

namespace Application.Categories.Commands.CreateCategoryCommand;

public class CreateCategoryCommandHandler
{
    private readonly ICategoryRepository _categoryRepository;

    public CreateCategoryCommandHandler(ICategoryRepository categoryRepository)
    {
        _categoryRepository = categoryRepository;
    }

    public async Task<Guid> Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
    {
        var category = new Category
        {
            category_id = Guid.NewGuid(),
            category_name = request.Name
        };

        await _categoryRepository.AddAsync(category);
        return category.category_id;
    }
}