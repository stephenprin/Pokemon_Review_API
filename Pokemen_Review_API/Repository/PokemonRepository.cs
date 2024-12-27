﻿using Pokemen_Review_API.Data;
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

        public Pokemon GetPokemon(int pokeId)
        {
            return _context.Pokemons.Where(p => p.Id == pokeId).FirstOrDefault();
        }

        public Pokemon GetPokemon(string name)
        {
            return _context.Pokemons.Where(p => p.Name == name).FirstOrDefault();
        }

        public decimal GetPokemonRating(int pokeId)
        {
            var reviews = _context.Reviews.Where(p => p.Pokemon.Id == pokeId);
            if (reviews.Count() <= 0)
                return 0;
            return ((decimal)reviews.Sum(r=>r.Rating) / reviews.Count());
        }

        public ICollection<Pokemon> GetPokemons()
        {
            return _context.Pokemons.OrderBy(p => p.Id).ToList();
        }

        public bool PokemonExists(int pokeId)
        {
           return _context.Pokemons.Any(p => p.Id == pokeId);
        }
    }
    }

