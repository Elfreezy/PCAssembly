using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApp.Migrations
{
    public partial class Addedothermodels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FormFactorPowerUnit",
                table: "Motherboards",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FormFactorSoundCard",
                table: "Motherboards",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FormFactorStorageDevice",
                table: "Motherboards",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VideoadapterInterface",
                table: "Motherboards",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "PowerUnits",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FormFactor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TitleImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateAdd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Subtitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModelName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Maker = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PowerUnits", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SoundCards",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FormFactor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TitleImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateAdd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Subtitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModelName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Maker = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SoundCards", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StorageDevices",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FormFactor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TitleImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateAdd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Subtitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModelName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Maker = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StorageDevices", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Videoadapters",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Interface = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TitleImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateAdd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Subtitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModelName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Maker = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Videoadapters", x => x.Id);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PowerUnits");

            migrationBuilder.DropTable(
                name: "SoundCards");

            migrationBuilder.DropTable(
                name: "StorageDevices");

            migrationBuilder.DropTable(
                name: "Videoadapters");

            migrationBuilder.DropColumn(
                name: "FormFactorPowerUnit",
                table: "Motherboards");

            migrationBuilder.DropColumn(
                name: "FormFactorSoundCard",
                table: "Motherboards");

            migrationBuilder.DropColumn(
                name: "FormFactorStorageDevice",
                table: "Motherboards");

            migrationBuilder.DropColumn(
                name: "VideoadapterInterface",
                table: "Motherboards");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ca761232-ed42-11ce-bacd-00aa0057b223",
                column: "ConcurrencyStamp",
                value: "af9d37e4-639c-484c-944a-8d41a81b2138");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ca761232-ed42-11ce-bacd-00aa0057b223",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "94ab8d7f-5beb-4612-82e9-1c4685856345", "AQAAAAEAACcQAAAAEBzPqe28fBYQf5bb0lhFPGwhwnl8HGtZqnvWeRkziRaj1kwjWnWiD6iEuMqsplCrAg==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("3c345af4-2678-4a3a-a170-4433e0caa87c"),
                column: "DateAdd",
                value: new DateTime(2021, 12, 19, 17, 19, 48, 151, DateTimeKind.Utc).AddTicks(7455));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("419b11ca-1cfe-4789-b86a-be0c4f19f98c"),
                column: "DateAdd",
                value: new DateTime(2021, 12, 19, 17, 19, 48, 151, DateTimeKind.Utc).AddTicks(9015));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("5a315af2-d467-4b53-ad25-043efe4cbdd7"),
                column: "DateAdd",
                value: new DateTime(2021, 12, 19, 17, 19, 48, 151, DateTimeKind.Utc).AddTicks(8981));
        }
    }
}
