using Microsoft.AspNetCore.Mvc;
using SkyExplorer.Common.Models;
using SkyExplorer.OpenSkyNetwork.Core.StateVectors;

namespace SkyExplorer.Api.Controllers.OpenSky;

[ApiController]
[Route("opensky/states")]
public class StateVectorsController : ControllerBase
{
    private readonly IStateVectorsService _stateVectorsService;

    public StateVectorsController(IStateVectorsService stateVectorsService)
    {
        _stateVectorsService = stateVectorsService;
    }

    [HttpGet]
    [Route("{icao24}/{time:int?}")]
    public async Task<IActionResult> Get(string icao24, int? time = null)
    {
        var result = await _stateVectorsService.GetStateVectorsByIcao24Async(icao24, time);
        
        throw new NotImplementedException();
    }

    [HttpGet]
    [Route("{la-min}/{lo-min}/{la-max}/{lo-max}")]
    public async Task<IActionResult> GetByBoundingBox([FromRoute(Name = "la-min")] double minLatitude,
        [FromRoute(Name = "lo-min")] double minLongitude, [FromRoute(Name = "la-max")] double maxLatitude,
        [FromRoute(Name = "lo-max")] double maxLongitude)
    {
        var bbox = new BoundingBox
        {
            MaxLatitude = maxLatitude,
            MaxLongitude = maxLongitude,
            MinLatitude = minLatitude,
            MinLongitude = minLongitude,
        };
        var result = await _stateVectorsService.GetStateVectorsByBoundingBoxAsync(bbox);

        throw new NotImplementedException();
    }
}