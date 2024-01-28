using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FullSD.Server.Migrations
{
    /// <inheritdoc />
    public partial class view : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "be04dd60-8599-41c2-8096-67868766306c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9aac3e89-a9a8-4587-b681-aef9f5a916eb", "AQAAAAIAAYagAAAAECQ8TMq3HwiAyxzSLTKlDpa/2LbwsQgVn9vQWMjv+iwiGy8PXjj1pHBj3aSZEdvTuw==", "13728421-c921-4527-bd4e-5f65b07d7732" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "be04dd60-8599-41c2-8096-67868766306c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ad4db57a-fbcf-4b24-ba3a-6a2704455b32", "AQAAAAIAAYagAAAAEIeguHL+wNIUslDT4YdWnT51IYVyce1HCDYTH/MiFbHlMvtudx8VmFwT7Fxt1W4dbg==", "81f95478-5f54-4aa9-ba56-f72dbc90e798" });
        }
    }
}
