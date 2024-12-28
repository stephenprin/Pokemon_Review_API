using Pokemen_Review_API.Data;
using Pokemen_Review_API.Interfaces;
using Pokemen_Review_API.Models;

namespace Pokemen_Review_API.Repository
{
    public class CountryRepository : ICountryRepository
    {
        private readonly DataContext _context;

        public CountryRepository(DataContext context)
        {
           _context = context;
        }
        public bool CountryExists(int countryId)
        {
           return _context.Countries.Any(c => c.Id == countryId);
        }

        public ICollection<Country> GetCountries()
        {
           return _context.Countries.OrderBy(c => c.Name).ToList();
        }

        public Country GetCountry(int id)
        {
            return _context.Countries.Where(c => c.Id == id).FirstOrDefault();
        }

        public Country GetCountryOfOwner(int ownerId)
        {
           return _context.Owners.Where(o => o.Id == ownerId).Select(c => c.Country).FirstOrDefault();
        }

        public ICollection<Owner> GetOwnersFromCountry(int countryId)
        {
           return _context.Owners.Where(o => o.Country.Id == countryId).ToList();
        }
    }
}
