using Microsoft.EntityFrameworkCore.Metadata.Internal;
using SkyExplorer.Common.Models;

namespace SkyExplorer.Data.Models;

public class Airport
{
    public int Id { get; set; }
    public AirportType Type { get; set; }
    public string Name { get; set; } = null!;
    public decimal Latitude { get; set; }
    public decimal Longitude { get; set; }
    public string CountryAlpha2 { get; set; } = null!;
    public string? Icao { get; set; }
    public string? Iata { get; set; }
    public string? HomeUrl { get; set; }
    public string? WikiUrl { get; set; }
    public virtual Country Country { get; set; } = null!;
}