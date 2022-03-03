# sky-explorer-api
.NET Core 6 API for sky-explorer repo - https://github.com/hadzhiyski/sky-explorer

## Migrations
```
dotnet ef migrations add MIGRATION_NAME -p src/SkyExplorer.Data -c SkyExplorerDbContext -- "TYPE_CONNECTION_STRING_HERE"
dotnet ef database update -p src/SkyExplorer.Data -c SkyExplorerDbContext -- "TYPE_CONNECTION_STRING_HERE" 
```

## Seeder
```
dotnet run --project ./tools/SkyExplorer.Data.Seeder -- "TYPE_CONNECTION_STRING_HERE"
```
