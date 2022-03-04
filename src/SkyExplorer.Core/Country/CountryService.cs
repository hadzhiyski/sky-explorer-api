using Microsoft.EntityFrameworkCore;
using SkyExplorer.Data;

namespace SkyExplorer.Core.Country;

public class CountryService : ICountryService
{
    private readonly ISkyExplorerDbContext _dbContext;

    public CountryService(ISkyExplorerDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<IReadOnlyCollection<Models.CountrySummary>> GetCountriesAsync()
    {
        return await _dbContext.Countries.Select(country => new Models.CountrySummary
        {
            Alpha2 = country.Alpha2,
            Name = country.Name,
        }).ToListAsync();
    }

    public async Task<Models.Country> GetCountryByAlpha2Async(string alpha2)
    {
        // ReSharper disable once SpecifyStringComparison
        var country = await _dbContext.Countries.SingleOrDefaultAsync(c => c.Alpha2 == alpha2.ToUpper());

        if (country == null)
        {
            throw new KeyNotFoundException("Country not found");
        }
        
        return new Models.Country
        {
            Alpha2 = country.Alpha2,
            Name = country.Name,
            BoundingBox = country.BoundingBox,
        };
    }
}