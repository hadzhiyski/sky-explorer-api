using Microsoft.AspNetCore.Mvc;
using SkyExplorer.Common.Models;
using SkyExplorer.Core.Airport;
using SkyExplorer.Api.Models.Airports;

namespace SkyExplorer.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class AirportsController : ControllerBase
{
    private readonly IAirportService _airportService;

    public AirportsController(IAirportService airportService)
    {
        _airportService = airportService;
    }

    [HttpGet]
    [Route("{country}")]
    [ProducesResponseType(typeof(IReadOnlyCollection<Airport>), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetAirportsByCountryAsync(string country)
    {
        try
        {
            var result = await _airportService.GetAirportsByCountryAsync(country);
            var airports = result.Select(airport => new Airport
            {
                Id = airport.Id,
                Name = airport.Name,
                Type = airport.Type,
                Latitude = airport.Latitude,
                Longitude = airport.Longitude,
                Iata = airport.Iata,
                Icao = airport.Icao,
                HomeUrl = airport.HomeUrl,
                WikiUrl = airport.WikiUrl,
            }).ToList();
            return Ok(airports);
        }
        catch (KeyNotFoundException)
        {
            return NotFound();
        }
    }

    [HttpGet]
    [Route("{la-min}/{lo-min}/{la-max}/{lo-max}")]
    public async Task<IReadOnlyCollection<Airport>> GetAirportsByBoundingBoxAsync(
        [FromRoute(Name = "la-min")] decimal minLatitude,
        [FromRoute(Name = "lo-min")] decimal minLongitude, [FromRoute(Name = "la-max")] decimal maxLatitude,
        [FromRoute(Name = "lo-max")] decimal maxLongitude)
    {
        var bbox = new BoundingBox
        {
            MaxLatitude = maxLatitude,
            MaxLongitude = maxLongitude,
            MinLatitude = minLatitude,
            MinLongitude = minLongitude,
        };

        var result = await _airportService.GetAirportsByBoundingBoxAsync(bbox);

        return result.Select(airport => new Airport
        {
            Id = airport.Id,
            Name = airport.Name,
            Type = airport.Type,
            Latitude = airport.Latitude,
            Longitude = airport.Longitude,
            Iata = airport.Iata,
            Icao = airport.Icao,
            HomeUrl = airport.HomeUrl,
            WikiUrl = airport.WikiUrl,
        }).ToList();
    }
}