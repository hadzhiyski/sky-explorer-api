using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SkyExplorer.Data.Models;

namespace SkyExplorer.Data.Configuration;

public class AirportEntityTypeConfiguration : IEntityTypeConfiguration<Airport>
{
    public void Configure(EntityTypeBuilder<Airport> builder)
    {
        builder.HasKey(e => e.Id);
        builder.Property(e => e.Latitude)
            .IsRequired();
        builder.Property(e => e.Longitude)
            .IsRequired();
        builder.Property(e => e.Name)
            .IsRequired()
            .HasMaxLength(256);
        builder.Property(e => e.Type)
            .IsRequired();
        builder.Property(e => e.CountryAlpha2)
            .IsRequired()
            .HasMaxLength(2);
        builder.Property(e => e.Icao)
            .HasMaxLength(4);
        builder.Property(e => e.Iata)
            .HasMaxLength(3);
        builder.HasIndex(e => new {IcaoCode = e.Icao, IataCode = e.Iata});
        builder.Property(e => e.HomeUrl)
            .HasMaxLength(4096);
        builder.Property(e => e.WikiUrl)
            .HasMaxLength(4096);
    }
}