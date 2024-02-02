using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FullSD.Server.Migrations
{
    /// <inheritdoc />
    public partial class staffseedchange : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "be04dd60-8599-41c2-8096-67868766306c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "320c8fcf-ce21-4d6a-ad0b-65bf8070ed3a", "AQAAAAIAAYagAAAAEEHEd6ZnmqCWLbTPCSo2DJsbulzMc1LVA0CHbaeK9S/Zx6O6eDAxtmPlw1XnfAQNeQ==", "942d3a8a-1c80-43a2-a519-4df6bce2f3de" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 1,
                column: "BranchId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 2,
                column: "BranchId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 3,
                column: "BranchId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 4,
                column: "BranchId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 5,
                column: "BranchId",
                value: 4);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "be04dd60-8599-41c2-8096-67868766306c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d5251561-c4ae-48ee-a7f8-70b4d273f050", "AQAAAAIAAYagAAAAEPNByaQIoz2pibgocxPo9pEgcwB2BYfPmWb+yvr/EzEhPU6KFQlJoch6P9BGumiw/A==", "543e487e-7f7f-4679-aef3-58664fbb6ed7" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 1,
                column: "BranchId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 2,
                column: "BranchId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 3,
                column: "BranchId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 4,
                column: "BranchId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 5,
                column: "BranchId",
                value: null);
        }
    }
}
