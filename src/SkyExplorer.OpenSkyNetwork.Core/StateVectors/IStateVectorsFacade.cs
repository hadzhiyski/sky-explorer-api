using SkyExplorer.Common.Models;
using SkyExplorer.OpenSkyNetwork.Core.StateVectors.Models;

namespace SkyExplorer.OpenSkyNetwork.Core.StateVectors;

public interface IStateVectorsFacade
{
    Task<IReadOnlyCollection<StateVector>?> GetStateVectorsByIcao24Async(string icao24, int? time);
    Task<IReadOnlyCollection<StateVector>?> GetStateVectorsByBoundingBoxAsync(BoundingBox bbox);
    /// <summary>
    /// Get state vectors by country's alpha-2 ISO code
    /// </summary>
    /// <param name="country">alpha-2 ISO code</param>
    /// <returns></returns>
    /// <exception cref="KeyNotFoundException">Thrown when the country was not found</exception>
    Task<IReadOnlyCollection<StateVector>?> GetStateVectorsByCountryAsync(string country);
}