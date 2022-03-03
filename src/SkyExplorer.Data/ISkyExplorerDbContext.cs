using Microsoft.EntityFrameworkCore;
using SkyExplorer.Data.Models;

namespace SkyExplorer.Data;

public interface ISkyExplorerDbContext
{
    DbSet<Country> Countries { get; }
    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}