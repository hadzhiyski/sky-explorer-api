namespace SkyExplorer.Core.Country;

public interface ICountryService
{
    Task<IReadOnlyCollection<Models.CountrySummary>> GetCountriesAsync();
    /// <summary>
    /// Get country by alpha2 iso code
    /// </summary>
    /// <param name="alpha2"></param>
    /// <returns></returns>
    /// <exception cref="KeyNotFoundException">Thrown if country was not found</exception>
    Task<Models.Country> GetCountryByAlpha2Async(string alpha2);
}