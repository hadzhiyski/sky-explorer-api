using Microsoft.AspNetCore.Mvc;
using SkyExplorer.Api.Constants;
using SkyExplorer.Common.Models;
using SkyExplorer.OpenSkyNetwork.Core.StateVectors;

namespace SkyExplorer.Api.Controllers.OpenSky;

[ApiController]
[Route("opensky/states")]
[ResponseCache(CacheProfileName = CacheProfiles.OpenSky)]
public class StateVectorsController : ControllerBase
{
    private readonly IStateVectorsFacade _stateVectorsFacade;

    public StateVectorsController(IStateVectorsFacade stateVectorsFacade)
    {
        _stateVectorsFacade = stateVectorsFacade;
    }

    [HttpGet]
    [Route("/icao24/{icao24}/{time:int?}")]
    public async Task<IActionResult> GetStateVectorsByIcao24Async(string icao24, int? time = null)
    {
        var result = await _stateVectorsFacade.GetStateVectorsByIcao24Async(icao24, time);
        return Ok(result);
    }
    
    [HttpGet]
    [Route("{country}")]
    public async Task<IActionResult> GetStateVectorsByCountryAsync(string country)
    {
        try
        {
            var result = await _stateVectorsFacade.GetStateVectorsByCountryAsync(country);
            return Ok(result);
        }
        catch (KeyNotFoundException)
        {
            return NotFound();
        }
    }

    [HttpGet]
    [Route("{la-min}/{lo-min}/{la-max}/{lo-max}")]
    public async Task<IActionResult> GetByBoundingBox([FromRoute(Name = "la-min")] decimal minLatitude,
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
        
        var result = await _stateVectorsFacade.GetStateVectorsByBoundingBoxAsync(bbox);
        return Ok(result);
    }
}