using Microsoft.EntityFrameworkCore;
using SkyExplorer.Data.Models;

namespace SkyExplorer.Data;

public interface ISkyExplorerDbContext
{
    DbSet<Country> Countries { get; }
    DbSet<Airport> Airports { get; }
    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}