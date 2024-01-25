using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FullSD.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedConfigurationRemovednFixed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "be04dd60-8599-41c2-8096-67868766306c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c1f3fbe5-d3a5-4012-a792-1ab3149740c2", "AQAAAAIAAYagAAAAEFnS9gLtWhxiY7T7XeClvUCPeLO4DlVGDps9ztpQjAMqYkN9kACsylGFbkFhzgl4OQ==", "c65c5c54-24ad-4270-ab11-6cc0d7cc5d87" });

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                column: "BranchPhoneNo",
                value: 62345678);

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 2,
                column: "BranchPhoneNo",
                value: 63456781);

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 3,
                column: "BranchPhoneNo",
                value: 64567812);

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 4,
                column: "BranchPhoneNo",
                value: 65678123);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 5,
                column: "FoodName",
                value: "Fish Paste");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 19,
                column: "FoodName",
                value: "Beancurd Rolls");

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 2,
                column: "StaffName",
                value: "Aaron");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "be04dd60-8599-41c2-8096-67868766306c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e1d0baf9-8ea2-46ee-a1f6-0988ed94c5cb", "AQAAAAIAAYagAAAAEO30+TJ7T9PQtWg+/LVyAN0P2dJcS/t8qJFn9SxsO/LC1EMlUhmkgxgypZERBd2/yw==", "41dabdaf-d935-47f9-9595-a37b818bc08e" });

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                column: "BranchPhoneNo",
                value: 12345678);

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 2,
                column: "BranchPhoneNo",
                value: 23456781);

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 3,
                column: "BranchPhoneNo",
                value: 34567812);

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 4,
                column: "BranchPhoneNo",
                value: 45678123);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 5,
                column: "FoodName",
                value: "Fish Cured");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 19,
                column: "FoodName",
                value: "Beencurd Rolls");

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 2,
                column: "StaffName",
                value: "Aron");
        }
    }
}
