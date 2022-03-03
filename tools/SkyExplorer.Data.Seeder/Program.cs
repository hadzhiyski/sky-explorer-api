using SkyExplorer.Data;
using SkyExplorer.Data.Seeder;

var dbFactory = new SkyExplorerDbContextDesignFactory();
var ctx = dbFactory.CreateDbContext(args);
var transaction = await ctx.Database.BeginTransactionAsync();
try
{
    await ctx.Countries.AddRangeAsync(CountriesSeed.Data);
    await ctx.SaveChangesAsync();
    await transaction.CommitAsync();
    Console.WriteLine("Done");
}
catch (Exception e)
{
    await transaction.RollbackAsync();
    Console.WriteLine(e);
    throw;
}