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

    public async Task<IReadOnlyCollection<Models.Country>> GetCountriesAsync()
    {
        return await _dbContext.Countries.Select(country => new Models.Country
        {
            Alpha2 = country.Alpha2,
            Name = country.Name,
        }).ToListAsync();
    }
}