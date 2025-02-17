using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BloggingPlatformAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddNewDataFixIssues : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BlogPost",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.InsertData(
                table: "BlogPost",
                columns: new[] { "Id", "Category", "CreatedAt", "Tags", "Title", "UpdatedAt", "content" },
                values: new object[] { 6, "Tech", new DateTime(2025, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Python, Software", "Title", new DateTime(2025, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Content" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BlogPost",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.InsertData(
                table: "BlogPost",
                columns: new[] { "Id", "Category", "CreatedAt", "Tags", "Title", "UpdatedAt", "content" },
                values: new object[] { 1, "News", new DateTime(2025, 2, 16, 22, 24, 27, 341, DateTimeKind.Local).AddTicks(9072), "[\"Programming\",\"Software\"]", "First Article", new DateTime(2025, 2, 16, 22, 24, 27, 342, DateTimeKind.Local).AddTicks(6437), "This is my first article" });
        }
    }
}
