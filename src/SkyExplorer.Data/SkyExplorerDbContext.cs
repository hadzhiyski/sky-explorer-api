using Microsoft.EntityFrameworkCore;
using Npgsql;
using Npgsql.EntityFrameworkCore.PostgreSQL.Storage.Internal.Mapping;
using SkyExplorer.Common.Models;
using SkyExplorer.Data.Configuration;
using SkyExplorer.Data.Models;

namespace SkyExplorer.Data;

public class SkyExplorerDbContext : DbContext, ISkyExplorerDbContext
{
    public SkyExplorerDbContext(DbContextOptions<SkyExplorerDbContext> options)
        : base(options)
    {
        NpgsqlConnection.GlobalTypeMapper.MapEnum<AirportType>();
    }

    public DbSet<Country> Countries { get; set; } = null!;
    public DbSet<Airport> Airports { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.HasPostgresEnum<AirportType>();
        modelBuilder.ApplyConfiguration(new CountryEntityTypeConfiguration());
        modelBuilder.ApplyConfiguration(new AirportEntityTypeConfiguration());
    }
}