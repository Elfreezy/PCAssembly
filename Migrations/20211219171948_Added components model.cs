using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApp.Migrations
{
    public partial class Addedcomponentsmodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Components",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Motherboard = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Processor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Subtitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TitleImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateAdd = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Components", x => x.Id);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Components");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ca761232-ed42-11ce-bacd-00aa0057b223",
                column: "ConcurrencyStamp",
                value: "318f071f-ce3c-4c83-9542-98490ba4ecde");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ca761232-ed42-11ce-bacd-00aa0057b223",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "60fd77e1-b917-4016-8c3f-f41370e5fc49", "AQAAAAEAACcQAAAAELXrJfz3OsmhqKF+/scH6XJfz+maRtovwM36vLDwVmxmewVk5+WBP2VriM/VUb/s+w==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("3c345af4-2678-4a3a-a170-4433e0caa87c"),
                column: "DateAdd",
                value: new DateTime(2021, 12, 19, 9, 26, 7, 208, DateTimeKind.Utc).AddTicks(3874));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("419b11ca-1cfe-4789-b86a-be0c4f19f98c"),
                column: "DateAdd",
                value: new DateTime(2021, 12, 19, 9, 26, 7, 208, DateTimeKind.Utc).AddTicks(6203));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("5a315af2-d467-4b53-ad25-043efe4cbdd7"),
                column: "DateAdd",
                value: new DateTime(2021, 12, 19, 9, 26, 7, 208, DateTimeKind.Utc).AddTicks(6145));
        }
    }
}
