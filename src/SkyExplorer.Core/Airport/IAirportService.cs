using SkyExplorer.Common.Models;

namespace SkyExplorer.Core.Airport;

public interface IAirportService
{
    Task<IReadOnlyCollection<Models.Airport>> GetAirportsByBoundingBoxAsync(BoundingBox bbox);
    Task<IReadOnlyCollection<Models.Airport>> GetAirportsByCountryAsync(string countryAlpha2);
}