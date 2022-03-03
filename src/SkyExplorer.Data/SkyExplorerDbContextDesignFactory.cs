using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace SkyExplorer.Data;

// ReSharper disable once UnusedType.Global
public class SkyExplorerDbContextDesignFactory : IDesignTimeDbContextFactory<SkyExplorerDbContext>
{
    public SkyExplorerDbContext CreateDbContext(string[] args)
    {   
        var connectionString = args[0];
        var builder = new DbContextOptionsBuilder<SkyExplorerDbContext>();
        builder.UseNpgsql(connectionString);

        return new SkyExplorerDbContext(builder.Options);
    }
}