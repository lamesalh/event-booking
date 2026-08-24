using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace soft20181_starter.Migrations
{
    /// <inheritdoc />
    public partial class AddMoreEvents : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Date", "Description", "ImageUrl", "Name", "Venue" },
                values: new object[] { new DateTime(2025, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Join Baby Gang as he takes the stage in a thrilling showcase of his unique style and captivating flow.", "/images/babygang.jpeg", "Baby Gang", "Wembley Stadium - London" });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "Date", "Description", "ImageUrl", "Name", "Venue" },
                values: new object[,]
                {
                    { 4, new DateTime(2025, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Feel the energy of Bad Bunny, the global icon of Latin music. From reggaeton to trap, he brings infectious beats and passion.", "/images/badbunny.jpeg", "Bad Bunny", "Staples Center - Los Angeles" },
                    { 5, new DateTime(2026, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Experience the soulful magic of Adele as she performs her powerful ballads that have touched millions worldwide.", "/images/adele.jpeg", "Adele", "TD Garden - Boston" },
                    { 6, new DateTime(2026, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Celebrate Valentine's Day with The Weeknd. Enjoy his mesmerizing voice and hits like 'Blinding Lights' and 'Starboy.'", "/images/theweeknd.jpeg", "The Weeknd", "Manchester Arena - Manchester" },
                    { 7, new DateTime(2025, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Get hyped for Travis Scott's high-octane performance, blending hip-hop with immersive visuals. Known for 'SICKO MODE.'", "/images/travis.jpeg", "Travis", "O2 Arena - London" },
                    { 8, new DateTime(2025, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Discover Morad's unique style, combining deep storytelling with urban beats. His music resonates worldwide.", "/images/morad.jpeg", "Morad", "Barclays Center - New York" },
                    { 9, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Join Rosalia for a night of genre-bending music, where flamenco meets pop and reggaeton. Her performances are vibrant.", "/images/rossalia.jpeg", "Rossalia", "Sofi Stadium - Los Angeles" },
                    { 10, new DateTime(2026, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Catch Rema, the Nigerian superstar redefining Afrobeat with hits like 'Calm Down' and 'Dumebi.'", "/images/rema.jpeg", "Rema", "Emirates Stadium - Manchester" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Date", "Description", "ImageUrl", "Name", "Venue" },
                values: new object[] { new DateTime(2026, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Experience the soulful magic of Adele as she performs her powerful ballads that have touched millions worldwide.", "/images/adele.jpeg", "Adele", "TD Garden - Boston" });
        }
    }
}
