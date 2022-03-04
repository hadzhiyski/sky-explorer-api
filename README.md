# sky-explorer-api
.NET Core 6 API for sky-explorer - https://github.com/hadzhiyski/sky-explorer

## Credits

### Open Sky Network
[Open Sky Network](https://opensky-network.org/)

[Open Sky Network API](https://openskynetwork.github.io/opensky-api/)
#### Original OpenSky paper 
```
Matthias Schäfer, Martin Strohmeier, Vincent Lenders, Ivan Martinovic and Matthias Wilhelm.
"Bringing Up OpenSky: A Large-scale ADS-B Sensor Network for Research".
In Proceedings of the 13th IEEE/ACM International Symposium on Information Processing in Sensor Networks (IPSN), pages 83-94, April 2014.
```
### Our Airports
[Our Aiports](https://ourairports.com/data/)

[Our Aiports Github](https://github.com/davidmegginson/ourairports-data)

## Migrations
``` bash
dotnet ef migrations add MIGRATION_NAME -p src/SkyExplorer.Data -c SkyExplorerDbContext -- "TYPE_CONNECTION_STRING_HERE"
dotnet ef database update -p src/SkyExplorer.Data -c SkyExplorerDbContext -- "TYPE_CONNECTION_STRING_HERE" 
```
