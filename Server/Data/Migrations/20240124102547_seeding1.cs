using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FullSD.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class seeding1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "6ee1247a-4604-4cbf-836a-77c3a2c15e3a", null, "User", "USER" },
                    { "89e4ba74-bec1-4947-b652-49587cc7d8b9", null, "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "be04dd60-8599-41c2-8096-67868766306c", 0, "e1d0baf9-8ea2-46ee-a1f6-0988ed94c5cb", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEO30+TJ7T9PQtWg+/LVyAN0P2dJcS/t8qJFn9SxsO/LC1EMlUhmkgxgypZERBd2/yw==", null, false, "41dabdaf-d935-47f9-9595-a37b818bc08e", false, "admin@localhost.com" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "Id", "BranchAddress", "BranchCapacity", "BranchName", "BranchPhoneNo" },
                values: new object[,]
                {
                    { 1, "Tampines 1", 40, "Tampines", 12345678 },
                    { 2, "Ubi Avenue 1", 45, "Ubi", 23456781 },
                    { 3, "Serangoon Nex", 47, "Serangoon", 34567812 },
                    { 4, "Ang Mo Kio Hub", 50, "Ang Mo Kio", 45678123 }
                });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "Id", "FoodDescription", "FoodName", "FoodPrice" },
                values: new object[,]
                {
                    { 1, null, "Sliced Fish", 11.300000000000001 },
                    { 2, null, "Chicken Slices", 8.3000000000000007 },
                    { 3, null, "Beef Slices", 11.9 },
                    { 4, null, "Cheese Tofu", 5.9500000000000002 },
                    { 5, null, "Fish Cured", 5.9500000000000002 },
                    { 6, null, "Sliced Pork Belly", 11.9 },
                    { 7, null, "Abalone", 29.699999999999999 },
                    { 8, null, "Prawn", 10.699999999999999 },
                    { 9, null, "Pork Meatball", 8.9000000000000004 },
                    { 10, null, "Fishball", 5.9500000000000002 },
                    { 11, null, "Quail Eggs", 7.1500000000000004 },
                    { 12, null, "Golden Enoki Mushrooms", 6.5499999999999998 },
                    { 13, null, "Sweet Corn", 4.75 },
                    { 14, null, "Radish", 3.0 },
                    { 15, null, "Black Fungus", 4.2000000000000002 },
                    { 16, null, "Lettuce", 4.75 },
                    { 17, null, "Cabbage", 4.75 },
                    { 18, null, "Spinach", 4.75 },
                    { 19, null, "Beencurd Rolls", 7.7000000000000002 },
                    { 20, null, "Instant Noodles", 2.3999999999999999 }
                });

            migrationBuilder.InsertData(
                table: "Staffs",
                columns: new[] { "Id", "BranchId", "StaffDOB", "StaffIcNo", "StaffJoinDate", "StaffName", "StaffPhoneNo", "StaffPostion" },
                values: new object[,]
                {
                    { 1, null, null, "S1234567F", null, "Milly", 98765432, "Manager" },
                    { 2, null, null, "S2345678F", null, "Aron", 87654321, "Staff" },
                    { 3, null, null, "S3456789F", null, "Vedal", 76543210, "Staff" },
                    { 4, null, null, "S4567890F", null, "Marciana", 65432109, "Staff" },
                    { 5, null, null, "S5678901F", null, "Mark", 54321098, "Staff" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "89e4ba74-bec1-4947-b652-49587cc7d8b9", "be04dd60-8599-41c2-8096-67868766306c" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6ee1247a-4604-4cbf-836a-77c3a2c15e3a");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "89e4ba74-bec1-4947-b652-49587cc7d8b9", "be04dd60-8599-41c2-8096-67868766306c" });

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "89e4ba74-bec1-4947-b652-49587cc7d8b9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "be04dd60-8599-41c2-8096-67868766306c");
        }
    }
}
