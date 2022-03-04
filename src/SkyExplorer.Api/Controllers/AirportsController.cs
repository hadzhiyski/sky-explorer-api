using Microsoft.AspNetCore.Mvc;
using SkyExplorer.Common.Models;
using SkyExplorer.Core.Airport;

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
    public async Task<IActionResult> GetAirportsByCountryAsync(string country)
    {
        var result = await _airportService.GetAirportsByCountryAsync(country);
        return Ok(result);
    }
    
    [HttpGet]
    [Route("{la-min}/{lo-min}/{la-max}/{lo-max}")]
    public async Task<IActionResult> GetAirportsByBoundingBoxAsync([FromRoute(Name = "la-min")] decimal minLatitude,
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

        return Ok(result);
    }
}