using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HelpMe.Migrations
{
    /// <inheritdoc />
    public partial class Seeder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TypeIncidents",
                columns: new[] { "Id", "Type" },
                values: new object[,]
                {
            { 1, "Incendie" },
            { 2, "Accident routier" },
            { 3, "Accident fluviale" },
            { 4, "Accident aérien" },
            { 5, "Eboulement" },
            { 6, "Invasion de serpent" },
            { 7, "Fuite de gaz" },
            { 8, "Manifestation" },
            { 9, "Braquage" },
            { 10, "Evasion d’un prisonnier" },
                });

            migrationBuilder.InsertData(
                table: "Heroes",
                columns: new[] { "Id", "Name", "Latitude", "Longitude", "PhoneNumber" },
                values: new object[,]
                {
            { 1, "Spiderman", 48.8566, 2.3522, "0783390929" },
            { 2, "Batman", 40.7128, -74.0060, "0603575889" },
            { 3, "Aquaman", 37.7749, -122.4194, "0640208472" }
                });

            migrationBuilder.InsertData(
                table: "TypeIncidentHeroes",
                columns: new[] { "Id", "HeroId", "TypeIncidentId" },
                values: new object[,]
                {
            { 1, 1, 1 },
            { 2, 2, 2 },
            { 3, 3, 3 }
                });

            migrationBuilder.InsertData(
                table: "Incidents",
                columns: new[] { "Id", "TypeIncidentId", "Ville", "Latitude", "Longitude", "IsResolved" },
                values: new object[,]
                {
            { 1, 1, "Paris", 48.8606, 2.3376, false },
            { 2, 2, "Miami Beach", 25.7907, 80.1300, false },
            { 3, 3, "Venise", 45.4342, 12.3388, false }
                });

            migrationBuilder.InsertData(
                table: "HeroIncidents",
                columns: new[] { "Id", "HeroId", "IncidentId" },
                values: new object[,]
                {
            { 1, 1, 1 },
            { 2, 2, 2 },
            { 3, 3, 3 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "HeroIncidents",
                keyColumn: "Id",
                keyValues: new object[] { 1, 2, 3 });

            // Supprimer les Incidents
            migrationBuilder.DeleteData(
                table: "Incidents",
                keyColumn: "Id",
                keyValues: new object[] { 1, 2, 3 });

            // Supprimer les SuperHeroIncidentResources
            migrationBuilder.DeleteData(
                table: "TypeIncidentHeroes",
                keyColumn: "Id",
                keyValues: new object[] { 1, 2, 3 });

            // Supprimer les SuperHeroes
            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValues: new object[] { 1, 2, 3 });

            // Supprimer les IncidentResources
            migrationBuilder.DeleteData(
                table: "TypeIncidents",
                keyColumn: "Id",
                keyValues: new object[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });
        }
    }
}
