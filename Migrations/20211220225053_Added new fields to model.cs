using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApp.Migrations
{
    public partial class Addednewfieldstomodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PowerUnit",
                table: "Components",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SoundCard",
                table: "Components",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StorageDevice",
                table: "Components",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Videoadapter",
                table: "Components",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ca761232-ed42-11ce-bacd-00aa0057b223",
                column: "ConcurrencyStamp",
                value: "1d4b68ce-b7f2-49ff-a365-4ee405e887f1");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ca761232-ed42-11ce-bacd-00aa0057b223",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "da3a38ef-01eb-46d5-af69-3a17a11a60e9", "AQAAAAEAACcQAAAAEJ8cy7GBP6w6ugKPX2tOdrcw7DjzINSdLdwLte+l1BV8I7cEwSXiaukZgPRr+B3BPA==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("3c345af4-2678-4a3a-a170-4433e0caa87c"),
                column: "DateAdd",
                value: new DateTime(2021, 12, 20, 22, 50, 52, 321, DateTimeKind.Utc).AddTicks(5339));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("419b11ca-1cfe-4789-b86a-be0c4f19f98c"),
                column: "DateAdd",
                value: new DateTime(2021, 12, 20, 22, 50, 52, 321, DateTimeKind.Utc).AddTicks(8020));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("5a315af2-d467-4b53-ad25-043efe4cbdd7"),
                column: "DateAdd",
                value: new DateTime(2021, 12, 20, 22, 50, 52, 321, DateTimeKind.Utc).AddTicks(7948));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PowerUnit",
                table: "Components");

            migrationBuilder.DropColumn(
                name: "SoundCard",
                table: "Components");

            migrationBuilder.DropColumn(
                name: "StorageDevice",
                table: "Components");

            migrationBuilder.DropColumn(
                name: "Videoadapter",
                table: "Components");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ca761232-ed42-11ce-bacd-00aa0057b223",
                column: "ConcurrencyStamp",
                value: "9e250d7e-5d3f-479e-9a36-47318e1ac906");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ca761232-ed42-11ce-bacd-00aa0057b223",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c5e0fdde-29ec-416e-889d-1b422e5f2552", "AQAAAAEAACcQAAAAEBlI9dG/pOf4mM69wxRfX1prkf4wJHizzbayv2STc1Yf5a7Ff+W93wOlJsdNDMlnHQ==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("3c345af4-2678-4a3a-a170-4433e0caa87c"),
                column: "DateAdd",
                value: new DateTime(2021, 12, 20, 17, 7, 14, 997, DateTimeKind.Utc).AddTicks(1528));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("419b11ca-1cfe-4789-b86a-be0c4f19f98c"),
                column: "DateAdd",
                value: new DateTime(2021, 12, 20, 17, 7, 14, 997, DateTimeKind.Utc).AddTicks(3135));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("5a315af2-d467-4b53-ad25-043efe4cbdd7"),
                column: "DateAdd",
                value: new DateTime(2021, 12, 20, 17, 7, 14, 997, DateTimeKind.Utc).AddTicks(3101));
        }
    }
}
