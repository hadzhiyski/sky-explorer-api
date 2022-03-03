namespace SkyExplorer.OpenSkyNetwork.Core.StateVectors.Models;

public class StateVector
{
    public string Icao24 { get; set; } = null!;
    public string? CallSign { get; set; }
    public string OriginCountry { get; set; } = null!;
    public DateTimeOffset? TimePosition { get; set; }
    public DateTimeOffset? LastContact { get; set; }
    public double? Longitude { get; set; }
    public double? Latitude { get; set; }
    public double? BarometricAltitude { get; set; }
    public bool OnGround { get; set; }
    public double? Velocity { get; set; }
    public double? TrueTrack { get; set; }
    public double? VerticalRate { get; set; }
    public double? GeoAltitude { get; set; }
    public string? Squawk { get; set; }
    public bool SpecialPurposeIndicator { get; set; }
    public PositionSource PositionSource { get; set; }
}