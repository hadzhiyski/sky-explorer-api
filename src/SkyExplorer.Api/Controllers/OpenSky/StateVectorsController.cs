using Microsoft.AspNetCore.Mvc;
using SkyExplorer.Api.Constants;
using SkyExplorer.Common.Models;
using SkyExplorer.OpenSkyNetwork.Core.StateVectors;
using SkyExplorer.OpenSkyNetwork.Core.StateVectors.Models;

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
    public async Task<IReadOnlyCollection<StateVector>> GetStateVectorsByIcao24Async(string icao24, int? time = null)
    {
        var result = await _stateVectorsFacade.GetStateVectorsByIcao24Async(icao24, time);
        return result;
    }
    
    [HttpGet]
    [Route("{country}")]
    [ProducesResponseType(typeof(IReadOnlyCollection<StateVector>), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
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
    public async Task<IReadOnlyCollection<StateVector>> GetByBoundingBox([FromRoute(Name = "la-min")] decimal minLatitude,
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
        return result;
    }
}