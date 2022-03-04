using SkyExplorer.Common.Models;

namespace SkyExplorer.Data.Models;

public class Country
{
    public string Alpha2 { get; set; } = null!;
    public string Name { get; set; } = null!;
    public BoundingBox BoundingBox { get; set; } = null!;
    public virtual ICollection<Airport> Airports { get; set; } = null!;
}