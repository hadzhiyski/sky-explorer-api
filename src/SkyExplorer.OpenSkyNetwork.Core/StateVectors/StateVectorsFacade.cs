using Microsoft.EntityFrameworkCore;
using SkyExplorer.Common.Models;
using SkyExplorer.Core.Country;
using SkyExplorer.Data;
using SkyExplorer.OpenSkyNetwork.Core.StateVectors.Models;

namespace SkyExplorer.OpenSkyNetwork.Core.StateVectors;

public class StateVectorsFacade : IStateVectorsFacade
{
    private readonly IStateVectorsApiService _stateVectorsApi;
    private readonly ICountryService _countryService;

    public StateVectorsFacade(IStateVectorsApiService stateVectorsApi, ICountryService countryService)
    {
        _stateVectorsApi = stateVectorsApi;
        _countryService = countryService;
    }

    public Task<IReadOnlyCollection<StateVector>> GetStateVectorsByIcao24Async(string icao24, int? time) =>
        _stateVectorsApi.GetStateVectorsByIcao24Async(icao24, time);

    public Task<IReadOnlyCollection<StateVector>> GetStateVectorsByBoundingBoxAsync(BoundingBox bbox) =>
        _stateVectorsApi.GetStateVectorsByBoundingBoxAsync(bbox);

    public async Task<IReadOnlyCollection<StateVector>> GetStateVectorsByCountryAsync(string countryAlpha2)
    {
        var country = await _countryService.GetCountryByAlpha2Async(countryAlpha2);

        return await GetStateVectorsByBoundingBoxAsync(country.BoundingBox);
    }
}