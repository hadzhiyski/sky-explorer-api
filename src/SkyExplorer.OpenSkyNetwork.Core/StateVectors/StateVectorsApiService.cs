using System.Globalization;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using SkyExplorer.Common.Models;
using SkyExplorer.OpenSkyNetwork.Core.StateVectors.Models;

namespace SkyExplorer.OpenSkyNetwork.Core.StateVectors;

public class StateVectorsApiService : IStateVectorsApiService
{
    private readonly IHttpClientFactory _httpClientFactory;
    private readonly OpenSkyApiOptions _openSkyApiOptions;

    public StateVectorsApiService(IHttpClientFactory httpClientFactory, IOptions<OpenSkyApiOptions> openSkyApiOptions)
    {
        _httpClientFactory = httpClientFactory;
        _openSkyApiOptions = openSkyApiOptions.Value;
    }

    public async Task<IReadOnlyCollection<StateVector>?> GetStateVectorsByIcao24Async(string icao24, int? time)
    {
        var httpClient = _httpClientFactory.CreateClient();
        httpClient.BaseAddress = new Uri(_openSkyApiOptions.BaseUrl);
        var query = new Dictionary<string, string>
        {
            {"icao24", icao24}
        };
        if (time.HasValue)
        {
            query.Add("time", time.Value.ToString());
        }

        var uri = QueryHelpers.AddQueryString(_openSkyApiOptions.StateVectorsEndpoint, query);
        var result = await httpClient.GetAsync(uri).ConfigureAwait(false);
        result.EnsureSuccessStatusCode();

        var responseString = await result.Content.ReadAsStringAsync().ConfigureAwait(false);

        var response = JsonConvert.DeserializeObject<GetStateVectorsResponse>(responseString);

        return MapStateVectors(response);
    }

    public async Task<IReadOnlyCollection<StateVector>?> GetStateVectorsByBoundingBoxAsync(BoundingBox bbox)
    {
        var httpClient = _httpClientFactory.CreateClient();
        httpClient.BaseAddress = new Uri(_openSkyApiOptions.BaseUrl);
        var query = new Dictionary<string, string>
        {
            {"lamin", bbox.MinLatitude.ToString(CultureInfo.InvariantCulture)},
            {"lomin", bbox.MinLongitude.ToString(CultureInfo.InvariantCulture)},
            {"lamax", bbox.MaxLatitude.ToString(CultureInfo.InvariantCulture)},
            {"lomax", bbox.MaxLongitude.ToString(CultureInfo.InvariantCulture)},
        };

        var uri = QueryHelpers.AddQueryString(_openSkyApiOptions.StateVectorsEndpoint, query);
        var result = await httpClient.GetAsync(uri).ConfigureAwait(false);
        result.EnsureSuccessStatusCode();

        var responseString = await result.Content.ReadAsStringAsync().ConfigureAwait(false);

        var response = JsonConvert.DeserializeObject<GetStateVectorsResponse>(responseString);

        return MapStateVectors(response);
    }

    private static IReadOnlyCollection<StateVector>? MapStateVectors(GetStateVectorsResponse? response)
    {
        return response?.States.Select(state =>
        {
            var timePositionParsed = int.TryParse(state[3]?.ToString(), out var timePosition);
            var lastContactParsed = int.TryParse(state[4]?.ToString(), out var lastContact);
            var longitudeParsed = double.TryParse(state[5]?.ToString(), out var longitude);
            var latitudeParsed = double.TryParse(state[6]?.ToString(), out var latitude);
            var barometricAltitudeParsed = double.TryParse(state[7]?.ToString(), out var barometricAltitude);
            var onGroundParsed = bool.TryParse(state[8]?.ToString(), out var onGround);
            var velocityParsed = double.TryParse(state[9]?.ToString(), out var velocity);
            var trueTrackParsed = double.TryParse(state[10]?.ToString(), out var trueTrack);
            var verticalRateParsed = double.TryParse(state[11]?.ToString(), out var verticalRate);
            var geoAltitudeParsed = double.TryParse(state[13]?.ToString(), out var geoAltitude);
            var spiParsed = bool.TryParse(state[15]?.ToString(), out var spi);
            Enum.TryParse(typeof(PositionSource), state[16]?.ToString(), out var positionSource);

            return new StateVector
            {
                Icao24 = state[0]?.ToString() ?? string.Empty,
                CallSign = state[1]?.ToString(),
                OriginCountry = state[2]?.ToString() ?? string.Empty,
                TimePosition = timePositionParsed ? DateTimeOffset.FromUnixTimeSeconds(timePosition) : null,
                LastContact = lastContactParsed ? DateTimeOffset.FromUnixTimeSeconds(lastContact) : null,
                Longitude = longitudeParsed ? longitude : null,
                Latitude = latitudeParsed ? latitude : null,
                BarometricAltitude = barometricAltitudeParsed ? barometricAltitude : null,
                OnGround = onGroundParsed && onGround,
                Velocity = velocityParsed ? velocity : null,
                TrueTrack = trueTrackParsed ? trueTrack : null,
                VerticalRate = verticalRateParsed ? verticalRate : null,
                GeoAltitude = geoAltitudeParsed ? geoAltitude : null,
                Squawk = state[14]?.ToString(),
                SpecialPurposeIndicator = spiParsed && spi,
                PositionSource = (PositionSource) (positionSource ?? PositionSource.Unknown)
            };
        }).ToList();
    }
}