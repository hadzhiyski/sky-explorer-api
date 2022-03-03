using Microsoft.Extensions.Options;
using SkyExplorer.Common.Models;
using SkyExplorer.OpenSkyNetwork.Core.StateVectors.Models;

namespace SkyExplorer.OpenSkyNetwork.Core.StateVectors;

public class StateVectorsService : IStateVectorsService
{
    private readonly IHttpClientFactory _httpClientFactory;
    private readonly OpenSkyApiOptions _openSkyApiOptions;

    public StateVectorsService(IHttpClientFactory httpClientFactory, IOptions<OpenSkyApiOptions> openSkyApiOptions)
    {
        _httpClientFactory = httpClientFactory;
        _openSkyApiOptions = openSkyApiOptions.Value;
    }

    public Task<IReadOnlyCollection<StateVector>> GetStateVectorsByIcao24Async(string icao24, int? time)
    {
        var httpClient = _httpClientFactory.CreateClient();
    
        throw new NotImplementedException();
    }

    public Task<IReadOnlyCollection<StateVector>> GetStateVectorsByBoundingBoxAsync(BoundingBox bbox)
    {
        throw new NotImplementedException();
    }
}