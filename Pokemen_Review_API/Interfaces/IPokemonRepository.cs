using Pokemen_Review_API.Models;

namespace Pokemen_Review_API.Interfaces
{
    public interface IPokemonRepository
    {
        ICollection<Pokemon> GetPokemons();
    }
}
