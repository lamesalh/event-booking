using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace soft20181_starter.Migrations
{
    /// <inheritdoc />
    public partial class UpdateToTheEventModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Venue",
                table: "Events",
                newName: "Location");

            migrationBuilder.RenameColumn(
                name: "ImageUrl",
                table: "Events",
                newName: "EventDateTime");

            migrationBuilder.RenameColumn(
                name: "Date",
                table: "Events",
                newName: "CoverPhoto");

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CoverPhoto", "EventDateTime" },
                values: new object[] { "/images/drake.jpeg", new DateTime(2025, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CoverPhoto", "EventDateTime" },
                values: new object[] { "/images/21savage.jpeg", new DateTime(2025, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CoverPhoto", "EventDateTime" },
                values: new object[] { "/images/babygang.jpeg", new DateTime(2025, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CoverPhoto", "EventDateTime" },
                values: new object[] { "/images/badbunny.jpeg", new DateTime(2025, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CoverPhoto", "EventDateTime" },
                values: new object[] { "/images/adele.jpeg", new DateTime(2026, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CoverPhoto", "EventDateTime" },
                values: new object[] { "/images/theweeknd.jpeg", new DateTime(2026, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CoverPhoto", "EventDateTime" },
                values: new object[] { "/images/travis.jpeg", new DateTime(2025, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CoverPhoto", "EventDateTime" },
                values: new object[] { "/images/morad.jpeg", new DateTime(2025, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CoverPhoto", "EventDateTime" },
                values: new object[] { "/images/rossalia.jpeg", new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CoverPhoto", "EventDateTime" },
                values: new object[] { "/images/rema.jpeg", new DateTime(2026, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Location",
                table: "Events",
                newName: "Venue");

            migrationBuilder.RenameColumn(
                name: "EventDateTime",
                table: "Events",
                newName: "ImageUrl");

            migrationBuilder.RenameColumn(
                name: "CoverPhoto",
                table: "Events",
                newName: "Date");

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Date", "ImageUrl" },
                values: new object[] { new DateTime(2025, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "/images/drake.jpeg" });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Date", "ImageUrl" },
                values: new object[] { new DateTime(2025, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "/images/21savage.jpeg" });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Date", "ImageUrl" },
                values: new object[] { new DateTime(2025, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "/images/babygang.jpeg" });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Date", "ImageUrl" },
                values: new object[] { new DateTime(2025, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "/images/badbunny.jpeg" });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Date", "ImageUrl" },
                values: new object[] { new DateTime(2026, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "/images/adele.jpeg" });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Date", "ImageUrl" },
                values: new object[] { new DateTime(2026, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "/images/theweeknd.jpeg" });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Date", "ImageUrl" },
                values: new object[] { new DateTime(2025, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "/images/travis.jpeg" });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Date", "ImageUrl" },
                values: new object[] { new DateTime(2025, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "/images/morad.jpeg" });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Date", "ImageUrl" },
                values: new object[] { new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "/images/rossalia.jpeg" });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Date", "ImageUrl" },
                values: new object[] { new DateTime(2026, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "/images/rema.jpeg" });
        }
    }
}
