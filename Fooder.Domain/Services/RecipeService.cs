using System.Collections.Generic;
using System.Threading.Tasks;
using Fooder.Domain.Models;

namespace Fooder.Domain.Services
{
    public class RecipeService : IRecipeService
    {
        private readonly IRecipeRepository _recipeRepository;

        public RecipeService(IRecipeRepository recipeRepository)
        {
            _recipeRepository = recipeRepository;
        }

        public Task AddAsync(Recipe recipe)
        {
            recipe.Id = System.Guid.NewGuid();
            return _recipeRepository.SaveAsync(recipe);
        }

        public Task<IReadOnlyCollection<Recipe>> GetAllAsync()
        {
            return _recipeRepository.GetAsync();
        }
    }
}
