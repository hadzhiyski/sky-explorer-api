namespace SkyExplorer.Core.Country;

public interface ICountryService
{
    Task<IReadOnlyCollection<Models.Country>> GetCountriesAsync();
}