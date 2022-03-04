using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using SkyExplorer.Common.Models;

#nullable disable

namespace SkyExplorer.Data.Migrations
{
    public partial class AddCountriesAndAirports : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("Npgsql:Enum:airport_type", "heliport,small_airport,medium_airport,large_airport,seaplane_base,balloonport,closed");

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Alpha2 = table.Column<string>(type: "character varying(2)", maxLength: 2, nullable: false),
                    Name = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: false),
                    BoundingBox = table.Column<BoundingBox>(type: "jsonb", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Alpha2);
                });

            migrationBuilder.CreateTable(
                name: "Airports",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Type = table.Column<AirportType>(type: "airport_type", nullable: false),
                    Name = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: false),
                    Latitude = table.Column<decimal>(type: "numeric", nullable: false),
                    Longitude = table.Column<decimal>(type: "numeric", nullable: false),
                    CountryAlpha2 = table.Column<string>(type: "character varying(2)", maxLength: 2, nullable: false),
                    Icao = table.Column<string>(type: "character varying(4)", maxLength: 4, nullable: true),
                    Iata = table.Column<string>(type: "character varying(3)", maxLength: 3, nullable: true),
                    HomeUrl = table.Column<string>(type: "character varying(4096)", maxLength: 4096, nullable: true),
                    WikiUrl = table.Column<string>(type: "character varying(4096)", maxLength: 4096, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Airports", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Airports_Countries_CountryAlpha2",
                        column: x => x.CountryAlpha2,
                        principalTable: "Countries",
                        principalColumn: "Alpha2",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Airports_CountryAlpha2",
                table: "Airports",
                column: "CountryAlpha2");

            migrationBuilder.CreateIndex(
                name: "IX_Airports_Icao_Iata",
                table: "Airports",
                columns: new[] { "Icao", "Iata" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Airports");

            migrationBuilder.DropTable(
                name: "Countries");
        }
    }
}
