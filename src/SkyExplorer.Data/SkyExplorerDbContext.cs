using Microsoft.EntityFrameworkCore;
using SkyExplorer.Data.Configuration;
using SkyExplorer.Data.Models;

namespace SkyExplorer.Data;

public class SkyExplorerDbContext : DbContext, ISkyExplorerDbContext
{
    public SkyExplorerDbContext(DbContextOptions<SkyExplorerDbContext> options)
        : base(options)
    {
    }

    public DbSet<Country> Countries { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfiguration(new CountryEntityTypeConfiguration());
    }
}