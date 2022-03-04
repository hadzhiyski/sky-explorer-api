using Microsoft.EntityFrameworkCore;
using SkyExplorer.Api.Constants;
using SkyExplorer.Api.Infrastructure;
using SkyExplorer.Core.Country;
using SkyExplorer.Data;
using SkyExplorer.OpenSkyNetwork.Core;
using SkyExplorer.OpenSkyNetwork.Core.StateVectors;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers(opts =>
{
    opts.CacheProfiles.Add(CacheProfiles.GetCountries, CacheProfiles.Profiles[CacheProfiles.GetCountries]);
    opts.CacheProfiles.Add(CacheProfiles.OpenSky, CacheProfiles.Profiles[CacheProfiles.OpenSky]);
});
builder.Services.AddRouting(opts =>
{
    opts.LowercaseUrls = true;
    opts.LowercaseQueryStrings = true;
});

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(opts => { opts.OperationFilter<ReApplyOptionalRouteParameterOperationFilter>(); });

builder.Services.AddDbContext<SkyExplorerDbContext>(opts =>
{
    opts.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection"));
});

builder.Services.Configure<OpenSkyApiOptions>(builder.Configuration.GetSection(nameof(OpenSkyApiOptions)));

builder.Services.AddScoped<ISkyExplorerDbContext>(services => services.GetRequiredService<SkyExplorerDbContext>());
builder.Services.AddTransient<ICountryService, CountryService>();
builder.Services.AddHttpClient();
builder.Services.AddTransient<IStateVectorsApiService, StateVectorsApiService>();
builder.Services.AddTransient<IStateVectorsFacade, StateVectorsFacade>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseResponseCaching();
app.UseAuthorization();
app.MapControllers();

app.Run();