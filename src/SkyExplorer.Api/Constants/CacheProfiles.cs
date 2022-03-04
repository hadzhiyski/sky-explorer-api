using Microsoft.AspNetCore.Mvc;

namespace SkyExplorer.Api.Constants;

internal static class CacheProfiles
{
    public const string GetCountries = "GetCountries";
    public const string OpenSky = "OpenSky";

    public static readonly Dictionary<string, CacheProfile> Profiles = new Dictionary<string, CacheProfile>
    {
        {GetCountries, new CacheProfile {Duration = (int) TimeSpan.FromDays(1).TotalSeconds}},
        {OpenSky, new CacheProfile {Duration = OpenSkyConstants.AnonymousTimeResolutionSeconds,}},
    };
}