# sky-explorer-api
.NET Core 6 API for sky-explorer - https://github.com/hadzhiyski/sky-explorer

## Credits

### Open Sky Network
[Open Sky Network](https://opensky-network.org/)

[Open Sky Network API](https://openskynetwork.github.io/opensky-api/)
### Our Airports
[Our Aiports](https://ourairports.com/data/)

[Our Aiports Github](https://github.com/davidmegginson/ourairports-data)

## Migrations
``` bash
dotnet ef migrations add MIGRATION_NAME -p src/SkyExplorer.Data -c SkyExplorerDbContext -- "TYPE_CONNECTION_STRING_HERE"
dotnet ef database update -p src/SkyExplorer.Data -c SkyExplorerDbContext -- "TYPE_CONNECTION_STRING_HERE" 
```
