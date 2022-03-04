using SkyExplorer.Common.Models;
using SkyExplorer.OpenSkyNetwork.Core.StateVectors.Models;

namespace SkyExplorer.OpenSkyNetwork.Core.StateVectors;

public interface IStateVectorsApiService
{
    Task<IReadOnlyCollection<StateVector>?> GetStateVectorsByIcao24Async(string icao24, int? time);
    Task<IReadOnlyCollection<StateVector>?> GetStateVectorsByBoundingBoxAsync(BoundingBox bbox);
}