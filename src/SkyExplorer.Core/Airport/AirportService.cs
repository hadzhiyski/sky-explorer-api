using Microsoft.EntityFrameworkCore;
using SkyExplorer.Common.Models;
using SkyExplorer.Core.Country;
using SkyExplorer.Data;

namespace SkyExplorer.Core.Airport;

public class AirportService : IAirportService
{
    private readonly ISkyExplorerDbContext _dbContext;
    private readonly ICountryService _countryService;

    public AirportService(ISkyExplorerDbContext dbContext, ICountryService countryService)
    {
        _dbContext = dbContext;
        _countryService = countryService;
    }

    public async Task<IReadOnlyCollection<Models.Airport>> GetAirportsByBoundingBoxAsync(BoundingBox bbox)
    {
        var airports = await _dbContext.Airports.Where(airport =>
                airport.Latitude >= bbox.MinLatitude && airport.Latitude <= bbox.MaxLatitude &&
                airport.Longitude >= bbox.MinLongitude && airport.Longitude <= bbox.MaxLongitude)
            .Select(airport =>
                new Models.Airport
                {
                    Name = airport.Name,
                    Type = airport.Type,
                    Latitude = airport.Latitude,
                    Longitude = airport.Longitude,
                    Iata = airport.Iata,
                    Icao = airport.Icao,
                    HomeUrl = airport.HomeUrl,
                    WikiUrl = airport.WikiUrl,
                }).ToListAsync();

        return airports;
    }

    public async Task<IReadOnlyCollection<Models.Airport>> GetAirportsByCountryAsync(string countryAlpha2)
    {
        var country = await _countryService.GetCountryByAlpha2Async(countryAlpha2);

        return await GetAirportsByBoundingBoxAsync(country.BoundingBox);
    }
}