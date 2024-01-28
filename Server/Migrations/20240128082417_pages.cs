using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FullSD.Server.Migrations
{
    /// <inheritdoc />
    public partial class pages : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "be04dd60-8599-41c2-8096-67868766306c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5d7f6395-053c-4019-b324-a6b7d0ff783f", "AQAAAAIAAYagAAAAEIS0BrCfGPWHR/6+XOeHMdN7Ey7iI9gnNjYASN0QTPWNlG6OhQJH1enmkxyslfUeEA==", "d8ba4b27-8dd2-4e46-b210-954661acde2e" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "be04dd60-8599-41c2-8096-67868766306c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9a32b852-a58c-4850-a0d6-c90920d35636", "AQAAAAIAAYagAAAAEI8STkr4crooMs/fMTOrn6YSfvahHuxQElJo9ZR98M8+o2f+VURXO7FtHtVhb1Gyog==", "63d06bef-fe22-45e1-b9de-96bca7bfd1a8" });
        }
    }
}
