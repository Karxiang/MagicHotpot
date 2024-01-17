using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FullSD.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddApplicationTablesremovedDateTimefromBaseDomain : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BookDate",
                table: "Staffs");

            migrationBuilder.DropColumn(
                name: "BookTime",
                table: "Staffs");

            migrationBuilder.DropColumn(
                name: "BookDate",
                table: "Reviews");

            migrationBuilder.DropColumn(
                name: "BookTime",
                table: "Reviews");

            migrationBuilder.DropColumn(
                name: "BookDate",
                table: "OrderItems");

            migrationBuilder.DropColumn(
                name: "BookTime",
                table: "OrderItems");

            migrationBuilder.DropColumn(
                name: "BookDate",
                table: "Foods");

            migrationBuilder.DropColumn(
                name: "BookTime",
                table: "Foods");

            migrationBuilder.DropColumn(
                name: "BookDate",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "BookTime",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "BookDate",
                table: "Branches");

            migrationBuilder.DropColumn(
                name: "BookTime",
                table: "Branches");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "BookDate",
                table: "Staffs",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "BookTime",
                table: "Staffs",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "BookDate",
                table: "Reviews",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "BookTime",
                table: "Reviews",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "BookDate",
                table: "OrderItems",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "BookTime",
                table: "OrderItems",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "BookDate",
                table: "Foods",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "BookTime",
                table: "Foods",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "BookDate",
                table: "Customers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "BookTime",
                table: "Customers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "BookDate",
                table: "Branches",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "BookTime",
                table: "Branches",
                type: "datetime2",
                nullable: true);
        }
    }
}
