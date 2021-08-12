using Fooder.Domain.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Fooder.Domain.Services
{
    public interface IRecipeRepository
    {
        public Task<Recipe> GetAsync(Guid id);
        public Task<IReadOnlyCollection<Recipe>> GetAsync();
        Task SaveAsync(Recipe recipe);
    }
}
