using Microsoft.AspNetCore.Mvc;
using Pokemen_Review_API.Interfaces;
using Pokemen_Review_API.Models;

namespace Pokemen_Review_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PokemonController : Controller
    {
        private readonly IPokemonRepository _pokemonRepository;

        public PokemonController(IPokemonRepository pokemonRepository)
        {
            _pokemonRepository = pokemonRepository;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Pokemon>))]
        public IActionResult GetPokemons() { 
            var pokenmons = _pokemonRepository.GetPokemons();

            if(!ModelState.IsValid)
                return BadRequest(ModelState);
            return Ok(pokenmons);
        }
    }
}
