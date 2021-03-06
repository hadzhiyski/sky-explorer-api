using SkyExplorer.Common.Models;

namespace SkyExplorer.Core.Country.Models;

public class Country
{
    public string Name { get; set; } = null!;
    public string Alpha2 { get; set; } = null!;
    public BoundingBox BoundingBox { get; set; } = null!;
}