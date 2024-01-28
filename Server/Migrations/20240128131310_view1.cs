using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FullSD.Server.Migrations
{
    /// <inheritdoc />
    public partial class view1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "be04dd60-8599-41c2-8096-67868766306c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ca3a8e50-4778-48f2-909c-bf4252991ec2", "AQAAAAIAAYagAAAAEJd3v9vs12yAmJ6vo2C+8o5C/+orOTfcELGeF1F6Q8jnM+MU/zSfcHQ5avWBA9Pjcw==", "05e2b167-8cbc-4505-bad2-1371c6d79427" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "be04dd60-8599-41c2-8096-67868766306c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9aac3e89-a9a8-4587-b681-aef9f5a916eb", "AQAAAAIAAYagAAAAECQ8TMq3HwiAyxzSLTKlDpa/2LbwsQgVn9vQWMjv+iwiGy8PXjj1pHBj3aSZEdvTuw==", "13728421-c921-4527-bd4e-5f65b07d7732" });
        }
    }
}
