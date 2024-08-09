using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SharedMomentsBackend.App.DB.Migrations
{
    /// <inheritdoc />
    public partial class add_column_format_size_in_resource : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("6edbaad5-aea0-4970-9b14-42b14add76db"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7bbece95-f005-463a-ae50-f40551e72fa5"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("110c5b56-8453-49a4-bdd7-ced7aba73090"));

            migrationBuilder.AddColumn<string>(
                name: "Format",
                table: "Resources",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<long>(
                name: "Size",
                table: "Resources",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Format",
                table: "Resources");

            migrationBuilder.DropColumn(
                name: "Size",
                table: "Resources");

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreatedAt", "IsActive", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("110c5b56-8453-49a4-bdd7-ced7aba73090"), new DateTime(2024, 8, 9, 3, 47, 57, 625, DateTimeKind.Utc).AddTicks(4754), true, "Admin", new DateTime(2024, 8, 9, 3, 47, 57, 625, DateTimeKind.Utc).AddTicks(4757) },
                    { new Guid("6edbaad5-aea0-4970-9b14-42b14add76db"), new DateTime(2024, 8, 9, 3, 47, 57, 625, DateTimeKind.Utc).AddTicks(4759), true, "User", new DateTime(2024, 8, 9, 3, 47, 57, 625, DateTimeKind.Utc).AddTicks(4760) }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "DateOfBirth", "Email", "IsActive", "Name", "PasswordHash", "PhoneNumber", "ProfileId", "RoleId", "UpdatedAt" },
                values: new object[] { new Guid("7bbece95-f005-463a-ae50-f40551e72fa5"), new DateTime(2024, 8, 9, 3, 47, 57, 625, DateTimeKind.Utc).AddTicks(4904), new DateTime(2000, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "alvaroku123@gmail.com", true, "Alvaro Kú", "b2867617492e26c338ab49f72afabc984d798b59755a27e312b953716ae964d7", "9919596720", null, new Guid("110c5b56-8453-49a4-bdd7-ced7aba73090"), new DateTime(2024, 8, 9, 3, 47, 57, 625, DateTimeKind.Utc).AddTicks(4905) });
        }
    }
}
