using Microsoft.AspNetCore.Mvc;
using SkyExplorer.Api.Models.Countries;
using SkyExplorer.Core.Country;

namespace SkyExplorer.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class CountriesController : ControllerBase
{
    private readonly ICountryService _countryService;

    public CountriesController(ICountryService countryService)
    {
        _countryService = countryService ?? throw new ArgumentNullException(nameof(countryService));
    }

    [HttpGet]
    [ResponseCache(CacheProfileName = nameof(GetCountriesAsync))]
    public async Task<IEnumerable<Country>> GetCountriesAsync()
    {
        var countries = await _countryService.GetCountriesAsync();
        return countries.Select(country => new Country
        {
            Id = country.Id,
            Name = country.Name,
            Alpha2 = country.Alpha2,
        }).ToList();
    }
}