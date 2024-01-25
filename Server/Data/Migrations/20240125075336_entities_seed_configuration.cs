using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FullSD.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class entities_seed_configuration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "be04dd60-8599-41c2-8096-67868766306c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1d684c73-98af-4ab7-aa47-03dbb9aa76e7", "AQAAAAIAAYagAAAAEA1vm41L9F6H5MspCUxWnLc32JBCjsVGcGEN1rWej47QU+64ommdYkjef28O9S4TPw==", "be630e8a-55a6-4c95-8f7b-438529fa856e" });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FoodDescription", "FoodName", "FoodPrice" },
                values: new object[] { "Freshest Fish in the Ocean, Sliced up", "Sliced Fish", 11.300000000000001 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "FoodDescription", "FoodName", "FoodPrice" },
                values: new object[] { null, "Chicken Slices", 8.3000000000000007 });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "Id", "FoodDescription", "FoodName", "FoodPrice" },
                values: new object[,]
                {
                    { 3, null, "Beef Slices", 11.9 },
                    { 4, null, "Cheese Tofu", 5.9500000000000002 },
                    { 5, null, "Fish Paste", 5.9500000000000002 },
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
                    { 19, null, "Beancurd Rolls", 7.7000000000000002 },
                    { 20, null, "Instant Noodles", 2.3999999999999999 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "be04dd60-8599-41c2-8096-67868766306c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4b9db0c8-384a-4790-9da0-4497b55eb91a", "AQAAAAIAAYagAAAAENUjpIfiTnnM90R6tuNOvPi9e4nTFeKbo3TzZed3/qSA0f9bt288k2Ba9UiO6T4FzQ==", "7f2b6da9-81fc-438f-bfce-bed79999e3d7" });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FoodDescription", "FoodName", "FoodPrice" },
                values: new object[] { "System", "BMW", 3.0 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "FoodDescription", "FoodName", "FoodPrice" },
                values: new object[] { "System", "Yellow", 4.0 });
        }
    }
}
