using Pokemen_Review_API.Data;
using Pokemen_Review_API.Interfaces;
using Pokemen_Review_API.Models;

namespace Pokemen_Review_API.Repository
{
    public class PokemonRepository: IPokemonRepository
    {
        private readonly DataContext _context;

        public PokemonRepository(DataContext context)
        {
            _context = context;
        }

        public ICollection<Pokemon> GetPokemons()
        {
            return _context.Pokemons.OrderBy(p => p.Id).ToList();
        }
    }
    }

