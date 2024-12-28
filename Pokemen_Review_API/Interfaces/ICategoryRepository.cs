using Pokemen_Review_API.Models;

namespace Pokemen_Review_API.Interfaces
{
    public interface ICategoryRepository
    {
        ICollection<Category> GetCategories();

        Category GetCategory(int categoryId);
        ICollection<Pokemon> GetPokemonsForCategory(int categoryId);
        bool CategoryExists(int categoryId);
    }
}
