using Pokemen_Review_API.Models;

namespace Pokemen_Review_API.Interfaces
{
    public interface IPokemonRepository
    {
        ICollection<Pokemon> GetPokemons();
        Pokemon  GetPokemon(int pokeId);
        Pokemon GetPokemon(string name);
        decimal GetPokemonRating(int pokeId);
        bool PokemonExists(int pokeId);

    }
}
