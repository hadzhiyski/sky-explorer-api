using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SkyExplorer.Data.Models;

namespace SkyExplorer.Data.Configuration;

public class CountryEntityTypeConfiguration : IEntityTypeConfiguration<Country>
{
    public void Configure(EntityTypeBuilder<Country> builder)
    {
        builder.HasKey(e => e.Id);
        builder.Property(e => e.Name)
            .IsRequired()
            .HasMaxLength(128);
        builder.Property(e => e.Alpha2Code)
            .IsRequired()
            .HasMaxLength(2);
        builder.Property(e => e.BoundingBox)
            .IsRequired()
            .HasColumnType("jsonb");
    }
}