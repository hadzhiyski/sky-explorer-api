namespace SkyExplorer.OpenSkyNetwork.Core.StateVectors.Models;

internal class GetStateVectorsResponse
{
    public int Time { get; set; }
    public object?[][] States { get; set; } = null!;
}