using SkyExplorer.Common.Models;

namespace SkyExplorer.Api.Models.Airports;

public class Airport
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public AirportType Type { get; set; }
    public decimal Latitude { get; set; }
    public decimal Longitude { get; set; }
    public string? Icao { get; set; }
    public string? Iata { get; set; }
    public string? HomeUrl { get; set; }
    public string? WikiUrl { get; set; }
}