using Fooder.Domain.Models;
using Fooder.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fooder.Infrastructure.Repositories
{
    public class RecipeInMemoryRepository : IRecipeRepository
    {
        readonly List<Recipe> _recipes = new()
        {
            new Recipe(Guid.NewGuid(), "Köttbullar och potatismos"),
            new Recipe(Guid.NewGuid(), "Falukorv och makaroner"),
            new Recipe(Guid.NewGuid(), "Koreansk köttfärs och eis"),
            new Recipe(Guid.NewGuid(), "Pannkakor"),
            new Recipe(Guid.NewGuid(), "Bruna bönor och fläsk"),
            new Recipe(Guid.NewGuid(), "Svampsoppa"),
        };

        public Task<Recipe> GetAsync(Guid id)
        {
            return Task.FromResult(_recipes.SingleOrDefault(x => x.Id.Equals(id), Recipe.None));
        }

        public Task<IReadOnlyCollection<Recipe>> GetAsync()
        {
            return Task.FromResult(_recipes as IReadOnlyCollection<Recipe>);
        }
    }
}
