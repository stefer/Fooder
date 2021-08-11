using System.Collections.Generic;
using System.Threading.Tasks;
using Fooder.Domain.Models;

namespace Fooder.Domain.Services
{
    public class RecipeService : IRecipeService
    {
        private readonly IRecipeRepository recipeRepository;

        public RecipeService(IRecipeRepository recipeRepository)
        {
            this.recipeRepository = recipeRepository;
        }

        public Task<IReadOnlyCollection<Recipe>> GetAllAsync()
        {
            return recipeRepository.GetAsync();
        }
    }
}
