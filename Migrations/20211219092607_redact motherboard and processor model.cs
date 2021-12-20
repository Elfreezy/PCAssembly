using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApp.Migrations
{
    public partial class redactmotherboardandprocessormodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Model",
                table: "Processors",
                newName: "ModelName");

            migrationBuilder.RenameColumn(
                name: "Model",
                table: "Motherboards",
                newName: "ModelName");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ModelName",
                table: "Processors",
                newName: "Model");

            migrationBuilder.RenameColumn(
                name: "ModelName",
                table: "Motherboards",
                newName: "Model");

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
    }
}
