FROM mcr.microsoft.com/dotnet/sdk:6.0 as build

WORKDIR /app
COPY SkyExplorer.sln SkyExplorer.sln
COPY src src
RUN dotnet restore SkyExplorer.sln
RUN dotnet publish -c release --no-restore --output /app/publish src/SkyExplorer.Api

FROM mcr.microsoft.com/dotnet/aspnet:6.0

WORKDIR /app

COPY --from=build /app/publish .

EXPOSE 80

ENTRYPOINT ["dotnet", "SkyExplorer.Api.dll"]
