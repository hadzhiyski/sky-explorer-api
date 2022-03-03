namespace SkyExplorer.Api.Models.Countries;

public class Country
{
    public int Id { get; set; }
    public string Alpha2 { get; set; } = null!;
    public string Name { get; set; } = null!;
}