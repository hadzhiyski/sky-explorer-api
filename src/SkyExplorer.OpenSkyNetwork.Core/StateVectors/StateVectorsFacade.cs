using Microsoft.EntityFrameworkCore;
using SkyExplorer.Common.Models;
using SkyExplorer.Data;
using SkyExplorer.OpenSkyNetwork.Core.StateVectors.Models;

namespace SkyExplorer.OpenSkyNetwork.Core.StateVectors;

public class StateVectorsFacade : IStateVectorsFacade
{
    private readonly IStateVectorsApiService _stateVectorsApi;
    private readonly ISkyExplorerDbContext _dbContext;

    public StateVectorsFacade(IStateVectorsApiService stateVectorsApi, ISkyExplorerDbContext dbContext)
    {
        _stateVectorsApi = stateVectorsApi;
        _dbContext = dbContext;
    }

    public Task<IReadOnlyCollection<StateVector>?> GetStateVectorsByIcao24Async(string icao24, int? time) =>
        _stateVectorsApi.GetStateVectorsByIcao24Async(icao24, time);

    public Task<IReadOnlyCollection<StateVector>?> GetStateVectorsByBoundingBoxAsync(BoundingBox bbox) =>
        _stateVectorsApi.GetStateVectorsByBoundingBoxAsync(bbox);

    public async Task<IReadOnlyCollection<StateVector>?> GetStateVectorsByCountryAsync(string country)
    {
        // ReSharper disable once SpecifyStringComparison
        var countryByAlpha2 =
            await _dbContext.Countries.SingleOrDefaultAsync(c => c.Alpha2.ToLower() == country.ToLower());
        if (countryByAlpha2 == null)
        {
            throw new KeyNotFoundException($"Country '{country}' not found");
        }

        return await GetStateVectorsByBoundingBoxAsync(countryByAlpha2.BoundingBox);
    }
}