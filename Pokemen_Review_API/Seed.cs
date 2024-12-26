using Pokemen_Review_API.Data;
using Pokemen_Review_API.Models;

namespace Pokemen_Review_API
{
    public class Seed(DataContext context)
    {
        private readonly DataContext dataContext = context;

        public void SeedDataContext()
        {
            if (!dataContext.PokemonOwners.Any())
            {
                var electricCategory = new Category { Name = "Electric" };
                var waterCategory = new Category { Name = "Water" };
                var leafCategory = new Category { Name = "Leaf" };

                dataContext.Categories.AddRange(electricCategory, waterCategory, leafCategory);
                dataContext.SaveChanges();

                var pikachu = new Pokemon
                {
                    Name = "Pikachu",
                    BirthDate = new DateTime(1903, 1, 1),
                    PokemonCategories = new List<PokemonCategory>
            {
                new PokemonCategory { Category = electricCategory }
            },
                    Reviews = new List<Review>
            {
                new Review { Title = "Pikachu", Description = "Pickahu is the best pokemon, because it is electric", Rating = 5,
                    Reviewer = new Reviewer { FirstName = "Teddy", LastName = "Smith" } },
                // Add other reviews
            }
                };

                var squirtle = new Pokemon
                {
                    Name = "Squirtle",
                    BirthDate = new DateTime(1903, 1, 1),
                    PokemonCategories = new List<PokemonCategory>
            {
                new PokemonCategory { Category = waterCategory }
            },
                    Reviews = new List<Review>
            {
                new Review { Title = "Squirtle", Description = "Squirtle is the best pokemon, because it is water", Rating = 5,
                    Reviewer = new Reviewer { FirstName = "Teddy", LastName = "Smith" } },
                // Add other reviews
            }
                };

                var venasaur = new Pokemon
                {
                    Name = "Venasaur",
                    BirthDate = new DateTime(1903, 1, 1),
                    PokemonCategories = new List<PokemonCategory>
            {
                new PokemonCategory { Category = leafCategory }
            },
                    Reviews = new List<Review>
            {
                new Review { Title = "Venasaur", Description = "Venasaur is the best pokemon, because it is a leaf", Rating = 5,
                    Reviewer = new Reviewer { FirstName = "Teddy", LastName = "Smith" } },
                // Add other reviews
            }
                };

                var jack = new Owner
                {
                    FirstName = "Jack",
                    LastName = "London",
                    Gym = "Brocks Gym",
                    Country = new Country { Name = "Kanto" }
                };

                var harry = new Owner
                {
                    FirstName = "Harry",
                    LastName = "Potter",
                    Gym = "Mistys Gym",
                    Country = new Country { Name = "Saffron City" }
                };

                var ash = new Owner
                {
                    FirstName = "Ash",
                    LastName = "Ketchum",
                    Gym = "Ashs Gym",
                    Country = new Country { Name = "Millet Town" }
                };

                dataContext.PokemonOwners.AddRange(
                    new PokemonOwner { Pokemon = pikachu, Owner = jack },
                    new PokemonOwner { Pokemon = squirtle, Owner = harry },
                    new PokemonOwner { Pokemon = venasaur, Owner = ash }
                );

                dataContext.SaveChanges();
            }
        }
    }
}
        
