using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SharedMomentsBackend.App.DB.Migrations
{
    /// <inheritdoc />
    public partial class change_properties_resource : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("004b448a-aace-4857-9da3-23b5b013e4ad"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8cbffeff-5bb3-48da-8517-18384a4d660e"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("1a0aa029-963a-49b2-b0fe-7a7055131229"));

            migrationBuilder.RenameColumn(
                name: "Format",
                table: "Resources",
                newName: "Extension");

            migrationBuilder.AlterColumn<decimal>(
                name: "Size",
                table: "Resources",
                type: "decimal(20,0)",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreatedAt", "IsActive", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("78eaf133-a824-455b-b95c-9db3f18c13e8"), new DateTime(2024, 8, 9, 4, 57, 30, 903, DateTimeKind.Utc).AddTicks(3158), true, "User", new DateTime(2024, 8, 9, 4, 57, 30, 903, DateTimeKind.Utc).AddTicks(3158) },
                    { new Guid("8fc26b3c-cb55-4dc3-be6a-0abcafd96c3b"), new DateTime(2024, 8, 9, 4, 57, 30, 903, DateTimeKind.Utc).AddTicks(3152), true, "Admin", new DateTime(2024, 8, 9, 4, 57, 30, 903, DateTimeKind.Utc).AddTicks(3155) }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "DateOfBirth", "Email", "IsActive", "Name", "PasswordHash", "PhoneNumber", "ProfileId", "RoleId", "UpdatedAt" },
                values: new object[] { new Guid("6ab823f0-fbf9-4946-8073-8b487af51712"), new DateTime(2024, 8, 9, 4, 57, 30, 903, DateTimeKind.Utc).AddTicks(3306), new DateTime(2000, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "alvaroku123@gmail.com", true, "Alvaro Kú", "b2867617492e26c338ab49f72afabc984d798b59755a27e312b953716ae964d7", "9919596720", null, new Guid("8fc26b3c-cb55-4dc3-be6a-0abcafd96c3b"), new DateTime(2024, 8, 9, 4, 57, 30, 903, DateTimeKind.Utc).AddTicks(3306) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("78eaf133-a824-455b-b95c-9db3f18c13e8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6ab823f0-fbf9-4946-8073-8b487af51712"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8fc26b3c-cb55-4dc3-be6a-0abcafd96c3b"));

            migrationBuilder.RenameColumn(
                name: "Extension",
                table: "Resources",
                newName: "Format");

            migrationBuilder.AlterColumn<long>(
                name: "Size",
                table: "Resources",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(20,0)");

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreatedAt", "IsActive", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("004b448a-aace-4857-9da3-23b5b013e4ad"), new DateTime(2024, 8, 9, 3, 58, 15, 971, DateTimeKind.Utc).AddTicks(9876), true, "User", new DateTime(2024, 8, 9, 3, 58, 15, 971, DateTimeKind.Utc).AddTicks(9876) },
                    { new Guid("1a0aa029-963a-49b2-b0fe-7a7055131229"), new DateTime(2024, 8, 9, 3, 58, 15, 971, DateTimeKind.Utc).AddTicks(9870), true, "Admin", new DateTime(2024, 8, 9, 3, 58, 15, 971, DateTimeKind.Utc).AddTicks(9873) }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "DateOfBirth", "Email", "IsActive", "Name", "PasswordHash", "PhoneNumber", "ProfileId", "RoleId", "UpdatedAt" },
                values: new object[] { new Guid("8cbffeff-5bb3-48da-8517-18384a4d660e"), new DateTime(2024, 8, 9, 3, 58, 15, 972, DateTimeKind.Utc).AddTicks(15), new DateTime(2000, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "alvaroku123@gmail.com", true, "Alvaro Kú", "b2867617492e26c338ab49f72afabc984d798b59755a27e312b953716ae964d7", "9919596720", null, new Guid("1a0aa029-963a-49b2-b0fe-7a7055131229"), new DateTime(2024, 8, 9, 3, 58, 15, 972, DateTimeKind.Utc).AddTicks(15) });
        }
    }
}
