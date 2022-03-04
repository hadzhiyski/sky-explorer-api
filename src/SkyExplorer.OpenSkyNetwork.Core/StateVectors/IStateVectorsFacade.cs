using SkyExplorer.Common.Models;
using SkyExplorer.OpenSkyNetwork.Core.StateVectors.Models;

namespace SkyExplorer.OpenSkyNetwork.Core.StateVectors;

public interface IStateVectorsFacade
{
    Task<IReadOnlyCollection<StateVector>?> GetStateVectorsByIcao24Async(string icao24, int? time);
    Task<IReadOnlyCollection<StateVector>?> GetStateVectorsByBoundingBoxAsync(BoundingBox bbox);
    Task<IReadOnlyCollection<StateVector>?> GetStateVectorsByCountryAsync(string countryAlpha2);
}