using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace _024_chef_and_dishes.Migrations
{
    public partial class cadmigration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Chefs");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Dishes",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Dishes",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Chefs",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Chefs",
                nullable: false);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Chefs",
                nullable: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Chefs",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Dishes");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Dishes");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Chefs");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Chefs");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Chefs");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Chefs");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Chefs",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: false,
                defaultValue: "");
        }
    }
}
