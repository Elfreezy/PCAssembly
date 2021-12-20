using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApp.Migrations
{
    public partial class addprocessorandmotherboard : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Motherboards",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProcessorSocket = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TitleImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateAdd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Subtitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Maker = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Motherboards", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Processors",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Socket = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TitleImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateAdd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Subtitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Maker = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Processors", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ca761232-ed42-11ce-bacd-00aa0057b223",
                column: "ConcurrencyStamp",
                value: "14337d8f-75a9-4d02-a9be-30f53910b38f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ca761232-ed42-11ce-bacd-00aa0057b223",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e6878fe1-b9df-4940-8327-4b96ad65cff1", "AQAAAAEAACcQAAAAEIVSGM/xTpUVmCXN8uln7PfTe9rby+4iDAehOZZmsB3QDg5OD4VbbpSH06f1C8z6zg==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("3c345af4-2678-4a3a-a170-4433e0caa87c"),
                column: "DateAdd",
                value: new DateTime(2021, 12, 18, 19, 49, 34, 418, DateTimeKind.Utc).AddTicks(8555));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("419b11ca-1cfe-4789-b86a-be0c4f19f98c"),
                column: "DateAdd",
                value: new DateTime(2021, 12, 18, 19, 49, 34, 419, DateTimeKind.Utc).AddTicks(439));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("5a315af2-d467-4b53-ad25-043efe4cbdd7"),
                column: "DateAdd",
                value: new DateTime(2021, 12, 18, 19, 49, 34, 419, DateTimeKind.Utc).AddTicks(404));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Motherboards");

            migrationBuilder.DropTable(
                name: "Processors");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ca761232-ed42-11ce-bacd-00aa0057b223",
                column: "ConcurrencyStamp",
                value: "899065ae-9a95-4fcf-9925-9cafbb2ab24f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ca761232-ed42-11ce-bacd-00aa0057b223",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "42b0ac95-c3cd-4b44-8e48-26b7ee73cc84", "AQAAAAEAACcQAAAAEC52JsIS+ut7M0lfyLgfJ6X9B76i0vFyUvJv3gziTZnWvnUOJwzTXFuTGtSno8b4sQ==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("3c345af4-2678-4a3a-a170-4433e0caa87c"),
                column: "DateAdd",
                value: new DateTime(2021, 12, 6, 19, 4, 27, 319, DateTimeKind.Utc).AddTicks(174));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("419b11ca-1cfe-4789-b86a-be0c4f19f98c"),
                column: "DateAdd",
                value: new DateTime(2021, 12, 6, 19, 4, 27, 319, DateTimeKind.Utc).AddTicks(1714));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("5a315af2-d467-4b53-ad25-043efe4cbdd7"),
                column: "DateAdd",
                value: new DateTime(2021, 12, 6, 19, 4, 27, 319, DateTimeKind.Utc).AddTicks(1679));
        }
    }
}
