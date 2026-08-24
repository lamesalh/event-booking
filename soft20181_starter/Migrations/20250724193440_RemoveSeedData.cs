using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace soft20181_starter.Migrations
{
    /// <inheritdoc />
    public partial class RemoveSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 3);

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "CoverPhoto", "Description", "EventDateTime", "Location", "Name" },
                values: new object[,]
                {
                    { 1, "/images/drake.jpeg", "Experience an unforgettable night with Drake, the global sensation known for his chart-topping hits like 'God's Plan' and 'One Dance.'", new DateTime(2025, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "O2 Arena - London", "Drake" },
                    { 2, "/images/21savage.jpeg", "Dive into the world of 21 Savage, a trailblazer in modern hip-hop. His performances are raw, real, and unforgettable.", new DateTime(2025, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Madison Square Garden - New York", "21 Savage" },
                    { 3, "/images/babygang.jpeg", "Join Baby Gang as he takes the stage in a thrilling showcase of his unique style and captivating flow.", new DateTime(2025, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wembley Stadium - London", "Baby Gang" },
                    { 4, "/images/badbunny.jpeg", "Feel the energy of Bad Bunny, the global icon of Latin music. From reggaeton to trap, he brings infectious beats and passion.", new DateTime(2025, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Staples Center - Los Angeles", "Bad Bunny" },
                    { 5, "/images/adele.jpeg", "Experience the soulful magic of Adele as she performs her powerful ballads that have touched millions worldwide.", new DateTime(2026, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "TD Garden - Boston", "Adele" },
                    { 6, "/images/theweeknd.jpeg", "Celebrate Valentine's Day with The Weeknd. Enjoy his mesmerizing voice and hits like 'Blinding Lights' and 'Starboy.'", new DateTime(2026, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Manchester Arena - Manchester", "The Weeknd" },
                    { 7, "/images/travis.jpeg", "Get hyped for Travis Scott's high-octane performance, blending hip-hop with immersive visuals. Known for 'SICKO MODE.'", new DateTime(2025, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "O2 Arena - London", "Travis" },
                    { 8, "/images/morad.jpeg", "Discover Morad's unique style, combining deep storytelling with urban beats. His music resonates worldwide.", new DateTime(2025, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Barclays Center - New York", "Morad" },
                    { 9, "/images/rossalia.jpeg", "Join Rosalia for a night of genre-bending music, where flamenco meets pop and reggaeton. Her performances are vibrant.", new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sofi Stadium - Los Angeles", "Rossalia" },
                    { 10, "/images/rema.jpeg", "Catch Rema, the Nigerian superstar redefining Afrobeat with hits like 'Calm Down' and 'Dumebi.'", new DateTime(2026, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Emirates Stadium - Manchester", "Rema" }
                });
        }
    }
}
