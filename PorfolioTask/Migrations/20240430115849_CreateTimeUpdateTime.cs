using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PorfolioTask.Migrations
{
    public partial class CreateTimeUpdateTime : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreateTime",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateTime",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "isDelete",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateTime",
                table: "Tests",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateTime",
                table: "Tests",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "isDelete",
                table: "Tests",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateTime",
                table: "Services",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateTime",
                table: "Services",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "isDelete",
                table: "Services",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateTime",
                table: "Pricings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateTime",
                table: "Pricings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "isDelete",
                table: "Pricings",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateTime",
                table: "PricingDescriptions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateTime",
                table: "PricingDescriptions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "isDelete",
                table: "PricingDescriptions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateTime",
                table: "Portfolios",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateTime",
                table: "Portfolios",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "isDelete",
                table: "Portfolios",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateTime",
                table: "ContactMes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateTime",
                table: "ContactMes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "isDelete",
                table: "ContactMes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateTime",
                table: "Blogs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateTime",
                table: "Blogs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "isDelete",
                table: "Blogs",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreateTime",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "UpdateTime",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "isDelete",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "CreateTime",
                table: "Tests");

            migrationBuilder.DropColumn(
                name: "UpdateTime",
                table: "Tests");

            migrationBuilder.DropColumn(
                name: "isDelete",
                table: "Tests");

            migrationBuilder.DropColumn(
                name: "CreateTime",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "UpdateTime",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "isDelete",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "CreateTime",
                table: "Pricings");

            migrationBuilder.DropColumn(
                name: "UpdateTime",
                table: "Pricings");

            migrationBuilder.DropColumn(
                name: "isDelete",
                table: "Pricings");

            migrationBuilder.DropColumn(
                name: "CreateTime",
                table: "PricingDescriptions");

            migrationBuilder.DropColumn(
                name: "UpdateTime",
                table: "PricingDescriptions");

            migrationBuilder.DropColumn(
                name: "isDelete",
                table: "PricingDescriptions");

            migrationBuilder.DropColumn(
                name: "CreateTime",
                table: "Portfolios");

            migrationBuilder.DropColumn(
                name: "UpdateTime",
                table: "Portfolios");

            migrationBuilder.DropColumn(
                name: "isDelete",
                table: "Portfolios");

            migrationBuilder.DropColumn(
                name: "CreateTime",
                table: "ContactMes");

            migrationBuilder.DropColumn(
                name: "UpdateTime",
                table: "ContactMes");

            migrationBuilder.DropColumn(
                name: "isDelete",
                table: "ContactMes");

            migrationBuilder.DropColumn(
                name: "CreateTime",
                table: "Blogs");

            migrationBuilder.DropColumn(
                name: "UpdateTime",
                table: "Blogs");

            migrationBuilder.DropColumn(
                name: "isDelete",
                table: "Blogs");
        }
    }
}
