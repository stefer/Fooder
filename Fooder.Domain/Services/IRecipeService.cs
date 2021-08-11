using Fooder.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Fooder.Domain.Services
{
    public interface IRecipeService
    {
        Task<IReadOnlyCollection<Recipe>> GetAllAsync();
    }
}