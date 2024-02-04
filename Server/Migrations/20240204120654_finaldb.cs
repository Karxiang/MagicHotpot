using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FullSD.Server.Migrations
{
    /// <inheritdoc />
    public partial class finaldb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "be04dd60-8599-41c2-8096-67868766306c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b9839ef8-4916-499c-93ff-be9ea43b094a", "AQAAAAIAAYagAAAAEM5XgB/P28OTo+wb6VZO52LKZhP4k+BhR+5iFhUQqiXMZxDGLupxIYbINfhcEkAHbw==", "a602e6ca-8126-40c7-b856-f7a028d4869f" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "be04dd60-8599-41c2-8096-67868766306c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f3a27498-3ddc-454c-8c50-665e035b9ca1", "AQAAAAIAAYagAAAAEKNrVEmeeaot9kCudN5T+qnv0EFoT7NwT1hTsf9765jVPDr1ACkLU7VFjqr8739nRg==", "acabd61e-9b29-49b1-ab24-6fe526cdee6e" });
        }
    }
}
