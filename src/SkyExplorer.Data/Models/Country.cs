using SkyExplorer.Common.Models;

namespace SkyExplorer.Data.Models;

public class Country
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string Alpha2Code { get; set; } = null!;
    public BoundingBox BoundingBox { get; set; } = null!;
}