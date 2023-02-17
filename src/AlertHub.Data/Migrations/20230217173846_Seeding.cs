using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AlertHub.Data.Migrations
{
    /// <inheritdoc />
    public partial class Seeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "a9e093d7-98bd-a80e-a609-b542da0848bb", "a9e093d7-98bd-a80e-a609-b542da0848bb", "Civil_Protection", "CIVIL_PROTECTION" },
                    { "e07c5c55-d904-7439-1b5e-676b40f9b621", "e07c5c55-d904-7439-1b5e-676b40f9b621", "Simple_User", "SIMPLE_USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a9e093d7-98bd-a80e-a609-b542da0848bb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e07c5c55-d904-7439-1b5e-676b40f9b621");
        }
    }
}
